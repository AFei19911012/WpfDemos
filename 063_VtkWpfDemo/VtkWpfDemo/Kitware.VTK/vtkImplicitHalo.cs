using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitHalo
/// </summary>
/// <remarks>
///    implicit function for an halo
///
/// vtkImplicitHalo evaluates to 1.0 for each position in the sphere of a
/// given center and radius Radius*(1-FadeOut). It evaluates to 0.0 for each
/// position out the sphere of a given Center and radius Radius. It fades out
/// linearly from 1.0 to 0.0 for points in a radius from Radius*(1-FadeOut) to
/// Radius.
/// vtkImplicitHalo is a concrete implementation of vtkImplicitFunction.
/// It is useful as an input to
/// vtkSampleFunction to generate an 2D image of an halo. It is used this way by
/// vtkShadowMapPass.
/// @warning
/// It does not implement the gradient.
/// </remarks>
public class vtkImplicitHalo : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitHalo";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitHalo()
	{
		MRClassNameKey = "class vtkImplicitHalo";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitHalo"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitHalo(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitHalo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
	/// </summary>
	public new static vtkImplicitHalo New()
	{
		vtkImplicitHalo result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitHalo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
	/// </summary>
	public vtkImplicitHalo()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitHalo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImplicitHalo_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate the equation.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitHalo_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitHalo_EvaluateGradient_02(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate normal. Not implemented.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkImplicitHalo_EvaluateGradient_02(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitHalo_GetCenter_03(HandleRef pThis);

	/// <summary>
	/// Center of the sphere.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkImplicitHalo_GetCenter_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitHalo_GetCenter_04(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Center of the sphere.
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImplicitHalo_GetCenter_04(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitHalo_GetCenter_05(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Center of the sphere.
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkImplicitHalo_GetCenter_05(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitHalo_GetFadeOut_06(HandleRef pThis);

	/// <summary>
	/// FadeOut ratio. Valid values are between 0.0 and 1.0.
	/// </summary>
	public virtual double GetFadeOut()
	{
		return vtkImplicitHalo_GetFadeOut_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitHalo_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitHalo_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitHalo_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitHalo_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitHalo_GetRadius_09(HandleRef pThis);

	/// <summary>
	/// Radius of the sphere.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkImplicitHalo_GetRadius_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitHalo_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitHalo_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitHalo_IsTypeOf_11(string type);

	/// <summary>
	/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitHalo_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitHalo_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
	/// </summary>
	public new vtkImplicitHalo NewInstance()
	{
		vtkImplicitHalo result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitHalo_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitHalo_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Center=(0.0,0.0,0.0), Radius=1.0, FadeOut=0.01
	/// </summary>
	public new static vtkImplicitHalo SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitHalo vtkImplicitHalo2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitHalo_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitHalo2 = (vtkImplicitHalo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitHalo2.Register(null);
			}
		}
		return vtkImplicitHalo2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitHalo_SetCenter_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Center of the sphere.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkImplicitHalo_SetCenter_15(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitHalo_SetCenter_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Center of the sphere.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkImplicitHalo_SetCenter_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitHalo_SetFadeOut_17(HandleRef pThis, double _arg);

	/// <summary>
	/// FadeOut ratio. Valid values are between 0.0 and 1.0.
	/// </summary>
	public virtual void SetFadeOut(double _arg)
	{
		vtkImplicitHalo_SetFadeOut_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitHalo_SetRadius_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Radius of the sphere.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkImplicitHalo_SetRadius_18(GetCppThis(), _arg);
	}
}
