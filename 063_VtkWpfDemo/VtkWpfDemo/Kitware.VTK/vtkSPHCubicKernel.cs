using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSPHCubicKernel
/// </summary>
/// <remarks>
///    a cubic SPH interpolation kernel
///
///
/// vtkSPHCubicKernel is an smooth particle hydrodynamics interpolation kernel as
/// described by D.J. Price. This is a cubic formulation.
///
/// @warning
/// For more information see D.J. Price, Smoothed particle hydrodynamics and
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
public class vtkSPHCubicKernel : vtkSPHKernel
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSPHCubicKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSPHCubicKernel()
	{
		MRClassNameKey = "class vtkSPHCubicKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSPHCubicKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSPHCubicKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHCubicKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkSPHCubicKernel New()
	{
		vtkSPHCubicKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHCubicKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSPHCubicKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkSPHCubicKernel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSPHCubicKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkSPHCubicKernel_ComputeDerivWeight_01(HandleRef pThis, double d);

	/// <summary>
	/// Compute weighting factor for derivative quantities given a normalized
	/// distance from a sample point.
	/// </summary>
	public override double ComputeDerivWeight(double d)
	{
		return vtkSPHCubicKernel_ComputeDerivWeight_01(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkSPHCubicKernel_ComputeFunctionWeight_02(HandleRef pThis, double d);

	/// <summary>
	/// Compute weighting factor given a normalized distance from a sample point.
	/// </summary>
	public override double ComputeFunctionWeight(double d)
	{
		return vtkSPHCubicKernel_ComputeFunctionWeight_02(GetCppThis(), d);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHCubicKernel_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSPHCubicKernel_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSPHCubicKernel_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSPHCubicKernel_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSPHCubicKernel_Initialize_05(HandleRef pThis, HandleRef loc, HandleRef ds, HandleRef pd);

	/// <summary>
	/// Produce the computational parameters for the kernel. Invoke this method
	/// after setting initial values like SpatialStep.
	/// </summary>
	public override void Initialize(vtkAbstractPointLocator loc, vtkDataSet ds, vtkPointData pd)
	{
		vtkSPHCubicKernel_Initialize_05(GetCppThis(), loc?.GetCppThis() ?? default(HandleRef), ds?.GetCppThis() ?? default(HandleRef), pd?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHCubicKernel_IsA_06(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSPHCubicKernel_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSPHCubicKernel_IsTypeOf_07(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSPHCubicKernel_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHCubicKernel_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkSPHCubicKernel NewInstance()
	{
		vtkSPHCubicKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHCubicKernel_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSPHCubicKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSPHCubicKernel_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkSPHCubicKernel SafeDownCast(vtkObjectBase o)
	{
		vtkSPHCubicKernel vtkSPHCubicKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSPHCubicKernel_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSPHCubicKernel2 = (vtkSPHCubicKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSPHCubicKernel2.Register(null);
			}
		}
		return vtkSPHCubicKernel2;
	}
}
