using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCollectGraph
/// </summary>
/// <remarks>
///    Collect distributed graph.
///
/// This filter has code to collect a graph from across processes onto vertex 0.
/// Collection can be turned on or off using the "PassThrough" flag.
/// </remarks>
public class vtkCollectGraph : vtkGraphAlgorithm
{
	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public enum DIRECTED_OUTPUT_WrapperEnum
	{
		/// <summary>enum member</summary>
		DIRECTED_OUTPUT,
		/// <summary>enum member</summary>
		UNDIRECTED_OUTPUT,
		/// <summary>enum member</summary>
		USE_INPUT_TYPE
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCollectGraph";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCollectGraph()
	{
		MRClassNameKey = "class vtkCollectGraph";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollectGraph"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCollectGraph(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectGraph_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollectGraph New()
	{
		vtkCollectGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCollectGraph()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCollectGraph_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectGraph_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// By default this filter uses the global controller,
	/// but this method can be used to set another instead.
	/// </summary>
	public virtual vtkMultiProcessController GetController()
	{
		vtkMultiProcessController vtkMultiProcessController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectGraph_GetController_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMultiProcessController2 = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMultiProcessController2.Register(null);
			}
		}
		return vtkMultiProcessController2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollectGraph_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCollectGraph_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollectGraph_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCollectGraph_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollectGraph_GetOutputType_04(HandleRef pThis);

	/// <summary>
	/// Directedness flag, used to signal whether the output graph is directed or undirected.
	/// DIRECTED_OUTPUT expects that this filter is generating a directed graph.
	/// UNDIRECTED_OUTPUT expects that this filter is generating an undirected graph.
	/// DIRECTED_OUTPUT and UNDIRECTED_OUTPUT flags should only be set on the client
	/// filter.  Server filters should be set to USE_INPUT_TYPE since they have valid
	/// input and the directedness is determined from the input type.
	/// </summary>
	public virtual int GetOutputType()
	{
		return vtkCollectGraph_GetOutputType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollectGraph_GetPassThrough_05(HandleRef pThis);

	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public virtual int GetPassThrough()
	{
		return vtkCollectGraph_GetPassThrough_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectGraph_GetSocketController_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When this filter is being used in client-server mode,
	/// this is the controller used to communicate between
	/// client and server.  Client should not set the other controller.
	/// </summary>
	public virtual vtkSocketController GetSocketController()
	{
		vtkSocketController vtkSocketController2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectGraph_GetSocketController_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSocketController2 = (vtkSocketController)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSocketController2.Register(null);
			}
		}
		return vtkSocketController2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollectGraph_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCollectGraph_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollectGraph_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCollectGraph_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectGraph_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCollectGraph NewInstance()
	{
		vtkCollectGraph result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectGraph_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectGraph_PassThroughOff_11(HandleRef pThis);

	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public virtual void PassThroughOff()
	{
		vtkCollectGraph_PassThroughOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectGraph_PassThroughOn_12(HandleRef pThis);

	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public virtual void PassThroughOn()
	{
		vtkCollectGraph_PassThroughOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollectGraph_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollectGraph SafeDownCast(vtkObjectBase o)
	{
		vtkCollectGraph vtkCollectGraph2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollectGraph_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCollectGraph2 = (vtkCollectGraph)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCollectGraph2.Register(null);
			}
		}
		return vtkCollectGraph2;
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectGraph_SetController_14(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// By default this filter uses the global controller,
	/// but this method can be used to set another instead.
	/// </summary>
	public virtual void SetController(vtkMultiProcessController arg0)
	{
		vtkCollectGraph_SetController_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectGraph_SetOutputType_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Directedness flag, used to signal whether the output graph is directed or undirected.
	/// DIRECTED_OUTPUT expects that this filter is generating a directed graph.
	/// UNDIRECTED_OUTPUT expects that this filter is generating an undirected graph.
	/// DIRECTED_OUTPUT and UNDIRECTED_OUTPUT flags should only be set on the client
	/// filter.  Server filters should be set to USE_INPUT_TYPE since they have valid
	/// input and the directedness is determined from the input type.
	/// </summary>
	public virtual void SetOutputType(int _arg)
	{
		vtkCollectGraph_SetOutputType_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectGraph_SetPassThrough_16(HandleRef pThis, int _arg);

	/// <summary>
	/// To collect or just copy input to output. Off (collect) by default.
	/// </summary>
	public virtual void SetPassThrough(int _arg)
	{
		vtkCollectGraph_SetPassThrough_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollectGraph_SetSocketController_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// When this filter is being used in client-server mode,
	/// this is the controller used to communicate between
	/// client and server.  Client should not set the other controller.
	/// </summary>
	public virtual void SetSocketController(vtkSocketController arg0)
	{
		vtkCollectGraph_SetSocketController_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}
}
