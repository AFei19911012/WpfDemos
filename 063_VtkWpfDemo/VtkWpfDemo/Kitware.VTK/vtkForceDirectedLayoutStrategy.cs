using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkForceDirectedLayoutStrategy
/// </summary>
/// <remarks>
///    a force directed graph layout algorithm
///
///
/// Lays out a graph in 2D or 3D using a force-directed algorithm.
/// The user may specify whether to layout the graph randomly initially,
/// the bounds, the number of dimensions (2 or 3), and the cool-down rate.
///
/// @par Thanks:
/// Thanks to Brian Wylie for adding functionality for allowing this layout
/// to be incremental.
/// </remarks>
public class vtkForceDirectedLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkForceDirectedLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkForceDirectedLayoutStrategy()
	{
		MRClassNameKey = "class vtkForceDirectedLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkForceDirectedLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkForceDirectedLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkForceDirectedLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkForceDirectedLayoutStrategy New()
	{
		vtkForceDirectedLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkForceDirectedLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkForceDirectedLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkForceDirectedLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void AutomaticBoundsComputationOff()
	{
		vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void AutomaticBoundsComputationOn()
	{
		vtkForceDirectedLayoutStrategy_AutomaticBoundsComputationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetAutomaticBoundsComputation_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual int GetAutomaticBoundsComputation()
	{
		return vtkForceDirectedLayoutStrategy_GetAutomaticBoundsComputation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRate_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual double GetCoolDownRate()
	{
		return vtkForceDirectedLayoutStrategy_GetCoolDownRate_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRateMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual double GetCoolDownRateMaxValue()
	{
		return vtkForceDirectedLayoutStrategy_GetCoolDownRateMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkForceDirectedLayoutStrategy_GetCoolDownRateMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual double GetCoolDownRateMinValue()
	{
		return vtkForceDirectedLayoutStrategy_GetCoolDownRateMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkForceDirectedLayoutStrategy_GetGraphBounds_07(HandleRef pThis);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual double[] GetGraphBounds()
	{
		IntPtr intPtr = vtkForceDirectedLayoutStrategy_GetGraphBounds_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_GetGraphBounds_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void GetGraphBounds(IntPtr data)
	{
		vtkForceDirectedLayoutStrategy_GetGraphBounds_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperature_09(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  If zero (the default) , the initial temperature
	/// will be computed automatically.
	/// </summary>
	public virtual float GetInitialTemperature()
	{
		return vtkForceDirectedLayoutStrategy_GetInitialTemperature_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperatureMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  If zero (the default) , the initial temperature
	/// will be computed automatically.
	/// </summary>
	public virtual float GetInitialTemperatureMaxValue()
	{
		return vtkForceDirectedLayoutStrategy_GetInitialTemperatureMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkForceDirectedLayoutStrategy_GetInitialTemperatureMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  If zero (the default) , the initial temperature
	/// will be computed automatically.
	/// </summary>
	public virtual float GetInitialTemperatureMinValue()
	{
		return vtkForceDirectedLayoutStrategy_GetInitialTemperatureMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayout_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '50' to match the default 'MaxNumberOfIterations'
	/// </summary>
	public virtual int GetIterationsPerLayout()
	{
		return vtkForceDirectedLayoutStrategy_GetIterationsPerLayout_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '50' to match the default 'MaxNumberOfIterations'
	/// </summary>
	public virtual int GetIterationsPerLayoutMaxValue()
	{
		return vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '50' to match the default 'MaxNumberOfIterations'
	/// </summary>
	public virtual int GetIterationsPerLayoutMinValue()
	{
		return vtkForceDirectedLayoutStrategy_GetIterationsPerLayoutMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterations_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// The default is '50' for no particular reason
	/// </summary>
	public virtual int GetMaxNumberOfIterations()
	{
		return vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterations_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// The default is '50' for no particular reason
	/// </summary>
	public virtual int GetMaxNumberOfIterationsMaxValue()
	{
		return vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMinValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// The default is '50' for no particular reason
	/// </summary>
	public virtual int GetMaxNumberOfIterationsMinValue()
	{
		return vtkForceDirectedLayoutStrategy_GetMaxNumberOfIterationsMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkForceDirectedLayoutStrategy_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkForceDirectedLayoutStrategy_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkForceDirectedLayoutStrategy_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkForceDirectedLayoutStrategy_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetRandomInitialPoints_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of random positions within the graph bounds as initial points.
	/// </summary>
	public virtual int GetRandomInitialPoints()
	{
		return vtkForceDirectedLayoutStrategy_GetRandomInitialPoints_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeed_21(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeed()
	{
		return vtkForceDirectedLayoutStrategy_GetRandomSeed_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeedMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMaxValue()
	{
		return vtkForceDirectedLayoutStrategy_GetRandomSeedMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetRandomSeedMinValue_23(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMinValue()
	{
		return vtkForceDirectedLayoutStrategy_GetRandomSeedMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_GetThreeDimensionalLayout_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off layout of graph in three dimensions. If off, graph
	/// layout occurs in two dimensions. By default, three dimensional
	/// layout is off.
	/// </summary>
	public virtual int GetThreeDimensionalLayout()
	{
		return vtkForceDirectedLayoutStrategy_GetThreeDimensionalLayout_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_Initialize_25(HandleRef pThis);

	/// <summary>
	/// This strategy sets up some data structures
	/// for faster processing of each Layout() call
	/// </summary>
	public override void Initialize()
	{
		vtkForceDirectedLayoutStrategy_Initialize_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_IsA_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkForceDirectedLayoutStrategy_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_IsLayoutComplete_27(HandleRef pThis);

	/// <summary>
	/// I'm an iterative layout so this method lets the caller
	/// know if I'm done laying out the graph
	/// </summary>
	public override int IsLayoutComplete()
	{
		return vtkForceDirectedLayoutStrategy_IsLayoutComplete_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkForceDirectedLayoutStrategy_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkForceDirectedLayoutStrategy_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_Layout_29(HandleRef pThis);

	/// <summary>
	/// This is the layout method where the graph that was
	/// set in SetGraph() is laid out. The method can either
	/// entirely layout the graph or iteratively lay out the
	/// graph. If you have an iterative layout please implement
	/// the IsLayoutComplete() method.
	/// </summary>
	public override void Layout()
	{
		vtkForceDirectedLayoutStrategy_Layout_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkForceDirectedLayoutStrategy_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkForceDirectedLayoutStrategy NewInstance()
	{
		vtkForceDirectedLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkForceDirectedLayoutStrategy_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_RandomInitialPointsOff_32(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of random positions within the graph bounds as initial points.
	/// </summary>
	public virtual void RandomInitialPointsOff()
	{
		vtkForceDirectedLayoutStrategy_RandomInitialPointsOff_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_RandomInitialPointsOn_33(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of random positions within the graph bounds as initial points.
	/// </summary>
	public virtual void RandomInitialPointsOn()
	{
		vtkForceDirectedLayoutStrategy_RandomInitialPointsOn_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkForceDirectedLayoutStrategy_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkForceDirectedLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkForceDirectedLayoutStrategy vtkForceDirectedLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkForceDirectedLayoutStrategy_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkForceDirectedLayoutStrategy2 = (vtkForceDirectedLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkForceDirectedLayoutStrategy2.Register(null);
			}
		}
		return vtkForceDirectedLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetAutomaticBoundsComputation_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void SetAutomaticBoundsComputation(int _arg)
	{
		vtkForceDirectedLayoutStrategy_SetAutomaticBoundsComputation_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetCoolDownRate_36(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual void SetCoolDownRate(double _arg)
	{
		vtkForceDirectedLayoutStrategy_SetCoolDownRate_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetGraphBounds_37(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkForceDirectedLayoutStrategy_SetGraphBounds_37(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetGraphBounds_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void SetGraphBounds(IntPtr _arg)
	{
		vtkForceDirectedLayoutStrategy_SetGraphBounds_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetInitialTemperature_39(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the initial temperature.  If zero (the default) , the initial temperature
	/// will be computed automatically.
	/// </summary>
	public virtual void SetInitialTemperature(float _arg)
	{
		vtkForceDirectedLayoutStrategy_SetInitialTemperature_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetIterationsPerLayout_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '50' to match the default 'MaxNumberOfIterations'
	/// </summary>
	public virtual void SetIterationsPerLayout(int _arg)
	{
		vtkForceDirectedLayoutStrategy_SetIterationsPerLayout_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetMaxNumberOfIterations_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// The default is '50' for no particular reason
	/// </summary>
	public virtual void SetMaxNumberOfIterations(int _arg)
	{
		vtkForceDirectedLayoutStrategy_SetMaxNumberOfIterations_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetRandomInitialPoints_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off use of random positions within the graph bounds as initial points.
	/// </summary>
	public virtual void SetRandomInitialPoints(int _arg)
	{
		vtkForceDirectedLayoutStrategy_SetRandomInitialPoints_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetRandomSeed_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual void SetRandomSeed(int _arg)
	{
		vtkForceDirectedLayoutStrategy_SetRandomSeed_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_SetThreeDimensionalLayout_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off layout of graph in three dimensions. If off, graph
	/// layout occurs in two dimensions. By default, three dimensional
	/// layout is off.
	/// </summary>
	public virtual void SetThreeDimensionalLayout(int _arg)
	{
		vtkForceDirectedLayoutStrategy_SetThreeDimensionalLayout_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOff_45(HandleRef pThis);

	/// <summary>
	/// Turn on/off layout of graph in three dimensions. If off, graph
	/// layout occurs in two dimensions. By default, three dimensional
	/// layout is off.
	/// </summary>
	public virtual void ThreeDimensionalLayoutOff()
	{
		vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOff_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOn_46(HandleRef pThis);

	/// <summary>
	/// Turn on/off layout of graph in three dimensions. If off, graph
	/// layout occurs in two dimensions. By default, three dimensional
	/// layout is off.
	/// </summary>
	public virtual void ThreeDimensionalLayoutOn()
	{
		vtkForceDirectedLayoutStrategy_ThreeDimensionalLayoutOn_46(GetCppThis());
	}
}
