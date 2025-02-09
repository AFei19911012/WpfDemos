using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageShiftScale
/// </summary>
/// <remarks>
///    shift and scale an input image
///
/// With vtkImageShiftScale Pixels are shifted (a constant value added)
/// and then scaled (multiplied by a scalar. As a convenience, this class
/// allows you to set the output scalar type similar to vtkImageCast.
/// This is because shift scale operations frequently convert data types.
/// </remarks>
public class vtkImageShiftScale : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageShiftScale";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageShiftScale()
	{
		MRClassNameKey = "class vtkImageShiftScale";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageShiftScale"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageShiftScale(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageShiftScale_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageShiftScale New()
	{
		vtkImageShiftScale result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageShiftScale_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageShiftScale()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageShiftScale_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageShiftScale_ClampOverflowOff_01(HandleRef pThis);

	/// <summary>
	/// When the ClampOverflow flag is on, the data is thresholded so that
	/// the output value does not exceed the max or min of the data type.
	/// Clamping is safer because otherwise you might invoke undefined
	/// behavior (and may crash) if the type conversion is out of range
	/// of the data type.  On the other hand, clamping is slower.
	/// By default, ClampOverflow is off.
	/// </summary>
	public virtual void ClampOverflowOff()
	{
		vtkImageShiftScale_ClampOverflowOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_ClampOverflowOn_02(HandleRef pThis);

	/// <summary>
	/// When the ClampOverflow flag is on, the data is thresholded so that
	/// the output value does not exceed the max or min of the data type.
	/// Clamping is safer because otherwise you might invoke undefined
	/// behavior (and may crash) if the type conversion is out of range
	/// of the data type.  On the other hand, clamping is slower.
	/// By default, ClampOverflow is off.
	/// </summary>
	public virtual void ClampOverflowOn()
	{
		vtkImageShiftScale_ClampOverflowOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShiftScale_GetClampOverflow_03(HandleRef pThis);

	/// <summary>
	/// When the ClampOverflow flag is on, the data is thresholded so that
	/// the output value does not exceed the max or min of the data type.
	/// Clamping is safer because otherwise you might invoke undefined
	/// behavior (and may crash) if the type conversion is out of range
	/// of the data type.  On the other hand, clamping is slower.
	/// By default, ClampOverflow is off.
	/// </summary>
	public virtual int GetClampOverflow()
	{
		return vtkImageShiftScale_GetClampOverflow_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageShiftScale_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageShiftScale_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageShiftScale_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageShiftScale_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShiftScale_GetOutputScalarType_06(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImageShiftScale_GetOutputScalarType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageShiftScale_GetScale_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the scale value. Each pixel is multiplied by this value.
	/// </summary>
	public virtual double GetScale()
	{
		return vtkImageShiftScale_GetScale_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageShiftScale_GetShift_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the shift value. This value is added to each pixel
	/// </summary>
	public virtual double GetShift()
	{
		return vtkImageShiftScale_GetShift_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShiftScale_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageShiftScale_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageShiftScale_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageShiftScale_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageShiftScale_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageShiftScale NewInstance()
	{
		vtkImageShiftScale result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageShiftScale_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageShiftScale_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageShiftScale SafeDownCast(vtkObjectBase o)
	{
		vtkImageShiftScale vtkImageShiftScale2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageShiftScale_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageShiftScale2 = (vtkImageShiftScale)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageShiftScale2.Register(null);
			}
		}
		return vtkImageShiftScale2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetClampOverflow_14(HandleRef pThis, int _arg);

	/// <summary>
	/// When the ClampOverflow flag is on, the data is thresholded so that
	/// the output value does not exceed the max or min of the data type.
	/// Clamping is safer because otherwise you might invoke undefined
	/// behavior (and may crash) if the type conversion is out of range
	/// of the data type.  On the other hand, clamping is slower.
	/// By default, ClampOverflow is off.
	/// </summary>
	public virtual void SetClampOverflow(int _arg)
	{
		vtkImageShiftScale_SetClampOverflow_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarType_15(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkImageShiftScale_SetOutputScalarType_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToChar_16(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToChar()
	{
		vtkImageShiftScale_SetOutputScalarTypeToChar_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToDouble_17(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkImageShiftScale_SetOutputScalarTypeToDouble_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToFloat_18(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkImageShiftScale_SetOutputScalarTypeToFloat_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToInt_19(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToInt()
	{
		vtkImageShiftScale_SetOutputScalarTypeToInt_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToLong_20(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToLong()
	{
		vtkImageShiftScale_SetOutputScalarTypeToLong_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToShort_21(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToShort()
	{
		vtkImageShiftScale_SetOutputScalarTypeToShort_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedChar_22(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedChar()
	{
		vtkImageShiftScale_SetOutputScalarTypeToUnsignedChar_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedInt_23(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedInt()
	{
		vtkImageShiftScale_SetOutputScalarTypeToUnsignedInt_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedLong_24(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedLong()
	{
		vtkImageShiftScale_SetOutputScalarTypeToUnsignedLong_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetOutputScalarTypeToUnsignedShort_25(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type. The result of the shift
	/// and scale operations is cast to the type specified.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedShort()
	{
		vtkImageShiftScale_SetOutputScalarTypeToUnsignedShort_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetScale_26(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the scale value. Each pixel is multiplied by this value.
	/// </summary>
	public virtual void SetScale(double _arg)
	{
		vtkImageShiftScale_SetScale_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageShiftScale_SetShift_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the shift value. This value is added to each pixel
	/// </summary>
	public virtual void SetShift(double _arg)
	{
		vtkImageShiftScale_SetShift_27(GetCppThis(), _arg);
	}
}
