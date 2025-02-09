using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkExtractTimeSteps
/// </summary>
/// <remarks>
///    extract specific time-steps from dataset
///
/// vtkExtractTimeSteps extracts the specified time steps from the input dataset.
/// It has two modes, one to specify timesteps explicitly by their indices and one
/// to specify a range of timesteps to extract.
///
/// When specifying timesteps explicitly the timesteps to be extracted are
/// specified by their indices. If no time step is specified, all of the input
/// time steps are extracted.
///
/// When specifying a range, the beginning and end times are specified and the
/// timesteps in between are extracted.  This can be modified by the TimeStepInterval
/// property that sets the filter to extract every Nth timestep.
///
/// This filter is useful when one wants to work with only a sub-set of the input
/// time steps.
/// </remarks>
public class vtkExtractTimeSteps : vtkPassInputTypeAlgorithm
{
	/// <summary>
	/// Get/Set the time step interval to extract.  This is the N in 'extract every
	/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
	/// </summary>
	public enum NEAREST_TIMESTEP_WrapperEnum
	{
		/// <summary>enum member</summary>
		NEAREST_TIMESTEP = 2,
		/// <summary>enum member</summary>
		NEXT_TIMESTEP = 1,
		/// <summary>enum member</summary>
		PREVIOUS_TIMESTEP = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkExtractTimeSteps";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkExtractTimeSteps()
	{
		MRClassNameKey = "class vtkExtractTimeSteps";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractTimeSteps"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkExtractTimeSteps(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTimeSteps_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractTimeSteps New()
	{
		vtkExtractTimeSteps result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractTimeSteps_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractTimeSteps)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkExtractTimeSteps()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkExtractTimeSteps_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_AddTimeStepIndex_01(HandleRef pThis, int timeStepIndex);

	/// <summary>
	/// Add a time step index. Not added if the index already exists.
	/// </summary>
	public void AddTimeStepIndex(int timeStepIndex)
	{
		vtkExtractTimeSteps_AddTimeStepIndex_01(GetCppThis(), timeStepIndex);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_ClearTimeStepIndices_02(HandleRef pThis);

	/// <summary>
	/// Clear the time step indices
	/// </summary>
	public void ClearTimeStepIndices()
	{
		vtkExtractTimeSteps_ClearTimeStepIndices_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_GenerateTimeStepIndices_03(HandleRef pThis, int begin, int end, int step);

	/// <summary>
	/// Generate a range of indices in [begin, end) with a step size of 'step'
	/// </summary>
	public void GenerateTimeStepIndices(int begin, int end, int step)
	{
		vtkExtractTimeSteps_GenerateTimeStepIndices_03(GetCppThis(), begin, end, step);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractTimeSteps_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkExtractTimeSteps_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkExtractTimeSteps_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkExtractTimeSteps_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTimeSteps_GetNumberOfTimeSteps_06(HandleRef pThis);

	/// <summary>
	/// Get the number of time steps that will be extracted
	/// </summary>
	public int GetNumberOfTimeSteps()
	{
		return vtkExtractTimeSteps_GetNumberOfTimeSteps_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTimeSteps_GetRange_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the range of time steps to extract.
	/// </summary>
	public virtual int[] GetRange()
	{
		IntPtr intPtr = vtkExtractTimeSteps_GetRange_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_GetRange_08(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Get/Set the range of time steps to extract.
	/// </summary>
	public virtual void GetRange(ref int _arg1, ref int _arg2)
	{
		vtkExtractTimeSteps_GetRange_08(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_GetRange_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the range of time steps to extract.
	/// </summary>
	public virtual void GetRange(IntPtr _arg)
	{
		vtkExtractTimeSteps_GetRange_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTimeSteps_GetTimeEstimationMode_10(HandleRef pThis);

	/// <summary>
	/// Get/Set what to do when the requested time is not one of the timesteps this filter
	/// is set to extract.  Should be one of the values of the enum
	/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
	/// </summary>
	public virtual int GetTimeEstimationMode()
	{
		return vtkExtractTimeSteps_GetTimeEstimationMode_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_GetTimeStepIndices_11(HandleRef pThis, IntPtr timeStepIndices);

	/// <summary>
	/// Get/Set an array of time step indices. For the Get function,
	/// timeStepIndices should be big enough for GetNumberOfTimeSteps() values.
	/// </summary>
	public void GetTimeStepIndices(IntPtr timeStepIndices)
	{
		vtkExtractTimeSteps_GetTimeStepIndices_11(GetCppThis(), timeStepIndices);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTimeSteps_GetTimeStepInterval_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the time step interval to extract.  This is the N in 'extract every
	/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
	/// </summary>
	public virtual int GetTimeStepInterval()
	{
		return vtkExtractTimeSteps_GetTimeStepInterval_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTimeSteps_GetTimeStepIntervalMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Get/Set the time step interval to extract.  This is the N in 'extract every
	/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
	/// </summary>
	public virtual int GetTimeStepIntervalMaxValue()
	{
		return vtkExtractTimeSteps_GetTimeStepIntervalMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTimeSteps_GetTimeStepIntervalMinValue_14(HandleRef pThis);

	/// <summary>
	/// Get/Set the time step interval to extract.  This is the N in 'extract every
	/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
	/// </summary>
	public virtual int GetTimeStepIntervalMinValue()
	{
		return vtkExtractTimeSteps_GetTimeStepIntervalMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkExtractTimeSteps_GetUseRange_15(HandleRef pThis);

	/// <summary>
	/// Get/Set whether to extract a range of timesteps.  When false, extracts
	/// the time steps explicitly set with SetTimeStepIndices.  Defaults to false.
	/// </summary>
	public virtual bool GetUseRange()
	{
		return (vtkExtractTimeSteps_GetUseRange_15(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTimeSteps_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkExtractTimeSteps_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkExtractTimeSteps_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkExtractTimeSteps_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTimeSteps_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkExtractTimeSteps NewInstance()
	{
		vtkExtractTimeSteps result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractTimeSteps_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkExtractTimeSteps)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkExtractTimeSteps_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkExtractTimeSteps SafeDownCast(vtkObjectBase o)
	{
		vtkExtractTimeSteps vtkExtractTimeSteps2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkExtractTimeSteps_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkExtractTimeSteps2 = (vtkExtractTimeSteps)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkExtractTimeSteps2.Register(null);
			}
		}
		return vtkExtractTimeSteps2;
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetRange_21(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Get/Set the range of time steps to extract.
	/// </summary>
	public virtual void SetRange(int _arg1, int _arg2)
	{
		vtkExtractTimeSteps_SetRange_21(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetRange_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the range of time steps to extract.
	/// </summary>
	public void SetRange(IntPtr _arg)
	{
		vtkExtractTimeSteps_SetRange_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetTimeEstimationMode_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set what to do when the requested time is not one of the timesteps this filter
	/// is set to extract.  Should be one of the values of the enum
	/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
	/// </summary>
	public virtual void SetTimeEstimationMode(int _arg)
	{
		vtkExtractTimeSteps_SetTimeEstimationMode_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetTimeEstimationModeToNearest_24(HandleRef pThis);

	/// <summary>
	/// Get/Set what to do when the requested time is not one of the timesteps this filter
	/// is set to extract.  Should be one of the values of the enum
	/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
	/// </summary>
	public void SetTimeEstimationModeToNearest()
	{
		vtkExtractTimeSteps_SetTimeEstimationModeToNearest_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetTimeEstimationModeToNext_25(HandleRef pThis);

	/// <summary>
	/// Get/Set what to do when the requested time is not one of the timesteps this filter
	/// is set to extract.  Should be one of the values of the enum
	/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
	/// </summary>
	public void SetTimeEstimationModeToNext()
	{
		vtkExtractTimeSteps_SetTimeEstimationModeToNext_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetTimeEstimationModeToPrevious_26(HandleRef pThis);

	/// <summary>
	/// Get/Set what to do when the requested time is not one of the timesteps this filter
	/// is set to extract.  Should be one of the values of the enum
	/// vtkExtractTimeSteps::EstimationMode. The default is PREVIOUS_TIMESTEP.
	/// </summary>
	public void SetTimeEstimationModeToPrevious()
	{
		vtkExtractTimeSteps_SetTimeEstimationModeToPrevious_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetTimeStepIndices_27(HandleRef pThis, int count, IntPtr timeStepIndices);

	/// <summary>
	/// Get/Set an array of time step indices. For the Get function,
	/// timeStepIndices should be big enough for GetNumberOfTimeSteps() values.
	/// </summary>
	public void SetTimeStepIndices(int count, IntPtr timeStepIndices)
	{
		vtkExtractTimeSteps_SetTimeStepIndices_27(GetCppThis(), count, timeStepIndices);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetTimeStepInterval_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the time step interval to extract.  This is the N in 'extract every
	/// Nth timestep in this range'.  Default to 1 or 'extract all timesteps in this range.
	/// </summary>
	public virtual void SetTimeStepInterval(int _arg)
	{
		vtkExtractTimeSteps_SetTimeStepInterval_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_SetUseRange_29(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set whether to extract a range of timesteps.  When false, extracts
	/// the time steps explicitly set with SetTimeStepIndices.  Defaults to false.
	/// </summary>
	public virtual void SetUseRange(bool _arg)
	{
		vtkExtractTimeSteps_SetUseRange_29(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_UseRangeOff_30(HandleRef pThis);

	/// <summary>
	/// Get/Set whether to extract a range of timesteps.  When false, extracts
	/// the time steps explicitly set with SetTimeStepIndices.  Defaults to false.
	/// </summary>
	public virtual void UseRangeOff()
	{
		vtkExtractTimeSteps_UseRangeOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkExtractTimeSteps_UseRangeOn_31(HandleRef pThis);

	/// <summary>
	/// Get/Set whether to extract a range of timesteps.  When false, extracts
	/// the time steps explicitly set with SetTimeStepIndices.  Defaults to false.
	/// </summary>
	public virtual void UseRangeOn()
	{
		vtkExtractTimeSteps_UseRangeOn_31(GetCppThis());
	}
}
