using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageThreshold
/// </summary>
/// <remarks>
///     Flexible threshold
///
/// vtkImageThreshold can do binary or continuous thresholding for lower, upper
/// or a range of data.  The output data type may be different than the
/// output, but defaults to the same type.
/// </remarks>
public class vtkImageThreshold : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageThreshold";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageThreshold()
	{
		MRClassNameKey = "class vtkImageThreshold";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageThreshold"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageThreshold(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThreshold_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageThreshold New()
	{
		vtkImageThreshold result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageThreshold()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageThreshold_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImageThreshold_GetInValue_01(HandleRef pThis);

	/// <summary>
	/// Replace the in range pixels with this value.
	/// </summary>
	public virtual double GetInValue()
	{
		return vtkImageThreshold_GetInValue_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThreshold_GetLowerThreshold_02(HandleRef pThis);

	/// <summary>
	/// Get the Upper and Lower thresholds.
	/// </summary>
	public virtual double GetLowerThreshold()
	{
		return vtkImageThreshold_GetLowerThreshold_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageThreshold_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageThreshold_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageThreshold_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageThreshold_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThreshold_GetOutValue_05(HandleRef pThis);

	/// <summary>
	/// Replace the in range pixels with this value.
	/// </summary>
	public virtual double GetOutValue()
	{
		return vtkImageThreshold_GetOutValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThreshold_GetOutputScalarType_06(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImageThreshold_GetOutputScalarType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThreshold_GetReplaceIn_07(HandleRef pThis);

	/// <summary>
	/// Determines whether to replace the pixel in range with InValue
	/// </summary>
	public virtual int GetReplaceIn()
	{
		return vtkImageThreshold_GetReplaceIn_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThreshold_GetReplaceOut_08(HandleRef pThis);

	/// <summary>
	/// Determines whether to replace the pixel out of range with OutValue
	/// </summary>
	public virtual int GetReplaceOut()
	{
		return vtkImageThreshold_GetReplaceOut_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageThreshold_GetUpperThreshold_09(HandleRef pThis);

	/// <summary>
	/// Get the Upper and Lower thresholds.
	/// </summary>
	public virtual double GetUpperThreshold()
	{
		return vtkImageThreshold_GetUpperThreshold_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThreshold_IsA_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageThreshold_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageThreshold_IsTypeOf_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageThreshold_IsTypeOf_11(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThreshold_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageThreshold NewInstance()
	{
		vtkImageThreshold result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageThreshold_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_ReplaceInOff_14(HandleRef pThis);

	/// <summary>
	/// Determines whether to replace the pixel in range with InValue
	/// </summary>
	public virtual void ReplaceInOff()
	{
		vtkImageThreshold_ReplaceInOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_ReplaceInOn_15(HandleRef pThis);

	/// <summary>
	/// Determines whether to replace the pixel in range with InValue
	/// </summary>
	public virtual void ReplaceInOn()
	{
		vtkImageThreshold_ReplaceInOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_ReplaceOutOff_16(HandleRef pThis);

	/// <summary>
	/// Determines whether to replace the pixel out of range with OutValue
	/// </summary>
	public virtual void ReplaceOutOff()
	{
		vtkImageThreshold_ReplaceOutOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_ReplaceOutOn_17(HandleRef pThis);

	/// <summary>
	/// Determines whether to replace the pixel out of range with OutValue
	/// </summary>
	public virtual void ReplaceOutOn()
	{
		vtkImageThreshold_ReplaceOutOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageThreshold_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageThreshold SafeDownCast(vtkObjectBase o)
	{
		vtkImageThreshold vtkImageThreshold2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageThreshold_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageThreshold2 = (vtkImageThreshold)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageThreshold2.Register(null);
			}
		}
		return vtkImageThreshold2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetInValue_19(HandleRef pThis, double val);

	/// <summary>
	/// Replace the in range pixels with this value.
	/// </summary>
	public void SetInValue(double val)
	{
		vtkImageThreshold_SetInValue_19(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutValue_20(HandleRef pThis, double val);

	/// <summary>
	/// Replace the in range pixels with this value.
	/// </summary>
	public void SetOutValue(double val)
	{
		vtkImageThreshold_SetOutValue_20(GetCppThis(), val);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarType_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkImageThreshold_SetOutputScalarType_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToChar_22(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToChar()
	{
		vtkImageThreshold_SetOutputScalarTypeToChar_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToDouble_23(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkImageThreshold_SetOutputScalarTypeToDouble_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToFloat_24(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkImageThreshold_SetOutputScalarTypeToFloat_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToInt_25(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToInt()
	{
		vtkImageThreshold_SetOutputScalarTypeToInt_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToLong_26(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToLong()
	{
		vtkImageThreshold_SetOutputScalarTypeToLong_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToShort_27(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToShort()
	{
		vtkImageThreshold_SetOutputScalarTypeToShort_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToSignedChar_28(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToSignedChar()
	{
		vtkImageThreshold_SetOutputScalarTypeToSignedChar_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedChar_29(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToUnsignedChar()
	{
		vtkImageThreshold_SetOutputScalarTypeToUnsignedChar_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedInt_30(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToUnsignedInt()
	{
		vtkImageThreshold_SetOutputScalarTypeToUnsignedInt_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedLong_31(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToUnsignedLong()
	{
		vtkImageThreshold_SetOutputScalarTypeToUnsignedLong_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetOutputScalarTypeToUnsignedShort_32(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to
	/// </summary>
	public void SetOutputScalarTypeToUnsignedShort()
	{
		vtkImageThreshold_SetOutputScalarTypeToUnsignedShort_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetReplaceIn_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Determines whether to replace the pixel in range with InValue
	/// </summary>
	public virtual void SetReplaceIn(int _arg)
	{
		vtkImageThreshold_SetReplaceIn_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_SetReplaceOut_34(HandleRef pThis, int _arg);

	/// <summary>
	/// Determines whether to replace the pixel out of range with OutValue
	/// </summary>
	public virtual void SetReplaceOut(int _arg)
	{
		vtkImageThreshold_SetReplaceOut_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_ThresholdBetween_35(HandleRef pThis, double lower, double upper);

	/// <summary>
	/// The values in a range (inclusive) match
	/// </summary>
	public void ThresholdBetween(double lower, double upper)
	{
		vtkImageThreshold_ThresholdBetween_35(GetCppThis(), lower, upper);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_ThresholdByLower_36(HandleRef pThis, double thresh);

	/// <summary>
	/// The values less than or equal to the value match.
	/// </summary>
	public void ThresholdByLower(double thresh)
	{
		vtkImageThreshold_ThresholdByLower_36(GetCppThis(), thresh);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageThreshold_ThresholdByUpper_37(HandleRef pThis, double thresh);

	/// <summary>
	/// The values greater than or equal to the value match.
	/// </summary>
	public void ThresholdByUpper(double thresh)
	{
		vtkImageThreshold_ThresholdByUpper_37(GetCppThis(), thresh);
	}
}
