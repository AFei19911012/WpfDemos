using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPiecewiseControlPointsItem
/// </summary>
/// <remarks>
///    Control points for
/// vtkPiecewiseFunction.
///
/// vtkPiecewiseControlPointsItem draws the control points of a vtkPiecewiseFunction.
/// </remarks>
/// <seealso>
///
/// vtkControlPointsItem
/// vtkPiecewiseFunctionItem
/// vtkCompositeTransferFunctionItem
/// </seealso>
public class vtkPiecewiseControlPointsItem : vtkControlPointsItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPiecewiseControlPointsItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPiecewiseControlPointsItem()
	{
		MRClassNameKey = "class vtkPiecewiseControlPointsItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPiecewiseControlPointsItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPiecewiseControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a piecewise control points object
	/// </summary>
	public new static vtkPiecewiseControlPointsItem New()
	{
		vtkPiecewiseControlPointsItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a piecewise control points object
	/// </summary>
	public vtkPiecewiseControlPointsItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPiecewiseControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkPiecewiseControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

	/// <summary>
	/// Add a point to the function. Returns the index of the point (0 based),
	/// or -1 on error.
	/// Subclasses should reimplement this function to do the actual work.
	/// </summary>
	public override long AddPoint(IntPtr newPos)
	{
		return vtkPiecewiseControlPointsItem_AddPoint_01(GetCppThis(), newPos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPiecewiseControlPointsItem_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPiecewiseControlPointsItem_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPiecewiseControlPointsItem_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPiecewiseControlPointsItem_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseControlPointsItem_GetPiecewiseFunction_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the piecewise function
	/// </summary>
	public virtual vtkPiecewiseFunction GetPiecewiseFunction()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseControlPointsItem_GetPiecewiseFunction_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseFunction2 = (vtkPiecewiseFunction)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseFunction2.Register(null);
			}
		}
		return vtkPiecewiseFunction2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseControlPointsItem_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPiecewiseControlPointsItem_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPiecewiseControlPointsItem_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPiecewiseControlPointsItem_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseControlPointsItem_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPiecewiseControlPointsItem NewInstance()
	{
		vtkPiecewiseControlPointsItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseControlPointsItem_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPiecewiseControlPointsItem_RemovePoint_09(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Remove a point of the function. Returns the index of the point (0 based),
	/// or -1 on error.
	/// Subclasses should reimplement this function to do the actual work.
	/// </summary>
	public override long RemovePoint(IntPtr pos)
	{
		return vtkPiecewiseControlPointsItem_RemovePoint_09(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPiecewiseControlPointsItem_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPiecewiseControlPointsItem SafeDownCast(vtkObjectBase o)
	{
		vtkPiecewiseControlPointsItem vtkPiecewiseControlPointsItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPiecewiseControlPointsItem_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPiecewiseControlPointsItem2 = (vtkPiecewiseControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPiecewiseControlPointsItem2.Register(null);
			}
		}
		return vtkPiecewiseControlPointsItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPiecewiseControlPointsItem_SetPiecewiseFunction_11(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set the piecewise function to draw its points
	/// </summary>
	public virtual void SetPiecewiseFunction(vtkPiecewiseFunction function)
	{
		vtkPiecewiseControlPointsItem_SetPiecewiseFunction_11(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}
}
