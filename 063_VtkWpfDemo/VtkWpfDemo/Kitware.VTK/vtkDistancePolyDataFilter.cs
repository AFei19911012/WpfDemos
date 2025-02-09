using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDistancePolyDataFilter
///
///
/// Computes the signed distance from one vtkPolyData to another. The
/// signed distance to the second input is computed at every point in
/// the first input using vtkImplicitPolyDataDistance. Optionally, the signed
/// distance to the first input at every point in the second input can
/// be computed. This may be enabled by calling
/// ComputeSecondDistanceOn().
///
/// If the signed distance is not desired, the unsigned distance can be
/// computed by calling SignedDistanceOff(). The signed distance field
/// may be negated by calling NegateDistanceOn();
///
/// This code was contributed in the VTK Journal paper:
/// "Boolean Operations on Surfaces in VTK Without External Libraries"
/// by Cory Quammen, Chris Weigle C., Russ Taylor
/// http://hdl.handle.net/10380/3262
/// http://www.midasjournal.org/browse/publication/797
/// </summary>
public class vtkDistancePolyDataFilter : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDistancePolyDataFilter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDistancePolyDataFilter()
	{
		MRClassNameKey = "class vtkDistancePolyDataFilter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDistancePolyDataFilter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDistancePolyDataFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistancePolyDataFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDistancePolyDataFilter New()
	{
		vtkDistancePolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistancePolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistancePolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDistancePolyDataFilter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDistancePolyDataFilter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_ComputeCellCenterDistanceOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of cell-center distance to the
	/// second poly data. Defaults to on for backwards compatibility.
	///
	/// If the first poly data consists of just vertex cells,
	/// computing point and cell-center distances is redundant.
	/// </summary>
	public virtual void ComputeCellCenterDistanceOff()
	{
		vtkDistancePolyDataFilter_ComputeCellCenterDistanceOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_ComputeCellCenterDistanceOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of cell-center distance to the
	/// second poly data. Defaults to on for backwards compatibility.
	///
	/// If the first poly data consists of just vertex cells,
	/// computing point and cell-center distances is redundant.
	/// </summary>
	public virtual void ComputeCellCenterDistanceOn()
	{
		vtkDistancePolyDataFilter_ComputeCellCenterDistanceOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_ComputeSecondDistanceOff_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of a second output poly data with the
	/// distance from the first poly data at each point. Defaults to on.
	/// </summary>
	public virtual void ComputeSecondDistanceOff()
	{
		vtkDistancePolyDataFilter_ComputeSecondDistanceOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_ComputeSecondDistanceOn_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of a second output poly data with the
	/// distance from the first poly data at each point. Defaults to on.
	/// </summary>
	public virtual void ComputeSecondDistanceOn()
	{
		vtkDistancePolyDataFilter_ComputeSecondDistanceOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistancePolyDataFilter_GetComputeCellCenterDistance_05(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of cell-center distance to the
	/// second poly data. Defaults to on for backwards compatibility.
	///
	/// If the first poly data consists of just vertex cells,
	/// computing point and cell-center distances is redundant.
	/// </summary>
	public virtual int GetComputeCellCenterDistance()
	{
		return vtkDistancePolyDataFilter_GetComputeCellCenterDistance_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistancePolyDataFilter_GetComputeSecondDistance_06(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of a second output poly data with the
	/// distance from the first poly data at each point. Defaults to on.
	/// </summary>
	public virtual int GetComputeSecondDistance()
	{
		return vtkDistancePolyDataFilter_GetComputeSecondDistance_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistancePolyDataFilter_GetNegateDistance_07(HandleRef pThis);

	/// <summary>
	/// Enable/disable negation of the distance values. Defaults to
	/// off. Has no effect if SignedDistance is off.
	/// </summary>
	public virtual int GetNegateDistance()
	{
		return vtkDistancePolyDataFilter_GetNegateDistance_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistancePolyDataFilter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDistancePolyDataFilter_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDistancePolyDataFilter_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDistancePolyDataFilter_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistancePolyDataFilter_GetSecondDistanceOutput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the second output, which is a copy of the second input with an
	/// additional distance scalar field.
	/// Note this will return a valid data object only after this-&gt;Update() is
	/// called.
	/// </summary>
	public vtkPolyData GetSecondDistanceOutput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistancePolyDataFilter_GetSecondDistanceOutput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistancePolyDataFilter_GetSignedDistance_11(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of the signed distance between
	/// the first poly data and the second poly data. Defaults to on.
	/// </summary>
	public virtual int GetSignedDistance()
	{
		return vtkDistancePolyDataFilter_GetSignedDistance_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistancePolyDataFilter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDistancePolyDataFilter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDistancePolyDataFilter_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDistancePolyDataFilter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_NegateDistanceOff_14(HandleRef pThis);

	/// <summary>
	/// Enable/disable negation of the distance values. Defaults to
	/// off. Has no effect if SignedDistance is off.
	/// </summary>
	public virtual void NegateDistanceOff()
	{
		vtkDistancePolyDataFilter_NegateDistanceOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_NegateDistanceOn_15(HandleRef pThis);

	/// <summary>
	/// Enable/disable negation of the distance values. Defaults to
	/// off. Has no effect if SignedDistance is off.
	/// </summary>
	public virtual void NegateDistanceOn()
	{
		vtkDistancePolyDataFilter_NegateDistanceOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistancePolyDataFilter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDistancePolyDataFilter NewInstance()
	{
		vtkDistancePolyDataFilter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistancePolyDataFilter_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDistancePolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDistancePolyDataFilter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDistancePolyDataFilter SafeDownCast(vtkObjectBase o)
	{
		vtkDistancePolyDataFilter vtkDistancePolyDataFilter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDistancePolyDataFilter_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDistancePolyDataFilter2 = (vtkDistancePolyDataFilter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDistancePolyDataFilter2.Register(null);
			}
		}
		return vtkDistancePolyDataFilter2;
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_SetComputeCellCenterDistance_19(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable computation of cell-center distance to the
	/// second poly data. Defaults to on for backwards compatibility.
	///
	/// If the first poly data consists of just vertex cells,
	/// computing point and cell-center distances is redundant.
	/// </summary>
	public virtual void SetComputeCellCenterDistance(int _arg)
	{
		vtkDistancePolyDataFilter_SetComputeCellCenterDistance_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_SetComputeSecondDistance_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable computation of a second output poly data with the
	/// distance from the first poly data at each point. Defaults to on.
	/// </summary>
	public virtual void SetComputeSecondDistance(int _arg)
	{
		vtkDistancePolyDataFilter_SetComputeSecondDistance_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_SetNegateDistance_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable negation of the distance values. Defaults to
	/// off. Has no effect if SignedDistance is off.
	/// </summary>
	public virtual void SetNegateDistance(int _arg)
	{
		vtkDistancePolyDataFilter_SetNegateDistance_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_SetSignedDistance_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable computation of the signed distance between
	/// the first poly data and the second poly data. Defaults to on.
	/// </summary>
	public virtual void SetSignedDistance(int _arg)
	{
		vtkDistancePolyDataFilter_SetSignedDistance_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_SignedDistanceOff_23(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of the signed distance between
	/// the first poly data and the second poly data. Defaults to on.
	/// </summary>
	public virtual void SignedDistanceOff()
	{
		vtkDistancePolyDataFilter_SignedDistanceOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDistancePolyDataFilter_SignedDistanceOn_24(HandleRef pThis);

	/// <summary>
	/// Enable/disable computation of the signed distance between
	/// the first poly data and the second poly data. Defaults to on.
	/// </summary>
	public virtual void SignedDistanceOn()
	{
		vtkDistancePolyDataFilter_SignedDistanceOn_24(GetCppThis());
	}
}
