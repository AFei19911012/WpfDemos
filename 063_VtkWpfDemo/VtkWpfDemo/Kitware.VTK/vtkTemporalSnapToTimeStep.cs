using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalSnapToTimeStep
/// </summary>
/// <remarks>
///    modify the time range/steps of temporal data
///
/// vtkTemporalSnapToTimeStep  modify the time range or time steps of
/// the data without changing the data itself. The data is not resampled
/// by this filter, only the information accompanying the data is modified.
///
/// @par Thanks:
/// John Bidiscombe of CSCS - Swiss National Supercomputing Centre
/// for creating and contributing this class.
/// For related material, please refer to :
/// John Biddiscombe, Berk Geveci, Ken Martin, Kenneth Moreland, David Thompson,
/// "Time Dependent Processing in a Parallel Pipeline Architecture",
/// IEEE Visualization 2007.
/// </remarks>
public class vtkTemporalSnapToTimeStep : vtkPassInputTypeAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum VTK_SNAP_NEAREST_WrapperEnum
	{
		/// <summary>enum member</summary>
		VTK_SNAP_NEAREST = 0,
		/// <summary>enum member</summary>
		VTK_SNAP_NEXTABOVE_OR_EQUAL = 2,
		/// <summary>enum member</summary>
		VTK_SNAP_NEXTBELOW_OR_EQUAL = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalSnapToTimeStep";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalSnapToTimeStep()
	{
		MRClassNameKey = "class vtkTemporalSnapToTimeStep";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalSnapToTimeStep"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalSnapToTimeStep(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalSnapToTimeStep_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalSnapToTimeStep New()
	{
		vtkTemporalSnapToTimeStep result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalSnapToTimeStep_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTemporalSnapToTimeStep()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalSnapToTimeStep_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkTemporalSnapToTimeStep_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalSnapToTimeStep_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalSnapToTimeStep_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalSnapToTimeStep_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalSnapToTimeStep_GetSnapMode_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetSnapMode()
	{
		return vtkTemporalSnapToTimeStep_GetSnapMode_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalSnapToTimeStep_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalSnapToTimeStep_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalSnapToTimeStep_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalSnapToTimeStep_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalSnapToTimeStep_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTemporalSnapToTimeStep NewInstance()
	{
		vtkTemporalSnapToTimeStep result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalSnapToTimeStep_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalSnapToTimeStep_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalSnapToTimeStep SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalSnapToTimeStep vtkTemporalSnapToTimeStep2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalSnapToTimeStep_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalSnapToTimeStep2 = (vtkTemporalSnapToTimeStep)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalSnapToTimeStep2.Register(null);
			}
		}
		return vtkTemporalSnapToTimeStep2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalSnapToTimeStep_SetSnapMode_09(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSnapMode(int _arg)
	{
		vtkTemporalSnapToTimeStep_SetSnapMode_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNearest_10(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetSnapModeToNearest()
	{
		vtkTemporalSnapToTimeStep_SetSnapModeToNearest_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNextAboveOrEqual_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetSnapModeToNextAboveOrEqual()
	{
		vtkTemporalSnapToTimeStep_SetSnapModeToNextAboveOrEqual_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalSnapToTimeStep_SetSnapModeToNextBelowOrEqual_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetSnapModeToNextBelowOrEqual()
	{
		vtkTemporalSnapToTimeStep_SetSnapModeToNextBelowOrEqual_12(GetCppThis());
	}
}
