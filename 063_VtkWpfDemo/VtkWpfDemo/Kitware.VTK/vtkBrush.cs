using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBrush
/// </summary>
/// <remarks>
///    provides a brush that fills shapes drawn by vtkContext2D.
///
///
/// The vtkBrush defines the fill (or pattern) of shapes that are drawn by
/// vtkContext2D. The color is stored as four unsigned chars (RGBA), where the
/// opacity defaults to 255, but can be modified separately to the other
/// components. Ideally we would use a lightweight color class to store and pass
/// around colors.
/// </remarks>
public class vtkBrush : vtkObject
{
	/// <summary>
	/// Texture properties
	/// </summary>
	public enum TextureProperty
	{
		/// <summary>enum member</summary>
		Linear = 2,
		/// <summary>enum member</summary>
		Nearest = 1,
		/// <summary>enum member</summary>
		Repeat = 8,
		/// <summary>enum member</summary>
		Stretch = 4
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBrush";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBrush()
	{
		MRClassNameKey = "class vtkBrush";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBrush"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBrush(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrush_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBrush New()
	{
		vtkBrush result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrush_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBrush()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBrush_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_DeepCopy_01(HandleRef pThis, HandleRef brush);

	/// <summary>
	/// Make a deep copy of the supplied brush.
	/// </summary>
	public void DeepCopy(vtkBrush brush)
	{
		vtkBrush_DeepCopy_01(GetCppThis(), brush?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_GetColor_02(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Get the color of the brush - expects an unsigned char of length 4.
	/// </summary>
	public void GetColor(IntPtr color)
	{
		vtkBrush_GetColor_02(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrush_GetColor_03(HandleRef pThis);

	/// <summary>
	/// Get the color of the brush - gives a pointer to the underlying data.
	/// </summary>
	public IntPtr GetColor()
	{
		return vtkBrush_GetColor_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_GetColorF_04(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Get the color of the brush - expects a double of length 4 to copy into.
	/// </summary>
	public void GetColorF(IntPtr color)
	{
		vtkBrush_GetColorF_04(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrush_GetColorObject_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color of the brush.
	/// </summary>
	public vtkColor4ub GetColorObject()
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrush_GetColorObject_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBrush_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBrush_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBrush_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBrush_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkBrush_GetOpacity_08(HandleRef pThis);

	/// <summary>
	/// Get the opacity ranging from 0 (transparent) to 255(opaque).
	/// </summary>
	public byte GetOpacity()
	{
		return vtkBrush_GetOpacity_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkBrush_GetOpacityF_09(HandleRef pThis);

	/// <summary>
	/// Get the opacity ranging from 0.0 (transparent) to 1.0(opaque).
	/// </summary>
	public double GetOpacityF()
	{
		return vtkBrush_GetOpacityF_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrush_GetTexture_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the texture that is used to fill polygons
	/// </summary>
	public virtual vtkImageData GetTexture()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrush_GetTexture_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrush_GetTextureProperties_11(HandleRef pThis);

	/// <summary>
	/// Get the properties associated to the texture
	/// </summary>
	public virtual int GetTextureProperties()
	{
		return vtkBrush_GetTextureProperties_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrush_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBrush_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBrush_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBrush_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrush_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBrush NewInstance()
	{
		vtkBrush result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrush_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBrush_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBrush SafeDownCast(vtkObjectBase o)
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBrush_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBrush2 = (vtkBrush)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBrush2.Register(null);
			}
		}
		return vtkBrush2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetColor_17(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Set the color of the brush with three component unsigned chars (RGB),
	/// ranging from 0 to 255.
	/// </summary>
	public void SetColor(IntPtr color)
	{
		vtkBrush_SetColor_17(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetColor_18(HandleRef pThis, byte r, byte g, byte b);

	/// <summary>
	/// Set the color of the brush with three component unsigned chars (RGB),
	/// ranging from 0 to 255.
	/// </summary>
	public void SetColor(byte r, byte g, byte b)
	{
		vtkBrush_SetColor_18(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetColor_19(HandleRef pThis, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Set the color of the brush with four component unsigned chars (RGBA),
	/// ranging from 0 to 255.
	/// </summary>
	public void SetColor(byte r, byte g, byte b, byte a)
	{
		vtkBrush_SetColor_19(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetColor_20(HandleRef pThis, HandleRef color);

	/// <summary>
	/// Set the color of the brush with four component unsigned chars (RGBA),
	/// ranging from 0 to 255.
	/// </summary>
	public void SetColor(vtkColor4ub color)
	{
		vtkBrush_SetColor_20(GetCppThis(), color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetColorF_21(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Set the color of the brush with three component doubles (RGB), ranging from
	/// 0.0 to 1.0.
	/// </summary>
	public void SetColorF(IntPtr color)
	{
		vtkBrush_SetColorF_21(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetColorF_22(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the color of the brush with three component doubles (RGB), ranging from
	/// 0.0 to 1.0.
	/// </summary>
	public void SetColorF(double r, double g, double b)
	{
		vtkBrush_SetColorF_22(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetColorF_23(HandleRef pThis, double r, double g, double b, double a);

	/// <summary>
	/// Set the color of the brush with four component doubles (RGBA), ranging from
	/// 0.0 to 1.0.
	/// </summary>
	public void SetColorF(double r, double g, double b, double a)
	{
		vtkBrush_SetColorF_23(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetOpacity_24(HandleRef pThis, byte a);

	/// <summary>
	/// Set the opacity with an unsigned char, ranging from 0 (transparent) to 255
	/// (opaque).
	/// </summary>
	public void SetOpacity(byte a)
	{
		vtkBrush_SetOpacity_24(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetOpacityF_25(HandleRef pThis, double a);

	/// <summary>
	/// Set the opacity with a double, ranging from 0.0 (transparent) to 1.0
	/// (opaque).
	/// </summary>
	public void SetOpacityF(double a)
	{
		vtkBrush_SetOpacityF_25(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetTexture_26(HandleRef pThis, HandleRef image);

	/// <summary>
	/// Set the texture that will be used to fill polygons
	/// By default, no texture is set. The image will be registered with the brush
	/// (ref count is incremented)
	/// To disable the texture, set Texture to 0.
	/// </summary>
	public void SetTexture(vtkImageData image)
	{
		vtkBrush_SetTexture_26(GetCppThis(), image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBrush_SetTextureProperties_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Set properties to the texture
	/// By default, the texture is linearly stretched.
	/// The behavior is undefined when Linear and Nearest are both set
	/// The behavior is undefined when Stretch and Repeat are both set
	/// The behavior is undefined if TextureProperties is 0
	/// </summary>
	public virtual void SetTextureProperties(int _arg)
	{
		vtkBrush_SetTextureProperties_27(GetCppThis(), _arg);
	}
}
