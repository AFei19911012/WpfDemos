using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSPHQuinticKernel
/// </summary>
/// <remarks>
///    a quintic SPH interpolation kernel
///
///
/// vtkSPHQuinticKernel is an smooth particle hydrodynamics interpolation kernel as
/// described by D.J. Price. This is a quintic formulation.
///
/// @warning
/// FOr more information see D.J. Price, Smoothed particle hydrodynamics and
/// magnetohydrodynamics, J. Comput. Phys. 231:759-794, 2012. Especially
/// equation 49.
///
/// @par Acknowledgments:
/// The following work has been generously supported by Altair Engineering
/// and FluiDyna GmbH. Please contact Steve Cosgrove or Milos Stanic for
/// more information.
///
/// </remarks>
/// <seealso>
///
/// vtkSPHKernel vtkSPHInterpolator
/// </seealso>
public class vtkSPHQuinticKernel : vtkSPHKernel
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSPHQuinticKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSPHQuinticKernel()
	{
		MRClassNameKey = "class vtkSPHQuinticKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHQuinticKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSPHQuinticKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHQuinticKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkSPHQuinticKernel New()
	{
		vtkSPHQuinticKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHQuinticKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSPHQuinticKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkSPHQuinticKernel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSPHQuinticKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkSPHQuinticKernel_ComputeDerivWeight_01(HandleRef pThis, double d);

	/// <summary>
	/// Compute weighting factor for derivative quantities given a normalized
	/// distance from a sample point.
	/// </summary>
	public override double ComputeDerivWeight(double d)
	{
		return vtkSPHQuinticKernel_ComputeDerivWeight_01(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHQuinticKernel_ComputeFunctionWeight_02(HandleRef pThis, double d);

	/// <summary>
	/// Compute weighting factor given a normalized distance from a sample point.
	/// </summary>
	public override double ComputeFunctionWeight(double d)
	{
		return vtkSPHQuinticKernel_ComputeFunctionWeight_02(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHQuinticKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSPHQuinticKernel_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHQuinticKernel_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSPHQuinticKernel_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHQuinticKernel_Initialize_05(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

	/// <summary>
	/// Produce the computational parameters for the kernel. Invoke this method
	/// after setting initial values like SpatialStep.
	/// </summary>
	public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
	{
		vtkSPHQuinticKernel_Initialize_05(GetCppThis(), loc?.GetCppThis() ?? default(HandleRef), ds?.GetCppThis() ?? default(HandleRef), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHQuinticKernel_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSPHQuinticKernel_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHQuinticKernel_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSPHQuinticKernel_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHQuinticKernel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkSPHQuinticKernel NewInstance()
	{
		vtkSPHQuinticKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHQuinticKernel_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSPHQuinticKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHQuinticKernel_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkSPHQuinticKernel SafeDownCast(vtkObjectBase o)
	{
		vtkSPHQuinticKernel vtkSPHQuinticKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHQuinticKernel_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSPHQuinticKernel2 = (vtkSPHQuinticKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSPHQuinticKernel2.Register(null);
			}
		}
		return vtkSPHQuinticKernel2;
	}
}
