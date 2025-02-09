using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSuperquadric
/// </summary>
/// <remarks>
///    implicit function for a Superquadric
///
/// vtkSuperquadric computes the implicit function and function gradient
/// for a superquadric. vtkSuperquadric is a concrete implementation of
/// vtkImplicitFunction.  The superquadric is centered at Center and axes
/// of rotation is along the y-axis. (Use the superclass'
/// vtkImplicitFunction transformation matrix if necessary to reposition.)
/// Roundness parameters (PhiRoundness and ThetaRoundness) control
/// the shape of the superquadric.  The Toroidal boolean controls whether
/// a toroidal superquadric is produced.  If so, the Thickness parameter
/// controls the thickness of the toroid:  0 is the thinnest allowable
/// toroid, and 1 has a minimum sized hole.  The Scale parameters allow
/// the superquadric to be scaled in x, y, and z (normal vectors are correctly
/// generated in any case).  The Size parameter controls size of the
/// superquadric.
///
/// This code is based on "Rigid physically based superquadrics", A. H. Barr,
/// in "Graphics Gems III", David Kirk, ed., Academic Press, 1992.
///
/// @warning
/// The Size and Thickness parameters control coefficients of superquadric
/// generation, and may do not exactly describe the size of the superquadric.
///
/// </remarks>
public class vtkSuperquadric : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSuperquadric";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSuperquadric()
	{
		MRClassNameKey = "class vtkSuperquadric";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSuperquadric"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSuperquadric(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public new static vtkSuperquadric New()
	{
		vtkSuperquadric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSuperquadric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public vtkSuperquadric()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSuperquadric_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkSuperquadric_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkSuperquadric_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkSuperquadric_EvaluateGradient_02(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadric_GetCenter_03(HandleRef pThis);

	/// <summary>
	/// Set the center of the superquadric. Default is 0,0,0.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkSuperquadric_GetCenter_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_GetCenter_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the superquadric. Default is 0,0,0.
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkSuperquadric_GetCenter_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSuperquadric_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSuperquadric_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSuperquadric_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSuperquadric_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadric_GetPhiRoundness_07(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric north/south roundness.
	/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
	/// </summary>
	public virtual double GetPhiRoundness()
	{
		return vtkSuperquadric_GetPhiRoundness_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadric_GetScale_08(HandleRef pThis);

	/// <summary>
	/// Set the scale factors of the superquadric. Default is 1,1,1.
	/// </summary>
	public virtual double[] GetScale()
	{
		IntPtr intPtr = vtkSuperquadric_GetScale_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_GetScale_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the scale factors of the superquadric. Default is 1,1,1.
	/// </summary>
	public virtual void GetScale(IntPtr data)
	{
		vtkSuperquadric_GetScale_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadric_GetSize_10(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric isotropic size.
	/// </summary>
	public virtual double GetSize()
	{
		return vtkSuperquadric_GetSize_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadric_GetThetaRoundness_11(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric east/west roundness.
	/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
	/// </summary>
	public virtual double GetThetaRoundness()
	{
		return vtkSuperquadric_GetThetaRoundness_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadric_GetThickness_12(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric ring thickness (toroids only).
	/// Changing thickness maintains the outside diameter of the toroid.
	/// </summary>
	public virtual double GetThickness()
	{
		return vtkSuperquadric_GetThickness_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadric_GetThicknessMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric ring thickness (toroids only).
	/// Changing thickness maintains the outside diameter of the toroid.
	/// </summary>
	public virtual double GetThicknessMaxValue()
	{
		return vtkSuperquadric_GetThicknessMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSuperquadric_GetThicknessMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get Superquadric ring thickness (toroids only).
	/// Changing thickness maintains the outside diameter of the toroid.
	/// </summary>
	public virtual double GetThicknessMinValue()
	{
		return vtkSuperquadric_GetThicknessMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadric_GetToroidal_15(HandleRef pThis);

	/// <summary>
	/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
	/// </summary>
	public virtual int GetToroidal()
	{
		return vtkSuperquadric_GetToroidal_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadric_IsA_16(HandleRef pThis, string type);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSuperquadric_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSuperquadric_IsTypeOf_17(string type);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSuperquadric_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadric_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public new vtkSuperquadric NewInstance()
	{
		vtkSuperquadric result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSuperquadric_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSuperquadric_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with superquadric radius of 0.5, toroidal off, center at 0.0,
	/// scale (1,1,1), size 0.5, phi roundness 1.0, and theta roundness 0.0.
	/// </summary>
	public new static vtkSuperquadric SafeDownCast(vtkObjectBase o)
	{
		vtkSuperquadric vtkSuperquadric2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSuperquadric_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSuperquadric2 = (vtkSuperquadric)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSuperquadric2.Register(null);
			}
		}
		return vtkSuperquadric2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetCenter_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the superquadric. Default is 0,0,0.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkSuperquadric_SetCenter_21(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetCenter_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the superquadric. Default is 0,0,0.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkSuperquadric_SetCenter_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetPhiRoundness_23(HandleRef pThis, double e);

	/// <summary>
	/// Set/Get Superquadric north/south roundness.
	/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
	/// </summary>
	public void SetPhiRoundness(double e)
	{
		vtkSuperquadric_SetPhiRoundness_23(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetScale_24(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the scale factors of the superquadric. Default is 1,1,1.
	/// </summary>
	public virtual void SetScale(double _arg1, double _arg2, double _arg3)
	{
		vtkSuperquadric_SetScale_24(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetScale_25(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the scale factors of the superquadric. Default is 1,1,1.
	/// </summary>
	public virtual void SetScale(IntPtr _arg)
	{
		vtkSuperquadric_SetScale_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetSize_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get Superquadric isotropic size.
	/// </summary>
	public virtual void SetSize(double _arg)
	{
		vtkSuperquadric_SetSize_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetThetaRoundness_27(HandleRef pThis, double e);

	/// <summary>
	/// Set/Get Superquadric east/west roundness.
	/// Values range from 0 (rectangular) to 1 (circular) to higher orders.
	/// </summary>
	public void SetThetaRoundness(double e)
	{
		vtkSuperquadric_SetThetaRoundness_27(GetCppThis(), e);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetThickness_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get Superquadric ring thickness (toroids only).
	/// Changing thickness maintains the outside diameter of the toroid.
	/// </summary>
	public virtual void SetThickness(double _arg)
	{
		vtkSuperquadric_SetThickness_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_SetToroidal_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
	/// </summary>
	public virtual void SetToroidal(int _arg)
	{
		vtkSuperquadric_SetToroidal_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_ToroidalOff_30(HandleRef pThis);

	/// <summary>
	/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
	/// </summary>
	public virtual void ToroidalOff()
	{
		vtkSuperquadric_ToroidalOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSuperquadric_ToroidalOn_31(HandleRef pThis);

	/// <summary>
	/// Set/Get whether or not the superquadric is toroidal (1) or ellipsoidal (0).
	/// </summary>
	public virtual void ToroidalOn()
	{
		vtkSuperquadric_ToroidalOn_31(GetCppThis());
	}
}
