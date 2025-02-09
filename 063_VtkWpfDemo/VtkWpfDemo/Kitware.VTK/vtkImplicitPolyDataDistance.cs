using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImplicitPolyDataDistance
/// </summary>
/// <remarks>
///    Implicit function that computes the distance from a point x to the nearest point p on an
/// input vtkPolyData.
///
/// Implicit function that computes the distance from a point x to the
/// nearest point p on an input vtkPolyData. The sign of the function
/// is set to the sign of the dot product between the angle-weighted
/// pseudonormal at the nearest surface point and the vector x - p.
/// Points interior to the geometry have a negative distance, points on
/// the exterior have a positive distance, and points on the input
/// vtkPolyData have a distance of zero. The gradient of the function
/// is the angle-weighted pseudonormal at the nearest point.
///
/// Baerentzen, J. A. and Aanaes, H. (2005). Signed distance
/// computation using the angle weighted pseudonormal. IEEE
/// Transactions on Visualization and Computer Graphics, 11:243-253.
///
/// This code was contributed in the VTK Journal paper:
/// "Boolean Operations on Surfaces in VTK Without External Libraries"
/// by Cory Quammen, Chris Weigle C., Russ Taylor
/// http://hdl.handle.net/10380/3262
/// http://www.midasjournal.org/browse/publication/797
/// </remarks>
public class vtkImplicitPolyDataDistance : vtkImplicitFunction
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitPolyDataDistance";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImplicitPolyDataDistance()
	{
		MRClassNameKey = "class vtkImplicitPolyDataDistance";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitPolyDataDistance"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImplicitPolyDataDistance(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPolyDataDistance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitPolyDataDistance New()
	{
		vtkImplicitPolyDataDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPolyDataDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitPolyDataDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImplicitPolyDataDistance()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImplicitPolyDataDistance_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPolyDataDistance_EvaluateFunction_01(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Evaluate plane equation of nearest triangle to point x[3].
	/// </summary>
	public override double EvaluateFunction(IntPtr x)
	{
		return vtkImplicitPolyDataDistance_EvaluateFunction_01(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPolyDataDistance_EvaluateFunctionAndGetClosestPoint_02(HandleRef pThis, IntPtr x, IntPtr closestPoint);

	/// <summary>
	/// Evaluate plane equation of nearest triangle to point x[3] and provides closest point on an
	/// input vtkPolyData.
	/// </summary>
	public double EvaluateFunctionAndGetClosestPoint(IntPtr x, IntPtr closestPoint)
	{
		return vtkImplicitPolyDataDistance_EvaluateFunctionAndGetClosestPoint_02(GetCppThis(), x, closestPoint);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_EvaluateGradient_03(HandleRef pThis, IntPtr x, IntPtr g);

	/// <summary>
	/// Evaluate function gradient of nearest triangle to point x[3].
	/// </summary>
	public override void EvaluateGradient(IntPtr x, IntPtr g)
	{
		vtkImplicitPolyDataDistance_EvaluateGradient_03(GetCppThis(), x, g);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImplicitPolyDataDistance_GetMTime_04(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the Input dependency.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImplicitPolyDataDistance_GetMTime_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPolyDataDistance_GetNoClosestPoint_05(HandleRef pThis);

	/// <summary>
	/// Set/get the closest point to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual double[] GetNoClosestPoint()
	{
		IntPtr intPtr = vtkImplicitPolyDataDistance_GetNoClosestPoint_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_GetNoClosestPoint_06(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get the closest point to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void GetNoClosestPoint(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImplicitPolyDataDistance_GetNoClosestPoint_06(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_GetNoClosestPoint_07(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the closest point to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void GetNoClosestPoint(IntPtr _arg)
	{
		vtkImplicitPolyDataDistance_GetNoClosestPoint_07(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPolyDataDistance_GetNoGradient_08(HandleRef pThis);

	/// <summary>
	/// Set/get the function gradient to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual double[] GetNoGradient()
	{
		IntPtr intPtr = vtkImplicitPolyDataDistance_GetNoGradient_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_GetNoGradient_09(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/get the function gradient to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void GetNoGradient(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImplicitPolyDataDistance_GetNoGradient_09(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_GetNoGradient_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the function gradient to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void GetNoGradient(IntPtr _arg)
	{
		vtkImplicitPolyDataDistance_GetNoGradient_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPolyDataDistance_GetNoValue_11(HandleRef pThis);

	/// <summary>
	/// Set/get the function value to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual double GetNoValue()
	{
		return vtkImplicitPolyDataDistance_GetNoValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitPolyDataDistance_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImplicitPolyDataDistance_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImplicitPolyDataDistance_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImplicitPolyDataDistance_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImplicitPolyDataDistance_GetTolerance_14(HandleRef pThis);

	/// <summary>
	/// Set/get the tolerance used for the locator.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkImplicitPolyDataDistance_GetTolerance_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPolyDataDistance_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImplicitPolyDataDistance_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImplicitPolyDataDistance_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImplicitPolyDataDistance_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPolyDataDistance_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImplicitPolyDataDistance NewInstance()
	{
		vtkImplicitPolyDataDistance result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPolyDataDistance_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImplicitPolyDataDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImplicitPolyDataDistance_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImplicitPolyDataDistance SafeDownCast(vtkObjectBase o)
	{
		vtkImplicitPolyDataDistance vtkImplicitPolyDataDistance2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImplicitPolyDataDistance_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImplicitPolyDataDistance2 = (vtkImplicitPolyDataDistance)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImplicitPolyDataDistance2.Register(null);
			}
		}
		return vtkImplicitPolyDataDistance2;
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_SetInput_20(HandleRef pThis, HandleRef input);

	/// <summary>
	/// Set the input vtkPolyData used for the implicit function
	/// evaluation.  Passes input through an internal instance of
	/// vtkTriangleFilter to remove vertices and lines, leaving only
	/// triangular polygons for evaluation as implicit planes.
	/// </summary>
	public void SetInput(vtkPolyData input)
	{
		vtkImplicitPolyDataDistance_SetInput_20(GetCppThis(), input?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_SetNoClosestPoint_21(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get the closest point to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void SetNoClosestPoint(double _arg1, double _arg2, double _arg3)
	{
		vtkImplicitPolyDataDistance_SetNoClosestPoint_21(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_SetNoClosestPoint_22(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the closest point to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void SetNoClosestPoint(IntPtr _arg)
	{
		vtkImplicitPolyDataDistance_SetNoClosestPoint_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_SetNoGradient_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/get the function gradient to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void SetNoGradient(double _arg1, double _arg2, double _arg3)
	{
		vtkImplicitPolyDataDistance_SetNoGradient_23(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_SetNoGradient_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/get the function gradient to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void SetNoGradient(IntPtr _arg)
	{
		vtkImplicitPolyDataDistance_SetNoGradient_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_SetNoValue_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the function value to use if no input vtkPolyData
	/// specified.
	/// </summary>
	public virtual void SetNoValue(double _arg)
	{
		vtkImplicitPolyDataDistance_SetNoValue_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImplicitPolyDataDistance_SetTolerance_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/get the tolerance used for the locator.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkImplicitPolyDataDistance_SetTolerance_26(GetCppThis(), _arg);
	}
}
