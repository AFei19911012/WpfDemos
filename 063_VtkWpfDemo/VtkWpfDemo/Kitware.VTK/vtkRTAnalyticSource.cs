using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRTAnalyticSource
/// </summary>
/// <remarks>
///    Create an image for regression testing
///
/// vtkRTAnalyticSource just produces images with pixel values determined
/// by a Maximum*Gaussian*XMag*sin(XFreq*x)*sin(YFreq*y)*cos(ZFreq*z)
/// Values are float scalars on point data with name "RTData".
/// </remarks>
public class vtkRTAnalyticSource : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRTAnalyticSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRTAnalyticSource()
	{
		MRClassNameKey = "class vtkRTAnalyticSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRTAnalyticSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRTAnalyticSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRTAnalyticSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRTAnalyticSource New()
	{
		vtkRTAnalyticSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRTAnalyticSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRTAnalyticSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRTAnalyticSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRTAnalyticSource_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkRTAnalyticSource_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkRTAnalyticSource_GetCenter_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkRTAnalyticSource_GetCenter_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRTAnalyticSource_GetMaximum_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the Maximum value of the function. Initial value is 255.0.
	/// </summary>
	public virtual double GetMaximum()
	{
		return vtkRTAnalyticSource_GetMaximum_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRTAnalyticSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRTAnalyticSource_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRTAnalyticSource_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRTAnalyticSource_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRTAnalyticSource_GetStandardDeviation_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the standard deviation of the function. Initial value is 0.5.
	/// </summary>
	public virtual double GetStandardDeviation()
	{
		return vtkRTAnalyticSource_GetStandardDeviation_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRTAnalyticSource_GetSubsampleRate_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the sub-sample rate. Initial value is 1.
	/// </summary>
	public virtual int GetSubsampleRate()
	{
		return vtkRTAnalyticSource_GetSubsampleRate_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRTAnalyticSource_GetWholeExtent_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the extent of the whole output image. Initial value is
	/// {-10,10,-10,10,-10,10}
	/// </summary>
	public virtual int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkRTAnalyticSource_GetWholeExtent_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_GetWholeExtent_10(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set/Get the extent of the whole output image. Initial value is
	/// {-10,10,-10,10,-10,10}
	/// </summary>
	public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkRTAnalyticSource_GetWholeExtent_10(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_GetWholeExtent_11(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the extent of the whole output image. Initial value is
	/// {-10,10,-10,10,-10,10}
	/// </summary>
	public virtual void GetWholeExtent(IntPtr _arg)
	{
		vtkRTAnalyticSource_GetWholeExtent_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRTAnalyticSource_GetXFreq_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the natural frequency in x. Initial value is 60.
	/// </summary>
	public virtual double GetXFreq()
	{
		return vtkRTAnalyticSource_GetXFreq_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRTAnalyticSource_GetXMag_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the magnitude in x. Initial value is 10.
	/// </summary>
	public virtual double GetXMag()
	{
		return vtkRTAnalyticSource_GetXMag_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRTAnalyticSource_GetYFreq_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the natural frequency in y. Initial value is 30.
	/// </summary>
	public virtual double GetYFreq()
	{
		return vtkRTAnalyticSource_GetYFreq_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRTAnalyticSource_GetYMag_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the magnitude in y. Initial value is 18.
	/// </summary>
	public virtual double GetYMag()
	{
		return vtkRTAnalyticSource_GetYMag_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRTAnalyticSource_GetZFreq_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the natural frequency in z. Initial value is 40.
	/// </summary>
	public virtual double GetZFreq()
	{
		return vtkRTAnalyticSource_GetZFreq_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRTAnalyticSource_GetZMag_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the magnitude in z. Initial value is 5.
	/// </summary>
	public virtual double GetZMag()
	{
		return vtkRTAnalyticSource_GetZMag_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRTAnalyticSource_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRTAnalyticSource_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRTAnalyticSource_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRTAnalyticSource_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRTAnalyticSource_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRTAnalyticSource NewInstance()
	{
		vtkRTAnalyticSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRTAnalyticSource_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRTAnalyticSource_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRTAnalyticSource SafeDownCast(vtkObjectBase o)
	{
		vtkRTAnalyticSource vtkRTAnalyticSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRTAnalyticSource_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRTAnalyticSource2 = (vtkRTAnalyticSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRTAnalyticSource2.Register(null);
			}
		}
		return vtkRTAnalyticSource2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetCenter_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkRTAnalyticSource_SetCenter_23(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetCenter_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the center of function. Initial value is {0.0,0.0,0.0}
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkRTAnalyticSource_SetCenter_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetMaximum_25(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Maximum value of the function. Initial value is 255.0.
	/// </summary>
	public virtual void SetMaximum(double _arg)
	{
		vtkRTAnalyticSource_SetMaximum_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetStandardDeviation_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the standard deviation of the function. Initial value is 0.5.
	/// </summary>
	public virtual void SetStandardDeviation(double _arg)
	{
		vtkRTAnalyticSource_SetStandardDeviation_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetSubsampleRate_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the sub-sample rate. Initial value is 1.
	/// </summary>
	public virtual void SetSubsampleRate(int _arg)
	{
		vtkRTAnalyticSource_SetSubsampleRate_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetWholeExtent_28(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

	/// <summary>
	/// Set/Get the extent of the whole output image. Initial value is
	/// {-10,10,-10,10,-10,10}
	/// </summary>
	public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
	{
		vtkRTAnalyticSource_SetWholeExtent_28(GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetXFreq_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the natural frequency in x. Initial value is 60.
	/// </summary>
	public virtual void SetXFreq(double _arg)
	{
		vtkRTAnalyticSource_SetXFreq_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetXMag_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the magnitude in x. Initial value is 10.
	/// </summary>
	public virtual void SetXMag(double _arg)
	{
		vtkRTAnalyticSource_SetXMag_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetYFreq_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the natural frequency in y. Initial value is 30.
	/// </summary>
	public virtual void SetYFreq(double _arg)
	{
		vtkRTAnalyticSource_SetYFreq_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetYMag_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the magnitude in y. Initial value is 18.
	/// </summary>
	public virtual void SetYMag(double _arg)
	{
		vtkRTAnalyticSource_SetYMag_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetZFreq_33(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the natural frequency in z. Initial value is 40.
	/// </summary>
	public virtual void SetZFreq(double _arg)
	{
		vtkRTAnalyticSource_SetZFreq_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRTAnalyticSource_SetZMag_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the magnitude in z. Initial value is 5.
	/// </summary>
	public virtual void SetZMag(double _arg)
	{
		vtkRTAnalyticSource_SetZMag_34(GetCppThis(), _arg);
	}
}
