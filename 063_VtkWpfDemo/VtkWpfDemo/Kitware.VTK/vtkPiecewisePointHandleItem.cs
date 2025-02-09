using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPiecewisePointHandleItem
/// </summary>
/// <remarks>
///    a vtkContextItem that draws handles
///       around a point of a piecewise function
///
///
/// This is a vtkContextItem that can be placed into a vtkContextScene. It draws
/// handles around a given point of a piecewise function so that the curve can
/// be adjusted using these handles.
/// </remarks>
public class vtkPiecewisePointHandleItem : vtkContextItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewisePointHandleItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPiecewisePointHandleItem()
	{
		MRClassNameKey = "class vtkPiecewisePointHandleItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewisePointHandleItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPiecewisePointHandleItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewisePointHandleItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPiecewisePointHandleItem New()
	{
		vtkPiecewisePointHandleItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewisePointHandleItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPiecewisePointHandleItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPiecewisePointHandleItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPiecewisePointHandleItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPiecewisePointHandleItem_CallRedraw_01(HandleRef sender, uint arg1, IntPtr receiver, IntPtr arg3);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static void CallRedraw(vtkObject sender, uint arg1, IntPtr receiver, IntPtr arg3)
	{
		vtkPiecewisePointHandleItem_CallRedraw_01(sender?.GetCppThis() ?? default(HandleRef), arg1, receiver, arg3);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPiecewisePointHandleItem_GetCurrentPointIndex_02(HandleRef pThis);

	/// <summary>
	/// The current point id in the piecewise function being handled.
	/// </summary>
	public virtual long GetCurrentPointIndex()
	{
		return vtkPiecewisePointHandleItem_GetCurrentPointIndex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPiecewisePointHandleItem_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPiecewisePointHandleItem_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPiecewisePointHandleItem_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPiecewisePointHandleItem_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewisePointHandleItem_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPiecewisePointHandleItem_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewisePointHandleItem_IsOverHandle_06(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Returns the index of the handle if pos is over any of the handles,
	/// otherwise return -1;
	/// </summary>
	public int IsOverHandle(IntPtr pos)
	{
		return vtkPiecewisePointHandleItem_IsOverHandle_06(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewisePointHandleItem_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPiecewisePointHandleItem_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewisePointHandleItem_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPiecewisePointHandleItem NewInstance()
	{
		vtkPiecewisePointHandleItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewisePointHandleItem_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPiecewisePointHandleItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPiecewisePointHandleItem_Paint_10(HandleRef pThis, HandleRef painter);

	/// <summary>
	/// Paint event for the item.
	/// </summary>
	public override bool Paint(vtkContext2D painter)
	{
		return (vtkPiecewisePointHandleItem_Paint_10(GetCppThis(), painter?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewisePointHandleItem_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPiecewisePointHandleItem SafeDownCast(vtkObjectBase o)
	{
		vtkPiecewisePointHandleItem vtkPiecewisePointHandleItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewisePointHandleItem_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewisePointHandleItem2 = (vtkPiecewisePointHandleItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewisePointHandleItem2.Register(null);
			}
		}
		return vtkPiecewisePointHandleItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewisePointHandleItem_SetCurrentPointIndex_12(HandleRef pThis, long _arg);

	/// <summary>
	/// The current point id in the piecewise function being handled.
	/// </summary>
	public virtual void SetCurrentPointIndex(long _arg)
	{
		vtkPiecewisePointHandleItem_SetCurrentPointIndex_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewisePointHandleItem_SetParent_13(HandleRef pThis, HandleRef parent);

	/// <summary>
	/// Set the parent item, which should be a vtkControlPointItem
	/// </summary>
	public override void SetParent(vtkAbstractContextItem parent)
	{
		vtkPiecewisePointHandleItem_SetParent_13(GetCppThis(), parent?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewisePointHandleItem_SetPiecewiseFunction_14(HandleRef pThis, HandleRef piecewiseFunc);

	/// <summary>
	/// Set the PieceWiseFunction the handles will manipulate
	/// </summary>
	public virtual void SetPiecewiseFunction(vtkPiecewiseFunction piecewiseFunc)
	{
		vtkPiecewisePointHandleItem_SetPiecewiseFunction_14(GetCppThis(), piecewiseFunc?.GetCppThis() ?? default(HandleRef));
	}
}
