using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSphere
/// </summary>
/// <remarks>
///    implicit function for a sphere
///
/// vtkSphere computes the implicit function and/or gradient for a sphere.
/// vtkSphere is a concrete implementation of vtkImplicitFunction. Additional
/// methods are available for sphere-related computations, such as computing
/// bounding spheres for a set of points, or set of spheres.
/// </remarks>
public class vtkSphere : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSphere";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSphere()
	{
		MRClassNameKey = "class vtkSphere";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSphere"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSphere(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphere_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct sphere with center at (0,0,0) and radius=0.5.
	/// </summary>
	public new static vtkSphere New()
	{
		vtkSphere result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphere_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct sphere with center at (0,0,0) and radius=0.5.
	/// </summary>
	public vtkSphere()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSphere_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkSphere_ComputeBoundingSphere_01(IntPtr pts, long numPts, IntPtr sphere, IntPtr hints);

	/// <summary>
	/// Create a bounding sphere from a set of points. The set of points is
	/// defined by an array of doubles, in the order of x-y-z (which repeats for
	/// each point).  An optional hints array provides a guess for the initial
	/// bounding sphere; the two values in the hints array are the two points
	/// expected to be the furthest apart. The output sphere consists of a
	/// center (x-y-z) and a radius.
	/// </summary>
	public static void ComputeBoundingSphere(IntPtr pts, long numPts, IntPtr sphere, IntPtr hints)
	{
		vtkSphere_ComputeBoundingSphere_01(pts, numPts, sphere, hints);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphere_Evaluate_02(IntPtr center, double R, IntPtr x);

	/// <summary>
	/// Quick evaluation of the sphere equation ((x-x0)^2 + (y-y0)^2 + (z-z0)^2) - R^2.
	/// </summary>
	public static double Evaluate(IntPtr center, double R, IntPtr x)
	{
		return vtkSphere_Evaluate_02(center, R, x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphere_EvaluateFunction_03(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate sphere equation ((x-x0)^2 + (y-y0)^2 + (z-z0)^2) - R^2.
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkSphere_EvaluateFunction_03(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphere_EvaluateGradient_04(HandleRef pThis, IntPtr x, IntPtr n);

	/// <summary>
	/// Evaluate sphere gradient.
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr n)
	{
		vtkSphere_EvaluateGradient_04(GetCppThis(), x, n);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphere_GetCenter_05(HandleRef pThis);

	/// <summary>
	/// Set / get the center of the sphere. The default is (0,0,0).
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkSphere_GetCenter_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphere_GetCenter_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / get the center of the sphere. The default is (0,0,0).
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkSphere_GetCenter_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphere_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSphere_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSphere_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSphere_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSphere_GetRadius_09(HandleRef pThis);

	/// <summary>
	/// Set / get the radius of the sphere. The default is 0.5.
	/// </summary>
	public virtual double GetRadius()
	{
		return vtkSphere_GetRadius_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphere_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSphere_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSphere_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSphere_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphere_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSphere NewInstance()
	{
		vtkSphere result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphere_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSphere_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSphere SafeDownCast(vtkObjectBase o)
	{
		vtkSphere vtkSphere2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSphere_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSphere2 = (vtkSphere)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSphere2.Register(null);
			}
		}
		return vtkSphere2;
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphere_SetCenter_15(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set / get the center of the sphere. The default is (0,0,0).
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkSphere_SetCenter_15(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphere_SetCenter_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / get the center of the sphere. The default is (0,0,0).
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkSphere_SetCenter_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSphere_SetRadius_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / get the radius of the sphere. The default is 0.5.
	/// </summary>
	public virtual void SetRadius(double _arg)
	{
		vtkSphere_SetRadius_17(GetCppThis(), _arg);
	}
}
