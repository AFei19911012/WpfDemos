using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageProperty
/// </summary>
/// <remarks>
///    image display properties
///
/// vtkImageProperty is an object that allows control of the display
/// of an image slice.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImage vtkImageMapper3D vtkImageSliceMapper vtkImageResliceMapper
/// </seealso>
public class vtkImageProperty : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageProperty";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageProperty()
	{
		MRClassNameKey = "class vtkImageProperty";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageProperty"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct a property with no lookup table.
	/// </summary>
	public new static vtkImageProperty New()
	{
		vtkImageProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct a property with no lookup table.
	/// </summary>
	public vtkImageProperty()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageProperty_BackingOff_01(HandleRef pThis);

	/// <summary>
	/// Use an opaque backing polygon, which will be visible where the image
	/// is translucent.  When images are in a stack, the backing polygons
	/// for all images will be drawn before any of the images in the stack,
	/// in order to allow the images in the stack to be composited.
	/// </summary>
	public virtual void BackingOff()
	{
		vtkImageProperty_BackingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_BackingOn_02(HandleRef pThis);

	/// <summary>
	/// Use an opaque backing polygon, which will be visible where the image
	/// is translucent.  When images are in a stack, the backing polygons
	/// for all images will be drawn before any of the images in the stack,
	/// in order to allow the images in the stack to be composited.
	/// </summary>
	public virtual void BackingOn()
	{
		vtkImageProperty_BackingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_CheckerboardOff_03(HandleRef pThis);

	/// <summary>
	/// Make a checkerboard pattern where the black squares are transparent.
	/// The pattern is aligned with the camera, and centered by default.
	/// </summary>
	public virtual void CheckerboardOff()
	{
		vtkImageProperty_CheckerboardOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_CheckerboardOn_04(HandleRef pThis);

	/// <summary>
	/// Make a checkerboard pattern where the black squares are transparent.
	/// The pattern is aligned with the camera, and centered by default.
	/// </summary>
	public virtual void CheckerboardOn()
	{
		vtkImageProperty_CheckerboardOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_DeepCopy_05(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public void DeepCopy(vtkImageProperty p)
	{
		vtkImageProperty_DeepCopy_05(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetAmbient_06(HandleRef pThis);

	/// <summary>
	/// The ambient lighting coefficient.  The default is 1.0.
	/// </summary>
	public virtual double GetAmbient()
	{
		return vtkImageProperty_GetAmbient_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetAmbientMaxValue_07(HandleRef pThis);

	/// <summary>
	/// The ambient lighting coefficient.  The default is 1.0.
	/// </summary>
	public virtual double GetAmbientMaxValue()
	{
		return vtkImageProperty_GetAmbientMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetAmbientMinValue_08(HandleRef pThis);

	/// <summary>
	/// The ambient lighting coefficient.  The default is 1.0.
	/// </summary>
	public virtual double GetAmbientMinValue()
	{
		return vtkImageProperty_GetAmbientMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_GetBacking_09(HandleRef pThis);

	/// <summary>
	/// Use an opaque backing polygon, which will be visible where the image
	/// is translucent.  When images are in a stack, the backing polygons
	/// for all images will be drawn before any of the images in the stack,
	/// in order to allow the images in the stack to be composited.
	/// </summary>
	public virtual int GetBacking()
	{
		return vtkImageProperty_GetBacking_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageProperty_GetBackingColor_10(HandleRef pThis);

	/// <summary>
	/// Set the color of the backing polygon.  The default color is black.
	/// </summary>
	public virtual double[] GetBackingColor()
	{
		IntPtr intPtr = vtkImageProperty_GetBackingColor_10(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_GetBackingColor_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set the color of the backing polygon.  The default color is black.
	/// </summary>
	public virtual void GetBackingColor(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageProperty_GetBackingColor_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_GetBackingColor_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the backing polygon.  The default color is black.
	/// </summary>
	public virtual void GetBackingColor(IntPtr _arg)
	{
		vtkImageProperty_GetBackingColor_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_GetCheckerboard_13(HandleRef pThis);

	/// <summary>
	/// Make a checkerboard pattern where the black squares are transparent.
	/// The pattern is aligned with the camera, and centered by default.
	/// </summary>
	public virtual int GetCheckerboard()
	{
		return vtkImageProperty_GetCheckerboard_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageProperty_GetCheckerboardOffset_14(HandleRef pThis);

	/// <summary>
	/// The phase offset for checkerboarding, in units of spacing.  Use a
	/// value between -1 and +1, where 1 is an offset of one squares.
	/// </summary>
	public virtual double[] GetCheckerboardOffset()
	{
		IntPtr intPtr = vtkImageProperty_GetCheckerboardOffset_14(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_GetCheckerboardOffset_15(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// The phase offset for checkerboarding, in units of spacing.  Use a
	/// value between -1 and +1, where 1 is an offset of one squares.
	/// </summary>
	public virtual void GetCheckerboardOffset(ref double _arg1, ref double _arg2)
	{
		vtkImageProperty_GetCheckerboardOffset_15(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_GetCheckerboardOffset_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The phase offset for checkerboarding, in units of spacing.  Use a
	/// value between -1 and +1, where 1 is an offset of one squares.
	/// </summary>
	public virtual void GetCheckerboardOffset(IntPtr _arg)
	{
		vtkImageProperty_GetCheckerboardOffset_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageProperty_GetCheckerboardSpacing_17(HandleRef pThis);

	/// <summary>
	/// The spacing for checkerboarding.  This is in real units, not pixels.
	/// </summary>
	public virtual double[] GetCheckerboardSpacing()
	{
		IntPtr intPtr = vtkImageProperty_GetCheckerboardSpacing_17(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_GetCheckerboardSpacing_18(HandleRef pThis, ref double _arg1, ref double _arg2);

	/// <summary>
	/// The spacing for checkerboarding.  This is in real units, not pixels.
	/// </summary>
	public virtual void GetCheckerboardSpacing(ref double _arg1, ref double _arg2)
	{
		vtkImageProperty_GetCheckerboardSpacing_18(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_GetCheckerboardSpacing_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The spacing for checkerboarding.  This is in real units, not pixels.
	/// </summary>
	public virtual void GetCheckerboardSpacing(IntPtr _arg)
	{
		vtkImageProperty_GetCheckerboardSpacing_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetColorLevel_20(HandleRef pThis);

	/// <summary>
	/// The level value for window/level.
	/// </summary>
	public virtual double GetColorLevel()
	{
		return vtkImageProperty_GetColorLevel_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetColorWindow_21(HandleRef pThis);

	/// <summary>
	/// The window value for window/level.
	/// </summary>
	public virtual double GetColorWindow()
	{
		return vtkImageProperty_GetColorWindow_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetDiffuse_22(HandleRef pThis);

	/// <summary>
	/// The diffuse lighting coefficient.  The default is 0.0.
	/// </summary>
	public virtual double GetDiffuse()
	{
		return vtkImageProperty_GetDiffuse_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetDiffuseMaxValue_23(HandleRef pThis);

	/// <summary>
	/// The diffuse lighting coefficient.  The default is 0.0.
	/// </summary>
	public virtual double GetDiffuseMaxValue()
	{
		return vtkImageProperty_GetDiffuseMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetDiffuseMinValue_24(HandleRef pThis);

	/// <summary>
	/// The diffuse lighting coefficient.  The default is 0.0.
	/// </summary>
	public virtual double GetDiffuseMinValue()
	{
		return vtkImageProperty_GetDiffuseMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_GetInterpolationType_25(HandleRef pThis);

	/// <summary>
	/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
	/// </summary>
	public virtual int GetInterpolationType()
	{
		return vtkImageProperty_GetInterpolationType_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageProperty_GetInterpolationTypeAsString_26(HandleRef pThis);

	/// <summary>
	/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
	/// </summary>
	public virtual string GetInterpolationTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageProperty_GetInterpolationTypeAsString_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_GetInterpolationTypeMaxValue_27(HandleRef pThis);

	/// <summary>
	/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
	/// </summary>
	public virtual int GetInterpolationTypeMaxValue()
	{
		return vtkImageProperty_GetInterpolationTypeMaxValue_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_GetInterpolationTypeMinValue_28(HandleRef pThis);

	/// <summary>
	/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
	/// </summary>
	public virtual int GetInterpolationTypeMinValue()
	{
		return vtkImageProperty_GetInterpolationTypeMinValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_GetLayerNumber_29(HandleRef pThis);

	/// <summary>
	/// Set the layer number.  This is ignored unless the image is part
	/// of a vtkImageStack.  The default layer number is zero.
	/// </summary>
	public int GetLayerNumber()
	{
		return vtkImageProperty_GetLayerNumber_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageProperty_GetLookupTable_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a lookup table for the data.  If the data is
	/// to be displayed as greyscale, or if the input data is
	/// already RGB, there is no need to set a lookup table.
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageProperty_GetLookupTable_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageProperty_GetMTime_31(HandleRef pThis);

	/// <summary>
	/// Get the MTime for this property.  If the lookup table is set,
	/// the mtime will include the mtime of the lookup table.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageProperty_GetMTime_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageProperty_GetNumberOfGenerationsFromBase_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageProperty_GetNumberOfGenerationsFromBase_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageProperty_GetNumberOfGenerationsFromBaseType_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageProperty_GetNumberOfGenerationsFromBaseType_33(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetOpacity_34(HandleRef pThis);

	/// <summary>
	/// The opacity of the image, where 1.0 is opaque and 0.0 is
	/// transparent.  If the image has an alpha component, then
	/// the alpha component will be multiplied by this value.
	/// The default is 1.0.
	/// </summary>
	public virtual double GetOpacity()
	{
		return vtkImageProperty_GetOpacity_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetOpacityMaxValue_35(HandleRef pThis);

	/// <summary>
	/// The opacity of the image, where 1.0 is opaque and 0.0 is
	/// transparent.  If the image has an alpha component, then
	/// the alpha component will be multiplied by this value.
	/// The default is 1.0.
	/// </summary>
	public virtual double GetOpacityMaxValue()
	{
		return vtkImageProperty_GetOpacityMaxValue_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageProperty_GetOpacityMinValue_36(HandleRef pThis);

	/// <summary>
	/// The opacity of the image, where 1.0 is opaque and 0.0 is
	/// transparent.  If the image has an alpha component, then
	/// the alpha component will be multiplied by this value.
	/// The default is 1.0.
	/// </summary>
	public virtual double GetOpacityMinValue()
	{
		return vtkImageProperty_GetOpacityMinValue_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_GetUseLookupTableScalarRange_37(HandleRef pThis);

	/// <summary>
	/// Use the range that is set in the lookup table, instead
	/// of setting the range from the Window/Level settings.
	/// This is off by default.
	/// </summary>
	public virtual int GetUseLookupTableScalarRange()
	{
		return vtkImageProperty_GetUseLookupTableScalarRange_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_IsA_38(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageProperty_IsA_38(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageProperty_IsTypeOf_39(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageProperty_IsTypeOf_39(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageProperty_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageProperty NewInstance()
	{
		vtkImageProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageProperty_NewInstance_41(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageProperty_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageProperty SafeDownCast(vtkObjectBase o)
	{
		vtkImageProperty vtkImageProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageProperty_SafeDownCast_42(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageProperty2 = (vtkImageProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageProperty2.Register(null);
			}
		}
		return vtkImageProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetAmbient_43(HandleRef pThis, double _arg);

	/// <summary>
	/// The ambient lighting coefficient.  The default is 1.0.
	/// </summary>
	public virtual void SetAmbient(double _arg)
	{
		vtkImageProperty_SetAmbient_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetBacking_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Use an opaque backing polygon, which will be visible where the image
	/// is translucent.  When images are in a stack, the backing polygons
	/// for all images will be drawn before any of the images in the stack,
	/// in order to allow the images in the stack to be composited.
	/// </summary>
	public virtual void SetBacking(int _arg)
	{
		vtkImageProperty_SetBacking_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetBackingColor_45(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set the color of the backing polygon.  The default color is black.
	/// </summary>
	public virtual void SetBackingColor(double _arg1, double _arg2, double _arg3)
	{
		vtkImageProperty_SetBackingColor_45(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetBackingColor_46(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color of the backing polygon.  The default color is black.
	/// </summary>
	public virtual void SetBackingColor(IntPtr _arg)
	{
		vtkImageProperty_SetBackingColor_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetCheckerboard_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Make a checkerboard pattern where the black squares are transparent.
	/// The pattern is aligned with the camera, and centered by default.
	/// </summary>
	public virtual void SetCheckerboard(int _arg)
	{
		vtkImageProperty_SetCheckerboard_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetCheckerboardOffset_48(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// The phase offset for checkerboarding, in units of spacing.  Use a
	/// value between -1 and +1, where 1 is an offset of one squares.
	/// </summary>
	public virtual void SetCheckerboardOffset(double _arg1, double _arg2)
	{
		vtkImageProperty_SetCheckerboardOffset_48(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetCheckerboardOffset_49(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The phase offset for checkerboarding, in units of spacing.  Use a
	/// value between -1 and +1, where 1 is an offset of one squares.
	/// </summary>
	public void SetCheckerboardOffset(IntPtr _arg)
	{
		vtkImageProperty_SetCheckerboardOffset_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetCheckerboardSpacing_50(HandleRef pThis, double _arg1, double _arg2);

	/// <summary>
	/// The spacing for checkerboarding.  This is in real units, not pixels.
	/// </summary>
	public virtual void SetCheckerboardSpacing(double _arg1, double _arg2)
	{
		vtkImageProperty_SetCheckerboardSpacing_50(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetCheckerboardSpacing_51(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// The spacing for checkerboarding.  This is in real units, not pixels.
	/// </summary>
	public void SetCheckerboardSpacing(IntPtr _arg)
	{
		vtkImageProperty_SetCheckerboardSpacing_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetColorLevel_52(HandleRef pThis, double _arg);

	/// <summary>
	/// The level value for window/level.
	/// </summary>
	public virtual void SetColorLevel(double _arg)
	{
		vtkImageProperty_SetColorLevel_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetColorWindow_53(HandleRef pThis, double _arg);

	/// <summary>
	/// The window value for window/level.
	/// </summary>
	public virtual void SetColorWindow(double _arg)
	{
		vtkImageProperty_SetColorWindow_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetDiffuse_54(HandleRef pThis, double _arg);

	/// <summary>
	/// The diffuse lighting coefficient.  The default is 0.0.
	/// </summary>
	public virtual void SetDiffuse(double _arg)
	{
		vtkImageProperty_SetDiffuse_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetInterpolationType_55(HandleRef pThis, int _arg);

	/// <summary>
	/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
	/// </summary>
	public virtual void SetInterpolationType(int _arg)
	{
		vtkImageProperty_SetInterpolationType_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetInterpolationTypeToCubic_56(HandleRef pThis);

	/// <summary>
	/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
	/// </summary>
	public void SetInterpolationTypeToCubic()
	{
		vtkImageProperty_SetInterpolationTypeToCubic_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetInterpolationTypeToLinear_57(HandleRef pThis);

	/// <summary>
	/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
	/// </summary>
	public void SetInterpolationTypeToLinear()
	{
		vtkImageProperty_SetInterpolationTypeToLinear_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetInterpolationTypeToNearest_58(HandleRef pThis);

	/// <summary>
	/// The interpolation type (default: VTK_LINEAR_INTERPOLATION).
	/// </summary>
	public void SetInterpolationTypeToNearest()
	{
		vtkImageProperty_SetInterpolationTypeToNearest_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetLayerNumber_59(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the layer number.  This is ignored unless the image is part
	/// of a vtkImageStack.  The default layer number is zero.
	/// </summary>
	public virtual void SetLayerNumber(int _arg)
	{
		vtkImageProperty_SetLayerNumber_59(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetLookupTable_60(HandleRef pThis, HandleRef lut);

	/// <summary>
	/// Specify a lookup table for the data.  If the data is
	/// to be displayed as greyscale, or if the input data is
	/// already RGB, there is no need to set a lookup table.
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors lut)
	{
		vtkImageProperty_SetLookupTable_60(GetCppThis(), lut?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetOpacity_61(HandleRef pThis, double _arg);

	/// <summary>
	/// The opacity of the image, where 1.0 is opaque and 0.0 is
	/// transparent.  If the image has an alpha component, then
	/// the alpha component will be multiplied by this value.
	/// The default is 1.0.
	/// </summary>
	public virtual void SetOpacity(double _arg)
	{
		vtkImageProperty_SetOpacity_61(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_SetUseLookupTableScalarRange_62(HandleRef pThis, int _arg);

	/// <summary>
	/// Use the range that is set in the lookup table, instead
	/// of setting the range from the Window/Level settings.
	/// This is off by default.
	/// </summary>
	public virtual void SetUseLookupTableScalarRange(int _arg)
	{
		vtkImageProperty_SetUseLookupTableScalarRange_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_UseLookupTableScalarRangeOff_63(HandleRef pThis);

	/// <summary>
	/// Use the range that is set in the lookup table, instead
	/// of setting the range from the Window/Level settings.
	/// This is off by default.
	/// </summary>
	public virtual void UseLookupTableScalarRangeOff()
	{
		vtkImageProperty_UseLookupTableScalarRangeOff_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageProperty_UseLookupTableScalarRangeOn_64(HandleRef pThis);

	/// <summary>
	/// Use the range that is set in the lookup table, instead
	/// of setting the range from the Window/Level settings.
	/// This is off by default.
	/// </summary>
	public virtual void UseLookupTableScalarRangeOn()
	{
		vtkImageProperty_UseLookupTableScalarRangeOn_64(GetCppThis());
	}
}
