using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFast2DLayoutStrategy
/// </summary>
/// <remarks>
///    a simple fast 2D graph layout
///
///
/// This class is a density grid based force directed layout strategy.
/// Also please note that 'fast' is relative to quite slow. :)
/// The layout running time is O(V+E) with an extremely high constant.
/// @par Thanks:
/// Thanks to Godzilla for not eating my computer so that this class
/// could be written.
/// </remarks>
public class vtkFast2DLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFast2DLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFast2DLayoutStrategy()
	{
		MRClassNameKey = "class vtkFast2DLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFast2DLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFast2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFast2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFast2DLayoutStrategy New()
	{
		vtkFast2DLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFast2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFast2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFast2DLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFast2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkFast2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

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
		return vtkFast2DLayoutStrategy_GetCoolDownRate_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFast2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

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
		return vtkFast2DLayoutStrategy_GetCoolDownRateMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkFast2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

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
		return vtkFast2DLayoutStrategy_GetCoolDownRateMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFast2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperature()
	{
		return vtkFast2DLayoutStrategy_GetInitialTemperature_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFast2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperatureMaxValue()
	{
		return vtkFast2DLayoutStrategy_GetInitialTemperatureMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFast2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperatureMinValue()
	{
		return vtkFast2DLayoutStrategy_GetInitialTemperatureMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayout()
	{
		return vtkFast2DLayoutStrategy_GetIterationsPerLayout_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayoutMaxValue()
	{
		return vtkFast2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayoutMinValue()
	{
		return vtkFast2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetMaxNumberOfIterations_10(HandleRef pThis);

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
		return vtkFast2DLayoutStrategy_GetMaxNumberOfIterations_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(HandleRef pThis);

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
		return vtkFast2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(HandleRef pThis);

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
		return vtkFast2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFast2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFast2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFast2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFast2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetRandomSeed_15(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeed()
	{
		return vtkFast2DLayoutStrategy_GetRandomSeed_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetRandomSeedMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMaxValue()
	{
		return vtkFast2DLayoutStrategy_GetRandomSeedMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_GetRandomSeedMinValue_17(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMinValue()
	{
		return vtkFast2DLayoutStrategy_GetRandomSeedMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFast2DLayoutStrategy_GetRestDistance_18(HandleRef pThis);

	/// <summary>
	/// Manually set the resting distance. Otherwise the
	/// distance is computed automatically.
	/// </summary>
	public virtual float GetRestDistance()
	{
		return vtkFast2DLayoutStrategy_GetRestDistance_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFast2DLayoutStrategy_Initialize_19(HandleRef pThis);

	/// <summary>
	/// This strategy sets up some data structures
	/// for faster processing of each Layout() call
	/// </summary>
	public override void Initialize()
	{
		vtkFast2DLayoutStrategy_Initialize_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFast2DLayoutStrategy_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_IsLayoutComplete_21(HandleRef pThis);

	/// <summary>
	/// I'm an iterative layout so this method lets the caller
	/// know if I'm done laying out the graph
	/// </summary>
	public override int IsLayoutComplete()
	{
		return vtkFast2DLayoutStrategy_IsLayoutComplete_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFast2DLayoutStrategy_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFast2DLayoutStrategy_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFast2DLayoutStrategy_Layout_23(HandleRef pThis);

	/// <summary>
	/// This is the layout method where the graph that was
	/// set in SetGraph() is laid out. The method can either
	/// entirely layout the graph or iteratively lay out the
	/// graph. If you have an iterative layout please implement
	/// the IsLayoutComplete() method.
	/// </summary>
	public override void Layout()
	{
		vtkFast2DLayoutStrategy_Layout_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFast2DLayoutStrategy_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFast2DLayoutStrategy NewInstance()
	{
		vtkFast2DLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFast2DLayoutStrategy_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFast2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFast2DLayoutStrategy_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFast2DLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkFast2DLayoutStrategy vtkFast2DLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFast2DLayoutStrategy_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFast2DLayoutStrategy2 = (vtkFast2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFast2DLayoutStrategy2.Register(null);
			}
		}
		return vtkFast2DLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFast2DLayoutStrategy_SetCoolDownRate_27(HandleRef pThis, double _arg);

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
		vtkFast2DLayoutStrategy_SetCoolDownRate_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFast2DLayoutStrategy_SetInitialTemperature_28(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual void SetInitialTemperature(float _arg)
	{
		vtkFast2DLayoutStrategy_SetInitialTemperature_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFast2DLayoutStrategy_SetIterationsPerLayout_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual void SetIterationsPerLayout(int _arg)
	{
		vtkFast2DLayoutStrategy_SetIterationsPerLayout_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFast2DLayoutStrategy_SetMaxNumberOfIterations_30(HandleRef pThis, int _arg);

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
		vtkFast2DLayoutStrategy_SetMaxNumberOfIterations_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFast2DLayoutStrategy_SetRandomSeed_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual void SetRandomSeed(int _arg)
	{
		vtkFast2DLayoutStrategy_SetRandomSeed_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFast2DLayoutStrategy_SetRestDistance_32(HandleRef pThis, float _arg);

	/// <summary>
	/// Manually set the resting distance. Otherwise the
	/// distance is computed automatically.
	/// </summary>
	public virtual void SetRestDistance(float _arg)
	{
		vtkFast2DLayoutStrategy_SetRestDistance_32(GetCppThis(), _arg);
	}
}
