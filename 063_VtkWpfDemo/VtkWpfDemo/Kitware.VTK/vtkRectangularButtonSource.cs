using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRectangularButtonSource
/// </summary>
/// <remarks>
///    create a rectangular button
///
/// vtkRectangularButtonSource creates a rectangular shaped button with
/// texture coordinates suitable for application of a texture map. This
/// provides a way to make nice looking 3D buttons. The buttons are
/// represented as vtkPolyData that includes texture coordinates and
/// normals. The button lies in the x-y plane.
///
/// To use this class you must define its width, height and length. These
/// measurements are all taken with respect to the shoulder of the button.
/// The shoulder is defined as follows. Imagine a box sitting on the floor.
/// The distance from the floor to the top of the box is the depth; the other
/// directions are the length (x-direction) and height (y-direction). In
/// this particular widget the box can have a smaller bottom than top. The
/// ratio in size between bottom and top is called the box ratio (by
/// default=1.0). The ratio of the texture region to the shoulder region
/// is the texture ratio. And finally the texture region may be out of plane
/// compared to the shoulder. The texture height ratio controls this.
///
/// </remarks>
/// <seealso>
///
/// vtkButtonSource vtkEllipticalButtonSource
///
/// @warning
/// The button is defined in the x-y plane. Use vtkTransformPolyDataFilter
/// or vtkGlyph3D to orient the button in a different direction.
/// </seealso>
public class vtkRectangularButtonSource : vtkButtonSource
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRectangularButtonSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRectangularButtonSource()
	{
		MRClassNameKey = "class vtkRectangularButtonSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRectangularButtonSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRectangularButtonSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectangularButtonSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a circular button with depth 10% of its height.
	/// </summary>
	public new static vtkRectangularButtonSource New()
	{
		vtkRectangularButtonSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectangularButtonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a circular button with depth 10% of its height.
	/// </summary>
	public vtkRectangularButtonSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRectangularButtonSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkRectangularButtonSource_GetBoxRatio_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the bottom of the button with the
	/// shoulder region. Numbers greater than one produce buttons
	/// with a wider bottom than shoulder; ratios less than one
	/// produce buttons that have a wider shoulder than bottom.
	/// </summary>
	public virtual double GetBoxRatio()
	{
		return vtkRectangularButtonSource_GetBoxRatio_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetBoxRatioMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the bottom of the button with the
	/// shoulder region. Numbers greater than one produce buttons
	/// with a wider bottom than shoulder; ratios less than one
	/// produce buttons that have a wider shoulder than bottom.
	/// </summary>
	public virtual double GetBoxRatioMaxValue()
	{
		return vtkRectangularButtonSource_GetBoxRatioMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetBoxRatioMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the bottom of the button with the
	/// shoulder region. Numbers greater than one produce buttons
	/// with a wider bottom than shoulder; ratios less than one
	/// produce buttons that have a wider shoulder than bottom.
	/// </summary>
	public virtual double GetBoxRatioMinValue()
	{
		return vtkRectangularButtonSource_GetBoxRatioMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetDepth_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the depth of the button (the z-eliipsoid axis length).
	/// </summary>
	public virtual double GetDepth()
	{
		return vtkRectangularButtonSource_GetDepth_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetDepthMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the depth of the button (the z-eliipsoid axis length).
	/// </summary>
	public virtual double GetDepthMaxValue()
	{
		return vtkRectangularButtonSource_GetDepthMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetDepthMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the depth of the button (the z-eliipsoid axis length).
	/// </summary>
	public virtual double GetDepthMinValue()
	{
		return vtkRectangularButtonSource_GetDepthMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetHeight_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the height of the button.
	/// </summary>
	public virtual double GetHeight()
	{
		return vtkRectangularButtonSource_GetHeight_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetHeightMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the height of the button.
	/// </summary>
	public virtual double GetHeightMaxValue()
	{
		return vtkRectangularButtonSource_GetHeightMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetHeightMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the height of the button.
	/// </summary>
	public virtual double GetHeightMinValue()
	{
		return vtkRectangularButtonSource_GetHeightMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectangularButtonSource_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRectangularButtonSource_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRectangularButtonSource_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRectangularButtonSource_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectangularButtonSource_GetOutputPointsPrecision_12(HandleRef pThis);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual int GetOutputPointsPrecision()
	{
		return vtkRectangularButtonSource_GetOutputPointsPrecision_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetTextureHeightRatio_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the height of the texture region
	/// to the shoulder height. Values greater than 1.0 yield
	/// convex buttons with the texture region raised above the
	/// shoulder. Values less than 1.0 yield concave buttons with
	/// the texture region below the shoulder.
	/// </summary>
	public virtual double GetTextureHeightRatio()
	{
		return vtkRectangularButtonSource_GetTextureHeightRatio_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetTextureHeightRatioMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the height of the texture region
	/// to the shoulder height. Values greater than 1.0 yield
	/// convex buttons with the texture region raised above the
	/// shoulder. Values less than 1.0 yield concave buttons with
	/// the texture region below the shoulder.
	/// </summary>
	public virtual double GetTextureHeightRatioMaxValue()
	{
		return vtkRectangularButtonSource_GetTextureHeightRatioMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetTextureHeightRatioMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the height of the texture region
	/// to the shoulder height. Values greater than 1.0 yield
	/// convex buttons with the texture region raised above the
	/// shoulder. Values less than 1.0 yield concave buttons with
	/// the texture region below the shoulder.
	/// </summary>
	public virtual double GetTextureHeightRatioMinValue()
	{
		return vtkRectangularButtonSource_GetTextureHeightRatioMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetTextureRatio_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the texture region to the
	/// shoulder region. This number must be 0&lt;=tr&lt;=1.
	/// If the texture style is to fit the image, then satisfying
	/// the texture ratio may only be possible in one of the
	/// two directions (length or width) depending on the
	/// dimensions of the texture.
	/// </summary>
	public virtual double GetTextureRatio()
	{
		return vtkRectangularButtonSource_GetTextureRatio_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetTextureRatioMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the texture region to the
	/// shoulder region. This number must be 0&lt;=tr&lt;=1.
	/// If the texture style is to fit the image, then satisfying
	/// the texture ratio may only be possible in one of the
	/// two directions (length or width) depending on the
	/// dimensions of the texture.
	/// </summary>
	public virtual double GetTextureRatioMaxValue()
	{
		return vtkRectangularButtonSource_GetTextureRatioMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetTextureRatioMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the ratio of the texture region to the
	/// shoulder region. This number must be 0&lt;=tr&lt;=1.
	/// If the texture style is to fit the image, then satisfying
	/// the texture ratio may only be possible in one of the
	/// two directions (length or width) depending on the
	/// dimensions of the texture.
	/// </summary>
	public virtual double GetTextureRatioMinValue()
	{
		return vtkRectangularButtonSource_GetTextureRatioMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetWidth_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the button.
	/// </summary>
	public virtual double GetWidth()
	{
		return vtkRectangularButtonSource_GetWidth_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetWidthMaxValue_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the button.
	/// </summary>
	public virtual double GetWidthMaxValue()
	{
		return vtkRectangularButtonSource_GetWidthMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkRectangularButtonSource_GetWidthMinValue_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the width of the button.
	/// </summary>
	public virtual double GetWidthMinValue()
	{
		return vtkRectangularButtonSource_GetWidthMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectangularButtonSource_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRectangularButtonSource_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRectangularButtonSource_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRectangularButtonSource_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectangularButtonSource_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRectangularButtonSource NewInstance()
	{
		vtkRectangularButtonSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectangularButtonSource_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRectangularButtonSource_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRectangularButtonSource SafeDownCast(vtkObjectBase o)
	{
		vtkRectangularButtonSource vtkRectangularButtonSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRectangularButtonSource_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRectangularButtonSource2 = (vtkRectangularButtonSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRectangularButtonSource2.Register(null);
			}
		}
		return vtkRectangularButtonSource2;
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectangularButtonSource_SetBoxRatio_27(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio of the bottom of the button with the
	/// shoulder region. Numbers greater than one produce buttons
	/// with a wider bottom than shoulder; ratios less than one
	/// produce buttons that have a wider shoulder than bottom.
	/// </summary>
	public virtual void SetBoxRatio(double _arg)
	{
		vtkRectangularButtonSource_SetBoxRatio_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectangularButtonSource_SetDepth_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the depth of the button (the z-eliipsoid axis length).
	/// </summary>
	public virtual void SetDepth(double _arg)
	{
		vtkRectangularButtonSource_SetDepth_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectangularButtonSource_SetHeight_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the height of the button.
	/// </summary>
	public virtual void SetHeight(double _arg)
	{
		vtkRectangularButtonSource_SetHeight_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectangularButtonSource_SetOutputPointsPrecision_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/get the desired precision for the output points.
	/// vtkAlgorithm::SINGLE_PRECISION - Output single-precision floating point.
	/// vtkAlgorithm::DOUBLE_PRECISION - Output double-precision floating point.
	/// </summary>
	public virtual void SetOutputPointsPrecision(int _arg)
	{
		vtkRectangularButtonSource_SetOutputPointsPrecision_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectangularButtonSource_SetTextureHeightRatio_31(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio of the height of the texture region
	/// to the shoulder height. Values greater than 1.0 yield
	/// convex buttons with the texture region raised above the
	/// shoulder. Values less than 1.0 yield concave buttons with
	/// the texture region below the shoulder.
	/// </summary>
	public virtual void SetTextureHeightRatio(double _arg)
	{
		vtkRectangularButtonSource_SetTextureHeightRatio_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectangularButtonSource_SetTextureRatio_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the ratio of the texture region to the
	/// shoulder region. This number must be 0&lt;=tr&lt;=1.
	/// If the texture style is to fit the image, then satisfying
	/// the texture ratio may only be possible in one of the
	/// two directions (length or width) depending on the
	/// dimensions of the texture.
	/// </summary>
	public virtual void SetTextureRatio(double _arg)
	{
		vtkRectangularButtonSource_SetTextureRatio_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.FiltersSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRectangularButtonSource_SetWidth_33(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the width of the button.
	/// </summary>
	public virtual void SetWidth(double _arg)
	{
		vtkRectangularButtonSource_SetWidth_33(GetCppThis(), _arg);
	}
}
