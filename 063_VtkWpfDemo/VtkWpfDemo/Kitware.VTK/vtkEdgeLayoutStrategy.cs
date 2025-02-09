using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEdgeLayoutStrategy
/// </summary>
/// <remarks>
///    abstract superclass for all edge layout strategies
///
///
/// All edge layouts should subclass from this class.  vtkEdgeLayoutStrategy
/// works as a plug-in to the vtkEdgeLayout algorithm.
/// </remarks>
public abstract class vtkEdgeLayoutStrategy : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEdgeLayoutStrategy";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEdgeLayoutStrategy()
	{
		MRClassNameKey = "class vtkEdgeLayoutStrategy";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEdgeLayoutStrategy"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEdgeLayoutStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkEdgeLayoutStrategy_GetEdgeWeightArrayName_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the field to use for the edge weights.
	/// </summary>
	public virtual string GetEdgeWeightArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkEdgeLayoutStrategy_GetEdgeWeightArrayName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeLayoutStrategy_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEdgeLayoutStrategy_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEdgeLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEdgeLayoutStrategy_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeLayoutStrategy_Initialize_04(HandleRef pThis);

	/// <summary>
	/// This method allows the layout strategy to
	/// do initialization of data structures
	/// or whatever else it might want to do.
	/// </summary>
	public virtual void Initialize()
	{
		vtkEdgeLayoutStrategy_Initialize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeLayoutStrategy_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEdgeLayoutStrategy_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEdgeLayoutStrategy_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEdgeLayoutStrategy_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeLayoutStrategy_Layout_07(HandleRef pThis);

	/// <summary>
	/// This is the layout method where the graph that was
	/// set in SetGraph() is laid out.
	/// </summary>
	public virtual void Layout()
	{
		vtkEdgeLayoutStrategy_Layout_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeLayoutStrategy_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEdgeLayoutStrategy NewInstance()
	{
		vtkEdgeLayoutStrategy result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEdgeLayoutStrategy_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEdgeLayoutStrategy_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEdgeLayoutStrategy SafeDownCast(vtkObjectBase o)
	{
		vtkEdgeLayoutStrategy vtkEdgeLayoutStrategy2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEdgeLayoutStrategy_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEdgeLayoutStrategy2 = (vtkEdgeLayoutStrategy)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEdgeLayoutStrategy2.Register(null);
			}
		}
		return vtkEdgeLayoutStrategy2;
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeLayoutStrategy_SetEdgeWeightArrayName_10(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the field to use for the edge weights.
	/// </summary>
	public virtual void SetEdgeWeightArrayName(string _arg)
	{
		vtkEdgeLayoutStrategy_SetEdgeWeightArrayName_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisLayout.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEdgeLayoutStrategy_SetGraph_11(HandleRef pThis, HandleRef graph);

	/// <summary>
	/// Setting the graph for the layout strategy
	/// </summary>
	public virtual void SetGraph(vtkGraph graph)
	{
		vtkEdgeLayoutStrategy_SetGraph_11(GetCppThis(), graph?.GetCppThis() ?? default(HandleRef));
	}
}
