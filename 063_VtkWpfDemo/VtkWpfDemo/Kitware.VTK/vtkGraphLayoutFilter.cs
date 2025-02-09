using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphLayoutFilter
/// </summary>
/// <remarks>
///    nice layout of undirected graphs in 3D
///
/// vtkGraphLayoutFilter will reposition a network of nodes, connected by
/// lines or polylines, into a more pleasing arrangement. The class
/// implements a simple force-directed placement algorithm
/// (Fruchterman &amp; Reingold "Graph Drawing by Force-directed Placement"
/// Software-Practice and Experience 21(11) 1991).
///
/// The input to the filter is a vtkPolyData representing the undirected
/// graphs. A graph is represented by a set of polylines and/or lines.
/// The output is also a vtkPolyData, where the point positions have been
/// modified. To use the filter, specify whether you wish the layout to
/// occur in 2D or 3D; the bounds in which the graph should lie (note that you
/// can just use automatic bounds computation); and modify the cool down
/// rate (controls the final process of simulated annealing).
/// </remarks>
public class vtkGraphLayoutFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphLayoutFilter()
	{
		MRClassNameKey = "class vtkGraphLayoutFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphLayoutFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphLayoutFilter New()
	{
		vtkGraphLayoutFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGraphLayoutFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGraphLayoutFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGraphLayoutFilter_AutomaticBoundsComputationOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void AutomaticBoundsComputationOff()
	{
		vtkGraphLayoutFilter_AutomaticBoundsComputationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_AutomaticBoundsComputationOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void AutomaticBoundsComputationOn()
	{
		vtkGraphLayoutFilter_AutomaticBoundsComputationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutFilter_GetAutomaticBoundsComputation_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual int GetAutomaticBoundsComputation()
	{
		return vtkGraphLayoutFilter_GetAutomaticBoundsComputation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphLayoutFilter_GetCoolDownRate_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual double GetCoolDownRate()
	{
		return vtkGraphLayoutFilter_GetCoolDownRate_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphLayoutFilter_GetCoolDownRateMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual double GetCoolDownRateMaxValue()
	{
		return vtkGraphLayoutFilter_GetCoolDownRateMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGraphLayoutFilter_GetCoolDownRateMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual double GetCoolDownRateMinValue()
	{
		return vtkGraphLayoutFilter_GetCoolDownRateMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutFilter_GetGraphBounds_07(HandleRef pThis);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual double[] GetGraphBounds()
	{
		IntPtr intPtr = vtkGraphLayoutFilter_GetGraphBounds_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_GetGraphBounds_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void GetGraphBounds(IntPtr data)
	{
		vtkGraphLayoutFilter_GetGraphBounds_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterations_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// </summary>
	public virtual int GetMaxNumberOfIterations()
	{
		return vtkGraphLayoutFilter_GetMaxNumberOfIterations_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterationsMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// </summary>
	public virtual int GetMaxNumberOfIterationsMaxValue()
	{
		return vtkGraphLayoutFilter_GetMaxNumberOfIterationsMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutFilter_GetMaxNumberOfIterationsMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// </summary>
	public virtual int GetMaxNumberOfIterationsMinValue()
	{
		return vtkGraphLayoutFilter_GetMaxNumberOfIterationsMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphLayoutFilter_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphLayoutFilter_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphLayoutFilter_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphLayoutFilter_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutFilter_GetThreeDimensionalLayout_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual int GetThreeDimensionalLayout()
	{
		return vtkGraphLayoutFilter_GetThreeDimensionalLayout_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutFilter_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphLayoutFilter_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutFilter_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphLayoutFilter_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutFilter_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphLayoutFilter NewInstance()
	{
		vtkGraphLayoutFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutFilter_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutFilter_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphLayoutFilter SafeDownCast(vtkObjectBase o)
	{
		vtkGraphLayoutFilter vtkGraphLayoutFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutFilter_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphLayoutFilter2 = (vtkGraphLayoutFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphLayoutFilter2.Register(null);
			}
		}
		return vtkGraphLayoutFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_SetAutomaticBoundsComputation_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void SetAutomaticBoundsComputation(int _arg)
	{
		vtkGraphLayoutFilter_SetAutomaticBoundsComputation_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_SetCoolDownRate_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual void SetCoolDownRate(double _arg)
	{
		vtkGraphLayoutFilter_SetCoolDownRate_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_SetGraphBounds_22(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkGraphLayoutFilter_SetGraphBounds_22(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_SetGraphBounds_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void SetGraphBounds(IntPtr _arg)
	{
		vtkGraphLayoutFilter_SetGraphBounds_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_SetMaxNumberOfIterations_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the maximum number of iterations to be used.
	/// The higher this number, the more iterations through the algorithm
	/// is possible, and thus, the more the graph gets modified.
	/// </summary>
	public virtual void SetMaxNumberOfIterations(int _arg)
	{
		vtkGraphLayoutFilter_SetMaxNumberOfIterations_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_SetThreeDimensionalLayout_25(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual void SetThreeDimensionalLayout(int _arg)
	{
		vtkGraphLayoutFilter_SetThreeDimensionalLayout_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_ThreeDimensionalLayoutOff_26(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual void ThreeDimensionalLayoutOff()
	{
		vtkGraphLayoutFilter_ThreeDimensionalLayoutOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutFilter_ThreeDimensionalLayoutOn_27(HandleRef pThis);

	/// <summary>
	/// Set/Get the Cool-down rate.
	/// The higher this number is, the longer it will take to "cool-down",
	/// and thus, the more the graph will be modified.
	/// </summary>
	public virtual void ThreeDimensionalLayoutOn()
	{
		vtkGraphLayoutFilter_ThreeDimensionalLayoutOn_27(GetCppThis());
	}
}
