using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPointLoad
/// </summary>
/// <remarks>
///    compute stress tensors given point load on semi-infinite domain
///
/// vtkPointLoad is a source object that computes stress tensors on a volume.
/// The tensors are computed from the application of a point load on a
/// semi-infinite domain. (The analytical results are adapted from Saada - see
/// text.) It also is possible to compute effective stress scalars if desired.
/// This object serves as a specialized data generator for some of the examples
/// in the text.
///
/// </remarks>
/// <seealso>
///
/// vtkTensorGlyph vtkHyperStreamline vtkGlyphPackingFilter
/// </seealso>
public class vtkPointLoad : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPointLoad";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPointLoad()
	{
		MRClassNameKey = "class vtkPointLoad";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPointLoad"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPointLoad(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLoad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct with ModelBounds=(-1,1,-1,1,-1,1), SampleDimensions=(50,50,50),
	/// and LoadValue = 1.
	/// </summary>
	public new static vtkPointLoad New()
	{
		vtkPointLoad result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointLoad_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct with ModelBounds=(-1,1,-1,1,-1,1), SampleDimensions=(50,50,50),
	/// and LoadValue = 1.
	/// </summary>
	public vtkPointLoad()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPointLoad_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_ComputeEffectiveStressOff_01(HandleRef pThis);

	/// <summary>
	/// Turn on/off computation of effective stress scalar. These methods do
	/// nothing. The effective stress is always computed.
	/// </summary>
	public void ComputeEffectiveStressOff()
	{
		vtkPointLoad_ComputeEffectiveStressOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_ComputeEffectiveStressOn_02(HandleRef pThis);

	/// <summary>
	/// Turn on/off computation of effective stress scalar. These methods do
	/// nothing. The effective stress is always computed.
	/// </summary>
	public void ComputeEffectiveStressOn()
	{
		vtkPointLoad_ComputeEffectiveStressOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLoad_GetComputeEffectiveStress_03(HandleRef pThis);

	/// <summary>
	/// Turn on/off computation of effective stress scalar. These methods do
	/// nothing. The effective stress is always computed.
	/// </summary>
	public int GetComputeEffectiveStress()
	{
		return vtkPointLoad_GetComputeEffectiveStress_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointLoad_GetLoadValue_04(HandleRef pThis);

	/// <summary>
	/// Set/Get value of applied load.
	/// </summary>
	public virtual double GetLoadValue()
	{
		return vtkPointLoad_GetLoadValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLoad_GetModelBounds_05(HandleRef pThis);

	/// <summary>
	/// Specify the region in space over which the tensors are computed. The point
	/// load is assumed to be applied at top center of the volume.
	/// </summary>
	public virtual double[] GetModelBounds()
	{
		IntPtr intPtr = vtkPointLoad_GetModelBounds_05(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_GetModelBounds_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the region in space over which the tensors are computed. The point
	/// load is assumed to be applied at top center of the volume.
	/// </summary>
	public virtual void GetModelBounds(IntPtr data)
	{
		vtkPointLoad_GetModelBounds_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLoad_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPointLoad_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPointLoad_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPointLoad_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPointLoad_GetPoissonsRatio_09(HandleRef pThis);

	/// <summary>
	/// Set/Get Poisson's ratio.
	/// </summary>
	public virtual double GetPoissonsRatio()
	{
		return vtkPointLoad_GetPoissonsRatio_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLoad_GetSampleDimensions_10(HandleRef pThis);

	/// <summary>
	/// Specify the dimensions of the volume. A stress tensor will be computed for
	/// each point in the volume.
	/// </summary>
	public virtual int[] GetSampleDimensions()
	{
		IntPtr intPtr = vtkPointLoad_GetSampleDimensions_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_GetSampleDimensions_11(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the dimensions of the volume. A stress tensor will be computed for
	/// each point in the volume.
	/// </summary>
	public virtual void GetSampleDimensions(IntPtr data)
	{
		vtkPointLoad_GetSampleDimensions_11(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLoad_IsA_12(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPointLoad_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPointLoad_IsTypeOf_13(string type);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPointLoad_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLoad_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public new vtkPointLoad NewInstance()
	{
		vtkPointLoad result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointLoad_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPointLoad_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for obtaining type information and printing.
	/// </summary>
	public new static vtkPointLoad SafeDownCast(vtkObjectBase o)
	{
		vtkPointLoad vtkPointLoad2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPointLoad_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPointLoad2 = (vtkPointLoad)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPointLoad2.Register(null);
			}
		}
		return vtkPointLoad2;
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_SetComputeEffectiveStress_17(HandleRef pThis, int arg0);

	/// <summary>
	/// Turn on/off computation of effective stress scalar. These methods do
	/// nothing. The effective stress is always computed.
	/// </summary>
	public void SetComputeEffectiveStress(int arg0)
	{
		vtkPointLoad_SetComputeEffectiveStress_17(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_SetLoadValue_18(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get value of applied load.
	/// </summary>
	public virtual void SetLoadValue(double _arg)
	{
		vtkPointLoad_SetLoadValue_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_SetModelBounds_19(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6);

	/// <summary>
	/// Specify the region in space over which the tensors are computed. The point
	/// load is assumed to be applied at top center of the volume.
	/// </summary>
	public virtual void SetModelBounds(double _arg1, double _arg2, double _arg3, double _arg4, double _arg5, double _arg6)
	{
		vtkPointLoad_SetModelBounds_19(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_SetModelBounds_20(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the region in space over which the tensors are computed. The point
	/// load is assumed to be applied at top center of the volume.
	/// </summary>
	public virtual void SetModelBounds(IntPtr _arg)
	{
		vtkPointLoad_SetModelBounds_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_SetPoissonsRatio_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get Poisson's ratio.
	/// </summary>
	public virtual void SetPoissonsRatio(double _arg)
	{
		vtkPointLoad_SetPoissonsRatio_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_SetSampleDimensions_22(HandleRef pThis, IntPtr dim);

	/// <summary>
	/// Specify the dimensions of the volume. A stress tensor will be computed for
	/// each point in the volume.
	/// </summary>
	public void SetSampleDimensions(IntPtr dim)
	{
		vtkPointLoad_SetSampleDimensions_22(GetCppThis(), dim);
	}

	[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPointLoad_SetSampleDimensions_23(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Specify the dimensions of the volume. A stress tensor will be computed for
	/// each point in the volume.
	/// </summary>
	public void SetSampleDimensions(int i, int j, int k)
	{
		vtkPointLoad_SetSampleDimensions_23(GetCppThis(), i, j, k);
	}
}
