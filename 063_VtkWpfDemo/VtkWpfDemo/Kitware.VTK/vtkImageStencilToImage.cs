using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageStencilToImage
/// </summary>
/// <remarks>
///    Convert an image stencil into an image
///
/// vtkImageStencilToImage will convert an image stencil into a binary
/// image.  The default output will be an 8-bit image with a value of 1
/// inside the stencil and 0 outside.  When used in combination with
/// vtkPolyDataToImageStencil or vtkImplicitFunctionToImageStencil, this
/// can be used to create a binary image from a mesh or a function.
/// </remarks>
/// <seealso>
///
/// vtkImplicitModeller
/// </seealso>
public class vtkImageStencilToImage : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencilToImage";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageStencilToImage()
	{
		MRClassNameKey = "class vtkImageStencilToImage";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencilToImage"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageStencilToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStencilToImage New()
	{
		vtkImageStencilToImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilToImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageStencilToImage()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageStencilToImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageStencilToImage_GetInsideValue_01(HandleRef pThis);

	/// <summary>
	/// The value to use inside the stencil.  The default is 1.
	/// </summary>
	public virtual double GetInsideValue()
	{
		return vtkImageStencilToImage_GetInsideValue_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStencilToImage_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageStencilToImage_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageStencilToImage_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageStencilToImage_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilToImage_GetOutputScalarType_04(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public virtual int GetOutputScalarType()
	{
		return vtkImageStencilToImage_GetOutputScalarType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageStencilToImage_GetOutsideValue_05(HandleRef pThis);

	/// <summary>
	/// The value to use outside the stencil.  The default is 0.
	/// </summary>
	public virtual double GetOutsideValue()
	{
		return vtkImageStencilToImage_GetOutsideValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilToImage_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageStencilToImage_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageStencilToImage_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageStencilToImage_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilToImage_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageStencilToImage NewInstance()
	{
		vtkImageStencilToImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilToImage_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageStencilToImage_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageStencilToImage SafeDownCast(vtkObjectBase o)
	{
		vtkImageStencilToImage vtkImageStencilToImage2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageStencilToImage_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageStencilToImage2 = (vtkImageStencilToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageStencilToImage2.Register(null);
			}
		}
		return vtkImageStencilToImage2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetInsideValue_11(HandleRef pThis, double _arg);

	/// <summary>
	/// The value to use inside the stencil.  The default is 1.
	/// </summary>
	public virtual void SetInsideValue(double _arg)
	{
		vtkImageStencilToImage_SetInsideValue_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarType_12(HandleRef pThis, int _arg);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public virtual void SetOutputScalarType(int _arg)
	{
		vtkImageStencilToImage_SetOutputScalarType_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToChar_13(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToChar()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToChar_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToDouble_14(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToDouble()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToDouble_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToFloat_15(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToFloat()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToFloat_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToInt_16(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToInt()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToInt_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToLong_17(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToLong()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToLong_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToShort_18(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToShort()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToShort_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedChar_19(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedChar()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToUnsignedChar_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedInt_20(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedInt()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToUnsignedInt_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedLong_21(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedLong()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToUnsignedLong_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutputScalarTypeToUnsignedShort_22(HandleRef pThis);

	/// <summary>
	/// The desired output scalar type.  The default is unsigned char.
	/// </summary>
	public void SetOutputScalarTypeToUnsignedShort()
	{
		vtkImageStencilToImage_SetOutputScalarTypeToUnsignedShort_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageStencilToImage_SetOutsideValue_23(HandleRef pThis, double _arg);

	/// <summary>
	/// The value to use outside the stencil.  The default is 0.
	/// </summary>
	public virtual void SetOutsideValue(double _arg)
	{
		vtkImageStencilToImage_SetOutsideValue_23(GetCppThis(), _arg);
	}
}
