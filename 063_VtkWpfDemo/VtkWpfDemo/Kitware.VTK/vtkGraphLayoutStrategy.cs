using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGraphLayoutStrategy
/// </summary>
/// <remarks>
///    abstract superclass for all graph layout strategies
///
///
/// All graph layouts should subclass from this class.  vtkGraphLayoutStrategy
/// works as a plug-in to the vtkGraphLayout algorithm.  The Layout()
/// function should perform some reasonable "chunk" of the layout.
/// This allows the user to be able to see the progress of the layout.
/// Use IsLayoutComplete() to tell the user when there is no more layout
/// to perform.
///
/// @par Thanks:
/// Thanks to Brian Wylie from Sandia National Laboratories for adding incremental
/// layout capabilities.
/// </remarks>
public abstract class vtkGraphLayoutStrategy : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGraphLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGraphLayoutStrategy()
	{
		MRClassNameKey = "class vtkGraphLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGraphLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGraphLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern IntPtr vtkGraphLayoutStrategy_GetEdgeWeightField_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the field to use for the edge weights.
	/// </summary>
	public virtual string GetEdgeWeightField()
	{
		return Marshal.PtrToStringAnsi(vtkGraphLayoutStrategy_GetEdgeWeightField_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGraphLayoutStrategy_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGraphLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGraphLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGraphLayoutStrategy_GetWeightEdges_04(HandleRef pThis);

	/// <summary>
	/// Whether to use edge weights in the layout or not.
	/// </summary>
	public virtual bool GetWeightEdges()
	{
		return (vtkGraphLayoutStrategy_GetWeightEdges_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutStrategy_Initialize_05(HandleRef pThis);

	/// <summary>
	/// This method allows the layout strategy to
	/// do initialization of data structures
	/// or whatever else it might want to do.
	/// </summary>
	public virtual void Initialize()
	{
		vtkGraphLayoutStrategy_Initialize_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutStrategy_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGraphLayoutStrategy_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutStrategy_IsLayoutComplete_07(HandleRef pThis);

	/// <summary>
	/// If your concrete class is iterative than
	/// you should overload IsLayoutComplete()
	/// otherwise it simply returns 1 by default;
	/// </summary>
	public virtual int IsLayoutComplete()
	{
		return vtkGraphLayoutStrategy_IsLayoutComplete_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGraphLayoutStrategy_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGraphLayoutStrategy_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutStrategy_Layout_09(HandleRef pThis);

	/// <summary>
	/// This is the layout method where the graph that was
	/// set in SetGraph() is laid out. The method can either
	/// entirely layout the graph or iteratively lay out the
	/// graph. If you have an iterative layout please implement
	/// the IsLayoutComplete() method.
	/// </summary>
	public virtual void Layout()
	{
		vtkGraphLayoutStrategy_Layout_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGraphLayoutStrategy NewInstance()
	{
		vtkGraphLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutStrategy_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGraphLayoutStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGraphLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkGraphLayoutStrategy vtkGraphLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGraphLayoutStrategy_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGraphLayoutStrategy2 = (vtkGraphLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGraphLayoutStrategy2.Register(null);
			}
		}
		return vtkGraphLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutStrategy_SetEdgeWeightField_12(HandleRef pThis, string field);

	/// <summary>
	/// Set/Get the field to use for the edge weights.
	/// </summary>
	public virtual void SetEdgeWeightField(string field)
	{
		vtkGraphLayoutStrategy_SetEdgeWeightField_12(GetCppThis(), field);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutStrategy_SetGraph_13(HandleRef pThis, HandleRef graph);

	/// <summary>
	/// Setting the graph for the layout strategy
	/// </summary>
	public virtual void SetGraph(vtkGraph graph)
	{
		vtkGraphLayoutStrategy_SetGraph_13(GetCppThis(), graph?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGraphLayoutStrategy_SetWeightEdges_14(HandleRef pThis, byte state);

	/// <summary>
	/// Whether to use edge weights in the layout or not.
	/// </summary>
	public virtual void SetWeightEdges(bool state)
	{
		vtkGraphLayoutStrategy_SetWeightEdges_14(GetCppThis(), (byte)(state ? 1u : 0u));
	}
}
