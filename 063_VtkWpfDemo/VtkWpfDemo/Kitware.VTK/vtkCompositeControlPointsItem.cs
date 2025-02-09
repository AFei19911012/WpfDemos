using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCompositeControlPointsItem
/// </summary>
/// <remarks>
///    Control points for
/// vtkCompositeFunction.
///
/// vtkCompositeControlPointsItem draws the control points of a vtkPiecewiseFunction
/// and a vtkColorTransferFunction.
/// </remarks>
/// <seealso>
///
/// vtkControlPointsItem
/// vtkColorTransferControlPointsItem
/// vtkCompositeTransferFunctionItem
/// vtkPiecewisePointHandleItem
/// </seealso>
public class vtkCompositeControlPointsItem : vtkColorTransferControlPointsItem
{
	/// <summary>
	/// Utility function that calls SetPiecewiseFunction()
	/// </summary>
	public enum PointsFunctionType
	{
		/// <summary>enum member</summary>
		ColorAndOpacityPointsFunction = 3,
		/// <summary>enum member</summary>
		ColorPointsFunction = 1,
		/// <summary>enum member</summary>
		OpacityPointsFunction = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeControlPointsItem";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCompositeControlPointsItem()
	{
		MRClassNameKey = "class vtkCompositeControlPointsItem";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeControlPointsItem"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCompositeControlPointsItem(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeControlPointsItem_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a piecewise control points object
	/// </summary>
	public new static vtkCompositeControlPointsItem New()
	{
		vtkCompositeControlPointsItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a piecewise control points object
	/// </summary>
	public vtkCompositeControlPointsItem()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCompositeControlPointsItem_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkCompositeControlPointsItem_AddPoint_01(HandleRef pThis, IntPtr newPos);

	/// <summary>
	/// Add a point to the function. Returns the index of the point (0 based),
	/// or -1 on error.
	/// Subclasses should reimplement this function to do the actual work.
	/// </summary>
	public override long AddPoint(IntPtr newPos)
	{
		return vtkCompositeControlPointsItem_AddPoint_01(GetCppThis(), newPos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeControlPointsItem_GetControlPoint_02(HandleRef pThis, long index, IntPtr point);

	/// <summary>
	/// Returns the x and y coordinates as well as the midpoint and sharpness
	/// of the control point corresponding to the index.
	/// point must be a double array of size 4.
	/// The values will be recovered from the opacity function when available.
	/// </summary>
	public override void GetControlPoint(long index, IntPtr point)
	{
		vtkCompositeControlPointsItem_GetControlPoint_02(GetCppThis(), index, point);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeControlPointsItem_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCompositeControlPointsItem_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeControlPointsItem_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCompositeControlPointsItem_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeControlPointsItem_GetNumberOfPoints_05(HandleRef pThis);

	/// <summary>
	/// Returns the total number of points, either from
	/// using the superclass implementation or the opacity function
	/// when available
	/// </summary>
	public override long GetNumberOfPoints()
	{
		return vtkCompositeControlPointsItem_GetNumberOfPoints_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeControlPointsItem_GetOpacityFunction_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Utility function that calls SetPiecewiseFunction()
	/// </summary>
	public virtual vtkPiecewiseFunction GetOpacityFunction()
	{
		vtkPiecewiseFunction vtkPiecewiseFunction2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeControlPointsItem_GetOpacityFunction_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCompositeControlPointsItem_GetPointsFunction_07(HandleRef pThis);

	/// <summary>
	/// PointsFunction controls whether the points represent the
	/// ColorTransferFunction, OpacityTransferFunction or both.
	/// If ColorPointsFunction, only the points of the ColorTransfer function are
	/// used.
	/// If OpacityPointsFunction, only the points of the Opacity function are used
	/// If ColorAndOpacityPointsFunction, the points of both functions are shared
	/// by both functions.
	/// ColorAndOpacityPointsFunction by default.
	/// Note: Set the mode before the functions are set. ColorPointsFunction is
	/// not fully supported.
	/// </summary>
	public virtual int GetPointsFunction()
	{
		return vtkCompositeControlPointsItem_GetPointsFunction_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkCompositeControlPointsItem_GetUseOpacityPointHandles_08(HandleRef pThis);

	/// <summary>
	/// If UseOpacityPointHandles is true, when the current point is
	/// double clicked, a vtkPiecewisePointHandleItem will show up so
	/// that the sharpness and mid point can be adjusted in the scene
	/// with those handles
	/// False by default.
	/// </summary>
	public virtual bool GetUseOpacityPointHandles()
	{
		return (vtkCompositeControlPointsItem_GetUseOpacityPointHandles_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeControlPointsItem_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCompositeControlPointsItem_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCompositeControlPointsItem_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCompositeControlPointsItem_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeControlPointsItem_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCompositeControlPointsItem NewInstance()
	{
		vtkCompositeControlPointsItem result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeControlPointsItem_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCompositeControlPointsItem_RemovePoint_13(HandleRef pThis, IntPtr pos);

	/// <summary>
	/// Remove a point of the function. Returns the index of the point (0 based),
	/// or -1 on error.
	/// Subclasses should reimplement this function to do the actual work.
	/// </summary>
	public override long RemovePoint(IntPtr pos)
	{
		return vtkCompositeControlPointsItem_RemovePoint_13(GetCppThis(), pos);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCompositeControlPointsItem_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCompositeControlPointsItem SafeDownCast(vtkObjectBase o)
	{
		vtkCompositeControlPointsItem vtkCompositeControlPointsItem2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCompositeControlPointsItem_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCompositeControlPointsItem2 = (vtkCompositeControlPointsItem)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCompositeControlPointsItem2.Register(null);
			}
		}
		return vtkCompositeControlPointsItem2;
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeControlPointsItem_SetColorTransferFunction_15(HandleRef pThis, HandleRef function);

	/// <summary>
	/// Set the color transfer function to draw its points
	/// </summary>
	public new virtual void SetColorTransferFunction(vtkColorTransferFunction function)
	{
		vtkCompositeControlPointsItem_SetColorTransferFunction_15(GetCppThis(), function?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeControlPointsItem_SetControlPoint_16(HandleRef pThis, long index, IntPtr point);

	/// <summary>
	/// Sets the x and y coordinates as well as the midpoint and sharpness,
	/// of the control point corresponding to the index, either using the superclass
	/// implementation or the opacity function when available.
	/// The provided point should be a double array of size 4.
	/// </summary>
	public override void SetControlPoint(long index, IntPtr point)
	{
		vtkCompositeControlPointsItem_SetControlPoint_16(GetCppThis(), index, point);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeControlPointsItem_SetOpacityFunction_17(HandleRef pThis, HandleRef opacity);

	/// <summary>
	/// Utility function that calls SetPiecewiseFunction()
	/// </summary>
	public void SetOpacityFunction(vtkPiecewiseFunction opacity)
	{
		vtkCompositeControlPointsItem_SetOpacityFunction_17(GetCppThis(), opacity?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeControlPointsItem_SetPointsFunction_18(HandleRef pThis, int _arg);

	/// <summary>
	/// PointsFunction controls whether the points represent the
	/// ColorTransferFunction, OpacityTransferFunction or both.
	/// If ColorPointsFunction, only the points of the ColorTransfer function are
	/// used.
	/// If OpacityPointsFunction, only the points of the Opacity function are used
	/// If ColorAndOpacityPointsFunction, the points of both functions are shared
	/// by both functions.
	/// ColorAndOpacityPointsFunction by default.
	/// Note: Set the mode before the functions are set. ColorPointsFunction is
	/// not fully supported.
	/// </summary>
	public virtual void SetPointsFunction(int _arg)
	{
		vtkCompositeControlPointsItem_SetPointsFunction_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ChartsCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCompositeControlPointsItem_SetUseOpacityPointHandles_19(HandleRef pThis, byte _arg);

	/// <summary>
	/// If UseOpacityPointHandles is true, when the current point is
	/// double clicked, a vtkPiecewisePointHandleItem will show up so
	/// that the sharpness and mid point can be adjusted in the scene
	/// with those handles
	/// False by default.
	/// </summary>
	public virtual void SetUseOpacityPointHandles(bool _arg)
	{
		vtkCompositeControlPointsItem_SetUseOpacityPointHandles_19(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
