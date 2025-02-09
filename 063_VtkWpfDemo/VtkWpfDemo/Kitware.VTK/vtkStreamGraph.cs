using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStreamGraph
/// </summary>
/// <remarks>
///    combines two graphs
///
///
/// vtkStreamGraph iteratively collects information from the input graph
/// and combines it in the output graph. It internally maintains a graph
/// instance that is incrementally updated every time the filter is called.
///
/// Each update, vtkMergeGraphs is used to combine this filter's input with the
/// internal graph.
///
/// If you can use an edge window array to filter out old edges based on a
/// moving threshold.
/// </remarks>
public class vtkStreamGraph : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStreamGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStreamGraph()
	{
		MRClassNameKey = "class vtkStreamGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStreamGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStreamGraph New()
	{
		vtkStreamGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkStreamGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkStreamGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkStreamGraph_GetEdgeWindow_01(HandleRef pThis);

	/// <summary>
	/// The time window amount. Edges with values lower
	/// than the maximum value minus this window will be
	/// removed from the graph. The default edge window is
	/// 10000.
	/// </summary>
	public virtual double GetEdgeWindow()
	{
		return vtkStreamGraph_GetEdgeWindow_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamGraph_GetEdgeWindowArrayName_02(HandleRef pThis);

	/// <summary>
	/// The edge window array. The default array name is "time".
	/// </summary>
	public virtual string GetEdgeWindowArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkStreamGraph_GetEdgeWindowArrayName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStreamGraph_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStreamGraph_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStreamGraph_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStreamGraph_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStreamGraph_GetUseEdgeWindow_05(HandleRef pThis);

	/// <summary>
	/// Whether to use an edge window array. The default is to
	/// not use a window array.
	/// </summary>
	public virtual bool GetUseEdgeWindow()
	{
		return (vtkStreamGraph_GetUseEdgeWindow_05(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamGraph_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStreamGraph_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStreamGraph_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStreamGraph_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamGraph_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStreamGraph NewInstance()
	{
		vtkStreamGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamGraph_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStreamGraph_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStreamGraph SafeDownCast(vtkObjectBase o)
	{
		vtkStreamGraph vtkStreamGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStreamGraph_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStreamGraph2 = (vtkStreamGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStreamGraph2.Register(null);
			}
		}
		return vtkStreamGraph2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamGraph_SetEdgeWindow_11(HandleRef pThis, double _arg);

	/// <summary>
	/// The time window amount. Edges with values lower
	/// than the maximum value minus this window will be
	/// removed from the graph. The default edge window is
	/// 10000.
	/// </summary>
	public virtual void SetEdgeWindow(double _arg)
	{
		vtkStreamGraph_SetEdgeWindow_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamGraph_SetEdgeWindowArrayName_12(HandleRef pThis, string _arg);

	/// <summary>
	/// The edge window array. The default array name is "time".
	/// </summary>
	public virtual void SetEdgeWindowArrayName(string _arg)
	{
		vtkStreamGraph_SetEdgeWindowArrayName_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamGraph_SetUseEdgeWindow_13(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to use an edge window array. The default is to
	/// not use a window array.
	/// </summary>
	public virtual void SetUseEdgeWindow(bool _arg)
	{
		vtkStreamGraph_SetUseEdgeWindow_13(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamGraph_UseEdgeWindowOff_14(HandleRef pThis);

	/// <summary>
	/// Whether to use an edge window array. The default is to
	/// not use a window array.
	/// </summary>
	public virtual void UseEdgeWindowOff()
	{
		vtkStreamGraph_UseEdgeWindowOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStreamGraph_UseEdgeWindowOn_15(HandleRef pThis);

	/// <summary>
	/// Whether to use an edge window array. The default is to
	/// not use a window array.
	/// </summary>
	public virtual void UseEdgeWindowOn()
	{
		vtkStreamGraph_UseEdgeWindowOn_15(GetCppThis());
	}
}
