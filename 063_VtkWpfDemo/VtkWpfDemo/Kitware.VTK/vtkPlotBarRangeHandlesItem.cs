using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPlotBarRangeHandlesItem
/// </summary>
/// <remarks>
///    show and control the range of a vtkAxis used with a vtkPlotBar
///
/// This class is a vtkPlotRangeHandlesItem specialization working in
/// coordination with a vtkPlotBar. It ensures that handles are sticking to the
/// plot bars when being dragged.
/// Vertical and horizontal bars are both supported but the handles orientation
/// must match the vtkPlotBar orientation.
///
/// </remarks>
/// <seealso>
///
/// vtkPlotRangeHandlesItem
/// </seealso>
public class vtkPlotBarRangeHandlesItem : vtkPlotRangeHandlesItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPlotBarRangeHandlesItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPlotBarRangeHandlesItem()
	{
		MRClassNameKey = "class vtkPlotBarRangeHandlesItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPlotBarRangeHandlesItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPlotBarRangeHandlesItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBarRangeHandlesItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotBarRangeHandlesItem New()
	{
		vtkPlotBarRangeHandlesItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBarRangeHandlesItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotBarRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPlotBarRangeHandlesItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPlotBarRangeHandlesItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPlotBarRangeHandlesItem_GetBounds_01(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Recover the bounds of the item
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkPlotBarRangeHandlesItem_GetBounds_01(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotBarRangeHandlesItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPlotBarRangeHandlesItem_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPlotBarRangeHandlesItem_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPlotBarRangeHandlesItem_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBarRangeHandlesItem_GetPlotBar_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get/Set the plot bar object to work with.
	/// </summary>
	public virtual vtkPlotBar GetPlotBar()
	{
		vtkPlotBar vtkPlotBar2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBarRangeHandlesItem_GetPlotBar_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotBar2 = (vtkPlotBar)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotBar2.Register(null);
			}
		}
		return vtkPlotBar2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotBarRangeHandlesItem_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPlotBarRangeHandlesItem_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPlotBarRangeHandlesItem_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPlotBarRangeHandlesItem_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBarRangeHandlesItem_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPlotBarRangeHandlesItem NewInstance()
	{
		vtkPlotBarRangeHandlesItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBarRangeHandlesItem_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPlotBarRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPlotBarRangeHandlesItem_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPlotBarRangeHandlesItem SafeDownCast(vtkObjectBase o)
	{
		vtkPlotBarRangeHandlesItem vtkPlotBarRangeHandlesItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPlotBarRangeHandlesItem_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPlotBarRangeHandlesItem2 = (vtkPlotBarRangeHandlesItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPlotBarRangeHandlesItem2.Register(null);
			}
		}
		return vtkPlotBarRangeHandlesItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPlotBarRangeHandlesItem_SetPlotBar_10(HandleRef pThis, HandleRef _arg);

	/// <summary>
	/// Get/Set the plot bar object to work with.
	/// </summary>
	public virtual void SetPlotBar(vtkPlotBar _arg)
	{
		vtkPlotBarRangeHandlesItem_SetPlotBar_10(GetCppThis(), _arg?.GetCppThis() ?? default(HandleRef));
	}
}
