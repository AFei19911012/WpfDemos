using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCylinder
/// </summary>
/// <remarks>
///    implicit function for a cylinder
///
/// vtkCylinder computes the implicit function and function gradient
/// for a cylinder using F(r)=r^2-Radius^2. vtkCylinder is a concrete
/// implementation of vtkImplicitFunction. By default the Cylinder is
/// centered at the origin and the axis of rotation is along the
/// y-axis. You can redefine the center and axis of rotation by setting
/// the Center and Axis data members. (Note that it is also possible to
/// use the superclass' vtkImplicitFunction transformation matrix if
/// necessary to reposition by using FunctionValue() and
/// FunctionGradient().)
///
/// @warning
/// The cylinder is infinite in extent. To truncate the cylinder in
/// modeling operations use the vtkImplicitBoolean in combination with
/// clipping planes.
///
/// </remarks>
/// <seealso>
///
/// vtkCylinderSource
/// </seealso>
public class vtkCylinder : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCylinder";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCylinder()
	{
		MRClassNameKey = "class vtkCylinder";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCylinder"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCylinder(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinder_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct cylinder radius of 0.5; centered at origin with axis
	/// along y coordinate axis.
	/// </summary>
	public new static vtkCylinder New()
	{
		vtkCylinder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCylinder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct cylinder radius of 0.5; centered at origin with axis
	/// along y coordinate axis.
	/// </summary>
	public vtkCylinder()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCylinder_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCylinder_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate cylinder equation F(r) = r^2 - Radius^2.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkCylinder_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate cylinder function gradient.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkCylinder_EvaluateGradient_02(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinder_GetAxis_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the axis of the cylinder. If the axis is not specified as
	/// a unit vector, it will be normalized. If zero-length axis vector
	/// is used as input to this method, it will be ignored.
	/// </summary>
	public virtual double[] GetAxis()
	{
		IntPtr intPtr = vtkCylinder_GetAxis_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_GetAxis_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the axis of the cylinder. If the axis is not specified as
	/// a unit vector, it will be normalized. If zero-length axis vector
	/// is used as input to this method, it will be ignored.
	/// </summary>
	public virtual void GetAxis(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCylinder_GetAxis_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_GetAxis_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the axis of the cylinder. If the axis is not specified as
	/// a unit vector, it will be normalized. If zero-length axis vector
	/// is used as input to this method, it will be ignored.
	/// </summary>
	public virtual void GetAxis(IntPtr _arg)
	{
		vtkCylinder_GetAxis_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinder_GetCenter_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the cylinder center.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkCylinder_GetCenter_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_GetCenter_07(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the cylinder center.
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCylinder_GetCenter_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_GetCenter_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cylinder center.
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkCylinder_GetCenter_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCylinder_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCylinder_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCylinder_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCylinder_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCylinder_GetRadius_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the cylinder radius.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkCylinder_GetRadius_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinder_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCylinder_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCylinder_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCylinder_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinder_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCylinder NewInstance()
	{
		vtkCylinder result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCylinder_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCylinder_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCylinder SafeDownCast(vtkObjectBase o)
	{
		vtkCylinder vtkCylinder2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCylinder_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCylinder2 = (vtkCylinder)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCylinder2.Register(null);
			}
		}
		return vtkCylinder2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_SetAxis_17(HandleRef pThis, double ax, double ay, double az);

	/// <summary>
	/// Set/Get the axis of the cylinder. If the axis is not specified as
	/// a unit vector, it will be normalized. If zero-length axis vector
	/// is used as input to this method, it will be ignored.
	/// </summary>
	public void SetAxis(double ax, double ay, double az)
	{
		vtkCylinder_SetAxis_17(GetCppThis(), ax, ay, az);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_SetAxis_18(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set/Get the axis of the cylinder. If the axis is not specified as
	/// a unit vector, it will be normalized. If zero-length axis vector
	/// is used as input to this method, it will be ignored.
	/// </summary>
	public void SetAxis(IntPtr a)
	{
		vtkCylinder_SetAxis_18(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_SetCenter_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the cylinder center.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkCylinder_SetCenter_19(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_SetCenter_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the cylinder center.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkCylinder_SetCenter_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCylinder_SetRadius_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the cylinder radius.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkCylinder_SetRadius_21(GetCppThis(), _arg);
	}
}
