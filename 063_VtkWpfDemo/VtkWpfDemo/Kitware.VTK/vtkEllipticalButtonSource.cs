using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkEllipticalButtonSource
/// </summary>
/// <remarks>
///    create a ellipsoidal-shaped button
///
/// vtkEllipticalButtonSource creates a ellipsoidal shaped button with
/// texture coordinates suitable for application of a texture map. This
/// provides a way to make nice looking 3D buttons. The buttons are
/// represented as vtkPolyData that includes texture coordinates and
/// normals. The button lies in the x-y plane.
///
/// To use this class you must define the major and minor axes lengths of an
/// ellipsoid (expressed as width (x), height (y) and depth (z)). The button
/// has a rectangular mesh region in the center with texture coordinates that
/// range smoothly from (0,1). (This flat region is called the texture
/// region.) The outer, curved portion of the button (called the shoulder) has
/// texture coordinates set to a user specified value (by default (0,0).
/// (This results in coloring the button curve the same color as the (s,t)
/// location of the texture map.) The resolution in the radial direction, the
/// texture region, and the shoulder region must also be set. The button can
/// be moved by specifying an origin.
///
/// </remarks>
/// <seealso>
///
/// vtkButtonSource vtkRectangularButtonSource
/// </seealso>
public class vtkEllipticalButtonSource : vtkButtonSource
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkEllipticalButtonSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkEllipticalButtonSource()
	{
		MRClassNameKey = "class vtkEllipticalButtonSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkEllipticalButtonSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkEllipticalButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipticalButtonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a circular button with depth 10% of its height.
	/// </summary>
	public new static vtkEllipticalButtonSource New()
	{
		vtkEllipticalButtonSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipticalButtonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a circular button with depth 10% of its height.
	/// </summary>
	public vtkEllipticalButtonSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkEllipticalButtonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolution_01(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the button in the circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolution()
	{
		return vtkEllipticalButtonSource_GetCircumferentialResolution_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolutionMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the button in the circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolutionMaxValue()
	{
		return vtkEllipticalButtonSource_GetCircumferentialResolutionMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetCircumferentialResolutionMinValue_03(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the button in the circumferential direction.
	/// </summary>
	public virtual int GetCircumferentialResolutionMinValue()
	{
		return vtkEllipticalButtonSource_GetCircumferentialResolutionMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetDepth_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the depth of the button (the z-eliipsoid axis length).
	/// </summary>
	public virtual double GetDepth()
	{
		return vtkEllipticalButtonSource_GetDepth_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetDepthMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the depth of the button (the z-eliipsoid axis length).
	/// </summary>
	public virtual double GetDepthMaxValue()
	{
		return vtkEllipticalButtonSource_GetDepthMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetDepthMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the depth of the button (the z-eliipsoid axis length).
	/// </summary>
	public virtual double GetDepthMinValue()
	{
		return vtkEllipticalButtonSource_GetDepthMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetHeight_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the height of the button (the y-ellipsoid axis length * 2).
	/// </summary>
	public virtual double GetHeight()
	{
		return vtkEllipticalButtonSource_GetHeight_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetHeightMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the height of the button (the y-ellipsoid axis length * 2).
	/// </summary>
	public virtual double GetHeightMaxValue()
	{
		return vtkEllipticalButtonSource_GetHeightMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetHeightMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the height of the button (the y-ellipsoid axis length * 2).
	/// </summary>
	public virtual double GetHeightMinValue()
	{
		return vtkEllipticalButtonSource_GetHeightMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEllipticalButtonSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkEllipticalButtonSource_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkEllipticalButtonSource_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkEllipticalButtonSource_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetOutputPointsPrecision_12(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkEllipticalButtonSource_GetOutputPointsPrecision_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetRadialRatio_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the radial ratio. This is the measure of the radius of the
	/// outer ellipsoid to the inner ellipsoid of the button. The outer
	/// ellipsoid is the boundary of the button defined by the height and
	/// width. The inner ellipsoid circumscribes the texture region. Larger
	/// RadialRatio's cause the button to be more rounded (and the texture
	/// region to be smaller); smaller ratios produce sharply curved shoulders
	/// with a larger texture region.
	/// </summary>
	public virtual double GetRadialRatio()
	{
		return vtkEllipticalButtonSource_GetRadialRatio_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetRadialRatioMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the radial ratio. This is the measure of the radius of the
	/// outer ellipsoid to the inner ellipsoid of the button. The outer
	/// ellipsoid is the boundary of the button defined by the height and
	/// width. The inner ellipsoid circumscribes the texture region. Larger
	/// RadialRatio's cause the button to be more rounded (and the texture
	/// region to be smaller); smaller ratios produce sharply curved shoulders
	/// with a larger texture region.
	/// </summary>
	public virtual double GetRadialRatioMaxValue()
	{
		return vtkEllipticalButtonSource_GetRadialRatioMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetRadialRatioMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the radial ratio. This is the measure of the radius of the
	/// outer ellipsoid to the inner ellipsoid of the button. The outer
	/// ellipsoid is the boundary of the button defined by the height and
	/// width. The inner ellipsoid circumscribes the texture region. Larger
	/// RadialRatio's cause the button to be more rounded (and the texture
	/// region to be smaller); smaller ratios produce sharply curved shoulders
	/// with a larger texture region.
	/// </summary>
	public virtual double GetRadialRatioMinValue()
	{
		return vtkEllipticalButtonSource_GetRadialRatioMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetShoulderResolution_16(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the texture in the radial direction in the
	/// shoulder region.
	/// </summary>
	public virtual int GetShoulderResolution()
	{
		return vtkEllipticalButtonSource_GetShoulderResolution_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetShoulderResolutionMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the texture in the radial direction in the
	/// shoulder region.
	/// </summary>
	public virtual int GetShoulderResolutionMaxValue()
	{
		return vtkEllipticalButtonSource_GetShoulderResolutionMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetShoulderResolutionMinValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the texture in the radial direction in the
	/// shoulder region.
	/// </summary>
	public virtual int GetShoulderResolutionMinValue()
	{
		return vtkEllipticalButtonSource_GetShoulderResolutionMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetTextureResolution_19(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the texture in the radial direction in the
	/// texture region.
	/// </summary>
	public virtual int GetTextureResolution()
	{
		return vtkEllipticalButtonSource_GetTextureResolution_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetTextureResolutionMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the texture in the radial direction in the
	/// texture region.
	/// </summary>
	public virtual int GetTextureResolutionMaxValue()
	{
		return vtkEllipticalButtonSource_GetTextureResolutionMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_GetTextureResolutionMinValue_21(HandleRef pThis);

	/// <summary>
	/// Specify the resolution of the texture in the radial direction in the
	/// texture region.
	/// </summary>
	public virtual int GetTextureResolutionMinValue()
	{
		return vtkEllipticalButtonSource_GetTextureResolutionMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetWidth_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the button (the x-ellipsoid axis length * 2).
	/// </summary>
	public virtual double GetWidth()
	{
		return vtkEllipticalButtonSource_GetWidth_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetWidthMaxValue_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the button (the x-ellipsoid axis length * 2).
	/// </summary>
	public virtual double GetWidthMaxValue()
	{
		return vtkEllipticalButtonSource_GetWidthMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkEllipticalButtonSource_GetWidthMinValue_24(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the button (the x-ellipsoid axis length * 2).
	/// </summary>
	public virtual double GetWidthMinValue()
	{
		return vtkEllipticalButtonSource_GetWidthMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkEllipticalButtonSource_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkEllipticalButtonSource_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkEllipticalButtonSource_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipticalButtonSource_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkEllipticalButtonSource NewInstance()
	{
		vtkEllipticalButtonSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipticalButtonSource_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkEllipticalButtonSource_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkEllipticalButtonSource SafeDownCast(vtkObjectBase o)
	{
		vtkEllipticalButtonSource vtkEllipticalButtonSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkEllipticalButtonSource_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkEllipticalButtonSource2 = (vtkEllipticalButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkEllipticalButtonSource2.Register(null);
			}
		}
		return vtkEllipticalButtonSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipticalButtonSource_SetCircumferentialResolution_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the resolution of the button in the circumferential direction.
	/// </summary>
	public virtual void SetCircumferentialResolution(int _arg)
	{
		vtkEllipticalButtonSource_SetCircumferentialResolution_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipticalButtonSource_SetDepth_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the depth of the button (the z-eliipsoid axis length).
	/// </summary>
	public virtual void SetDepth(double _arg)
	{
		vtkEllipticalButtonSource_SetDepth_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipticalButtonSource_SetHeight_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the height of the button (the y-ellipsoid axis length * 2).
	/// </summary>
	public virtual void SetHeight(double _arg)
	{
		vtkEllipticalButtonSource_SetHeight_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipticalButtonSource_SetOutputPointsPrecision_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkEllipticalButtonSource_SetOutputPointsPrecision_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipticalButtonSource_SetRadialRatio_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the radial ratio. This is the measure of the radius of the
	/// outer ellipsoid to the inner ellipsoid of the button. The outer
	/// ellipsoid is the boundary of the button defined by the height and
	/// width. The inner ellipsoid circumscribes the texture region. Larger
	/// RadialRatio's cause the button to be more rounded (and the texture
	/// region to be smaller); smaller ratios produce sharply curved shoulders
	/// with a larger texture region.
	/// </summary>
	public virtual void SetRadialRatio(double _arg)
	{
		vtkEllipticalButtonSource_SetRadialRatio_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipticalButtonSource_SetShoulderResolution_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the resolution of the texture in the radial direction in the
	/// shoulder region.
	/// </summary>
	public virtual void SetShoulderResolution(int _arg)
	{
		vtkEllipticalButtonSource_SetShoulderResolution_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipticalButtonSource_SetTextureResolution_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the resolution of the texture in the radial direction in the
	/// texture region.
	/// </summary>
	public virtual void SetTextureResolution(int _arg)
	{
		vtkEllipticalButtonSource_SetTextureResolution_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkEllipticalButtonSource_SetWidth_37(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the width of the button (the x-ellipsoid axis length * 2).
	/// </summary>
	public virtual void SetWidth(double _arg)
	{
		vtkEllipticalButtonSource_SetWidth_37(GetCppThis(), _arg);
	}
}
