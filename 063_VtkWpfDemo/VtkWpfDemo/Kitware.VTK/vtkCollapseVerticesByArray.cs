using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCollapseVerticesByArray
/// </summary>
/// <remarks>
///    Collapse the graph given a vertex array
///
///
/// vtkCollapseVerticesByArray is a class which collapses the graph using
/// a vertex array as the key. So if the graph has vertices sharing common
/// traits then this class combines all these vertices into one. This class
/// does not perform aggregation on vertex data but allow to do so for edge data.
/// Users can choose one or more edge data arrays for aggregation using
/// AddAggregateEdgeArray function.
///
///
/// </remarks>
public class vtkCollapseVerticesByArray : vtkGraphAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCollapseVerticesByArray";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCollapseVerticesByArray()
	{
		MRClassNameKey = "class vtkCollapseVerticesByArray";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCollapseVerticesByArray"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCollapseVerticesByArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseVerticesByArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollapseVerticesByArray New()
	{
		vtkCollapseVerticesByArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollapseVerticesByArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCollapseVerticesByArray()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCollapseVerticesByArray_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCollapseVerticesByArray_AddAggregateEdgeArray_01(HandleRef pThis, string arrName);

	/// <summary>
	/// Add arrays on which aggregation of data is allowed.
	/// Default if replaced by the last value.
	/// </summary>
	public void AddAggregateEdgeArray(string arrName)
	{
		vtkCollapseVerticesByArray_AddAggregateEdgeArray_01(GetCppThis(), arrName);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_AllowSelfLoopsOff_02(HandleRef pThis);

	/// <summary>
	/// Boolean to allow self loops during collapse.
	/// </summary>
	public virtual void AllowSelfLoopsOff()
	{
		vtkCollapseVerticesByArray_AllowSelfLoopsOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_AllowSelfLoopsOn_03(HandleRef pThis);

	/// <summary>
	/// Boolean to allow self loops during collapse.
	/// </summary>
	public virtual void AllowSelfLoopsOn()
	{
		vtkCollapseVerticesByArray_AllowSelfLoopsOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_ClearAggregateEdgeArray_04(HandleRef pThis);

	/// <summary>
	/// Clear the list of arrays on which aggregation was set to allow.
	/// </summary>
	public void ClearAggregateEdgeArray()
	{
		vtkCollapseVerticesByArray_ClearAggregateEdgeArray_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_CountEdgesCollapsedOff_05(HandleRef pThis);

	/// <summary>
	/// Set if count should be made of how many edges collapsed.
	/// </summary>
	public virtual void CountEdgesCollapsedOff()
	{
		vtkCollapseVerticesByArray_CountEdgesCollapsedOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_CountEdgesCollapsedOn_06(HandleRef pThis);

	/// <summary>
	/// Set if count should be made of how many edges collapsed.
	/// </summary>
	public virtual void CountEdgesCollapsedOn()
	{
		vtkCollapseVerticesByArray_CountEdgesCollapsedOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_CountVerticesCollapsedOff_07(HandleRef pThis);

	/// <summary>
	/// Get/Set if count should be made of how many vertices collapsed.
	/// </summary>
	public virtual void CountVerticesCollapsedOff()
	{
		vtkCollapseVerticesByArray_CountVerticesCollapsedOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_CountVerticesCollapsedOn_08(HandleRef pThis);

	/// <summary>
	/// Get/Set if count should be made of how many vertices collapsed.
	/// </summary>
	public virtual void CountVerticesCollapsedOn()
	{
		vtkCollapseVerticesByArray_CountVerticesCollapsedOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCollapseVerticesByArray_GetAllowSelfLoops_09(HandleRef pThis);

	/// <summary>
	/// Boolean to allow self loops during collapse.
	/// </summary>
	public virtual bool GetAllowSelfLoops()
	{
		return (vtkCollapseVerticesByArray_GetAllowSelfLoops_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCollapseVerticesByArray_GetCountEdgesCollapsed_10(HandleRef pThis);

	/// <summary>
	/// Set if count should be made of how many edges collapsed.
	/// </summary>
	public virtual bool GetCountEdgesCollapsed()
	{
		return (vtkCollapseVerticesByArray_GetCountEdgesCollapsed_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCollapseVerticesByArray_GetCountVerticesCollapsed_11(HandleRef pThis);

	/// <summary>
	/// Get/Set if count should be made of how many vertices collapsed.
	/// </summary>
	public virtual bool GetCountVerticesCollapsed()
	{
		return (vtkCollapseVerticesByArray_GetCountVerticesCollapsed_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseVerticesByArray_GetEdgesCollapsedArray_12(HandleRef pThis);

	/// <summary>
	/// Name of the array where the count of how many edges collapsed will
	/// be stored.By default the name of array is "EdgesCollapsedCountArray".
	/// </summary>
	public virtual string GetEdgesCollapsedArray()
	{
		return Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray_GetEdgesCollapsedArray_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollapseVerticesByArray_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCollapseVerticesByArray_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCollapseVerticesByArray_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCollapseVerticesByArray_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseVerticesByArray_GetVertexArray_15(HandleRef pThis);

	/// <summary>
	/// Set the array using which perform the collapse.
	/// </summary>
	public virtual string GetVertexArray()
	{
		return Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray_GetVertexArray_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseVerticesByArray_GetVerticesCollapsedArray_16(HandleRef pThis);

	/// <summary>
	/// Name of the array where the count of how many vertices collapsed will
	/// be stored. By default name of the array is "VerticesCollapsedCountArray".
	/// </summary>
	public virtual string GetVerticesCollapsedArray()
	{
		return Marshal.PtrToStringAnsi(vtkCollapseVerticesByArray_GetVerticesCollapsedArray_16(GetCppThis()));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollapseVerticesByArray_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCollapseVerticesByArray_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCollapseVerticesByArray_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCollapseVerticesByArray_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseVerticesByArray_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCollapseVerticesByArray NewInstance()
	{
		vtkCollapseVerticesByArray result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollapseVerticesByArray_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCollapseVerticesByArray_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCollapseVerticesByArray SafeDownCast(vtkObjectBase o)
	{
		vtkCollapseVerticesByArray vtkCollapseVerticesByArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCollapseVerticesByArray_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCollapseVerticesByArray2 = (vtkCollapseVerticesByArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCollapseVerticesByArray2.Register(null);
			}
		}
		return vtkCollapseVerticesByArray2;
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_SetAllowSelfLoops_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Boolean to allow self loops during collapse.
	/// </summary>
	public virtual void SetAllowSelfLoops(bool _arg)
	{
		vtkCollapseVerticesByArray_SetAllowSelfLoops_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_SetCountEdgesCollapsed_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set if count should be made of how many edges collapsed.
	/// </summary>
	public virtual void SetCountEdgesCollapsed(bool _arg)
	{
		vtkCollapseVerticesByArray_SetCountEdgesCollapsed_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_SetCountVerticesCollapsed_24(HandleRef pThis, byte _arg);

	/// <summary>
	/// Get/Set if count should be made of how many vertices collapsed.
	/// </summary>
	public virtual void SetCountVerticesCollapsed(bool _arg)
	{
		vtkCollapseVerticesByArray_SetCountVerticesCollapsed_24(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_SetEdgesCollapsedArray_25(HandleRef pThis, string _arg);

	/// <summary>
	/// Name of the array where the count of how many edges collapsed will
	/// be stored.By default the name of array is "EdgesCollapsedCountArray".
	/// </summary>
	public virtual void SetEdgesCollapsedArray(string _arg)
	{
		vtkCollapseVerticesByArray_SetEdgesCollapsedArray_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_SetVertexArray_26(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the array using which perform the collapse.
	/// </summary>
	public virtual void SetVertexArray(string _arg)
	{
		vtkCollapseVerticesByArray_SetVertexArray_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCollapseVerticesByArray_SetVerticesCollapsedArray_27(HandleRef pThis, string _arg);

	/// <summary>
	/// Name of the array where the count of how many vertices collapsed will
	/// be stored. By default name of the array is "VerticesCollapsedCountArray".
	/// </summary>
	public virtual void SetVerticesCollapsedArray(string _arg)
	{
		vtkCollapseVerticesByArray_SetVerticesCollapsedArray_27(GetCppThis(), _arg);
	}
}
