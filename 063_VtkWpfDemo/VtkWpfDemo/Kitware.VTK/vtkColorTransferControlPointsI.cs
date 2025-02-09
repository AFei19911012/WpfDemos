using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkColorTransferControlPointsItem
/// </summary>
/// <remarks>
///    Control points for
/// vtkColorTransferFunction.
///
/// vtkColorTransferControlPointsItem draws the control points of a vtkColorTransferFunction.
/// </remarks>
/// <seealso>
///
/// vtkControlPointsItem
/// vtkColorTransferFunctionItem
/// vtkCompositeTransferFunctionItem
/// </seealso>
public class vtkColorTransferControlPointsItem : vtkControlPointsItem
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkColorTransferControlPointsItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkColorTransferControlPointsItem()
	{
		MRClassNameKey = "class vtkColorTransferControlPointsItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkColorTransferControlPointsItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkColorTransferControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a piecewise control points object
	/// </summary>
	public new static vtkColorTransferControlPointsItem New()
	{
		vtkColorTransferControlPointsItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorTransferControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a piecewise control points object
	/// </summary>
	public vtkColorTransferControlPointsItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkColorTransferControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkColorTransferControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

	/// <summary>
	/// Add a point to the function. Returns the index of the point (0 based),
	/// or -1 on error.
	/// Subclasses should reimplement this function to do the actual work.
	/// </summary>
	public override long AddPoint(IntPtr newPos)
	{
		return vtkColorTransferControlPointsItem_AddPoint_01(GetCppThis(), newPos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkColorTransferControlPointsItem_GetColorFill_02(HandleRef pThis);

	/// <summary>
	/// If ColorFill is true, the control point brush color is set with the
	/// matching color in the color transfer function.
	/// False by default.
	/// </summary>
	public virtual bool GetColorFill()
	{
		return (vtkColorTransferControlPointsItem_GetColorFill_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferControlPointsItem_GetColorTransferFunction_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the piecewise function
	/// </summary>
	public virtual vtkColorTransferFunction GetColorTransferFunction()
	{
		vtkColorTransferFunction vtkColorTransferFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorTransferControlPointsItem_GetColorTransferFunction_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkColorTransferControlPointsItem_GetControlPoint_04(HandleRef pThis, long index, IntPtr point);

	/// <summary>
	/// Returns the x and y coordinates as well as the midpoint and sharpness
	/// of the control point corresponding to the index.
	/// Note: The y (point[1]) is always 0.5
	/// </summary>
	public override void GetControlPoint(long index, IntPtr point)
	{
		vtkColorTransferControlPointsItem_GetControlPoint_04(GetCppThis(), index, point);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorTransferControlPointsItem_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkColorTransferControlPointsItem_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorTransferControlPointsItem_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkColorTransferControlPointsItem_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorTransferControlPointsItem_GetNumberOfPoints_07(HandleRef pThis);

	/// <summary>
	/// Return the number of points in the color transfer function.
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkColorTransferControlPointsItem_GetNumberOfPoints_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferControlPointsItem_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkColorTransferControlPointsItem_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkColorTransferControlPointsItem_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkColorTransferControlPointsItem_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferControlPointsItem_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkColorTransferControlPointsItem NewInstance()
	{
		vtkColorTransferControlPointsItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorTransferControlPointsItem_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkColorTransferControlPointsItem_RemovePoint_12(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Remove a point of the function. Returns the index of the point (0 based),
	/// or -1 on error.
	/// Subclasses should reimplement this function to do the actual work.
	/// </summary>
	public override long RemovePoint(IntPtr pos)
	{
		return vtkColorTransferControlPointsItem_RemovePoint_12(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkColorTransferControlPointsItem_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkColorTransferControlPointsItem SafeDownCast(vtkObjectBase o)
	{
		vtkColorTransferControlPointsItem vtkColorTransferControlPointsItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkColorTransferControlPointsItem_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkColorTransferControlPointsItem2 = (vtkColorTransferControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkColorTransferControlPointsItem2.Register(null);
			}
		}
		return vtkColorTransferControlPointsItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferControlPointsItem_SetColorFill_14(HandleRef pThis, byte _arg);

	/// <summary>
	/// If ColorFill is true, the control point brush color is set with the
	/// matching color in the color transfer function.
	/// False by default.
	/// </summary>
	public virtual void SetColorFill(bool _arg)
	{
		vtkColorTransferControlPointsItem_SetColorFill_14(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferControlPointsItem_SetColorTransferFunction_15(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set the piecewise function to draw its points
	/// </summary>
	public void SetColorTransferFunction(vtkColorTransferFunction function)
	{
		vtkColorTransferControlPointsItem_SetColorTransferFunction_15(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkColorTransferControlPointsItem_SetControlPoint_16(HandleRef pThis, long index, IntPtr point);

	/// <summary>
	/// Sets the x and y coordinates as well as the midpoint and sharpness
	/// of the control point corresponding to the index.
	/// Changing the y has no effect, it will always be 0.5
	/// </summary>
	public override void SetControlPoint(long index, IntPtr point)
	{
		vtkColorTransferControlPointsItem_SetControlPoint_16(GetCppThis(), index, point);
	}
}
