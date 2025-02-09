using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageCast
/// </summary>
/// <remarks>
///     Image Data type Casting Filter
///
/// vtkImageCast filter casts the input type to match the output type in
/// the image processing pipeline.  The filter does nothing if the input
/// already has the correct type.  To specify the "CastTo" type,
/// use "SetOutputScalarType" method.
///
/// @warning
/// As vtkImageCast only casts values without rescaling them, its use is not
/// recommended. vtkImageShiftScale is the recommended way to change the type
/// of an image data.
///
/// </remarks>
/// <seealso>
///
/// vtkImageThreshold vtkImageShiftScale
/// </seealso>
public class vtkImageCast : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageCast";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageCast()
	{
		MRClassNameKey = "class vtkImageCast";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageCast"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageCast(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCast_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageCast New()
	{
		vtkImageCast result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCast_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageCast()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageCast_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageCast_ClampOverflowOff_01(HandleRef pThis);

	/// <summary>
	/// When the ClampOverflow flag is on, the data is thresholded so that
	/// the output value does not exceed the max or min of the data type.
	/// Clamping is safer because otherwise you might invoke undefined
	/// behavior (and may crash) if the type conversion is out of range
	/// of the data type.  On the other hand, clamping is slower.
	/// By default ClampOverflow is off.
	/// </summary>
	public virtual void ClampOverflowOff()
	{
		vtkImageCast_ClampOverflowOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_ClampOverflowOn_02(HandleRef pThis);

	/// <summary>
	/// When the ClampOverflow flag is on, the data is thresholded so that
	/// the output value does not exceed the max or min of the data type.
	/// Clamping is safer because otherwise you might invoke undefined
	/// behavior (and may crash) if the type conversion is out of range
	/// of the data type.  On the other hand, clamping is slower.
	/// By default ClampOverflow is off.
	/// </summary>
	public virtual void ClampOverflowOn()
	{
		vtkImageCast_ClampOverflowOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCast_GetClampOverflow_03(HandleRef pThis);

	/// <summary>
	/// When the ClampOverflow flag is on, the data is thresholded so that
	/// the output value does not exceed the max or min of the data type.
	/// Clamping is safer because otherwise you might invoke undefined
	/// behavior (and may crash) if the type conversion is out of range
	/// of the data type.  On the other hand, clamping is slower.
	/// By default ClampOverflow is off.
	/// </summary>
	public virtual int GetClampOverflow()
	{
		return vtkImageCast_GetClampOverflow_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageCast_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageCast_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageCast_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageCast_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCast_GetOutputScalarType_06(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImageCast_GetOutputScalarType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCast_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageCast_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageCast_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageCast_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCast_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageCast NewInstance()
	{
		vtkImageCast result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCast_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageCast_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageCast SafeDownCast(vtkObjectBase o)
	{
		vtkImageCast vtkImageCast2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageCast_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageCast2 = (vtkImageCast)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageCast2.Register(null);
			}
		}
		return vtkImageCast2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetClampOverflow_12(HandleRef pThis, int _arg);

	/// <summary>
	/// When the ClampOverflow flag is on, the data is thresholded so that
	/// the output value does not exceed the max or min of the data type.
	/// Clamping is safer because otherwise you might invoke undefined
	/// behavior (and may crash) if the type conversion is out of range
	/// of the data type.  On the other hand, clamping is slower.
	/// By default ClampOverflow is off.
	/// </summary>
	public virtual void SetClampOverflow(int _arg)
	{
		vtkImageCast_SetClampOverflow_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarType_13(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkImageCast_SetOutputScalarType_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToChar_14(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToChar()
	{
		vtkImageCast_SetOutputScalarTypeToChar_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToDouble_15(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkImageCast_SetOutputScalarTypeToDouble_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToFloat_16(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkImageCast_SetOutputScalarTypeToFloat_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToInt_17(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToInt()
	{
		vtkImageCast_SetOutputScalarTypeToInt_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToLong_18(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToLong()
	{
		vtkImageCast_SetOutputScalarTypeToLong_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToShort_19(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToShort()
	{
		vtkImageCast_SetOutputScalarTypeToShort_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedChar_20(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedChar()
	{
		vtkImageCast_SetOutputScalarTypeToUnsignedChar_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedInt_21(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedInt()
	{
		vtkImageCast_SetOutputScalarTypeToUnsignedInt_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedLong_22(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedLong()
	{
		vtkImageCast_SetOutputScalarTypeToUnsignedLong_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageCast_SetOutputScalarTypeToUnsignedShort_23(HandleRef pThis);

	/// <summary>
	/// Set the desired output scalar type to cast to.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedShort()
	{
		vtkImageCast_SetOutputScalarTypeToUnsignedShort_23(GetCppThis());
	}
}
