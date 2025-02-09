using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProbabilisticVoronoiKernel
/// </summary>
/// <remarks>
///    interpolate from the weighted closest point
///
///
/// vtkProbabilisticVoronoiKernel is an interpolation kernel that interpolates
/// from the closest weighted point from a neighborhood of points. The weights
/// refer to the probabilistic weighting that can be provided to the
/// ComputeWeights() method.
///
/// Note that the local neighborhood is taken from the kernel footprint
/// specified in the superclass vtkGeneralizedKernel.
///
/// @warning
/// If probability weightings are not defined, then the kernel provides the
/// same results as vtkVoronoiKernel, except a less efficiently.
///
/// </remarks>
/// <seealso>
///
/// vtkInterpolationKernel vtkGeneralizedKernel vtkVoronoiKernel
/// </seealso>
public class vtkProbabilisticVoronoiKernel : vtkGeneralizedKernel
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProbabilisticVoronoiKernel";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProbabilisticVoronoiKernel()
	{
		MRClassNameKey = "class vtkProbabilisticVoronoiKernel";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProbabilisticVoronoiKernel"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProbabilisticVoronoiKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbabilisticVoronoiKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkProbabilisticVoronoiKernel New()
	{
		vtkProbabilisticVoronoiKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbabilisticVoronoiKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProbabilisticVoronoiKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public vtkProbabilisticVoronoiKernel()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProbabilisticVoronoiKernel_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkProbabilisticVoronoiKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

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
		return vtkProbabilisticVoronoiKernel_ComputeWeights_01(GetCppThis(), x, pIds?.GetCppThis() ?? default(HandleRef), prob?.GetCppThis() ?? default(HandleRef), weights?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProbabilisticVoronoiKernel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProbabilisticVoronoiKernel_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProbabilisticVoronoiKernel_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProbabilisticVoronoiKernel_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbabilisticVoronoiKernel_IsA_04(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProbabilisticVoronoiKernel_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProbabilisticVoronoiKernel_IsTypeOf_05(string type);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProbabilisticVoronoiKernel_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbabilisticVoronoiKernel_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new vtkProbabilisticVoronoiKernel NewInstance()
	{
		vtkProbabilisticVoronoiKernel result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbabilisticVoronoiKernel_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProbabilisticVoronoiKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProbabilisticVoronoiKernel_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for instantiation, obtaining type information, and printing.
	/// </summary>
	public new static vtkProbabilisticVoronoiKernel SafeDownCast(vtkObjectBase o)
	{
		vtkProbabilisticVoronoiKernel vtkProbabilisticVoronoiKernel2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProbabilisticVoronoiKernel_SafeDownCast_08(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProbabilisticVoronoiKernel2 = (vtkProbabilisticVoronoiKernel)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProbabilisticVoronoiKernel2.Register(null);
			}
		}
		return vtkProbabilisticVoronoiKernel2;
	}
}
