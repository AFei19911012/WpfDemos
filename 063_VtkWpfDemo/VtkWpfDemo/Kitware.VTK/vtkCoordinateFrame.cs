using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCoordinateFrame
/// </summary>
/// <remarks>
///    implicit function for a right-handed coordinate system
///
/// vtkCoordinateFrame computes an implicit function and function gradient
/// for a set of 3 orthogonal planes.
///
/// The function evaluates to a combination of quartic spherical harmonic
/// basis functions:
/// \f$\sqrt(\frac{7}{12})*Y_{4,0} + \sqrt(\frac{5}{12})*Y_{4,4}\f$
/// that – when evaluated on a unit sphere centered at the coordinate frame's
/// origin – form a 6-lobed function with a maximum along each of the
/// 6 axes (3 positive, 3 negative).
/// This function is frequently used in frame-field design.
///
/// See the paper "On Smooth Frame Field Design" by Nicolas Ray and
/// Dmitry Sokolov (2016, hal-01245657,
/// https://hal.inria.fr/hal-01245657/file/framefield.pdf ) for more
/// information.
/// </remarks>
public class vtkCoordinateFrame : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCoordinateFrame";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCoordinateFrame()
	{
		MRClassNameKey = "class vtkCoordinateFrame";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCoordinateFrame"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCoordinateFrame(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrame_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkCoordinateFrame New()
	{
		vtkCoordinateFrame result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrame_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCoordinateFrame)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public vtkCoordinateFrame()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCoordinateFrame_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkCoordinateFrame_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate plane equations. Return largest value (i.e., an intersection
	/// operation between all planes).
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkCoordinateFrame_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate coordinate frame gradient.
	///
	/// \a n is the output gradient evaluated at point \a x.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkCoordinateFrame_EvaluateGradient_02(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCoordinateFrame_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCoordinateFrame_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCoordinateFrame_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCoordinateFrame_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrame_GetOrigin_05(HandleRef pThis);

	/// <summary>
	/// Specify the point through which all 3 planes pass.
	/// </summary>
	public virtual double[] GetOrigin()
	{
		IntPtr intPtr = vtkCoordinateFrame_GetOrigin_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_GetOrigin_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify the point through which all 3 planes pass.
	/// </summary>
	public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinateFrame_GetOrigin_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_GetOrigin_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the point through which all 3 planes pass.
	/// </summary>
	public virtual void GetOrigin(IntPtr _arg)
	{
		vtkCoordinateFrame_GetOrigin_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrame_GetXAxis_08(HandleRef pThis);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual double[] GetXAxis()
	{
		IntPtr intPtr = vtkCoordinateFrame_GetXAxis_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_GetXAxis_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void GetXAxis(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinateFrame_GetXAxis_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_GetXAxis_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void GetXAxis(IntPtr _arg)
	{
		vtkCoordinateFrame_GetXAxis_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrame_GetYAxis_11(HandleRef pThis);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual double[] GetYAxis()
	{
		IntPtr intPtr = vtkCoordinateFrame_GetYAxis_11(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_GetYAxis_12(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void GetYAxis(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinateFrame_GetYAxis_12(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_GetYAxis_13(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void GetYAxis(IntPtr _arg)
	{
		vtkCoordinateFrame_GetYAxis_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrame_GetZAxis_14(HandleRef pThis);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual double[] GetZAxis()
	{
		IntPtr intPtr = vtkCoordinateFrame_GetZAxis_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_GetZAxis_15(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void GetZAxis(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkCoordinateFrame_GetZAxis_15(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_GetZAxis_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void GetZAxis(IntPtr _arg)
	{
		vtkCoordinateFrame_GetZAxis_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrame_IsA_17(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCoordinateFrame_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCoordinateFrame_IsTypeOf_18(string type);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCoordinateFrame_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrame_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new vtkCoordinateFrame NewInstance()
	{
		vtkCoordinateFrame result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrame_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCoordinateFrame)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCoordinateFrame_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, type information, and printing.
	/// </summary>
	public new static vtkCoordinateFrame SafeDownCast(vtkObjectBase o)
	{
		vtkCoordinateFrame vtkCoordinateFrame2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCoordinateFrame_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinateFrame2 = (vtkCoordinateFrame)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinateFrame2.Register(null);
			}
		}
		return vtkCoordinateFrame2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_SetOrigin_22(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the point through which all 3 planes pass.
	/// </summary>
	public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkCoordinateFrame_SetOrigin_22(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_SetOrigin_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the point through which all 3 planes pass.
	/// </summary>
	public virtual void SetOrigin(IntPtr _arg)
	{
		vtkCoordinateFrame_SetOrigin_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_SetXAxis_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void SetXAxis(double _arg1, double _arg2, double _arg3)
	{
		vtkCoordinateFrame_SetXAxis_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_SetXAxis_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void SetXAxis(IntPtr _arg)
	{
		vtkCoordinateFrame_SetXAxis_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_SetYAxis_26(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void SetYAxis(double _arg1, double _arg2, double _arg3)
	{
		vtkCoordinateFrame_SetYAxis_26(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_SetYAxis_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void SetYAxis(IntPtr _arg)
	{
		vtkCoordinateFrame_SetYAxis_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_SetZAxis_28(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void SetZAxis(double _arg1, double _arg2, double _arg3)
	{
		vtkCoordinateFrame_SetZAxis_28(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCoordinateFrame_SetZAxis_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a list of unit-length normal vectors for each plane.
	/// </summary>
	public virtual void SetZAxis(IntPtr _arg)
	{
		vtkCoordinateFrame_SetZAxis_29(GetCppThis(), _arg);
	}
}
