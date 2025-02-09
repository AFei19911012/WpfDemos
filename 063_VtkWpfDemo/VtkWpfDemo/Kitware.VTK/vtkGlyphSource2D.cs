using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGlyphSource2D
/// </summary>
/// <remarks>
///    create 2D glyphs represented by vtkPolyData
///
/// vtkGlyphSource2D can generate a family of 2D glyphs each of which lies
/// in the x-y plane (i.e., the z-coordinate is zero). The class is a helper
/// class to be used with vtkGlyph2D and vtkXYPlotActor.
///
/// To use this class, specify the glyph type to use and its
/// attributes. Attributes include its position (i.e., center point), scale,
/// color, and whether the symbol is filled or not (a polygon or closed line
/// sequence). You can also put a short line through the glyph running from -x
/// to +x (the glyph looks like it's on a line), or a cross.
/// </remarks>
public class vtkGlyphSource2D : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGlyphSource2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGlyphSource2D()
	{
		MRClassNameKey = "class vtkGlyphSource2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGlyphSource2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGlyphSource2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyphSource2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a vertex glyph centered at the origin, scale 1.0, white in
	/// color, filled, with line segment passing through the point.
	/// </summary>
	public new static vtkGlyphSource2D New()
	{
		vtkGlyphSource2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyphSource2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a vertex glyph centered at the origin, scale 1.0, white in
	/// color, filled, with line segment passing through the point.
	/// </summary>
	public vtkGlyphSource2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGlyphSource2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_CrossOff_01(HandleRef pThis);

	/// <summary>
	/// Specify whether a cross is drawn as part of the glyph. (This
	/// is in addition to the glyph. If the glyph type is set to
	/// "Cross" there is no need to enable this flag.)
	/// </summary>
	public virtual void CrossOff()
	{
		vtkGlyphSource2D_CrossOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_CrossOn_02(HandleRef pThis);

	/// <summary>
	/// Specify whether a cross is drawn as part of the glyph. (This
	/// is in addition to the glyph. If the glyph type is set to
	/// "Cross" there is no need to enable this flag.)
	/// </summary>
	public virtual void CrossOn()
	{
		vtkGlyphSource2D_CrossOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_DashOff_03(HandleRef pThis);

	/// <summary>
	/// Specify whether a short line segment is drawn through the
	/// glyph. (This is in addition to the glyph. If the glyph type
	/// is set to "Dash" there is no need to enable this flag.)
	/// </summary>
	public virtual void DashOff()
	{
		vtkGlyphSource2D_DashOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_DashOn_04(HandleRef pThis);

	/// <summary>
	/// Specify whether a short line segment is drawn through the
	/// glyph. (This is in addition to the glyph. If the glyph type
	/// is set to "Dash" there is no need to enable this flag.)
	/// </summary>
	public virtual void DashOn()
	{
		vtkGlyphSource2D_DashOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_FilledOff_05(HandleRef pThis);

	/// <summary>
	/// Specify whether the glyph is filled (a polygon) or not (a
	/// closed polygon defined by line segments). This only applies
	/// to 2D closed glyphs.
	/// </summary>
	public virtual void FilledOff()
	{
		vtkGlyphSource2D_FilledOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_FilledOn_06(HandleRef pThis);

	/// <summary>
	/// Specify whether the glyph is filled (a polygon) or not (a
	/// closed polygon defined by line segments). This only applies
	/// to 2D closed glyphs.
	/// </summary>
	public virtual void FilledOn()
	{
		vtkGlyphSource2D_FilledOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyphSource2D_GetCenter_07(HandleRef pThis);

	/// <summary>
	/// Set the center of the glyph. By default the center is (0,0,0).
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkGlyphSource2D_GetCenter_07(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_GetCenter_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the center of the glyph. By default the center is (0,0,0).
	/// </summary>
	public virtual void GetCenter(IntPtr data)
	{
		vtkGlyphSource2D_GetCenter_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyphSource2D_GetColor_09(HandleRef pThis);

	/// <summary>
	/// Set the color of the glyph. The default color is white.
	/// </summary>
	public virtual double[] GetColor()
	{
		IntPtr intPtr = vtkGlyphSource2D_GetColor_09(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_GetColor_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the color of the glyph. The default color is white.
	/// </summary>
	public virtual void GetColor(IntPtr data)
	{
		vtkGlyphSource2D_GetColor_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetCross_11(HandleRef pThis);

	/// <summary>
	/// Specify whether a cross is drawn as part of the glyph. (This
	/// is in addition to the glyph. If the glyph type is set to
	/// "Cross" there is no need to enable this flag.)
	/// </summary>
	public virtual int GetCross()
	{
		return vtkGlyphSource2D_GetCross_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetDash_12(HandleRef pThis);

	/// <summary>
	/// Specify whether a short line segment is drawn through the
	/// glyph. (This is in addition to the glyph. If the glyph type
	/// is set to "Dash" there is no need to enable this flag.)
	/// </summary>
	public virtual int GetDash()
	{
		return vtkGlyphSource2D_GetDash_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetFilled_13(HandleRef pThis);

	/// <summary>
	/// Specify whether the glyph is filled (a polygon) or not (a
	/// closed polygon defined by line segments). This only applies
	/// to 2D closed glyphs.
	/// </summary>
	public virtual int GetFilled()
	{
		return vtkGlyphSource2D_GetFilled_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetGlyphType_14(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public virtual int GetGlyphType()
	{
		return vtkGlyphSource2D_GetGlyphType_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetGlyphTypeMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public virtual int GetGlyphTypeMaxValue()
	{
		return vtkGlyphSource2D_GetGlyphTypeMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetGlyphTypeMinValue_16(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public virtual int GetGlyphTypeMinValue()
	{
		return vtkGlyphSource2D_GetGlyphTypeMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyphSource2D_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGlyphSource2D_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGlyphSource2D_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGlyphSource2D_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetOutputPointsPrecision_19(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkGlyphSource2D_GetOutputPointsPrecision_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetResolution_20(HandleRef pThis);

	/// <summary>
	/// Specify the number of points that form the circular glyph.
	/// </summary>
	public virtual int GetResolution()
	{
		return vtkGlyphSource2D_GetResolution_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetResolutionMaxValue_21(HandleRef pThis);

	/// <summary>
	/// Specify the number of points that form the circular glyph.
	/// </summary>
	public virtual int GetResolutionMaxValue()
	{
		return vtkGlyphSource2D_GetResolutionMaxValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_GetResolutionMinValue_22(HandleRef pThis);

	/// <summary>
	/// Specify the number of points that form the circular glyph.
	/// </summary>
	public virtual int GetResolutionMinValue()
	{
		return vtkGlyphSource2D_GetResolutionMinValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyphSource2D_GetRotationAngle_23(HandleRef pThis);

	/// <summary>
	/// Specify an angle (in degrees) to rotate the glyph around
	/// the z-axis. Using this ivar, it is possible to generate
	/// rotated glyphs (e.g., crosses, arrows, etc.)
	/// </summary>
	public virtual double GetRotationAngle()
	{
		return vtkGlyphSource2D_GetRotationAngle_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyphSource2D_GetScale_24(HandleRef pThis);

	/// <summary>
	/// Set the scale of the glyph. Note that the glyphs are designed
	/// to fit in the (1,1) rectangle.
	/// </summary>
	public virtual double GetScale()
	{
		return vtkGlyphSource2D_GetScale_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyphSource2D_GetScale2_25(HandleRef pThis);

	/// <summary>
	/// Set the scale of optional portions of the glyph (e.g., the
	/// dash and cross is DashOn() and CrossOn()).
	/// </summary>
	public virtual double GetScale2()
	{
		return vtkGlyphSource2D_GetScale2_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyphSource2D_GetScale2MaxValue_26(HandleRef pThis);

	/// <summary>
	/// Set the scale of optional portions of the glyph (e.g., the
	/// dash and cross is DashOn() and CrossOn()).
	/// </summary>
	public virtual double GetScale2MaxValue()
	{
		return vtkGlyphSource2D_GetScale2MaxValue_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyphSource2D_GetScale2MinValue_27(HandleRef pThis);

	/// <summary>
	/// Set the scale of optional portions of the glyph (e.g., the
	/// dash and cross is DashOn() and CrossOn()).
	/// </summary>
	public virtual double GetScale2MinValue()
	{
		return vtkGlyphSource2D_GetScale2MinValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyphSource2D_GetScaleMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Set the scale of the glyph. Note that the glyphs are designed
	/// to fit in the (1,1) rectangle.
	/// </summary>
	public virtual double GetScaleMaxValue()
	{
		return vtkGlyphSource2D_GetScaleMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkGlyphSource2D_GetScaleMinValue_29(HandleRef pThis);

	/// <summary>
	/// Set the scale of the glyph. Note that the glyphs are designed
	/// to fit in the (1,1) rectangle.
	/// </summary>
	public virtual double GetScaleMinValue()
	{
		return vtkGlyphSource2D_GetScaleMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGlyphSource2D_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGlyphSource2D_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGlyphSource2D_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyphSource2D_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGlyphSource2D NewInstance()
	{
		vtkGlyphSource2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyphSource2D_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGlyphSource2D_SafeDownCast_34(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGlyphSource2D SafeDownCast(vtkObjectBase o)
	{
		vtkGlyphSource2D vtkGlyphSource2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGlyphSource2D_SafeDownCast_34(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGlyphSource2D2 = (vtkGlyphSource2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGlyphSource2D2.Register(null);
			}
		}
		return vtkGlyphSource2D2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetCenter_35(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the center of the glyph. By default the center is (0,0,0).
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkGlyphSource2D_SetCenter_35(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetCenter_36(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the center of the glyph. By default the center is (0,0,0).
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkGlyphSource2D_SetCenter_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetColor_37(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color of the glyph. The default color is white.
	/// </summary>
	public virtual void SetColor(double _arg1, double _arg2, double _arg3)
	{
		vtkGlyphSource2D_SetColor_37(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetColor_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the glyph. The default color is white.
	/// </summary>
	public virtual void SetColor(IntPtr _arg)
	{
		vtkGlyphSource2D_SetColor_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetCross_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether a cross is drawn as part of the glyph. (This
	/// is in addition to the glyph. If the glyph type is set to
	/// "Cross" there is no need to enable this flag.)
	/// </summary>
	public virtual void SetCross(int _arg)
	{
		vtkGlyphSource2D_SetCross_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetDash_40(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether a short line segment is drawn through the
	/// glyph. (This is in addition to the glyph. If the glyph type
	/// is set to "Dash" there is no need to enable this flag.)
	/// </summary>
	public virtual void SetDash(int _arg)
	{
		vtkGlyphSource2D_SetDash_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetFilled_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify whether the glyph is filled (a polygon) or not (a
	/// closed polygon defined by line segments). This only applies
	/// to 2D closed glyphs.
	/// </summary>
	public virtual void SetFilled(int _arg)
	{
		vtkGlyphSource2D_SetFilled_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphType_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public virtual void SetGlyphType(int _arg)
	{
		vtkGlyphSource2D_SetGlyphType_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToArrow_43(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToArrow()
	{
		vtkGlyphSource2D_SetGlyphTypeToArrow_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToCircle_44(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToCircle()
	{
		vtkGlyphSource2D_SetGlyphTypeToCircle_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToCross_45(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToCross()
	{
		vtkGlyphSource2D_SetGlyphTypeToCross_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToDash_46(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToDash()
	{
		vtkGlyphSource2D_SetGlyphTypeToDash_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToDiamond_47(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToDiamond()
	{
		vtkGlyphSource2D_SetGlyphTypeToDiamond_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToEdgeArrow_48(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToEdgeArrow()
	{
		vtkGlyphSource2D_SetGlyphTypeToEdgeArrow_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToHookedArrow_49(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToHookedArrow()
	{
		vtkGlyphSource2D_SetGlyphTypeToHookedArrow_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToNone_50(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToNone()
	{
		vtkGlyphSource2D_SetGlyphTypeToNone_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToSquare_51(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToSquare()
	{
		vtkGlyphSource2D_SetGlyphTypeToSquare_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToThickArrow_52(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToThickArrow()
	{
		vtkGlyphSource2D_SetGlyphTypeToThickArrow_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToThickCross_53(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToThickCross()
	{
		vtkGlyphSource2D_SetGlyphTypeToThickCross_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToTriangle_54(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToTriangle()
	{
		vtkGlyphSource2D_SetGlyphTypeToTriangle_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetGlyphTypeToVertex_55(HandleRef pThis);

	/// <summary>
	/// Specify the type of glyph to generate.
	/// </summary>
	public void SetGlyphTypeToVertex()
	{
		vtkGlyphSource2D_SetGlyphTypeToVertex_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetOutputPointsPrecision_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkGlyphSource2D_SetOutputPointsPrecision_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetResolution_57(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of points that form the circular glyph.
	/// </summary>
	public virtual void SetResolution(int _arg)
	{
		vtkGlyphSource2D_SetResolution_57(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetRotationAngle_58(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify an angle (in degrees) to rotate the glyph around
	/// the z-axis. Using this ivar, it is possible to generate
	/// rotated glyphs (e.g., crosses, arrows, etc.)
	/// </summary>
	public virtual void SetRotationAngle(double _arg)
	{
		vtkGlyphSource2D_SetRotationAngle_58(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetScale_59(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the scale of the glyph. Note that the glyphs are designed
	/// to fit in the (1,1) rectangle.
	/// </summary>
	public virtual void SetScale(double _arg)
	{
		vtkGlyphSource2D_SetScale_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGlyphSource2D_SetScale2_60(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the scale of optional portions of the glyph (e.g., the
	/// dash and cross is DashOn() and CrossOn()).
	/// </summary>
	public virtual void SetScale2(double _arg)
	{
		vtkGlyphSource2D_SetScale2_60(GetCppThis(), _arg);
	}
}
