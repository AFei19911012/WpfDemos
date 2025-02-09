using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTemporalInterpolator
/// </summary>
/// <remarks>
///    interpolate datasets between time steps to produce a new dataset
///
/// vtkTemporalInterpolator interpolates between two time steps to
/// produce new data for an arbitrary T.
/// vtkTemporalInterpolator has three modes of operation.
/// The default mode is to produce a continuous range of time
/// values as output, which enables a filter downstream to request
/// any value of T within the range.
/// The second mode of operation is enabled by setting
/// DiscreteTimeStepInterval to a non zero value. When this mode is
/// activated, the filter will report a finite number of Time steps
/// separated by deltaT between the original range of values.
/// This mode is useful when a dataset of N time steps has one (or more)
/// missing datasets for certain T values and you simply wish to smooth
/// over the missing steps but otherwise use the original data.
/// The third mode of operation is enabled by setting
/// ResampleFactor to a non zero positive integer value.
/// When this mode is activated, the filter will report a finite number
/// of Time steps which contain the original steps, plus N new values between
/// each original step 1/ResampleFactor time units apart.
/// Note that if the input time steps are irregular, then using ResampleFactor
/// will produce an irregular sequence of regular steps between
/// each of the original irregular steps (clear enough, yes?).
///
/// @todo
/// Higher order interpolation schemes will require changes to the API
/// as most calls assume only two timesteps are used.
///
/// @par Thanks:
/// Ken Martin (Kitware) and John Bidiscombe of
/// CSCS - Swiss National Supercomputing Centre
/// for creating and contributing this class.
/// For related material, please refer to :
/// John Biddiscombe, Berk Geveci, Ken Martin, Kenneth Moreland, David Thompson,
/// "Time Dependent Processing in a Parallel Pipeline Architecture",
/// IEEE Visualization 2007.
/// </remarks>
public class vtkTemporalInterpolator : vtkMultiTimeStepAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTemporalInterpolator()
	{
		MRClassNameKey = "class vtkTemporalInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTemporalInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalInterpolator New()
	{
		vtkTemporalInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTemporalInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTemporalInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkTemporalInterpolator_GetCacheData_01(HandleRef pThis);

	/// <summary>
	/// Controls whether input data is cached to avoid updating input
	/// when multiple interpolations are asked between 2 time steps.
	/// </summary>
	public virtual bool GetCacheData()
	{
		return (vtkTemporalInterpolator_GetCacheData_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkTemporalInterpolator_GetDiscreteTimeStepInterval_02(HandleRef pThis);

	/// <summary>
	/// If you require a discrete number of outputs steps, to be
	/// generated from an input source - for example, you required
	/// N steps separated by T, then set DiscreteTimeStepInterval to T
	/// and you will get TIME_RANGE/DiscreteTimeStepInterval steps
	/// This is a useful option to use if you have a dataset with one
	/// missing time step and wish to 'fill-in' the missing data
	/// with an interpolated value from the steps either side
	/// </summary>
	public virtual double GetDiscreteTimeStepInterval()
	{
		return vtkTemporalInterpolator_GetDiscreteTimeStepInterval_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalInterpolator_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTemporalInterpolator_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTemporalInterpolator_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTemporalInterpolator_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolator_GetResampleFactor_05(HandleRef pThis);

	/// <summary>
	/// When ResampleFactor is a non zero positive integer, each pair
	/// of input time steps will be interpolated between with the number
	/// of steps specified. For example an input of 1,2,3,4,5 and a resample factor
	/// of 10, will produce steps 0f 1.0, 1.1, 1.2.....1.9, 2.0 etc
	/// NB. Irregular input steps will produce irregular output steps.
	/// Resample factor wuill only be used if DiscreteTimeStepInterval is zero
	/// otherwise the DiscreteTimeStepInterval takes precedence
	/// </summary>
	public virtual int GetResampleFactor()
	{
		return vtkTemporalInterpolator_GetResampleFactor_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTemporalInterpolator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTemporalInterpolator_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTemporalInterpolator_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalInterpolator_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTemporalInterpolator NewInstance()
	{
		vtkTemporalInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalInterpolator_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTemporalInterpolator_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTemporalInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkTemporalInterpolator vtkTemporalInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTemporalInterpolator_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTemporalInterpolator2 = (vtkTemporalInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTemporalInterpolator2.Register(null);
			}
		}
		return vtkTemporalInterpolator2;
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolator_SetCacheData_11(HandleRef pThis, byte _arg);

	/// <summary>
	/// Controls whether input data is cached to avoid updating input
	/// when multiple interpolations are asked between 2 time steps.
	/// </summary>
	public virtual void SetCacheData(bool _arg)
	{
		vtkTemporalInterpolator_SetCacheData_11(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolator_SetDiscreteTimeStepInterval_12(HandleRef pThis, double _arg);

	/// <summary>
	/// If you require a discrete number of outputs steps, to be
	/// generated from an input source - for example, you required
	/// N steps separated by T, then set DiscreteTimeStepInterval to T
	/// and you will get TIME_RANGE/DiscreteTimeStepInterval steps
	/// This is a useful option to use if you have a dataset with one
	/// missing time step and wish to 'fill-in' the missing data
	/// with an interpolated value from the steps either side
	/// </summary>
	public virtual void SetDiscreteTimeStepInterval(double _arg)
	{
		vtkTemporalInterpolator_SetDiscreteTimeStepInterval_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTemporalInterpolator_SetResampleFactor_13(HandleRef pThis, int _arg);

	/// <summary>
	/// When ResampleFactor is a non zero positive integer, each pair
	/// of input time steps will be interpolated between with the number
	/// of steps specified. For example an input of 1,2,3,4,5 and a resample factor
	/// of 10, will produce steps 0f 1.0, 1.1, 1.2.....1.9, 2.0 etc
	/// NB. Irregular input steps will produce irregular output steps.
	/// Resample factor wuill only be used if DiscreteTimeStepInterval is zero
	/// otherwise the DiscreteTimeStepInterval takes precedence
	/// </summary>
	public virtual void SetResampleFactor(int _arg)
	{
		vtkTemporalInterpolator_SetResampleFactor_13(GetCppThis(), _arg);
	}
}
