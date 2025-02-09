using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMandelbrotSource
/// </summary>
/// <remarks>
///    Mandelbrot image.
///
/// vtkImageMandelbrotSource creates an unsigned char image of the Mandelbrot
/// set.  The values in the image are the number of iterations it takes for
/// the magnitude of the value to get over 2.  The equation repeated is
/// z = z^2 + C (z and C are complex).  Initial value of z is zero, and the
/// real value of C is mapped onto the x axis, and the imaginary value of C
/// is mapped onto the Y Axis.  I was thinking of extending this source
/// to generate Julia Sets (initial value of Z varies).  This would be 4
/// possible parameters to vary, but there are no more 4d images :(
/// The third dimension (z axis) is the imaginary value of the initial value.
/// </remarks>
public class vtkImageMandelbrotSource : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMandelbrotSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMandelbrotSource()
	{
		MRClassNameKey = "class vtkImageMandelbrotSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMandelbrotSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMandelbrotSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMandelbrotSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMandelbrotSource New()
	{
		vtkImageMandelbrotSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMandelbrotSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMandelbrotSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMandelbrotSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_ConstantSizeOff_01(HandleRef pThis);

	/// <summary>
	/// This flag determines whether the Size or spacing of
	/// a data set remain constant (when extent is changed).
	/// By default, size remains constant.
	/// </summary>
	public virtual void ConstantSizeOff()
	{
		vtkImageMandelbrotSource_ConstantSizeOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_ConstantSizeOn_02(HandleRef pThis);

	/// <summary>
	/// This flag determines whether the Size or spacing of
	/// a data set remain constant (when extent is changed).
	/// By default, size remains constant.
	/// </summary>
	public virtual void ConstantSizeOn()
	{
		vtkImageMandelbrotSource_ConstantSizeOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_CopyOriginAndSample_03(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Convenience for Viewer.  Copy the OriginCX and the SpacingCX.
	/// What about other parameters ???
	/// </summary>
	public void CopyOriginAndSample(vtkImageMandelbrotSource source)
	{
		vtkImageMandelbrotSource_CopyOriginAndSample_03(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMandelbrotSource_GetConstantSize_04(HandleRef pThis);

	/// <summary>
	/// This flag determines whether the Size or spacing of
	/// a data set remain constant (when extent is changed).
	/// By default, size remains constant.
	/// </summary>
	public virtual int GetConstantSize()
	{
		return vtkImageMandelbrotSource_GetConstantSize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterations_05(HandleRef pThis);

	/// <summary>
	/// The maximum number of cycles run to see if the value goes over 2
	/// </summary>
	public virtual ushort GetMaximumNumberOfIterations()
	{
		return vtkImageMandelbrotSource_GetMaximumNumberOfIterations_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMaxValue_06(HandleRef pThis);

	/// <summary>
	/// The maximum number of cycles run to see if the value goes over 2
	/// </summary>
	public virtual ushort GetMaximumNumberOfIterationsMaxValue()
	{
		return vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMinValue_07(HandleRef pThis);

	/// <summary>
	/// The maximum number of cycles run to see if the value goes over 2
	/// </summary>
	public virtual ushort GetMaximumNumberOfIterationsMinValue()
	{
		return vtkImageMandelbrotSource_GetMaximumNumberOfIterationsMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMandelbrotSource_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMandelbrotSource_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMandelbrotSource_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMandelbrotSource_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMandelbrotSource_GetOriginCX_10(HandleRef pThis);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual double[] GetOriginCX()
	{
		IntPtr intPtr = vtkImageMandelbrotSource_GetOriginCX_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetOriginCX_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual void GetOriginCX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkImageMandelbrotSource_GetOriginCX_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetOriginCX_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual void GetOriginCX(IntPtr _arg)
	{
		vtkImageMandelbrotSource_GetOriginCX_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMandelbrotSource_GetProjectionAxes_13(HandleRef pThis);

	/// <summary>
	/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
	/// to the axes of the 3D Volume.
	/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
	/// </summary>
	public virtual int[] GetProjectionAxes()
	{
		IntPtr intPtr = vtkImageMandelbrotSource_GetProjectionAxes_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetProjectionAxes_14(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
	/// to the axes of the 3D Volume.
	/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
	/// </summary>
	public virtual void GetProjectionAxes(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageMandelbrotSource_GetProjectionAxes_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetProjectionAxes_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
	/// to the axes of the 3D Volume.
	/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
	/// </summary>
	public virtual void GetProjectionAxes(IntPtr _arg)
	{
		vtkImageMandelbrotSource_GetProjectionAxes_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMandelbrotSource_GetSampleCX_16(HandleRef pThis);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual double[] GetSampleCX()
	{
		IntPtr intPtr = vtkImageMandelbrotSource_GetSampleCX_16(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetSampleCX_17(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual void GetSampleCX(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
	{
		vtkImageMandelbrotSource_GetSampleCX_17(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetSampleCX_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual void GetSampleCX(IntPtr _arg)
	{
		vtkImageMandelbrotSource_GetSampleCX_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMandelbrotSource_GetSizeCX_19(HandleRef pThis);

	/// <summary>
	/// Just a different way of setting the sample.
	/// This sets the size of the 4D volume.
	/// SampleCX is computed from size and extent.
	/// Size is ignored when a dimension i 0 (collapsed).
	/// </summary>
	public double[] GetSizeCX()
	{
		IntPtr intPtr = vtkImageMandelbrotSource_GetSizeCX_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetSizeCX_20(HandleRef pThis, IntPtr s);

	/// <summary>
	/// Just a different way of setting the sample.
	/// This sets the size of the 4D volume.
	/// SampleCX is computed from size and extent.
	/// Size is ignored when a dimension i 0 (collapsed).
	/// </summary>
	public void GetSizeCX(IntPtr s)
	{
		vtkImageMandelbrotSource_GetSizeCX_20(GetCppThis(), s);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMandelbrotSource_GetSubsampleRate_21(HandleRef pThis);

	/// <summary>
	/// Set/Get a subsample rate.
	/// </summary>
	public virtual int GetSubsampleRate()
	{
		return vtkImageMandelbrotSource_GetSubsampleRate_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMandelbrotSource_GetSubsampleRateMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get a subsample rate.
	/// </summary>
	public virtual int GetSubsampleRateMaxValue()
	{
		return vtkImageMandelbrotSource_GetSubsampleRateMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMandelbrotSource_GetSubsampleRateMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set/Get a subsample rate.
	/// </summary>
	public virtual int GetSubsampleRateMinValue()
	{
		return vtkImageMandelbrotSource_GetSubsampleRateMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMandelbrotSource_GetWholeExtent_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the extent of the whole output Volume.
	/// </summary>
	public virtual int[] GetWholeExtent()
	{
		IntPtr intPtr = vtkImageMandelbrotSource_GetWholeExtent_24(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetWholeExtent_25(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set/Get the extent of the whole output Volume.
	/// </summary>
	public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageMandelbrotSource_GetWholeExtent_25(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_GetWholeExtent_26(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the extent of the whole output Volume.
	/// </summary>
	public virtual void GetWholeExtent(IntPtr _arg)
	{
		vtkImageMandelbrotSource_GetWholeExtent_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMandelbrotSource_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMandelbrotSource_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMandelbrotSource_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMandelbrotSource_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMandelbrotSource_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMandelbrotSource NewInstance()
	{
		vtkImageMandelbrotSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMandelbrotSource_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_Pan_31(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Convenience for Viewer.  Pan 3D volume relative to spacing.
	/// Zoom constant factor.
	/// </summary>
	public void Pan(double x, double y, double z)
	{
		vtkImageMandelbrotSource_Pan_31(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMandelbrotSource_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMandelbrotSource SafeDownCast(vtkObjectBase o)
	{
		vtkImageMandelbrotSource vtkImageMandelbrotSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMandelbrotSource_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMandelbrotSource2 = (vtkImageMandelbrotSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMandelbrotSource2.Register(null);
			}
		}
		return vtkImageMandelbrotSource2;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetConstantSize_33(HandleRef pThis, int _arg);

	/// <summary>
	/// This flag determines whether the Size or spacing of
	/// a data set remain constant (when extent is changed).
	/// By default, size remains constant.
	/// </summary>
	public virtual void SetConstantSize(int _arg)
	{
		vtkImageMandelbrotSource_SetConstantSize_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetMaximumNumberOfIterations_34(HandleRef pThis, ushort _arg);

	/// <summary>
	/// The maximum number of cycles run to see if the value goes over 2
	/// </summary>
	public virtual void SetMaximumNumberOfIterations(ushort _arg)
	{
		vtkImageMandelbrotSource_SetMaximumNumberOfIterations_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetOriginCX_35(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual void SetOriginCX(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkImageMandelbrotSource_SetOriginCX_35(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetOriginCX_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual void SetOriginCX(IntPtr _arg)
	{
		vtkImageMandelbrotSource_SetOriginCX_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetProjectionAxes_37(HandleRef pThis, int x, int y, int z);

	/// <summary>
	/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
	/// to the axes of the 3D Volume.
	/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
	/// </summary>
	public void SetProjectionAxes(int x, int y, int z)
	{
		vtkImageMandelbrotSource_SetProjectionAxes_37(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetProjectionAxes_38(HandleRef pThis, IntPtr a);

	/// <summary>
	/// Set the projection from the 4D space (4 parameters / 2 imaginary numbers)
	/// to the axes of the 3D Volume.
	/// 0=C_Real, 1=C_Imaginary, 2=X_Real, 4=X_Imaginary
	/// </summary>
	public void SetProjectionAxes(IntPtr a)
	{
		vtkImageMandelbrotSource_SetProjectionAxes_38(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetSampleCX_39(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual void SetSampleCX(double _arg1, double _arg2, double _arg3, double _arg4)
	{
		vtkImageMandelbrotSource_SetSampleCX_39(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetSampleCX_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Imaginary and real value for C (constant in equation)
	/// and X (initial value).
	/// </summary>
	public virtual void SetSampleCX(IntPtr _arg)
	{
		vtkImageMandelbrotSource_SetSampleCX_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetSizeCX_41(HandleRef pThis, double cReal, double cImag, double xReal, double xImag);

	/// <summary>
	/// Just a different way of setting the sample.
	/// This sets the size of the 4D volume.
	/// SampleCX is computed from size and extent.
	/// Size is ignored when a dimension i 0 (collapsed).
	/// </summary>
	public void SetSizeCX(double cReal, double cImag, double xReal, double xImag)
	{
		vtkImageMandelbrotSource_SetSizeCX_41(GetCppThis(), cReal, cImag, xReal, xImag);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetSubsampleRate_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get a subsample rate.
	/// </summary>
	public virtual void SetSubsampleRate(int _arg)
	{
		vtkImageMandelbrotSource_SetSubsampleRate_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetWholeExtent_43(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set/Get the extent of the whole output Volume.
	/// </summary>
	public void SetWholeExtent(IntPtr extent)
	{
		vtkImageMandelbrotSource_SetWholeExtent_43(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_SetWholeExtent_44(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

	/// <summary>
	/// Set/Get the extent of the whole output Volume.
	/// </summary>
	public void SetWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
	{
		vtkImageMandelbrotSource_SetWholeExtent_44(GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMandelbrotSource_Zoom_45(HandleRef pThis, double factor);

	/// <summary>
	/// Convenience for Viewer.  Pan 3D volume relative to spacing.
	/// Zoom constant factor.
	/// </summary>
	public void Zoom(double factor)
	{
		vtkImageMandelbrotSource_Zoom_45(GetCppThis(), factor);
	}
}
