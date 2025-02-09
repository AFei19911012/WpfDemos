using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLinearKernel
/// </summary>
/// <remarks>
///    a linear interpolation kernel
///
///
/// vtkLinearKernel is an interpolation kernel that averages the contributions
/// of all points in the basis.
///
/// </remarks>
/// <seealso>
///
/// vtkPointInterpolator vtkInterpolationKernel vtkGeneralizedKernel
/// vtkGaussianKernel vtkLinearKernel vtkShepardKernel
/// </seealso>
public class vtkLinearKernel : vtkGeneralizedKernel
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLinearKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLinearKernel()
	{
		MRClassNameKey = "class vtkLinearKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLinearKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkLinearKernel New()
	{
		vtkLinearKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkLinearKernel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLinearKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkLinearKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

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
		return vtkLinearKernel_ComputeWeights_01(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), prob?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearKernel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLinearKernel_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLinearKernel_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLinearKernel_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearKernel_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLinearKernel_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLinearKernel_IsTypeOf_05(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLinearKernel_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearKernel_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkLinearKernel NewInstance()
	{
		vtkLinearKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearKernel_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLinearKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLinearKernel_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkLinearKernel SafeDownCast(vtkObjectBase o)
	{
		vtkLinearKernel vtkLinearKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLinearKernel_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLinearKernel2 = (vtkLinearKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLinearKernel2.Register(null);
			}
		}
		return vtkLinearKernel2;
	}
}
