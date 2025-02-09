using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkShepardKernel
/// </summary>
/// <remarks>
///    a Shepard method interpolation kernel
///
///
/// vtkShepardKernel is an interpolation kernel that uses the method of
/// Shepard to perform interpolation. The weights are computed as 1/r^p, where
/// r is the distance to a neighbor point within the kernel radius R; and p
/// (the power parameter) is a positive exponent (typically p=2).
///
/// @warning
/// The weights are normalized sp that SUM(Wi) = 1. If a neighbor point p
/// precisely lies on the point to be interpolated, then the interpolated
/// point takes on the values associated with p.
///
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator vtkPointInterpolator2D vtkInterpolationKernel
/// vtkGaussianKernel vtkSPHKernel vtkShepardKernel
/// </seealso>
public class vtkShepardKernel : vtkGeneralizedKernel
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkShepardKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkShepardKernel()
	{
		MRClassNameKey = "class vtkShepardKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkShepardKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkShepardKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShepardKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkShepardKernel New()
	{
		vtkShepardKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShepardKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShepardKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkShepardKernel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkShepardKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShepardKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

	/// <summary>
	/// Given a point x, a list of basis points pIds, and a probability
	/// weighting function prob, compute interpolation weights associated with
	/// these basis points.  Note that basis points list pIds, the probability
	/// weighting prob, and the weights array are provided by the caller of the
	/// method, and may be dynamically resized as necessary. The method returns
	/// the number of weights (pIds may be resized in some cases). Typically
	/// this method is called after ComputeBasis(), although advanced users can
	/// invoke ComputeWeights() and provide the interpolation basis points pIds
	/// directly. The probably weighting prob are numbers 0&lt;=prob&lt;=1 which are
	/// multiplied against the interpolation weights before normalization. They
	/// are estimates of local confidence of weights. The prob may be nullptr in
	/// which all probabilities are considered =1.
	/// </summary>
	public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
	{
		return vtkShepardKernel_ComputeWeights_01(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), prob?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShepardKernel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkShepardKernel_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShepardKernel_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkShepardKernel_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardKernel_GetPowerParameter_04(HandleRef pThis);

	/// <summary>
	/// Set / Get the power parameter p. By default p=2. Values (which must be
	/// a positive, real value) != 2 may affect performance significantly.
	/// </summary>
	public virtual double GetPowerParameter()
	{
		return vtkShepardKernel_GetPowerParameter_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardKernel_GetPowerParameterMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set / Get the power parameter p. By default p=2. Values (which must be
	/// a positive, real value) != 2 may affect performance significantly.
	/// </summary>
	public virtual double GetPowerParameterMaxValue()
	{
		return vtkShepardKernel_GetPowerParameterMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkShepardKernel_GetPowerParameterMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set / Get the power parameter p. By default p=2. Values (which must be
	/// a positive, real value) != 2 may affect performance significantly.
	/// </summary>
	public virtual double GetPowerParameterMinValue()
	{
		return vtkShepardKernel_GetPowerParameterMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShepardKernel_IsA_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkShepardKernel_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShepardKernel_IsTypeOf_08(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkShepardKernel_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShepardKernel_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkShepardKernel NewInstance()
	{
		vtkShepardKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShepardKernel_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShepardKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShepardKernel_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkShepardKernel SafeDownCast(vtkObjectBase o)
	{
		vtkShepardKernel vtkShepardKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShepardKernel_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShepardKernel2 = (vtkShepardKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShepardKernel2.Register(null);
			}
		}
		return vtkShepardKernel2;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShepardKernel_SetPowerParameter_12(HandleRef pThis, double _arg);

	/// <summary>
	/// Set / Get the power parameter p. By default p=2. Values (which must be
	/// a positive, real value) != 2 may affect performance significantly.
	/// </summary>
	public virtual void SetPowerParameter(double _arg)
	{
		vtkShepardKernel_SetPowerParameter_12(GetCppThis(), _arg);
	}
}
