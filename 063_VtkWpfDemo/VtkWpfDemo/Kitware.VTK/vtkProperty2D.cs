using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkProperty2D
/// </summary>
/// <remarks>
///    represent surface properties of a 2D image
///
/// vtkProperty2D contains properties used to render two dimensional images
/// and annotations.
///
/// </remarks>
/// <seealso>
///
/// vtkActor2D
/// </seealso>
public class vtkProperty2D : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkProperty2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkProperty2D()
	{
		MRClassNameKey = "class vtkProperty2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkProperty2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkProperty2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a vtkProperty2D with the following default values:
	/// Opacity 1, Color (1,1,1)
	/// </summary>
	public new static vtkProperty2D New()
	{
		vtkProperty2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProperty2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a vtkProperty2D with the following default values:
	/// Opacity 1, Color (1,1,1)
	/// </summary>
	public vtkProperty2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkProperty2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_DeepCopy_01(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public void DeepCopy(vtkProperty2D p)
	{
		vtkProperty2D_DeepCopy_01(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty2D_GetColor_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the RGB color of this property.
	/// </summary>
	public virtual double[] GetColor()
	{
		IntPtr intPtr = vtkProperty2D_GetColor_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_GetColor_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the RGB color of this property.
	/// </summary>
	public virtual void GetColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkProperty2D_GetColor_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_GetColor_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the RGB color of this property.
	/// </summary>
	public virtual void GetColor(IntPtr _arg)
	{
		vtkProperty2D_GetColor_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_GetDisplayLocation_05(HandleRef pThis);

	/// <summary>
	/// The DisplayLocation is either background or foreground.
	/// If it is background, then this 2D actor will be drawn
	/// behind all 3D props or foreground 2D actors. If it is
	/// foreground, then this 2D actor will be drawn in front of
	/// all 3D props and background 2D actors. Within 2D actors
	/// of the same DisplayLocation type, order is determined by
	/// the order in which the 2D actors were added to the viewport.
	/// </summary>
	public virtual int GetDisplayLocation()
	{
		return vtkProperty2D_GetDisplayLocation_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_GetDisplayLocationMaxValue_06(HandleRef pThis);

	/// <summary>
	/// The DisplayLocation is either background or foreground.
	/// If it is background, then this 2D actor will be drawn
	/// behind all 3D props or foreground 2D actors. If it is
	/// foreground, then this 2D actor will be drawn in front of
	/// all 3D props and background 2D actors. Within 2D actors
	/// of the same DisplayLocation type, order is determined by
	/// the order in which the 2D actors were added to the viewport.
	/// </summary>
	public virtual int GetDisplayLocationMaxValue()
	{
		return vtkProperty2D_GetDisplayLocationMaxValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_GetDisplayLocationMinValue_07(HandleRef pThis);

	/// <summary>
	/// The DisplayLocation is either background or foreground.
	/// If it is background, then this 2D actor will be drawn
	/// behind all 3D props or foreground 2D actors. If it is
	/// foreground, then this 2D actor will be drawn in front of
	/// all 3D props and background 2D actors. Within 2D actors
	/// of the same DisplayLocation type, order is determined by
	/// the order in which the 2D actors were added to the viewport.
	/// </summary>
	public virtual int GetDisplayLocationMinValue()
	{
		return vtkProperty2D_GetDisplayLocationMinValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_GetLineStipplePattern_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the stippling pattern of a Line, as a 16-bit binary pattern
	/// (1 = pixel on, 0 = pixel off).
	/// This is only implemented for OpenGL, not OpenGL2. The default is 0xFFFF.
	/// </summary>
	public virtual int GetLineStipplePattern()
	{
		return vtkProperty2D_GetLineStipplePattern_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_GetLineStippleRepeatFactor_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the stippling repeat factor of a Line, which specifies how
	/// many times each bit in the pattern is to be repeated.
	/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
	/// </summary>
	public virtual int GetLineStippleRepeatFactor()
	{
		return vtkProperty2D_GetLineStippleRepeatFactor_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_GetLineStippleRepeatFactorMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the stippling repeat factor of a Line, which specifies how
	/// many times each bit in the pattern is to be repeated.
	/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
	/// </summary>
	public virtual int GetLineStippleRepeatFactorMaxValue()
	{
		return vtkProperty2D_GetLineStippleRepeatFactorMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_GetLineStippleRepeatFactorMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the stippling repeat factor of a Line, which specifies how
	/// many times each bit in the pattern is to be repeated.
	/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
	/// </summary>
	public virtual int GetLineStippleRepeatFactorMinValue()
	{
		return vtkProperty2D_GetLineStippleRepeatFactorMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty2D_GetLineWidth_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of a Line. The width is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetLineWidth()
	{
		return vtkProperty2D_GetLineWidth_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty2D_GetLineWidthMaxValue_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of a Line. The width is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetLineWidthMaxValue()
	{
		return vtkProperty2D_GetLineWidthMaxValue_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty2D_GetLineWidthMinValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of a Line. The width is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetLineWidthMinValue()
	{
		return vtkProperty2D_GetLineWidthMinValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProperty2D_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkProperty2D_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkProperty2D_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkProperty2D_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkProperty2D_GetOpacity_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the Opacity of this property.
	/// </summary>
	public virtual double GetOpacity()
	{
		return vtkProperty2D_GetOpacity_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty2D_GetPointSize_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the diameter of a Point. The size is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetPointSize()
	{
		return vtkProperty2D_GetPointSize_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty2D_GetPointSizeMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the diameter of a Point. The size is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetPointSizeMaxValue()
	{
		return vtkProperty2D_GetPointSizeMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkProperty2D_GetPointSizeMinValue_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the diameter of a Point. The size is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual float GetPointSizeMinValue()
	{
		return vtkProperty2D_GetPointSizeMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkProperty2D_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkProperty2D_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkProperty2D_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty2D_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkProperty2D NewInstance()
	{
		vtkProperty2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProperty2D_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_Render_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Have the device specific subclass render this property.
	/// </summary>
	public virtual void Render(vtkViewport arg0)
	{
		vtkProperty2D_Render_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkProperty2D_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkProperty2D SafeDownCast(vtkObjectBase o)
	{
		vtkProperty2D vtkProperty2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkProperty2D_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2D2 = (vtkProperty2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2D2.Register(null);
			}
		}
		return vtkProperty2D2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetColor_27(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the RGB color of this property.
	/// </summary>
	public virtual void SetColor(double _arg1, double _arg2, double _arg3)
	{
		vtkProperty2D_SetColor_27(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetColor_28(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the RGB color of this property.
	/// </summary>
	public virtual void SetColor(IntPtr _arg)
	{
		vtkProperty2D_SetColor_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetDisplayLocation_29(HandleRef pThis, int _arg);

	/// <summary>
	/// The DisplayLocation is either background or foreground.
	/// If it is background, then this 2D actor will be drawn
	/// behind all 3D props or foreground 2D actors. If it is
	/// foreground, then this 2D actor will be drawn in front of
	/// all 3D props and background 2D actors. Within 2D actors
	/// of the same DisplayLocation type, order is determined by
	/// the order in which the 2D actors were added to the viewport.
	/// </summary>
	public virtual void SetDisplayLocation(int _arg)
	{
		vtkProperty2D_SetDisplayLocation_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetDisplayLocationToBackground_30(HandleRef pThis);

	/// <summary>
	/// The DisplayLocation is either background or foreground.
	/// If it is background, then this 2D actor will be drawn
	/// behind all 3D props or foreground 2D actors. If it is
	/// foreground, then this 2D actor will be drawn in front of
	/// all 3D props and background 2D actors. Within 2D actors
	/// of the same DisplayLocation type, order is determined by
	/// the order in which the 2D actors were added to the viewport.
	/// </summary>
	public void SetDisplayLocationToBackground()
	{
		vtkProperty2D_SetDisplayLocationToBackground_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetDisplayLocationToForeground_31(HandleRef pThis);

	/// <summary>
	/// The DisplayLocation is either background or foreground.
	/// If it is background, then this 2D actor will be drawn
	/// behind all 3D props or foreground 2D actors. If it is
	/// foreground, then this 2D actor will be drawn in front of
	/// all 3D props and background 2D actors. Within 2D actors
	/// of the same DisplayLocation type, order is determined by
	/// the order in which the 2D actors were added to the viewport.
	/// </summary>
	public void SetDisplayLocationToForeground()
	{
		vtkProperty2D_SetDisplayLocationToForeground_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetLineStipplePattern_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the stippling pattern of a Line, as a 16-bit binary pattern
	/// (1 = pixel on, 0 = pixel off).
	/// This is only implemented for OpenGL, not OpenGL2. The default is 0xFFFF.
	/// </summary>
	public virtual void SetLineStipplePattern(int _arg)
	{
		vtkProperty2D_SetLineStipplePattern_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetLineStippleRepeatFactor_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the stippling repeat factor of a Line, which specifies how
	/// many times each bit in the pattern is to be repeated.
	/// This is only implemented for OpenGL, not OpenGL2. The default is 1.
	/// </summary>
	public virtual void SetLineStippleRepeatFactor(int _arg)
	{
		vtkProperty2D_SetLineStippleRepeatFactor_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetLineWidth_34(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the width of a Line. The width is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual void SetLineWidth(float _arg)
	{
		vtkProperty2D_SetLineWidth_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetOpacity_35(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Opacity of this property.
	/// </summary>
	public virtual void SetOpacity(double _arg)
	{
		vtkProperty2D_SetOpacity_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkProperty2D_SetPointSize_36(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the diameter of a Point. The size is expressed in screen units.
	/// This is only implemented for OpenGL. The default is 1.0.
	/// </summary>
	public virtual void SetPointSize(float _arg)
	{
		vtkProperty2D_SetPointSize_36(GetCppThis(), _arg);
	}
}
