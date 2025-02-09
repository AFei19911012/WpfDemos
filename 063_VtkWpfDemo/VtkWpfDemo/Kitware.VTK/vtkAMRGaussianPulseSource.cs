using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAMRGaussianPulseSource
///
///
///  A source that generates sample AMR data with gaussian pulse field. The user
///  can control the refinement ratio as well as the pulse attributes such as
///  the pulse origin, length and amplitude.
///
/// </summary>
/// <seealso>
///
///  vtkOverlappingAMR
/// </seealso>
public class vtkAMRGaussianPulseSource : vtkOverlappingAMRAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAMRGaussianPulseSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAMRGaussianPulseSource()
	{
		MRClassNameKey = "class vtkAMRGaussianPulseSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAMRGaussianPulseSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAMRGaussianPulseSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRGaussianPulseSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRGaussianPulseSource New()
	{
		vtkAMRGaussianPulseSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRGaussianPulseSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRGaussianPulseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAMRGaussianPulseSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAMRGaussianPulseSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRGaussianPulseSource_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAMRGaussianPulseSource_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAMRGaussianPulseSource_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAMRGaussianPulseSource_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkAMRGaussianPulseSource_GetPulseAmplitude_03(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get macro for the pulse amplitude
	/// </summary>
	public virtual double GetPulseAmplitude()
	{
		return vtkAMRGaussianPulseSource_GetPulseAmplitude_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRGaussianPulseSource_GetPulseOrigin_04(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get macro for the pulse origin
	/// </summary>
	public virtual double[] GetPulseOrigin()
	{
		IntPtr intPtr = vtkAMRGaussianPulseSource_GetPulseOrigin_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_GetPulseOrigin_05(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set &amp; Get macro for the pulse origin
	/// </summary>
	public virtual void GetPulseOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAMRGaussianPulseSource_GetPulseOrigin_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_GetPulseOrigin_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set &amp; Get macro for the pulse origin
	/// </summary>
	public virtual void GetPulseOrigin(IntPtr _arg)
	{
		vtkAMRGaussianPulseSource_GetPulseOrigin_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRGaussianPulseSource_GetPulseWidth_07(HandleRef pThis);

	/// <summary>
	/// Set &amp; Get macro for the pulse width
	/// </summary>
	public virtual double[] GetPulseWidth()
	{
		IntPtr intPtr = vtkAMRGaussianPulseSource_GetPulseWidth_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_GetPulseWidth_08(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set &amp; Get macro for the pulse width
	/// </summary>
	public virtual void GetPulseWidth(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkAMRGaussianPulseSource_GetPulseWidth_08(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_GetPulseWidth_09(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set &amp; Get macro for the pulse width
	/// </summary>
	public virtual void GetPulseWidth(IntPtr _arg)
	{
		vtkAMRGaussianPulseSource_GetPulseWidth_09(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRGaussianPulseSource_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAMRGaussianPulseSource_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAMRGaussianPulseSource_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAMRGaussianPulseSource_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRGaussianPulseSource_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAMRGaussianPulseSource NewInstance()
	{
		vtkAMRGaussianPulseSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRGaussianPulseSource_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAMRGaussianPulseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAMRGaussianPulseSource_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAMRGaussianPulseSource SafeDownCast(vtkObjectBase o)
	{
		vtkAMRGaussianPulseSource vtkAMRGaussianPulseSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAMRGaussianPulseSource_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAMRGaussianPulseSource2 = (vtkAMRGaussianPulseSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAMRGaussianPulseSource2.Register(null);
			}
		}
		return vtkAMRGaussianPulseSource2;
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetDimension_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Sets the dimension of the AMR dataset to generate
	/// </summary>
	public virtual void SetDimension(int _arg)
	{
		vtkAMRGaussianPulseSource_SetDimension_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetNumberOfLevels_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Sets the number of levels to generate
	/// </summary>
	public virtual void SetNumberOfLevels(int _arg)
	{
		vtkAMRGaussianPulseSource_SetNumberOfLevels_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetPulseAmplitude_17(HandleRef pThis, double _arg);

	/// <summary>
	/// Set &amp; Get macro for the pulse amplitude
	/// </summary>
	public virtual void SetPulseAmplitude(double _arg)
	{
		vtkAMRGaussianPulseSource_SetPulseAmplitude_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetPulseOrigin_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set &amp; Get macro for the pulse origin
	/// </summary>
	public virtual void SetPulseOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkAMRGaussianPulseSource_SetPulseOrigin_18(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetPulseOrigin_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set &amp; Get macro for the pulse origin
	/// </summary>
	public virtual void SetPulseOrigin(IntPtr _arg)
	{
		vtkAMRGaussianPulseSource_SetPulseOrigin_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetPulseWidth_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set &amp; Get macro for the pulse width
	/// </summary>
	public virtual void SetPulseWidth(double _arg1, double _arg2, double _arg3)
	{
		vtkAMRGaussianPulseSource_SetPulseWidth_20(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetPulseWidth_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set &amp; Get macro for the pulse width
	/// </summary>
	public virtual void SetPulseWidth(IntPtr _arg)
	{
		vtkAMRGaussianPulseSource_SetPulseWidth_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetRefinementRatio_22(HandleRef pThis, int r);

	/// <summary>
	/// Set the refinement ratio
	/// </summary>
	public void SetRefinementRatio(int r)
	{
		vtkAMRGaussianPulseSource_SetRefinementRatio_22(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetRootSpacing_23(HandleRef pThis, double h0);

	/// <summary>
	/// Set the root spacing
	/// </summary>
	public void SetRootSpacing(double h0)
	{
		vtkAMRGaussianPulseSource_SetRootSpacing_23(GetCppThis(), h0);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetXPulseOrigin_24(HandleRef pThis, double f);

	/// <summary>
	/// Set &amp; Get macro for the pulse origin
	/// </summary>
	public void SetXPulseOrigin(double f)
	{
		vtkAMRGaussianPulseSource_SetXPulseOrigin_24(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetXPulseWidth_25(HandleRef pThis, double f);

	/// <summary>
	/// Set &amp; Get macro for the pulse width
	/// </summary>
	public void SetXPulseWidth(double f)
	{
		vtkAMRGaussianPulseSource_SetXPulseWidth_25(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetYPulseOrigin_26(HandleRef pThis, double f);

	/// <summary>
	/// Set &amp; Get macro for the pulse origin
	/// </summary>
	public void SetYPulseOrigin(double f)
	{
		vtkAMRGaussianPulseSource_SetYPulseOrigin_26(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetYPulseWidth_27(HandleRef pThis, double f);

	/// <summary>
	/// Set &amp; Get macro for the pulse width
	/// </summary>
	public void SetYPulseWidth(double f)
	{
		vtkAMRGaussianPulseSource_SetYPulseWidth_27(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetZPulseOrigin_28(HandleRef pThis, double f);

	/// <summary>
	/// Set &amp; Get macro for the pulse origin
	/// </summary>
	public void SetZPulseOrigin(double f)
	{
		vtkAMRGaussianPulseSource_SetZPulseOrigin_28(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.FiltersAMR.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAMRGaussianPulseSource_SetZPulseWidth_29(HandleRef pThis, double f);

	/// <summary>
	/// Set &amp; Get macro for the pulse width
	/// </summary>
	public void SetZPulseWidth(double f)
	{
		vtkAMRGaussianPulseSource_SetZPulseWidth_29(GetCppThis(), f);
	}
}
