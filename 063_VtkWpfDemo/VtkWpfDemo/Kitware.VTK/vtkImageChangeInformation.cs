using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageChangeInformation
/// </summary>
/// <remarks>
///    modify spacing, origin and extent.
///
/// vtkImageChangeInformation  modify the spacing, origin, or extent of
/// the data without changing the data itself.  The data is not resampled
/// by this filter, only the information accompanying the data is modified.
/// </remarks>
public class vtkImageChangeInformation : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageChangeInformation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageChangeInformation()
	{
		MRClassNameKey = "class vtkImageChangeInformation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageChangeInformation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageChangeInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageChangeInformation New()
	{
		vtkImageChangeInformation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageChangeInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageChangeInformation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageChangeInformation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageChangeInformation_CenterImageOff_01(HandleRef pThis);

	/// <summary>
	/// Set the Origin of the output so that image coordinate (0,0,0)
	/// lies at the Center of the data set.  This will override
	/// SetOutputOrigin.  This is often a useful operation to apply
	/// before using vtkImageReslice to apply a transformation to an image.
	/// </summary>
	public virtual void CenterImageOff()
	{
		vtkImageChangeInformation_CenterImageOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_CenterImageOn_02(HandleRef pThis);

	/// <summary>
	/// Set the Origin of the output so that image coordinate (0,0,0)
	/// lies at the Center of the data set.  This will override
	/// SetOutputOrigin.  This is often a useful operation to apply
	/// before using vtkImageReslice to apply a transformation to an image.
	/// </summary>
	public virtual void CenterImageOn()
	{
		vtkImageChangeInformation_CenterImageOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageChangeInformation_GetCenterImage_03(HandleRef pThis);

	/// <summary>
	/// Set the Origin of the output so that image coordinate (0,0,0)
	/// lies at the Center of the data set.  This will override
	/// SetOutputOrigin.  This is often a useful operation to apply
	/// before using vtkImageReslice to apply a transformation to an image.
	/// </summary>
	public virtual int GetCenterImage()
	{
		return vtkImageChangeInformation_GetCenterImage_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_GetExtentTranslation_04(HandleRef pThis);

	/// <summary>
	/// Apply a translation to the extent.
	/// </summary>
	public virtual int[] GetExtentTranslation()
	{
		IntPtr intPtr = vtkImageChangeInformation_GetExtentTranslation_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetExtentTranslation_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Apply a translation to the extent.
	/// </summary>
	public virtual void GetExtentTranslation(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageChangeInformation_GetExtentTranslation_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetExtentTranslation_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Apply a translation to the extent.
	/// </summary>
	public virtual void GetExtentTranslation(IntPtr _arg)
	{
		vtkImageChangeInformation_GetExtentTranslation_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_GetInformationInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Copy the information from another data set.  By default,
	/// the information is copied from the input.
	/// </summary>
	public virtual vtkImageData GetInformationInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageChangeInformation_GetInformationInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageChangeInformation_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageChangeInformation_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageChangeInformation_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageChangeInformation_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_GetOriginScale_10(HandleRef pThis);

	/// <summary>
	/// Apply a scale to the origin.  The scale is applied
	/// before the translation.
	/// </summary>
	public virtual double[] GetOriginScale()
	{
		IntPtr intPtr = vtkImageChangeInformation_GetOriginScale_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOriginScale_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Apply a scale to the origin.  The scale is applied
	/// before the translation.
	/// </summary>
	public virtual void GetOriginScale(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageChangeInformation_GetOriginScale_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOriginScale_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Apply a scale to the origin.  The scale is applied
	/// before the translation.
	/// </summary>
	public virtual void GetOriginScale(IntPtr _arg)
	{
		vtkImageChangeInformation_GetOriginScale_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_GetOriginTranslation_13(HandleRef pThis);

	/// <summary>
	/// Apply a translation to the origin.
	/// </summary>
	public virtual double[] GetOriginTranslation()
	{
		IntPtr intPtr = vtkImageChangeInformation_GetOriginTranslation_13(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOriginTranslation_14(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Apply a translation to the origin.
	/// </summary>
	public virtual void GetOriginTranslation(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageChangeInformation_GetOriginTranslation_14(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOriginTranslation_15(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Apply a translation to the origin.
	/// </summary>
	public virtual void GetOriginTranslation(IntPtr _arg)
	{
		vtkImageChangeInformation_GetOriginTranslation_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_GetOutputExtentStart_16(HandleRef pThis);

	/// <summary>
	/// Specify new starting values for the extent explicitly.
	/// These values are used as WholeExtent[0], WholeExtent[2] and
	/// WholeExtent[4] of the output.  The default is to the
	/// use the extent start of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual int[] GetOutputExtentStart()
	{
		IntPtr intPtr = vtkImageChangeInformation_GetOutputExtentStart_16(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOutputExtentStart_17(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Specify new starting values for the extent explicitly.
	/// These values are used as WholeExtent[0], WholeExtent[2] and
	/// WholeExtent[4] of the output.  The default is to the
	/// use the extent start of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void GetOutputExtentStart(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageChangeInformation_GetOutputExtentStart_17(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOutputExtentStart_18(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify new starting values for the extent explicitly.
	/// These values are used as WholeExtent[0], WholeExtent[2] and
	/// WholeExtent[4] of the output.  The default is to the
	/// use the extent start of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void GetOutputExtentStart(IntPtr _arg)
	{
		vtkImageChangeInformation_GetOutputExtentStart_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_GetOutputOrigin_19(HandleRef pThis);

	/// <summary>
	/// Specify a new data origin explicitly.  The default is to
	/// use the origin of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual double[] GetOutputOrigin()
	{
		IntPtr intPtr = vtkImageChangeInformation_GetOutputOrigin_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOutputOrigin_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify a new data origin explicitly.  The default is to
	/// use the origin of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void GetOutputOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageChangeInformation_GetOutputOrigin_20(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOutputOrigin_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a new data origin explicitly.  The default is to
	/// use the origin of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void GetOutputOrigin(IntPtr _arg)
	{
		vtkImageChangeInformation_GetOutputOrigin_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_GetOutputSpacing_22(HandleRef pThis);

	/// <summary>
	/// Specify a new data spacing explicitly.  The default is to
	/// use the spacing of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual double[] GetOutputSpacing()
	{
		IntPtr intPtr = vtkImageChangeInformation_GetOutputSpacing_22(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOutputSpacing_23(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Specify a new data spacing explicitly.  The default is to
	/// use the spacing of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void GetOutputSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageChangeInformation_GetOutputSpacing_23(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetOutputSpacing_24(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a new data spacing explicitly.  The default is to
	/// use the spacing of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void GetOutputSpacing(IntPtr _arg)
	{
		vtkImageChangeInformation_GetOutputSpacing_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_GetSpacingScale_25(HandleRef pThis);

	/// <summary>
	/// Apply a scale factor to the spacing.
	/// </summary>
	public virtual double[] GetSpacingScale()
	{
		IntPtr intPtr = vtkImageChangeInformation_GetSpacingScale_25(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetSpacingScale_26(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Apply a scale factor to the spacing.
	/// </summary>
	public virtual void GetSpacingScale(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageChangeInformation_GetSpacingScale_26(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_GetSpacingScale_27(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Apply a scale factor to the spacing.
	/// </summary>
	public virtual void GetSpacingScale(IntPtr _arg)
	{
		vtkImageChangeInformation_GetSpacingScale_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageChangeInformation_IsA_28(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageChangeInformation_IsA_28(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageChangeInformation_IsTypeOf_29(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageChangeInformation_IsTypeOf_29(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_NewInstance_31(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageChangeInformation NewInstance()
	{
		vtkImageChangeInformation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageChangeInformation_NewInstance_31(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageChangeInformation_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageChangeInformation SafeDownCast(vtkObjectBase o)
	{
		vtkImageChangeInformation vtkImageChangeInformation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageChangeInformation_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageChangeInformation2 = (vtkImageChangeInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageChangeInformation2.Register(null);
			}
		}
		return vtkImageChangeInformation2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetCenterImage_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the Origin of the output so that image coordinate (0,0,0)
	/// lies at the Center of the data set.  This will override
	/// SetOutputOrigin.  This is often a useful operation to apply
	/// before using vtkImageReslice to apply a transformation to an image.
	/// </summary>
	public virtual void SetCenterImage(int _arg)
	{
		vtkImageChangeInformation_SetCenterImage_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetExtentTranslation_34(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Apply a translation to the extent.
	/// </summary>
	public virtual void SetExtentTranslation(int _arg1, int _arg2, int _arg3)
	{
		vtkImageChangeInformation_SetExtentTranslation_34(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetExtentTranslation_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Apply a translation to the extent.
	/// </summary>
	public virtual void SetExtentTranslation(IntPtr _arg)
	{
		vtkImageChangeInformation_SetExtentTranslation_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetInformationInputData_36(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Copy the information from another data set.  By default,
	/// the information is copied from the input.
	/// </summary>
	public virtual void SetInformationInputData(vtkImageData arg0)
	{
		vtkImageChangeInformation_SetInformationInputData_36(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOriginScale_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Apply a scale to the origin.  The scale is applied
	/// before the translation.
	/// </summary>
	public virtual void SetOriginScale(double _arg1, double _arg2, double _arg3)
	{
		vtkImageChangeInformation_SetOriginScale_37(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOriginScale_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Apply a scale to the origin.  The scale is applied
	/// before the translation.
	/// </summary>
	public virtual void SetOriginScale(IntPtr _arg)
	{
		vtkImageChangeInformation_SetOriginScale_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOriginTranslation_39(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Apply a translation to the origin.
	/// </summary>
	public virtual void SetOriginTranslation(double _arg1, double _arg2, double _arg3)
	{
		vtkImageChangeInformation_SetOriginTranslation_39(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOriginTranslation_40(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Apply a translation to the origin.
	/// </summary>
	public virtual void SetOriginTranslation(IntPtr _arg)
	{
		vtkImageChangeInformation_SetOriginTranslation_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOutputExtentStart_41(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Specify new starting values for the extent explicitly.
	/// These values are used as WholeExtent[0], WholeExtent[2] and
	/// WholeExtent[4] of the output.  The default is to the
	/// use the extent start of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void SetOutputExtentStart(int _arg1, int _arg2, int _arg3)
	{
		vtkImageChangeInformation_SetOutputExtentStart_41(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOutputExtentStart_42(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify new starting values for the extent explicitly.
	/// These values are used as WholeExtent[0], WholeExtent[2] and
	/// WholeExtent[4] of the output.  The default is to the
	/// use the extent start of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void SetOutputExtentStart(IntPtr _arg)
	{
		vtkImageChangeInformation_SetOutputExtentStart_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOutputOrigin_43(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a new data origin explicitly.  The default is to
	/// use the origin of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void SetOutputOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkImageChangeInformation_SetOutputOrigin_43(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOutputOrigin_44(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a new data origin explicitly.  The default is to
	/// use the origin of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void SetOutputOrigin(IntPtr _arg)
	{
		vtkImageChangeInformation_SetOutputOrigin_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOutputSpacing_45(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify a new data spacing explicitly.  The default is to
	/// use the spacing of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void SetOutputSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkImageChangeInformation_SetOutputSpacing_45(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetOutputSpacing_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify a new data spacing explicitly.  The default is to
	/// use the spacing of the Input, or of the InformationInput
	/// if InformationInput is set.
	/// </summary>
	public virtual void SetOutputSpacing(IntPtr _arg)
	{
		vtkImageChangeInformation_SetOutputSpacing_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetSpacingScale_47(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Apply a scale factor to the spacing.
	/// </summary>
	public virtual void SetSpacingScale(double _arg1, double _arg2, double _arg3)
	{
		vtkImageChangeInformation_SetSpacingScale_47(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageChangeInformation_SetSpacingScale_48(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Apply a scale factor to the spacing.
	/// </summary>
	public virtual void SetSpacingScale(IntPtr _arg)
	{
		vtkImageChangeInformation_SetSpacingScale_48(GetCppThis(), _arg);
	}
}
