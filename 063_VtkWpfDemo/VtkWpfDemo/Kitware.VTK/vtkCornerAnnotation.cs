using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCornerAnnotation
/// </summary>
/// <remarks>
///    text annotation in four corners
///
/// This is an annotation object that manages four text actors / mappers
/// to provide annotation in the four corners of a viewport
///
/// @par Special input text::
/// - &lt;tt&gt;\&lt;image\&gt;&lt;/tt&gt; : will be replaced with slice number (relative number)
/// - &lt;tt&gt;\&lt;slice\&gt;&lt;/tt&gt; : will be replaced with slice number (relative number)
/// - &lt;tt&gt;\&lt;image_and_max\&gt;&lt;/tt&gt; : will be replaced with slice number and slice max (relative)
/// - &lt;tt&gt;\&lt;slice_and_max\&gt;&lt;/tt&gt; : will be replaced with slice number and slice max (relative)
/// - &lt;tt&gt;\&lt;slice_pos\&gt;&lt;/tt&gt; : will be replaced by the position of the current slice
/// - &lt;tt&gt;\&lt;window\&gt;&lt;/tt&gt; : will be replaced with window value
/// - &lt;tt&gt;\&lt;level\&gt;&lt;/tt&gt; : will be replaced with level value
/// - &lt;tt&gt;\&lt;window_level\&gt;&lt;/tt&gt; : will be replaced with window and level value
///
/// </remarks>
/// <seealso>
///
/// vtkActor2D vtkTextMapper
/// </seealso>
public class vtkCornerAnnotation : vtkActor2D
{
	/// <summary>
	/// Position used to get or set the corner annotation text.
	/// \sa GetText(), SetText()
	/// </summary>
	public enum TextPosition
	{
		/// <summary>enum member</summary>
		LeftEdge = 6,
		/// <summary>enum member</summary>
		LowerEdge = 4,
		/// <summary>enum member</summary>
		LowerLeft = 0,
		/// <summary>enum member</summary>
		LowerRight = 1,
		/// <summary>enum member</summary>
		RightEdge = 5,
		/// <summary>enum member</summary>
		UpperEdge = 7,
		/// <summary>enum member</summary>
		UpperLeft = 2,
		/// <summary>enum member</summary>
		UpperRight = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCornerAnnotation";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCornerAnnotation()
	{
		MRClassNameKey = "class vtkCornerAnnotation";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCornerAnnotation"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCornerAnnotation(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCornerAnnotation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with a rectangle in normaled view coordinates
	/// of (0.2,0.85, 0.8, 0.95).
	/// </summary>
	public new static vtkCornerAnnotation New()
	{
		vtkCornerAnnotation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCornerAnnotation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with a rectangle in normaled view coordinates
	/// of (0.2,0.85, 0.8, 0.95).
	/// </summary>
	public vtkCornerAnnotation()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCornerAnnotation_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_ClearAllTexts_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the text to be displayed for each corner
	/// \sa TextPosition
	/// </summary>
	public void ClearAllTexts()
	{
		vtkCornerAnnotation_ClearAllTexts_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_CopyAllTextsFrom_02(HandleRef pThis, HandleRef ca);

	/// <summary>
	/// Set/Get the text to be displayed for each corner
	/// \sa TextPosition
	/// </summary>
	public void CopyAllTextsFrom(vtkCornerAnnotation ca)
	{
		vtkCornerAnnotation_CopyAllTextsFrom_02(GetCppThis(), ca?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCornerAnnotation_GetImageActor_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set an image actor to look at for slice information
	/// </summary>
	public virtual vtkImageActor GetImageActor()
	{
		vtkImageActor vtkImageActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCornerAnnotation_GetImageActor_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageActor2 = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageActor2.Register(null);
			}
		}
		return vtkImageActor2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCornerAnnotation_GetLevelScale_04(HandleRef pThis);

	/// <summary>
	/// Set the value to scale the level by.
	/// </summary>
	public virtual double GetLevelScale()
	{
		return vtkCornerAnnotation_GetLevelScale_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCornerAnnotation_GetLevelShift_05(HandleRef pThis);

	/// <summary>
	/// Set the value to shift the level by.
	/// </summary>
	public virtual double GetLevelShift()
	{
		return vtkCornerAnnotation_GetLevelShift_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCornerAnnotation_GetLinearFontScaleFactor_06(HandleRef pThis);

	/// <summary>
	/// Set/Get font scaling factors
	/// The font size, f, is calculated as the largest possible value
	/// such that the annotations for the given viewport do not overlap.
	/// This font size is scaled non-linearly with the viewport size,
	/// to maintain an acceptable readable size at larger viewport sizes,
	/// without being too big.
	/// f' = linearScale * pow(f,nonlinearScale)
	/// </summary>
	public virtual double GetLinearFontScaleFactor()
	{
		return vtkCornerAnnotation_GetLinearFontScaleFactor_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_GetMaximumFontSize_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum/maximum size font that will be shown.
	/// If the font drops below the minimum size it will not be rendered.
	/// </summary>
	public virtual int GetMaximumFontSize()
	{
		return vtkCornerAnnotation_GetMaximumFontSize_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCornerAnnotation_GetMaximumLineHeight_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum height of a line of text as a
	/// percentage of the vertical area allocated to this
	/// scaled text actor. Defaults to 1.0
	/// </summary>
	public virtual double GetMaximumLineHeight()
	{
		return vtkCornerAnnotation_GetMaximumLineHeight_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_GetMinimumFontSize_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum/maximum size font that will be shown.
	/// If the font drops below the minimum size it will not be rendered.
	/// </summary>
	public virtual int GetMinimumFontSize()
	{
		return vtkCornerAnnotation_GetMinimumFontSize_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCornerAnnotation_GetNonlinearFontScaleFactor_10(HandleRef pThis);

	/// <summary>
	/// Set/Get font scaling factors
	/// The font size, f, is calculated as the largest possible value
	/// such that the annotations for the given viewport do not overlap.
	/// This font size is scaled non-linearly with the viewport size,
	/// to maintain an acceptable readable size at larger viewport sizes,
	/// without being too big.
	/// f' = linearScale * pow(f,nonlinearScale)
	/// </summary>
	public virtual double GetNonlinearFontScaleFactor()
	{
		return vtkCornerAnnotation_GetNonlinearFontScaleFactor_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCornerAnnotation_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCornerAnnotation_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCornerAnnotation_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCornerAnnotation_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_GetShowSliceAndImage_13(HandleRef pThis);

	/// <summary>
	/// Even if there is an image actor, should `slice' and `image' be displayed?
	/// </summary>
	public virtual int GetShowSliceAndImage()
	{
		return vtkCornerAnnotation_GetShowSliceAndImage_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCornerAnnotation_GetText_14(HandleRef pThis, int i);

	/// <summary>
	/// Set/Get the text to be displayed for each corner
	/// \sa TextPosition
	/// </summary>
	public string GetText(int i)
	{
		return Marshal.PtrToStringAnsi(vtkCornerAnnotation_GetText_14(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCornerAnnotation_GetTextProperty_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property of all corners.
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCornerAnnotation_GetTextProperty_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextProperty2 = (vtkTextProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextProperty2.Register(null);
			}
		}
		return vtkTextProperty2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCornerAnnotation_GetWindowLevel_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set an instance of vtkImageMapToWindowLevelColors to use for
	/// looking at window level changes
	/// </summary>
	public virtual vtkImageMapToWindowLevelColors GetWindowLevel()
	{
		vtkImageMapToWindowLevelColors vtkImageMapToWindowLevelColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCornerAnnotation_GetWindowLevel_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMapToWindowLevelColors2 = (vtkImageMapToWindowLevelColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMapToWindowLevelColors2.Register(null);
			}
		}
		return vtkImageMapToWindowLevelColors2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_HasTranslucentPolygonalGeometry_17(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCornerAnnotation_HasTranslucentPolygonalGeometry_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCornerAnnotation_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_IsTypeOf_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCornerAnnotation_IsTypeOf_19(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCornerAnnotation_NewInstance_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCornerAnnotation NewInstance()
	{
		vtkCornerAnnotation result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCornerAnnotation_NewInstance_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_ReleaseGraphicsResources_22(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCornerAnnotation_ReleaseGraphicsResources_22(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_RenderOpaqueGeometry_23(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the scalar bar and annotation text to the screen.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkCornerAnnotation_RenderOpaqueGeometry_23(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_RenderOverlay_24(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Draw the scalar bar and annotation text to the screen.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkCornerAnnotation_RenderOverlay_24(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCornerAnnotation_RenderTranslucentPolygonalGeometry_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Draw the scalar bar and annotation text to the screen.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCornerAnnotation_RenderTranslucentPolygonalGeometry_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCornerAnnotation_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCornerAnnotation SafeDownCast(vtkObjectBase o)
	{
		vtkCornerAnnotation vtkCornerAnnotation2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCornerAnnotation_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCornerAnnotation2 = (vtkCornerAnnotation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCornerAnnotation2.Register(null);
			}
		}
		return vtkCornerAnnotation2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetImageActor_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set an image actor to look at for slice information
	/// </summary>
	public void SetImageActor(vtkImageActor arg0)
	{
		vtkCornerAnnotation_SetImageActor_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetLevelScale_28(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the value to scale the level by.
	/// </summary>
	public virtual void SetLevelScale(double _arg)
	{
		vtkCornerAnnotation_SetLevelScale_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetLevelShift_29(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the value to shift the level by.
	/// </summary>
	public virtual void SetLevelShift(double _arg)
	{
		vtkCornerAnnotation_SetLevelShift_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetLinearFontScaleFactor_30(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get font scaling factors
	/// The font size, f, is calculated as the largest possible value
	/// such that the annotations for the given viewport do not overlap.
	/// This font size is scaled non-linearly with the viewport size,
	/// to maintain an acceptable readable size at larger viewport sizes,
	/// without being too big.
	/// f' = linearScale * pow(f,nonlinearScale)
	/// </summary>
	public virtual void SetLinearFontScaleFactor(double _arg)
	{
		vtkCornerAnnotation_SetLinearFontScaleFactor_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetMaximumFontSize_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the minimum/maximum size font that will be shown.
	/// If the font drops below the minimum size it will not be rendered.
	/// </summary>
	public virtual void SetMaximumFontSize(int _arg)
	{
		vtkCornerAnnotation_SetMaximumFontSize_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetMaximumLineHeight_32(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the maximum height of a line of text as a
	/// percentage of the vertical area allocated to this
	/// scaled text actor. Defaults to 1.0
	/// </summary>
	public virtual void SetMaximumLineHeight(double _arg)
	{
		vtkCornerAnnotation_SetMaximumLineHeight_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetMinimumFontSize_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the minimum/maximum size font that will be shown.
	/// If the font drops below the minimum size it will not be rendered.
	/// </summary>
	public virtual void SetMinimumFontSize(int _arg)
	{
		vtkCornerAnnotation_SetMinimumFontSize_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetNonlinearFontScaleFactor_34(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get font scaling factors
	/// The font size, f, is calculated as the largest possible value
	/// such that the annotations for the given viewport do not overlap.
	/// This font size is scaled non-linearly with the viewport size,
	/// to maintain an acceptable readable size at larger viewport sizes,
	/// without being too big.
	/// f' = linearScale * pow(f,nonlinearScale)
	/// </summary>
	public virtual void SetNonlinearFontScaleFactor(double _arg)
	{
		vtkCornerAnnotation_SetNonlinearFontScaleFactor_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetShowSliceAndImage_35(HandleRef pThis, int _arg);

	/// <summary>
	/// Even if there is an image actor, should `slice' and `image' be displayed?
	/// </summary>
	public virtual void SetShowSliceAndImage(int _arg)
	{
		vtkCornerAnnotation_SetShowSliceAndImage_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetText_36(HandleRef pThis, int i, string text);

	/// <summary>
	/// Set/Get the text to be displayed for each corner
	/// \sa TextPosition
	/// </summary>
	public void SetText(int i, string text)
	{
		vtkCornerAnnotation_SetText_36(GetCppThis(), i, text);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetTextProperty_37(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the text property of all corners.
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty p)
	{
		vtkCornerAnnotation_SetTextProperty_37(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_SetWindowLevel_38(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set an instance of vtkImageMapToWindowLevelColors to use for
	/// looking at window level changes
	/// </summary>
	public void SetWindowLevel(vtkImageMapToWindowLevelColors arg0)
	{
		vtkCornerAnnotation_SetWindowLevel_38(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_ShowSliceAndImageOff_39(HandleRef pThis);

	/// <summary>
	/// Even if there is an image actor, should `slice' and `image' be displayed?
	/// </summary>
	public virtual void ShowSliceAndImageOff()
	{
		vtkCornerAnnotation_ShowSliceAndImageOff_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCornerAnnotation_ShowSliceAndImageOn_40(HandleRef pThis);

	/// <summary>
	/// Even if there is an image actor, should `slice' and `image' be displayed?
	/// </summary>
	public virtual void ShowSliceAndImageOn()
	{
		vtkCornerAnnotation_ShowSliceAndImageOn_40(GetCppThis());
	}
}
