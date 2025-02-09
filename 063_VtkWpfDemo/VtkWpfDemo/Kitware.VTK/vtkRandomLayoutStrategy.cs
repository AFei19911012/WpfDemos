using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRandomLayoutStrategy
/// </summary>
/// <remarks>
///    randomly places vertices in 2 or 3 dimensions
///
///
/// Assigns points to the vertices of a graph randomly within a bounded range.
///
/// .SECTION Thanks
/// Thanks to Brian Wylie from Sandia National Laboratories for adding incremental
/// layout capabilities.
/// </remarks>
public class vtkRandomLayoutStrategy : vtkGraphLayoutStrategy
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRandomLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRandomLayoutStrategy()
	{
		MRClassNameKey = "class vtkRandomLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRandomLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRandomLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomLayoutStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRandomLayoutStrategy New()
	{
		vtkRandomLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRandomLayoutStrategy()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRandomLayoutStrategy_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRandomLayoutStrategy_AutomaticBoundsComputationOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void AutomaticBoundsComputationOff()
	{
		vtkRandomLayoutStrategy_AutomaticBoundsComputationOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_AutomaticBoundsComputationOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void AutomaticBoundsComputationOn()
	{
		vtkRandomLayoutStrategy_AutomaticBoundsComputationOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomLayoutStrategy_GetAutomaticBoundsComputation_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual int GetAutomaticBoundsComputation()
	{
		return vtkRandomLayoutStrategy_GetAutomaticBoundsComputation_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomLayoutStrategy_GetGraphBounds_04(HandleRef pThis);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual double[] GetGraphBounds()
	{
		IntPtr intPtr = vtkRandomLayoutStrategy_GetGraphBounds_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_GetGraphBounds_05(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void GetGraphBounds(IntPtr data)
	{
		vtkRandomLayoutStrategy_GetGraphBounds_05(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomLayoutStrategy_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRandomLayoutStrategy_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRandomLayoutStrategy_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRandomLayoutStrategy_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomLayoutStrategy_GetRandomSeed_08(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to compute point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeed()
	{
		return vtkRandomLayoutStrategy_GetRandomSeed_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomLayoutStrategy_GetRandomSeedMaxValue_09(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to compute point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMaxValue()
	{
		return vtkRandomLayoutStrategy_GetRandomSeedMaxValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomLayoutStrategy_GetRandomSeedMinValue_10(HandleRef pThis);

	/// <summary>
	/// Seed the random number generator used to compute point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual int GetRandomSeedMinValue()
	{
		return vtkRandomLayoutStrategy_GetRandomSeedMinValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomLayoutStrategy_GetThreeDimensionalLayout_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off layout of graph in three dimensions. If off, graph
	/// layout occurs in two dimensions. By default, three dimensional
	/// layout is on.
	/// </summary>
	public virtual int GetThreeDimensionalLayout()
	{
		return vtkRandomLayoutStrategy_GetThreeDimensionalLayout_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomLayoutStrategy_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRandomLayoutStrategy_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRandomLayoutStrategy_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRandomLayoutStrategy_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_Layout_14(HandleRef pThis);

	/// <summary>
	/// Perform the random layout.
	/// </summary>
	public override void Layout()
	{
		vtkRandomLayoutStrategy_Layout_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomLayoutStrategy_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRandomLayoutStrategy NewInstance()
	{
		vtkRandomLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomLayoutStrategy_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRandomLayoutStrategy_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRandomLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkRandomLayoutStrategy vtkRandomLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRandomLayoutStrategy_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRandomLayoutStrategy2 = (vtkRandomLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRandomLayoutStrategy2.Register(null);
			}
		}
		return vtkRandomLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_SetAutomaticBoundsComputation_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off automatic graph bounds calculation. If this
	/// boolean is off, then the manually specified GraphBounds is used.
	/// If on, then the input's bounds us used as the graph bounds.
	/// </summary>
	public virtual void SetAutomaticBoundsComputation(int _arg)
	{
		vtkRandomLayoutStrategy_SetAutomaticBoundsComputation_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_SetGraph_19(HandleRef pThis, HandleRef graph);

	/// <summary>
	/// Set the graph to layout.
	/// </summary>
	public override void SetGraph(vtkGraph graph)
	{
		vtkRandomLayoutStrategy_SetGraph_19(GetCppThis(), graph?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_SetGraphBounds_20(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void SetGraphBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkRandomLayoutStrategy_SetGraphBounds_20(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_SetGraphBounds_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the region in space in which to place the final graph.
	/// The GraphBounds only affects the results if AutomaticBoundsComputation
	/// is off.
	/// </summary>
	public virtual void SetGraphBounds(IntPtr _arg)
	{
		vtkRandomLayoutStrategy_SetGraphBounds_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_SetRandomSeed_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Seed the random number generator used to compute point positions.
	/// This has a significant effect on their final positions when
	/// the layout is complete.
	/// </summary>
	public virtual void SetRandomSeed(int _arg)
	{
		vtkRandomLayoutStrategy_SetRandomSeed_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_SetThreeDimensionalLayout_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off layout of graph in three dimensions. If off, graph
	/// layout occurs in two dimensions. By default, three dimensional
	/// layout is on.
	/// </summary>
	public virtual void SetThreeDimensionalLayout(int _arg)
	{
		vtkRandomLayoutStrategy_SetThreeDimensionalLayout_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_ThreeDimensionalLayoutOff_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off layout of graph in three dimensions. If off, graph
	/// layout occurs in two dimensions. By default, three dimensional
	/// layout is on.
	/// </summary>
	public virtual void ThreeDimensionalLayoutOff()
	{
		vtkRandomLayoutStrategy_ThreeDimensionalLayoutOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRandomLayoutStrategy_ThreeDimensionalLayoutOn_25(HandleRef pThis);

	/// <summary>
	/// Turn on/off layout of graph in three dimensions. If off, graph
	/// layout occurs in two dimensions. By default, three dimensional
	/// layout is on.
	/// </summary>
	public virtual void ThreeDimensionalLayoutOn()
	{
		vtkRandomLayoutStrategy_ThreeDimensionalLayoutOn_25(GetCppThis());
	}
}
