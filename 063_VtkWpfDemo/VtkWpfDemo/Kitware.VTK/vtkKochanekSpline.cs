using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkKochanekSpline
/// </summary>
/// <remarks>
///    computes an interpolating spline using a Kochanek basis.
///
/// Implements the Kochanek interpolating spline described in: Kochanek, D.,
/// Bartels, R., "Interpolating Splines with Local Tension, Continuity, and
/// Bias Control," Computer Graphics, vol. 18, no. 3, pp. 33-41, July 1984.
/// These splines give the user more control over the shape of the curve than
/// the cardinal splines implemented in vtkCardinalSpline. Three parameters
/// can be specified. All have a range from -1 to 1.
///
/// Tension controls how sharply the curve bends at an input point. A
/// value of -1 produces more slack in the curve. A value of 1 tightens
/// the curve.
///
/// Continuity controls the continuity of the first derivative at input
/// points.
///
/// Bias controls the direction of the curve at it passes through an input
/// point. A value of -1 undershoots the point while a value of 1
/// overshoots the point.
///
/// These three parameters give the user broad control over the shape of
/// the interpolating spline. The original Kochanek paper describes the
/// effects nicely and is recommended reading.
///
/// </remarks>
/// <seealso>
///
/// vtkSpline vtkCardinalSpline
/// </seealso>
public class vtkKochanekSpline : vtkSpline
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkKochanekSpline";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkKochanekSpline()
	{
		MRClassNameKey = "class vtkKochanekSpline";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkKochanekSpline"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkKochanekSpline(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKochanekSpline_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a KochanekSpline with the following defaults: DefaultBias = 0,
	/// DefaultTension = 0, DefaultContinuity = 0.
	/// </summary>
	public new static vtkKochanekSpline New()
	{
		vtkKochanekSpline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKochanekSpline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a KochanekSpline with the following defaults: DefaultBias = 0,
	/// DefaultTension = 0, DefaultContinuity = 0.
	/// </summary>
	public vtkKochanekSpline()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkKochanekSpline_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKochanekSpline_Compute_01(HandleRef pThis);

	/// <summary>
	/// Compute Kochanek Spline coefficients.
	/// </summary>
	public override void Compute()
	{
		vtkKochanekSpline_Compute_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKochanekSpline_DeepCopy_02(HandleRef pThis, HandleRef s);

	/// <summary>
	/// Deep copy of cardinal spline data.
	/// </summary>
	public override void DeepCopy(vtkSpline s)
	{
		vtkKochanekSpline_DeepCopy_02(GetCppThis(), s?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKochanekSpline_Evaluate_03(HandleRef pThis, double t);

	/// <summary>
	/// Evaluate a 1D Kochanek spline.
	/// </summary>
	public override double Evaluate(double t)
	{
		return vtkKochanekSpline_Evaluate_03(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKochanekSpline_GetDefaultBias_04(HandleRef pThis);

	/// <summary>
	/// Set the bias for all points. Default is 0.
	/// </summary>
	public virtual double GetDefaultBias()
	{
		return vtkKochanekSpline_GetDefaultBias_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKochanekSpline_GetDefaultContinuity_05(HandleRef pThis);

	/// <summary>
	/// Set the continuity for all points. Default is 0.
	/// </summary>
	public virtual double GetDefaultContinuity()
	{
		return vtkKochanekSpline_GetDefaultContinuity_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkKochanekSpline_GetDefaultTension_06(HandleRef pThis);

	/// <summary>
	/// Set the tension for all points. Default is 0.
	/// </summary>
	public virtual double GetDefaultTension()
	{
		return vtkKochanekSpline_GetDefaultTension_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKochanekSpline_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkKochanekSpline_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkKochanekSpline_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkKochanekSpline_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKochanekSpline_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkKochanekSpline_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkKochanekSpline_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkKochanekSpline_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKochanekSpline_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkKochanekSpline NewInstance()
	{
		vtkKochanekSpline result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKochanekSpline_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkKochanekSpline_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkKochanekSpline SafeDownCast(vtkObjectBase o)
	{
		vtkKochanekSpline vtkKochanekSpline2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkKochanekSpline_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkKochanekSpline2 = (vtkKochanekSpline)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkKochanekSpline2.Register(null);
			}
		}
		return vtkKochanekSpline2;
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKochanekSpline_SetDefaultBias_14(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the bias for all points. Default is 0.
	/// </summary>
	public virtual void SetDefaultBias(double _arg)
	{
		vtkKochanekSpline_SetDefaultBias_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKochanekSpline_SetDefaultContinuity_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the continuity for all points. Default is 0.
	/// </summary>
	public virtual void SetDefaultContinuity(double _arg)
	{
		vtkKochanekSpline_SetDefaultContinuity_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.CommonComputationalGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkKochanekSpline_SetDefaultTension_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the tension for all points. Default is 0.
	/// </summary>
	public virtual void SetDefaultTension(double _arg)
	{
		vtkKochanekSpline_SetDefaultTension_16(GetCppThis(), _arg);
	}
}
