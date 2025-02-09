using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMask
/// </summary>
/// <remarks>
///    Combines a mask and an image.
///
/// vtkImageMask combines a mask with an image.  Non zero mask
/// implies the output pixel will be the same as the image.
/// If a mask pixel is zero,  then the output pixel
/// is set to "MaskedValue".  The filter also has the option to pass
/// the mask through a boolean not operation before processing the image.
/// This reverses the passed and replaced pixels.
/// The two inputs should have the same "WholeExtent".
/// The mask input should be unsigned char, and the image scalar type
/// is the same as the output scalar type.
/// </remarks>
public class vtkImageMask : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMask";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMask()
	{
		MRClassNameKey = "class vtkImageMask";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMask"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMask(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMask_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMask New()
	{
		vtkImageMask result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMask_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMask()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMask_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImageMask_GetMaskAlpha_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the alpha blending value for the mask
	/// The input image is assumed to be at alpha = 1.0
	/// and the mask image uses this alpha to blend using
	/// an over operator.
	/// </summary>
	public virtual double GetMaskAlpha()
	{
		return vtkImageMask_GetMaskAlpha_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMask_GetMaskAlphaMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the alpha blending value for the mask
	/// The input image is assumed to be at alpha = 1.0
	/// and the mask image uses this alpha to blend using
	/// an over operator.
	/// </summary>
	public virtual double GetMaskAlphaMaxValue()
	{
		return vtkImageMask_GetMaskAlphaMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageMask_GetMaskAlphaMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the alpha blending value for the mask
	/// The input image is assumed to be at alpha = 1.0
	/// and the mask image uses this alpha to blend using
	/// an over operator.
	/// </summary>
	public virtual double GetMaskAlphaMinValue()
	{
		return vtkImageMask_GetMaskAlphaMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMask_GetMaskedOutputValue_04(HandleRef pThis);

	/// <summary>
	/// SetGet the value of the output pixel replaced by mask.
	/// </summary>
	public IntPtr GetMaskedOutputValue()
	{
		return vtkImageMask_GetMaskedOutputValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMask_GetMaskedOutputValueLength_05(HandleRef pThis);

	/// <summary>
	/// SetGet the value of the output pixel replaced by mask.
	/// </summary>
	public int GetMaskedOutputValueLength()
	{
		return vtkImageMask_GetMaskedOutputValueLength_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMask_GetNotMask_06(HandleRef pThis);

	/// <summary>
	/// When Not Mask is on, the mask is passed through a boolean not
	/// before it is used to mask the image.  The effect is to pass the
	/// pixels where the input mask is zero, and replace the pixels
	/// where the input value is non zero.
	/// </summary>
	public virtual int GetNotMask()
	{
		return vtkImageMask_GetNotMask_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMask_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMask_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMask_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMask_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMask_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMask_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMask_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMask_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMask_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMask NewInstance()
	{
		vtkImageMask result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMask_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_NotMaskOff_13(HandleRef pThis);

	/// <summary>
	/// When Not Mask is on, the mask is passed through a boolean not
	/// before it is used to mask the image.  The effect is to pass the
	/// pixels where the input mask is zero, and replace the pixels
	/// where the input value is non zero.
	/// </summary>
	public virtual void NotMaskOff()
	{
		vtkImageMask_NotMaskOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_NotMaskOn_14(HandleRef pThis);

	/// <summary>
	/// When Not Mask is on, the mask is passed through a boolean not
	/// before it is used to mask the image.  The effect is to pass the
	/// pixels where the input mask is zero, and replace the pixels
	/// where the input value is non zero.
	/// </summary>
	public virtual void NotMaskOn()
	{
		vtkImageMask_NotMaskOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMask_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMask SafeDownCast(vtkObjectBase o)
	{
		vtkImageMask vtkImageMask2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMask_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMask2 = (vtkImageMask)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMask2.Register(null);
			}
		}
		return vtkImageMask2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetImageInputData_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the input to be masked.
	/// </summary>
	public void SetImageInputData(vtkImageData arg0)
	{
		vtkImageMask_SetImageInputData_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetInput1Data_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the two inputs to this filter
	/// </summary>
	public virtual void SetInput1Data(vtkDataObject arg0)
	{
		vtkImageMask_SetInput1Data_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetInput2Data_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the two inputs to this filter
	/// </summary>
	public virtual void SetInput2Data(vtkDataObject arg0)
	{
		vtkImageMask_SetInput2Data_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetMaskAlpha_19(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the alpha blending value for the mask
	/// The input image is assumed to be at alpha = 1.0
	/// and the mask image uses this alpha to blend using
	/// an over operator.
	/// </summary>
	public virtual void SetMaskAlpha(double _arg)
	{
		vtkImageMask_SetMaskAlpha_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetMaskInputData_20(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set the mask to be used.
	/// </summary>
	public void SetMaskInputData(vtkImageData arg0)
	{
		vtkImageMask_SetMaskInputData_20(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetMaskedOutputValue_21(HandleRef pThis, int num, IntPtr v);

	/// <summary>
	/// SetGet the value of the output pixel replaced by mask.
	/// </summary>
	public void SetMaskedOutputValue(int num, IntPtr v)
	{
		vtkImageMask_SetMaskedOutputValue_21(GetCppThis(), num, v);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetMaskedOutputValue_22(HandleRef pThis, double v);

	/// <summary>
	/// SetGet the value of the output pixel replaced by mask.
	/// </summary>
	public void SetMaskedOutputValue(double v)
	{
		vtkImageMask_SetMaskedOutputValue_22(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetMaskedOutputValue_23(HandleRef pThis, double v1, double v2);

	/// <summary>
	/// SetGet the value of the output pixel replaced by mask.
	/// </summary>
	public void SetMaskedOutputValue(double v1, double v2)
	{
		vtkImageMask_SetMaskedOutputValue_23(GetCppThis(), v1, v2);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetMaskedOutputValue_24(HandleRef pThis, double v1, double v2, double v3);

	/// <summary>
	/// SetGet the value of the output pixel replaced by mask.
	/// </summary>
	public void SetMaskedOutputValue(double v1, double v2, double v3)
	{
		vtkImageMask_SetMaskedOutputValue_24(GetCppThis(), v1, v2, v3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMask_SetNotMask_25(HandleRef pThis, int _arg);

	/// <summary>
	/// When Not Mask is on, the mask is passed through a boolean not
	/// before it is used to mask the image.  The effect is to pass the
	/// pixels where the input mask is zero, and replace the pixels
	/// where the input value is non zero.
	/// </summary>
	public virtual void SetNotMask(int _arg)
	{
		vtkImageMask_SetNotMask_25(GetCppThis(), _arg);
	}
}
