using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSimple2DLayoutStrategy
/// </summary>
/// <remarks>
///    a simple 2D graph layout
///
///
/// This class is an implementation of the work presented in:
/// Fruchterman &amp; Reingold "Graph Drawing by Force-directed Placement"
/// Software-Practice and Experience 21(11) 1991).
/// The class includes some optimizations but nothing too fancy.
///
/// @par Thanks:
/// Thanks to Brian Wylie from Sandia National Laboratories for creating this
/// class.
/// </remarks>
public class vtkSimple2DLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSimple2DLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSimple2DLayoutStrategy()
	{
		MRClassNameKey = "class vtkSimple2DLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimple2DLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSimple2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimple2DLayoutStrategy New()
	{
		vtkSimple2DLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSimple2DLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSimple2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified. The default is '10'
	/// for no particular reason.
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual double GetCoolDownRate()
	{
		return vtkSimple2DLayoutStrategy_GetCoolDownRate_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified. The default is '10'
	/// for no particular reason.
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual double GetCoolDownRateMaxValue()
	{
		return vtkSimple2DLayoutStrategy_GetCoolDownRateMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSimple2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified. The default is '10'
	/// for no particular reason.
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual double GetCoolDownRateMinValue()
	{
		return vtkSimple2DLayoutStrategy_GetCoolDownRateMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperature()
	{
		return vtkSimple2DLayoutStrategy_GetInitialTemperature_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperatureMaxValue()
	{
		return vtkSimple2DLayoutStrategy_GetInitialTemperatureMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSimple2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperatureMinValue()
	{
		return vtkSimple2DLayoutStrategy_GetInitialTemperatureMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayout()
	{
		return vtkSimple2DLayoutStrategy_GetIterationsPerLayout_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayoutMaxValue()
	{
		return vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayoutMinValue()
	{
		return vtkSimple2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkSimple2DLayoutStrategy_GetJitter_10(HandleRef pThis);

	/// <summary>
	/// Set Random jitter of the nodes at initialization
	/// to on or off.
	/// Note: It's strongly recommendation to have jitter ON
	/// even if you have initial coordinates in your graph.
	/// Default is ON
	/// </summary>
	public virtual bool GetJitter()
	{
		return (vtkSimple2DLayoutStrategy_GetJitter_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterations_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// The default is '100' for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual int GetMaxNumberOfIterations()
	{
		return vtkSimple2DLayoutStrategy_GetMaxNumberOfIterations_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// The default is '100' for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual int GetMaxNumberOfIterationsMaxValue()
	{
		return vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// The default is '100' for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual int GetMaxNumberOfIterationsMinValue()
	{
		return vtkSimple2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimple2DLayoutStrategy_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSimple2DLayoutStrategy_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimple2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSimple2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeed_16(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeed()
	{
		return vtkSimple2DLayoutStrategy_GetRandomSeed_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeedMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMaxValue()
	{
		return vtkSimple2DLayoutStrategy_GetRandomSeedMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_GetRandomSeedMinValue_18(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMinValue()
	{
		return vtkSimple2DLayoutStrategy_GetRandomSeedMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkSimple2DLayoutStrategy_GetRestDistance_19(HandleRef pThis);

	/// <summary>
	/// Manually set the resting distance. Otherwise the
	/// distance is computed automatically.
	/// </summary>
	public virtual float GetRestDistance()
	{
		return vtkSimple2DLayoutStrategy_GetRestDistance_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_Initialize_20(HandleRef pThis);

	/// <summary>
	/// This strategy sets up some data structures
	/// for faster processing of each Layout() call
	/// </summary>
	public override void Initialize()
	{
		vtkSimple2DLayoutStrategy_Initialize_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSimple2DLayoutStrategy_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_IsLayoutComplete_22(HandleRef pThis);

	/// <summary>
	/// I'm an iterative layout so this method lets the caller
	/// know if I'm done laying out the graph
	/// </summary>
	public override int IsLayoutComplete()
	{
		return vtkSimple2DLayoutStrategy_IsLayoutComplete_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimple2DLayoutStrategy_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSimple2DLayoutStrategy_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_Layout_24(HandleRef pThis);

	/// <summary>
	/// This is the layout method where the graph that was
	/// set in SetGraph() is laid out. The method can either
	/// entirely layout the graph or iteratively lay out the
	/// graph. If you have an iterative layout please implement
	/// the IsLayoutComplete() method.
	/// </summary>
	public override void Layout()
	{
		vtkSimple2DLayoutStrategy_Layout_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple2DLayoutStrategy_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSimple2DLayoutStrategy NewInstance()
	{
		vtkSimple2DLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple2DLayoutStrategy_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimple2DLayoutStrategy_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimple2DLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkSimple2DLayoutStrategy vtkSimple2DLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimple2DLayoutStrategy_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSimple2DLayoutStrategy2 = (vtkSimple2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSimple2DLayoutStrategy2.Register(null);
			}
		}
		return vtkSimple2DLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_SetCoolDownRate_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified. The default is '10'
	/// for no particular reason.
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual void SetCoolDownRate(double _arg)
	{
		vtkSimple2DLayoutStrategy_SetCoolDownRate_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_SetInitialTemperature_29(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual void SetInitialTemperature(float _arg)
	{
		vtkSimple2DLayoutStrategy_SetInitialTemperature_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_SetIterationsPerLayout_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual void SetIterationsPerLayout(int _arg)
	{
		vtkSimple2DLayoutStrategy_SetIterationsPerLayout_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_SetJitter_31(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set Random jitter of the nodes at initialization
	/// to on or off.
	/// Note: It's strongly recommendation to have jitter ON
	/// even if you have initial coordinates in your graph.
	/// Default is ON
	/// </summary>
	public virtual void SetJitter(bool _arg)
	{
		vtkSimple2DLayoutStrategy_SetJitter_31(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_SetMaxNumberOfIterations_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// The default is '100' for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual void SetMaxNumberOfIterations(int _arg)
	{
		vtkSimple2DLayoutStrategy_SetMaxNumberOfIterations_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_SetRandomSeed_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual void SetRandomSeed(int _arg)
	{
		vtkSimple2DLayoutStrategy_SetRandomSeed_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimple2DLayoutStrategy_SetRestDistance_34(HandleRef pThis, float _arg);

	/// <summary>
	/// Manually set the resting distance. Otherwise the
	/// distance is computed automatically.
	/// </summary>
	public virtual void SetRestDistance(float _arg)
	{
		vtkSimple2DLayoutStrategy_SetRestDistance_34(GetCppThis(), _arg);
	}
}
