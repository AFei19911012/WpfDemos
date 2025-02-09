using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMergeGraphs
/// </summary>
/// <remarks>
///    combines two graphs
///
///
/// vtkMergeGraphs combines information from two graphs into one.
/// Both graphs must have pedigree ids assigned to the vertices.
/// The output will contain the vertices/edges in the first graph, in
/// addition to:
///
///  - vertices in the second graph whose pedigree id does not
///    match a vertex in the first input
///
///  - edges in the second graph
///
/// The output will contain the same attribute structure as the input;
/// fields associated only with the second input graph will not be passed
/// to the output. When possible, the vertex/edge data for new vertices and
/// edges will be populated with matching attributes on the second graph.
/// To be considered a matching attribute, the array must have the same name,
/// type, and number of components.
///
/// @warning
/// This filter is not "domain-aware". Pedigree ids are assumed to be globally
/// unique, regardless of their domain.
/// </remarks>
public class vtkMergeGraphs : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMergeGraphs";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMergeGraphs()
	{
		MRClassNameKey = "class vtkMergeGraphs";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMergeGraphs"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMergeGraphs(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeGraphs_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeGraphs New()
	{
		vtkMergeGraphs result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeGraphs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMergeGraphs()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMergeGraphs_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkMergeGraphs_ExtendGraph_01(HandleRef pThis, HandleRef g1, HandleRef g2);

	/// <summary>
	/// This is the core functionality of the algorithm. Adds edges
	/// and vertices from g2 into g1.
	/// </summary>
	public int ExtendGraph(vtkMutableGraphHelper g1, vtkGraph g2)
	{
		return vtkMergeGraphs_ExtendGraph_01(GetCppThis(), g1?.GetCppThis() ?? default(HandleRef), g2?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMergeGraphs_GetEdgeWindow_02(HandleRef pThis);

	/// <summary>
	/// The time window amount. Edges with values lower
	/// than the maximum value minus this window will be
	/// removed from the graph. The default edge window is
	/// 10000.
	/// </summary>
	public virtual double GetEdgeWindow()
	{
		return vtkMergeGraphs_GetEdgeWindow_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeGraphs_GetEdgeWindowArrayName_03(HandleRef pThis);

	/// <summary>
	/// The edge window array. The default array name is "time".
	/// </summary>
	public virtual string GetEdgeWindowArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkMergeGraphs_GetEdgeWindowArrayName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeGraphs_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMergeGraphs_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMergeGraphs_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMergeGraphs_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMergeGraphs_GetUseEdgeWindow_06(HandleRef pThis);

	/// <summary>
	/// Whether to use an edge window array. The default is to
	/// not use a window array.
	/// </summary>
	public virtual bool GetUseEdgeWindow()
	{
		return (vtkMergeGraphs_GetUseEdgeWindow_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeGraphs_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMergeGraphs_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMergeGraphs_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMergeGraphs_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeGraphs_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMergeGraphs NewInstance()
	{
		vtkMergeGraphs result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeGraphs_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMergeGraphs_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMergeGraphs SafeDownCast(vtkObjectBase o)
	{
		vtkMergeGraphs vtkMergeGraphs2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMergeGraphs_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMergeGraphs2 = (vtkMergeGraphs)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMergeGraphs2.Register(null);
			}
		}
		return vtkMergeGraphs2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeGraphs_SetEdgeWindow_12(HandleRef pThis, double _arg);

	/// <summary>
	/// The time window amount. Edges with values lower
	/// than the maximum value minus this window will be
	/// removed from the graph. The default edge window is
	/// 10000.
	/// </summary>
	public virtual void SetEdgeWindow(double _arg)
	{
		vtkMergeGraphs_SetEdgeWindow_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeGraphs_SetEdgeWindowArrayName_13(HandleRef pThis, string _arg);

	/// <summary>
	/// The edge window array. The default array name is "time".
	/// </summary>
	public virtual void SetEdgeWindowArrayName(string _arg)
	{
		vtkMergeGraphs_SetEdgeWindowArrayName_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeGraphs_SetUseEdgeWindow_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether to use an edge window array. The default is to
	/// not use a window array.
	/// </summary>
	public virtual void SetUseEdgeWindow(bool _arg)
	{
		vtkMergeGraphs_SetUseEdgeWindow_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeGraphs_UseEdgeWindowOff_15(HandleRef pThis);

	/// <summary>
	/// Whether to use an edge window array. The default is to
	/// not use a window array.
	/// </summary>
	public virtual void UseEdgeWindowOff()
	{
		vtkMergeGraphs_UseEdgeWindowOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMergeGraphs_UseEdgeWindowOn_16(HandleRef pThis);

	/// <summary>
	/// Whether to use an edge window array. The default is to
	/// not use a window array.
	/// </summary>
	public virtual void UseEdgeWindowOn()
	{
		vtkMergeGraphs_UseEdgeWindowOn_16(GetCppThis());
	}
}
