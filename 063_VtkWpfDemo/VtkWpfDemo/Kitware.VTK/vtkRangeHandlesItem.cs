using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRangeHandlesItem
/// </summary>
/// <remarks>
///    item to show and control the range of a vtkColorTransferFunction
///
/// vtkRangeHandlesItem provides range handles painting and management
/// for a provided vtkColorTransferFunction.
/// This specialization of vtkPlotRangeHandlesItem works in coordination with
/// the color transfer function to drive the behavior of handles.
/// Handles can only be dragged within the color transfer function range and
/// are forced to be placed vertically with a fixed height of 1.
///
/// A typical use case for this class is to observe EndInteractionEvent to
/// update the color transfer function range using the handles range.
///
/// </remarks>
/// <seealso>
///
/// vtkControlPointsItem
/// vtkScalarsToColorsItem
/// vtkColorTransferFunctionItem
/// </seealso>
public class vtkRangeHandlesItem : vtkPlotRangeHandlesItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRangeHandlesItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRangeHandlesItem()
	{
		MRClassNameKey = "class vtkRangeHandlesItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRangeHandlesItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRangeHandlesItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRangeHandlesItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRangeHandlesItem New()
	{
		vtkRangeHandlesItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRangeHandlesItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRangeHandlesItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRangeHandlesItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRangeHandlesItem_ComputeHandlesDrawRange_01(HandleRef pThis);

	/// <summary>
	/// Compute the handles draw range by using the handle width and the transfer
	/// function.
	/// </summary>
	public override void ComputeHandlesDrawRange()
	{
		vtkRangeHandlesItem_ComputeHandlesDrawRange_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRangeHandlesItem_GetBounds_02(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Overridden to get the bounds from the color transfer function range.
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkRangeHandlesItem_GetBounds_02(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRangeHandlesItem_GetColorTransferFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/set the color transfer function to interact with.
	/// </summary>
	public virtual vtkColorTransferFunction GetColorTransferFunction()
	{
		vtkColorTransferFunction vtkColorTransferFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRangeHandlesItem_GetColorTransferFunction_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorTransferFunction2 = (vtkColorTransferFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorTransferFunction2.Register(null);
			}
		}
		return vtkColorTransferFunction2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRangeHandlesItem_GetHandlesRange_04(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Overridden to return the range of the color transfer function.
	/// Use this method by observing EndInteractionEvent
	/// </summary>
	public override void GetHandlesRange(IntPtr range)
	{
		vtkRangeHandlesItem_GetHandlesRange_04(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRangeHandlesItem_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRangeHandlesItem_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRangeHandlesItem_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRangeHandlesItem_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRangeHandlesItem_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRangeHandlesItem_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRangeHandlesItem_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRangeHandlesItem_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRangeHandlesItem_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRangeHandlesItem NewInstance()
	{
		vtkRangeHandlesItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRangeHandlesItem_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkRangeHandlesItem_Paint_11(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Overridden to check that a color transfer function has been set before
	/// painting.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkRangeHandlesItem_Paint_11(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRangeHandlesItem_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRangeHandlesItem SafeDownCast(vtkObjectBase o)
	{
		vtkRangeHandlesItem vtkRangeHandlesItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRangeHandlesItem_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRangeHandlesItem2 = (vtkRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRangeHandlesItem2.Register(null);
			}
		}
		return vtkRangeHandlesItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRangeHandlesItem_SetColorTransferFunction_13(HandleRef pThis, HandleRef ctf);

	/// <summary>
	/// Get/set the color transfer function to interact with.
	/// </summary>
	public void SetColorTransferFunction(vtkColorTransferFunction ctf)
	{
		vtkRangeHandlesItem_SetColorTransferFunction_13(GetCppThis(), ctf?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRangeHandlesItem_SetHandleOrientation_14(HandleRef pThis, int arg0);

	/// <summary>
	/// Overridden to force using desynchronized vertical handles.
	/// Desynchronized handles means that handles are always moved independently,
	/// as opposed to synchronized handles where the left handle drives the
	/// modification of the whole range. See superclass for more information.
	/// </summary>
	public override void SetHandleOrientation(int arg0)
	{
		vtkRangeHandlesItem_SetHandleOrientation_14(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRangeHandlesItem_SetSynchronizeRangeHandles_15(HandleRef pThis, int arg0);

	/// <summary>
	/// Overridden to force using desynchronized vertical handles.
	/// Desynchronized handles means that handles are always moved independently,
	/// as opposed to synchronized handles where the left handle drives the
	/// modification of the whole range. See superclass for more information.
	/// </summary>
	public override void SetSynchronizeRangeHandles(int arg0)
	{
		vtkRangeHandlesItem_SetSynchronizeRangeHandles_15(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRangeHandlesItem_SynchronizeRangeHandlesOn_16(HandleRef pThis);

	/// <summary>
	/// Overridden to force using desynchronized vertical handles.
	/// Desynchronized handles means that handles are always moved independently,
	/// as opposed to synchronized handles where the left handle drives the
	/// modification of the whole range. See superclass for more information.
	/// </summary>
	public override void SynchronizeRangeHandlesOn()
	{
		vtkRangeHandlesItem_SynchronizeRangeHandlesOn_16(GetCppThis());
	}
}
