using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalPathLineFilter
/// </summary>
/// <remarks>
///    Generate a Polydata Pointset from any Dataset.
///
///
/// vtkTemporalPathLineFilter takes any dataset as input, it extracts the point
/// locations of all cells over time to build up a polyline trail.
/// The point number (index) is used as the 'key' if the points are randomly
/// changing their respective order in the points list, then you should specify
/// a scalar that represents the unique ID. This is intended to handle the output
/// of a filter such as the vtkParticleTracer.
///
/// </remarks>
/// <seealso>
///
/// vtkParticleTracer
///
/// @par Thanks:
/// John Bidiscombe of
/// CSCS - Swiss National Supercomputing Centre
/// for creating and contributing this class.
/// </seealso>
public class vtkTemporalPathLineFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalPathLineFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalPathLineFilter()
	{
		MRClassNameKey = "class vtkTemporalPathLineFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalPathLineFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalPathLineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalPathLineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new static vtkTemporalPathLineFilter New()
	{
		vtkTemporalPathLineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalPathLineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public vtkTemporalPathLineFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalPathLineFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTemporalPathLineFilter_Flush_01(HandleRef pThis);

	/// <summary>
	/// Flush will wipe any existing data so that traces can be restarted from
	/// whatever time step is next supplied.
	/// </summary>
	public void Flush()
	{
		vtkTemporalPathLineFilter_Flush_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalPathLineFilter_GetBackwardTime_02(HandleRef pThis);

	/// <summary>
	/// Set / Get if the filter is configured to work in backward time going mode.
	/// Default is false (time should go forward).
	///
	/// Time going forward means that for each call to RequestData, then the time
	/// step from vtkDataObject::DATA_TIME_STEP() is greater than the time step
	/// from the previous call. Time going backward means that the current time
	/// step is smaller than the previous one.
	/// </summary>
	public virtual bool GetBackwardTime()
	{
		return (vtkTemporalPathLineFilter_GetBackwardTime_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalPathLineFilter_GetIdChannelArray_03(HandleRef pThis);

	/// <summary>
	/// Specify the name of a scalar array which will be used to fetch
	/// the index of each point. This is necessary only if the particles
	/// change position (Id order) on each time step. The Id can be used
	/// to identify particles at each step and hence track them properly.
	/// If this array is nullptr, the global point ids are used.  If an Id
	/// array cannot otherwise be found, the point index is used as the ID.
	/// </summary>
	public virtual string GetIdChannelArray()
	{
		return Marshal.PtrToStringAnsi(vtkTemporalPathLineFilter_GetIdChannelArray_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTemporalPathLineFilter_GetKeepDeadTrails_04(HandleRef pThis);

	/// <summary>
	/// When a particle 'disappears', the trail belonging to it is removed from
	/// the list. When this flag is enabled, dead trails will persist
	/// until the next time the list is cleared. Use carefully as it may cause
	/// excessive memory consumption if left on by mistake.
	/// </summary>
	public virtual bool GetKeepDeadTrails()
	{
		return (vtkTemporalPathLineFilter_GetKeepDeadTrails_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalPathLineFilter_GetMaskPoints_05(HandleRef pThis);

	/// <summary>
	/// Set the number of particles to track as a ratio of the input
	/// example: setting MaskPoints to 10 will track every 10th point
	/// </summary>
	public virtual int GetMaskPoints()
	{
		return vtkTemporalPathLineFilter_GetMaskPoints_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalPathLineFilter_GetMaxStepDistance_06(HandleRef pThis);

	/// <summary>
	/// If a particle disappears from one end of a simulation and reappears
	/// on the other side, the track left will be unrepresentative.
	/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
	/// if a step occurs larger than the value (for the dimension), the track will
	/// be dropped and restarted after the step. (ie the part before the wrap
	/// around will be dropped and the newer part kept).
	/// </summary>
	public virtual double[] GetMaxStepDistance()
	{
		IntPtr intPtr = vtkTemporalPathLineFilter_GetMaxStepDistance_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_GetMaxStepDistance_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// If a particle disappears from one end of a simulation and reappears
	/// on the other side, the track left will be unrepresentative.
	/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
	/// if a step occurs larger than the value (for the dimension), the track will
	/// be dropped and restarted after the step. (ie the part before the wrap
	/// around will be dropped and the newer part kept).
	/// </summary>
	public virtual void GetMaxStepDistance(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkTemporalPathLineFilter_GetMaxStepDistance_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_GetMaxStepDistance_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// If a particle disappears from one end of a simulation and reappears
	/// on the other side, the track left will be unrepresentative.
	/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
	/// if a step occurs larger than the value (for the dimension), the track will
	/// be dropped and restarted after the step. (ie the part before the wrap
	/// around will be dropped and the newer part kept).
	/// </summary>
	public virtual void GetMaxStepDistance(IntPtr _arg)
	{
		vtkTemporalPathLineFilter_GetMaxStepDistance_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkTemporalPathLineFilter_GetMaxTrackLength_09(HandleRef pThis);

	/// <summary>
	/// If the Particles being traced animate for a long time, the
	/// trails or traces will become long and stringy. Setting
	/// the MaxTraceTimeLength will limit how much of the trace
	/// is displayed. Tracks longer then the Max will disappear
	/// and the trace will appear like a snake of fixed length
	/// which progresses as the particle moves
	/// </summary>
	public virtual uint GetMaxTrackLength()
	{
		return vtkTemporalPathLineFilter_GetMaxTrackLength_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalPathLineFilter_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalPathLineFilter_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalPathLineFilter_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalPathLineFilter_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalPathLineFilter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalPathLineFilter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalPathLineFilter_IsTypeOf_13(string type);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalPathLineFilter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalPathLineFilter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new vtkTemporalPathLineFilter NewInstance()
	{
		vtkTemporalPathLineFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalPathLineFilter_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalPathLineFilter_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard Type-Macro
	/// </summary>
	public new static vtkTemporalPathLineFilter SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalPathLineFilter vtkTemporalPathLineFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalPathLineFilter_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalPathLineFilter2 = (vtkTemporalPathLineFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalPathLineFilter2.Register(null);
			}
		}
		return vtkTemporalPathLineFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetBackwardTime_17(HandleRef pThis, byte backward);

	/// <summary>
	/// Set / Get if the filter is configured to work in backward time going mode.
	/// Default is false (time should go forward).
	///
	/// Time going forward means that for each call to RequestData, then the time
	/// step from vtkDataObject::DATA_TIME_STEP() is greater than the time step
	/// from the previous call. Time going backward means that the current time
	/// step is smaller than the previous one.
	/// </summary>
	public virtual void SetBackwardTime(bool backward)
	{
		vtkTemporalPathLineFilter_SetBackwardTime_17(GetCppThis(), (byte)(backward ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetIdChannelArray_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of a scalar array which will be used to fetch
	/// the index of each point. This is necessary only if the particles
	/// change position (Id order) on each time step. The Id can be used
	/// to identify particles at each step and hence track them properly.
	/// If this array is nullptr, the global point ids are used.  If an Id
	/// array cannot otherwise be found, the point index is used as the ID.
	/// </summary>
	public virtual void SetIdChannelArray(string _arg)
	{
		vtkTemporalPathLineFilter_SetIdChannelArray_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetKeepDeadTrails_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// When a particle 'disappears', the trail belonging to it is removed from
	/// the list. When this flag is enabled, dead trails will persist
	/// until the next time the list is cleared. Use carefully as it may cause
	/// excessive memory consumption if left on by mistake.
	/// </summary>
	public virtual void SetKeepDeadTrails(bool _arg)
	{
		vtkTemporalPathLineFilter_SetKeepDeadTrails_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetMaskPoints_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of particles to track as a ratio of the input
	/// example: setting MaskPoints to 10 will track every 10th point
	/// </summary>
	public virtual void SetMaskPoints(int _arg)
	{
		vtkTemporalPathLineFilter_SetMaskPoints_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetMaxStepDistance_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// If a particle disappears from one end of a simulation and reappears
	/// on the other side, the track left will be unrepresentative.
	/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
	/// if a step occurs larger than the value (for the dimension), the track will
	/// be dropped and restarted after the step. (ie the part before the wrap
	/// around will be dropped and the newer part kept).
	/// </summary>
	public virtual void SetMaxStepDistance(double _arg1, double _arg2, double _arg3)
	{
		vtkTemporalPathLineFilter_SetMaxStepDistance_21(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetMaxStepDistance_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// If a particle disappears from one end of a simulation and reappears
	/// on the other side, the track left will be unrepresentative.
	/// Set a MaxStepDistance{x,y,z} which acts as a threshold above which
	/// if a step occurs larger than the value (for the dimension), the track will
	/// be dropped and restarted after the step. (ie the part before the wrap
	/// around will be dropped and the newer part kept).
	/// </summary>
	public virtual void SetMaxStepDistance(IntPtr _arg)
	{
		vtkTemporalPathLineFilter_SetMaxStepDistance_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetMaxTrackLength_23(HandleRef pThis, uint _arg);

	/// <summary>
	/// If the Particles being traced animate for a long time, the
	/// trails or traces will become long and stringy. Setting
	/// the MaxTraceTimeLength will limit how much of the trace
	/// is displayed. Tracks longer then the Max will disappear
	/// and the trace will appear like a snake of fixed length
	/// which progresses as the particle moves
	/// </summary>
	public virtual void SetMaxTrackLength(uint _arg)
	{
		vtkTemporalPathLineFilter_SetMaxTrackLength_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetSelectionConnection_24(HandleRef pThis, HandleRef algOutput);

	/// <summary>
	/// Set a second input which is a selection. Particles with the same
	/// Id in the selection as the primary input will be chosen for pathlines
	/// Note that you must have the same IdChannelArray in the selection as the input
	/// </summary>
	public void SetSelectionConnection(vtkAlgorithmOutput algOutput)
	{
		vtkTemporalPathLineFilter_SetSelectionConnection_24(GetCppThis(), algOutput?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalPathLineFilter_SetSelectionData_25(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set a second input which is a selection. Particles with the same
	/// Id in the selection as the primary input will be chosen for pathlines
	/// Note that you must have the same IdChannelArray in the selection as the input
	/// </summary>
	public void SetSelectionData(vtkDataSet input)
	{
		vtkTemporalPathLineFilter_SetSelectionData_25(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}
}
