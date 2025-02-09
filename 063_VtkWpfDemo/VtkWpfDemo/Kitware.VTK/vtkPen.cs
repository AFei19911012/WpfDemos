using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPen
/// </summary>
/// <remarks>
///    provides a pen that draws the outlines of shapes drawn
/// by vtkContext2D.
///
///
/// The vtkPen defines the outline of shapes that are drawn by vtkContext2D.
/// The color is stored as four unsigned chars (RGBA), where the
/// opacity defaults to 255, but can be modified separately to the other
/// components. Ideally we would use a lightweight color class to store and pass
/// around colors.
/// </remarks>
public class vtkPen : vtkObject
{
	/// <summary>
	/// Enum of the available line types.
	/// </summary>
	public enum DASH_DOT_DOT_LINE_WrapperEnum
	{
		/// <summary>enum member</summary>
		DASH_DOT_DOT_LINE = 5,
		/// <summary>enum member</summary>
		DASH_DOT_LINE = 4,
		/// <summary>enum member</summary>
		DASH_LINE = 2,
		/// <summary>enum member</summary>
		DENSE_DOT_LINE = 6,
		/// <summary>enum member</summary>
		DOT_LINE = 3,
		/// <summary>enum member</summary>
		NO_PEN = 0,
		/// <summary>enum member</summary>
		SOLID_LINE = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPen";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPen()
	{
		MRClassNameKey = "class vtkPen";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPen"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPen(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPen_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPen New()
	{
		vtkPen result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPen_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPen()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPen_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkPen_DeepCopy_01(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Make a deep copy of the supplied pen.
	/// </summary>
	public void DeepCopy(vtkPen pen)
	{
		vtkPen_DeepCopy_01(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_GetColor_02(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Get the color of the brush - expects an unsigned char of length 3.
	/// </summary>
	public void GetColor(IntPtr color)
	{
		vtkPen_GetColor_02(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPen_GetColor_03(HandleRef pThis);

	/// <summary>
	/// Get the color of the brush - gives a pointer to the underlying data.
	/// </summary>
	public IntPtr GetColor()
	{
		return vtkPen_GetColor_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_GetColorF_04(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Get the color of the brush - expects a double of length 3 to copy into.
	/// </summary>
	public void GetColorF(IntPtr color)
	{
		vtkPen_GetColorF_04(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPen_GetColorObject_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the color of the pen.
	/// </summary>
	public vtkColor4ub GetColorObject()
	{
		vtkColor4ub result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPen_GetColorObject_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkColor4ub)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPen_GetLineType_06(HandleRef pThis);

	/// <summary>
	/// Get the type of line that the pen will draw.
	/// </summary>
	public int GetLineType()
	{
		return vtkPen_GetLineType_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPen_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPen_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPen_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPen_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPen_GetOpacity_09(HandleRef pThis);

	/// <summary>
	/// Get the opacity (unsigned char), ranging from 0 (transparent) to 255
	/// (opaque).
	/// </summary>
	public byte GetOpacity()
	{
		return vtkPen_GetOpacity_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkPen_GetWidth_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the pen.
	/// </summary>
	public virtual float GetWidth()
	{
		return vtkPen_GetWidth_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPen_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPen_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPen_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPen_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPen_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPen NewInstance()
	{
		vtkPen result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPen_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPen_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPen SafeDownCast(vtkObjectBase o)
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPen_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPen2 = (vtkPen)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPen2.Register(null);
			}
		}
		return vtkPen2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetColor_16(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Set the color of the brush with three component unsigned chars (RGB),
	/// ranging from 0 to 255.
	/// </summary>
	public void SetColor(IntPtr color)
	{
		vtkPen_SetColor_16(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetColor_17(HandleRef pThis, byte r, byte g, byte b);

	/// <summary>
	/// Set the color of the brush with three component unsigned chars (RGB),
	/// ranging from 0 to 255.
	/// </summary>
	public void SetColor(byte r, byte g, byte b)
	{
		vtkPen_SetColor_17(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetColor_18(HandleRef pThis, byte r, byte g, byte b, byte a);

	/// <summary>
	/// Set the color of the brush with four component unsigned chars (RGBA),
	/// ranging from 0 to 255.
	/// </summary>
	public void SetColor(byte r, byte g, byte b, byte a)
	{
		vtkPen_SetColor_18(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetColor_19(HandleRef pThis, HandleRef color);

	/// <summary>
	/// Set the color of the brush with four component unsigned chars (RGBA),
	/// ranging from 0 to 255.
	/// </summary>
	public void SetColor(vtkColor4ub color)
	{
		vtkPen_SetColor_19(GetCppThis(), color?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetColorF_20(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Set the color of the brush with three component doubles (RGB), ranging from
	/// 0.0 to 1.0.
	/// </summary>
	public void SetColorF(IntPtr color)
	{
		vtkPen_SetColorF_20(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetColorF_21(HandleRef pThis, double r, double g, double b);

	/// <summary>
	/// Set the color of the brush with three component doubles (RGB), ranging from
	/// 0.0 to 1.0.
	/// </summary>
	public void SetColorF(double r, double g, double b)
	{
		vtkPen_SetColorF_21(GetCppThis(), r, g, b);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetColorF_22(HandleRef pThis, double r, double g, double b, double a);

	/// <summary>
	/// Set the color of the brush with four component doubles (RGBA), ranging from
	/// 0.0 to 1.0.
	/// </summary>
	public void SetColorF(double r, double g, double b, double a)
	{
		vtkPen_SetColorF_22(GetCppThis(), r, g, b, a);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetLineType_23(HandleRef pThis, int type);

	/// <summary>
	/// Set the type of line that the pen should draw. The default is solid (1).
	/// </summary>
	public void SetLineType(int type)
	{
		vtkPen_SetLineType_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetOpacity_24(HandleRef pThis, byte a);

	/// <summary>
	/// Set the opacity with an unsigned char, ranging from 0 (transparent) to 255
	/// (opaque).
	/// </summary>
	public void SetOpacity(byte a)
	{
		vtkPen_SetOpacity_24(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetOpacityF_25(HandleRef pThis, double a);

	/// <summary>
	/// Set the opacity with a double, ranging from 0.0 (transparent) to 1.0
	/// (opaque).
	/// </summary>
	public void SetOpacityF(double a)
	{
		vtkPen_SetOpacityF_25(GetCppThis(), a);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPen_SetWidth_26(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the width of the pen.
	/// </summary>
	public virtual void SetWidth(float _arg)
	{
		vtkPen_SetWidth_26(GetCppThis(), _arg);
	}
}
