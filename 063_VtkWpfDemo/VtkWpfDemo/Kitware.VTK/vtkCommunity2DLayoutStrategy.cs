using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCommunity2DLayoutStrategy
/// </summary>
/// <remarks>
///    a simple fast 2D graph layout
/// that looks for a community array on it's input and strengthens
/// edges within a community and weakens edges not within the community.
///
///
/// This class is a density grid based force directed layout strategy.
/// Also please note that 'fast' is relative to quite slow. :)
/// The layout running time is O(V+E) with an extremely high constant.
/// @par Thanks:
/// Thanks to Godzilla for not eating my computer so that this class
/// could be written.
/// </remarks>
public class vtkCommunity2DLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCommunity2DLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCommunity2DLayoutStrategy()
	{
		MRClassNameKey = "class vtkCommunity2DLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCommunity2DLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCommunity2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommunity2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCommunity2DLayoutStrategy New()
	{
		vtkCommunity2DLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCommunity2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCommunity2DLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCommunity2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkCommunity2DLayoutStrategy_GetCommunityArrayName_01(HandleRef pThis);

	/// <summary>
	/// Get/Set the community array name
	/// </summary>
	public virtual string GetCommunityArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkCommunity2DLayoutStrategy_GetCommunityArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrength_02(HandleRef pThis);

	/// <summary>
	/// Set the community 'strength'.  The default is '1'
	/// which means vertices in the same community will be
	/// placed close together, values closer to .1 (minimum)
	/// will mean a layout closer to traditional force directed.
	/// </summary>
	public virtual float GetCommunityStrength()
	{
		return vtkCommunity2DLayoutStrategy_GetCommunityStrength_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrengthMaxValue_03(HandleRef pThis);

	/// <summary>
	/// Set the community 'strength'.  The default is '1'
	/// which means vertices in the same community will be
	/// placed close together, values closer to .1 (minimum)
	/// will mean a layout closer to traditional force directed.
	/// </summary>
	public virtual float GetCommunityStrengthMaxValue()
	{
		return vtkCommunity2DLayoutStrategy_GetCommunityStrengthMaxValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCommunity2DLayoutStrategy_GetCommunityStrengthMinValue_04(HandleRef pThis);

	/// <summary>
	/// Set the community 'strength'.  The default is '1'
	/// which means vertices in the same community will be
	/// placed close together, values closer to .1 (minimum)
	/// will mean a layout closer to traditional force directed.
	/// </summary>
	public virtual float GetCommunityStrengthMinValue()
	{
		return vtkCommunity2DLayoutStrategy_GetCommunityStrengthMinValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRate_05(HandleRef pThis);

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
		return vtkCommunity2DLayoutStrategy_GetCoolDownRate_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRateMaxValue_06(HandleRef pThis);

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
		return vtkCommunity2DLayoutStrategy_GetCoolDownRateMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCommunity2DLayoutStrategy_GetCoolDownRateMinValue_07(HandleRef pThis);

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
		return vtkCommunity2DLayoutStrategy_GetCoolDownRateMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperature_08(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperature()
	{
		return vtkCommunity2DLayoutStrategy_GetInitialTemperature_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperatureMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperatureMaxValue()
	{
		return vtkCommunity2DLayoutStrategy_GetInitialTemperatureMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCommunity2DLayoutStrategy_GetInitialTemperatureMinValue_10(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperatureMinValue()
	{
		return vtkCommunity2DLayoutStrategy_GetInitialTemperatureMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayout_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayout()
	{
		return vtkCommunity2DLayoutStrategy_GetIterationsPerLayout_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMaxValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayoutMaxValue()
	{
		return vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMaxValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMinValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayoutMinValue()
	{
		return vtkCommunity2DLayoutStrategy_GetIterationsPerLayoutMinValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterations_14(HandleRef pThis);

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
		return vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterations_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_15(HandleRef pThis);

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
		return vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_16(HandleRef pThis);

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
		return vtkCommunity2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCommunity2DLayoutStrategy_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCommunity2DLayoutStrategy_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCommunity2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCommunity2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeed_19(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeed()
	{
		return vtkCommunity2DLayoutStrategy_GetRandomSeed_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeedMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMaxValue()
	{
		return vtkCommunity2DLayoutStrategy_GetRandomSeedMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_GetRandomSeedMinValue_21(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMinValue()
	{
		return vtkCommunity2DLayoutStrategy_GetRandomSeedMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkCommunity2DLayoutStrategy_GetRestDistance_22(HandleRef pThis);

	/// <summary>
	/// Manually set the resting distance. Otherwise the
	/// distance is computed automatically.
	/// </summary>
	public virtual float GetRestDistance()
	{
		return vtkCommunity2DLayoutStrategy_GetRestDistance_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_Initialize_23(HandleRef pThis);

	/// <summary>
	/// This strategy sets up some data structures
	/// for faster processing of each Layout() call
	/// </summary>
	public override void Initialize()
	{
		vtkCommunity2DLayoutStrategy_Initialize_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCommunity2DLayoutStrategy_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_IsLayoutComplete_25(HandleRef pThis);

	/// <summary>
	/// I'm an iterative layout so this method lets the caller
	/// know if I'm done laying out the graph
	/// </summary>
	public override int IsLayoutComplete()
	{
		return vtkCommunity2DLayoutStrategy_IsLayoutComplete_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCommunity2DLayoutStrategy_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCommunity2DLayoutStrategy_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_Layout_27(HandleRef pThis);

	/// <summary>
	/// This is the layout method where the graph that was
	/// set in SetGraph() is laid out. The method can either
	/// entirely layout the graph or iteratively lay out the
	/// graph. If you have an iterative layout please implement
	/// the IsLayoutComplete() method.
	/// </summary>
	public override void Layout()
	{
		vtkCommunity2DLayoutStrategy_Layout_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommunity2DLayoutStrategy_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCommunity2DLayoutStrategy NewInstance()
	{
		vtkCommunity2DLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCommunity2DLayoutStrategy_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCommunity2DLayoutStrategy_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCommunity2DLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkCommunity2DLayoutStrategy vtkCommunity2DLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCommunity2DLayoutStrategy_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCommunity2DLayoutStrategy2 = (vtkCommunity2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCommunity2DLayoutStrategy2.Register(null);
			}
		}
		return vtkCommunity2DLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_SetCommunityArrayName_31(HandleRef pThis, string _arg);

	/// <summary>
	/// Get/Set the community array name
	/// </summary>
	public virtual void SetCommunityArrayName(string _arg)
	{
		vtkCommunity2DLayoutStrategy_SetCommunityArrayName_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_SetCommunityStrength_32(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the community 'strength'.  The default is '1'
	/// which means vertices in the same community will be
	/// placed close together, values closer to .1 (minimum)
	/// will mean a layout closer to traditional force directed.
	/// </summary>
	public virtual void SetCommunityStrength(float _arg)
	{
		vtkCommunity2DLayoutStrategy_SetCommunityStrength_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_SetCoolDownRate_33(HandleRef pThis, double _arg);

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
		vtkCommunity2DLayoutStrategy_SetCoolDownRate_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_SetInitialTemperature_34(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual void SetInitialTemperature(float _arg)
	{
		vtkCommunity2DLayoutStrategy_SetInitialTemperature_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_SetIterationsPerLayout_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual void SetIterationsPerLayout(int _arg)
	{
		vtkCommunity2DLayoutStrategy_SetIterationsPerLayout_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_SetMaxNumberOfIterations_36(HandleRef pThis, int _arg);

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
		vtkCommunity2DLayoutStrategy_SetMaxNumberOfIterations_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_SetRandomSeed_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual void SetRandomSeed(int _arg)
	{
		vtkCommunity2DLayoutStrategy_SetRandomSeed_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCommunity2DLayoutStrategy_SetRestDistance_38(HandleRef pThis, float _arg);

	/// <summary>
	/// Manually set the resting distance. Otherwise the
	/// distance is computed automatically.
	/// </summary>
	public virtual void SetRestDistance(float _arg)
	{
		vtkCommunity2DLayoutStrategy_SetRestDistance_38(GetCppThis(), _arg);
	}
}
