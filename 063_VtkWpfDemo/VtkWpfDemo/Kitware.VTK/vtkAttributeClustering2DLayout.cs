using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAttributeClustering2DLayoutStrategy
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
public class vtkAttributeClustering2DLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAttributeClustering2DLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAttributeClustering2DLayoutStrategy()
	{
		MRClassNameKey = "class vtkAttributeClustering2DLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAttributeClustering2DLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAttributeClustering2DLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAttributeClustering2DLayoutStrategy New()
	{
		vtkAttributeClustering2DLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAttributeClustering2DLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAttributeClustering2DLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRate_01(HandleRef pThis);

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
		return vtkAttributeClustering2DLayoutStrategy_GetCoolDownRate_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(HandleRef pThis);

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
		return vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(HandleRef pThis);

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
		return vtkAttributeClustering2DLayoutStrategy_GetCoolDownRateMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperature_04(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperature()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetInitialTemperature_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperatureMaxValue()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual float GetInitialTemperatureMinValue()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetInitialTemperatureMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayout_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayout()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayout_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayoutMaxValue()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual int GetIterationsPerLayoutMinValue()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetIterationsPerLayoutMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(HandleRef pThis);

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
		return vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterations_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(HandleRef pThis);

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
		return vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(HandleRef pThis);

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
		return vtkAttributeClustering2DLayoutStrategy_GetMaxNumberOfIterationsMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAttributeClustering2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAttributeClustering2DLayoutStrategy_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAttributeClustering2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAttributeClustering2DLayoutStrategy_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeed_15(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeed()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetRandomSeed_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMaxValue_16(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMaxValue()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMinValue_17(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMinValue()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetRandomSeedMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkAttributeClustering2DLayoutStrategy_GetRestDistance_18(HandleRef pThis);

	/// <summary>
	/// Manually set the resting distance. Otherwise the
	/// distance is computed automatically.
	/// </summary>
	public virtual float GetRestDistance()
	{
		return vtkAttributeClustering2DLayoutStrategy_GetRestDistance_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_GetVertexAttribute_19(HandleRef pThis);

	/// <summary>
	/// The name of the array on the vertices, whose values will be used for
	/// determining clusters.
	/// </summary>
	public virtual string GetVertexAttribute()
	{
		return Marshal.PtrToStringAnsi(vtkAttributeClustering2DLayoutStrategy_GetVertexAttribute_19(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_Initialize_20(HandleRef pThis);

	/// <summary>
	/// This strategy sets up some data structures
	/// for faster processing of each Layout() call
	/// </summary>
	public override void Initialize()
	{
		vtkAttributeClustering2DLayoutStrategy_Initialize_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAttributeClustering2DLayoutStrategy_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_IsLayoutComplete_22(HandleRef pThis);

	/// <summary>
	/// I'm an iterative layout so this method lets the caller
	/// know if I'm done laying out the graph
	/// </summary>
	public override int IsLayoutComplete()
	{
		return vtkAttributeClustering2DLayoutStrategy_IsLayoutComplete_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAttributeClustering2DLayoutStrategy_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAttributeClustering2DLayoutStrategy_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_Layout_24(HandleRef pThis);

	/// <summary>
	/// This is the layout method where the graph that was
	/// set in SetGraph() is laid out. The method can either
	/// entirely layout the graph or iteratively lay out the
	/// graph. If you have an iterative layout please implement
	/// the IsLayoutComplete() method.
	/// </summary>
	public override void Layout()
	{
		vtkAttributeClustering2DLayoutStrategy_Layout_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAttributeClustering2DLayoutStrategy NewInstance()
	{
		vtkAttributeClustering2DLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAttributeClustering2DLayoutStrategy_SafeDownCast_27(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAttributeClustering2DLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkAttributeClustering2DLayoutStrategy vtkAttributeClustering2DLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAttributeClustering2DLayoutStrategy_SafeDownCast_27(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAttributeClustering2DLayoutStrategy2 = (vtkAttributeClustering2DLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAttributeClustering2DLayoutStrategy2.Register(null);
			}
		}
		return vtkAttributeClustering2DLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_SetCoolDownRate_28(HandleRef pThis, double _arg);

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
		vtkAttributeClustering2DLayoutStrategy_SetCoolDownRate_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_SetInitialTemperature_29(HandleRef pThis, float _arg);

	/// <summary>
	/// Set the initial temperature.  The temperature default is '5'
	/// for no particular reason
	/// Note: The strong recommendation is that you do not change
	/// this parameter. :)
	/// </summary>
	public virtual void SetInitialTemperature(float _arg)
	{
		vtkAttributeClustering2DLayoutStrategy_SetInitialTemperature_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_SetIterationsPerLayout_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of iterations per layout.
	/// The only use for this ivar is for the application
	/// to do visualizations of the layout before it's complete.
	/// The default is '100' to match the default 'MaxNumberOfIterations'
	/// Note: Changing this parameter is just fine :)
	/// </summary>
	public virtual void SetIterationsPerLayout(int _arg)
	{
		vtkAttributeClustering2DLayoutStrategy_SetIterationsPerLayout_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_SetMaxNumberOfIterations_31(HandleRef pThis, int _arg);

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
		vtkAttributeClustering2DLayoutStrategy_SetMaxNumberOfIterations_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_SetRandomSeed_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Seed the random number generator used to jitter point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual void SetRandomSeed(int _arg)
	{
		vtkAttributeClustering2DLayoutStrategy_SetRandomSeed_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_SetRestDistance_33(HandleRef pThis, float _arg);

	/// <summary>
	/// Manually set the resting distance. Otherwise the
	/// distance is computed automatically.
	/// </summary>
	public virtual void SetRestDistance(float _arg)
	{
		vtkAttributeClustering2DLayoutStrategy_SetRestDistance_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAttributeClustering2DLayoutStrategy_SetVertexAttribute_34(HandleRef pThis, string arg0);

	/// <summary>
	/// The name of the array on the vertices, whose values will be used for
	/// determining clusters.
	/// </summary>
	public void SetVertexAttribute(string arg0)
	{
		vtkAttributeClustering2DLayoutStrategy_SetVertexAttribute_34(GetCppThis(), arg0);
	}
}
