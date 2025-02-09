using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextActor
/// </summary>
/// <remarks>
///    An actor that displays text. Scaled or unscaled
///
/// vtkTextActor can be used to place text annotation into a window.
/// When TextScaleMode is NONE, the text is fixed font and operation is
/// the same as a vtkPolyDataMapper2D/vtkActor2D pair.
/// When TextScaleMode is VIEWPORT, the font resizes such that it maintains a
/// consistent size relative to the viewport in which it is rendered.
/// When TextScaleMode is PROP, the font resizes such that the text fits inside
/// the box defined by the position 1 &amp; 2 coordinates. This class replaces the
/// deprecated vtkScaledTextActor and acts as a convenient wrapper for
/// a vtkTextMapper/vtkActor2D pair.
/// Set the text property/attributes through the vtkTextProperty associated to
/// this actor.
///
/// </remarks>
/// <seealso>
///
/// vtkActor2D vtkPolyDataMapper vtkTextProperty vtkTextRenderer
/// </seealso>
public class vtkTextActor : vtkTexturedActor2D
{
	/// <summary>
	/// Set how text should be scaled.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
	/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
	/// the text will be scaled to fit exactly in the prop as specified by the
	/// position 1 &amp; 2 coordinates.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
	/// the size of the viewport it is displayed in.
	/// </summary>
	public enum TEXT_SCALE_MODE_NONE_WrapperEnum
	{
		/// <summary>enum member</summary>
		TEXT_SCALE_MODE_NONE,
		/// <summary>enum member</summary>
		TEXT_SCALE_MODE_PROP,
		/// <summary>enum member</summary>
		TEXT_SCALE_MODE_VIEWPORT
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextActor()
	{
		MRClassNameKey = "class vtkTextActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate object with a rectangle in normaled view coordinates
	/// of (0.2,0.85, 0.8, 0.95).
	/// </summary>
	public new static vtkTextActor New()
	{
		vtkTextActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate object with a rectangle in normaled view coordinates
	/// of (0.2,0.85, 0.8, 0.95).
	/// </summary>
	public vtkTextActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTextActor_ComputeScaledFont_01(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Compute the scale the font should be given the viewport.  The result
	/// is placed in the ScaledTextProperty ivar.
	/// </summary>
	public virtual void ComputeScaledFont(vtkViewport viewport)
	{
		vtkTextActor_ComputeScaledFont_01(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_DisplayToSpecified_02(HandleRef pThis, IntPtr pos, HandleRef vport, int specified);

	/// <summary>
	/// This is just a simple coordinate conversion method used in the render
	/// process.
	/// </summary>
	public void DisplayToSpecified(IntPtr pos, vtkViewport vport, int specified)
	{
		vtkTextActor_DisplayToSpecified_02(GetCppThis(), pos, vport?.GetCppThis() ?? default(HandleRef), specified);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_GetAlignmentPoint_03(HandleRef pThis);

	/// <summary>
	/// This method is being deprecated.  Use SetJustification and
	/// SetVerticalJustification in text property instead.
	/// Set/Get the Alignment point
	/// if zero (default), the text aligns itself to the bottom left corner
	/// (which is defined by the PositionCoordinate)
	/// otherwise the text aligns itself to corner/midpoint or centre
	/// @verbatim
	/// 6   7   8
	/// 3   4   5
	/// 0   1   2
	/// @endverbatim
	/// This is the same as setting the TextProperty's justification.
	/// Currently TextActor is not oriented around its AlignmentPoint.
	/// </summary>
	public int GetAlignmentPoint()
	{
		return vtkTextActor_GetAlignmentPoint_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_GetBoundingBox_04(HandleRef pThis, HandleRef vport, IntPtr bbox);

	/// <summary>
	/// Return the bounding box coordinates of the text in pixels.
	/// The bbox array is populated with [ xmin, xmax, ymin, ymax ]
	/// values in that order.
	/// </summary>
	public virtual void GetBoundingBox(vtkViewport vport, IntPtr bbox)
	{
		vtkTextActor_GetBoundingBox_04(GetCppThis(), vport?.GetCppThis() ?? default(HandleRef), bbox);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkTextActor_GetFontScale_05(HandleRef viewport);

	/// <summary>
	/// Provide a font scaling based on a viewport.  This is the scaling factor
	/// used when the TextScaleMode is set to VIEWPORT and has been made public for
	/// other components to use.  This scaling assumes that the long dimension of
	/// the viewport is meant to be 6 inches (a typical width of text in a paper)
	/// and then resizes based on if that long dimension was 72 DPI.
	/// </summary>
	public static float GetFontScale(vtkViewport viewport)
	{
		return vtkTextActor_GetFontScale_05(viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor_GetInput_06(HandleRef pThis);

	/// <summary>
	/// Set the text string to be displayed. "\n" is recognized
	/// as a carriage return/linefeed (line separator).
	/// The characters must be in the UTF-8 encoding.
	/// Convenience method to the underlying mapper
	/// </summary>
	public string GetInput()
	{
		return Marshal.PtrToStringAnsi(vtkTextActor_GetInput_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkTextActor_GetMaximumLineHeight_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum height of a line of text as a
	/// percentage of the vertical area allocated to this
	/// scaled text actor. Defaults to 1.0.
	/// Only valid when TextScaleMode is PROP.
	/// </summary>
	public virtual float GetMaximumLineHeight()
	{
		return vtkTextActor_GetMaximumLineHeight_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor_GetMinimumSize_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the minimum size in pixels for this actor.
	/// Defaults to 10,10.
	/// Only valid when TextScaleMode is PROP.
	/// </summary>
	public virtual int[] GetMinimumSize()
	{
		IntPtr intPtr = vtkTextActor_GetMinimumSize_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_GetMinimumSize_09(HandleRef pThis, ref int _arg1, ref int _arg2);

	/// <summary>
	/// Set/Get the minimum size in pixels for this actor.
	/// Defaults to 10,10.
	/// Only valid when TextScaleMode is PROP.
	/// </summary>
	public virtual void GetMinimumSize(ref int _arg1, ref int _arg2)
	{
		vtkTextActor_GetMinimumSize_09(GetCppThis(), ref _arg1, ref _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_GetMinimumSize_10(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the minimum size in pixels for this actor.
	/// Defaults to 10,10.
	/// Only valid when TextScaleMode is PROP.
	/// </summary>
	public virtual void GetMinimumSize(IntPtr _arg)
	{
		vtkTextActor_GetMinimumSize_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextActor_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextActor_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextActor_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextActor_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkTextActor_GetOrientation_13(HandleRef pThis);

	/// <summary>
	/// Counterclockwise rotation around the Alignment point.
	/// Units are in degrees and defaults to 0.
	/// The orientation in the text property rotates the text in the
	/// texture map.  It will proba ly not give you the effect you
	/// desire.
	/// </summary>
	public virtual float GetOrientation()
	{
		return vtkTextActor_GetOrientation_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor_GetScaledTextProperty_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the scaled font.  Use ComputeScaledFont to set the scale for a given
	/// viewport.
	/// </summary>
	public virtual vtkTextProperty GetScaledTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor_GetScaledTextProperty_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_GetSize_15(HandleRef pThis, HandleRef vport, IntPtr size);

	/// <summary>
	/// Syntactic sugar to get the size of text instead of the entire bounding box.
	/// </summary>
	public virtual void GetSize(vtkViewport vport, IntPtr size)
	{
		vtkTextActor_GetSize_15(GetCppThis(), vport?.GetCppThis() ?? default(HandleRef), size);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor_GetTextProperty_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual vtkTextProperty GetTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor_GetTextProperty_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_GetTextScaleMode_17(HandleRef pThis);

	/// <summary>
	/// Set how text should be scaled.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
	/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
	/// the text will be scaled to fit exactly in the prop as specified by the
	/// position 1 &amp; 2 coordinates.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
	/// the size of the viewport it is displayed in.
	/// </summary>
	public virtual int GetTextScaleMode()
	{
		return vtkTextActor_GetTextScaleMode_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_GetTextScaleModeMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set how text should be scaled.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
	/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
	/// the text will be scaled to fit exactly in the prop as specified by the
	/// position 1 &amp; 2 coordinates.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
	/// the size of the viewport it is displayed in.
	/// </summary>
	public virtual int GetTextScaleModeMaxValue()
	{
		return vtkTextActor_GetTextScaleModeMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_GetTextScaleModeMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set how text should be scaled.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
	/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
	/// the text will be scaled to fit exactly in the prop as specified by the
	/// position 1 &amp; 2 coordinates.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
	/// the size of the viewport it is displayed in.
	/// </summary>
	public virtual int GetTextScaleModeMinValue()
	{
		return vtkTextActor_GetTextScaleModeMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_GetUseBorderAlign_20(HandleRef pThis);

	/// <summary>
	/// Turn on or off the UseBorderAlign option.
	/// When UseBorderAlign is on, the bounding rectangle is used to align the text,
	/// which is the proper behavior when using vtkTextRepresentation
	/// </summary>
	public virtual int GetUseBorderAlign()
	{
		return vtkTextActor_GetUseBorderAlign_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_HasTranslucentPolygonalGeometry_21(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkTextActor_HasTranslucentPolygonalGeometry_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextActor_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextActor_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextActor NewInstance()
	{
		vtkTextActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_ReleaseGraphicsResources_26(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTextActor_ReleaseGraphicsResources_26(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_RenderOpaqueGeometry_27(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the text actor to the screen.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkTextActor_RenderOpaqueGeometry_27(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_RenderOverlay_28(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the text actor to the screen.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkTextActor_RenderOverlay_28(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_RenderTranslucentPolygonalGeometry_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the text actor to the screen.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkTextActor_RenderTranslucentPolygonalGeometry_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextActor_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextActor SafeDownCast(vtkObjectBase o)
	{
		vtkTextActor vtkTextActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextActor_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextActor2 = (vtkTextActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextActor2.Register(null);
			}
		}
		return vtkTextActor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetAlignmentPoint_31(HandleRef pThis, int point);

	/// <summary>
	/// This method is being deprecated.  Use SetJustification and
	/// SetVerticalJustification in text property instead.
	/// Set/Get the Alignment point
	/// if zero (default), the text aligns itself to the bottom left corner
	/// (which is defined by the PositionCoordinate)
	/// otherwise the text aligns itself to corner/midpoint or centre
	/// @verbatim
	/// 6   7   8
	/// 3   4   5
	/// 0   1   2
	/// @endverbatim
	/// This is the same as setting the TextProperty's justification.
	/// Currently TextActor is not oriented around its AlignmentPoint.
	/// </summary>
	public void SetAlignmentPoint(int point)
	{
		vtkTextActor_SetAlignmentPoint_31(GetCppThis(), point);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_SetConstrainedFontSize_32(HandleRef pThis, HandleRef arg0, int targetWidth, int targetHeight);

	/// <summary>
	/// Set and return the font size required to make this mapper fit in a given
	/// target rectangle (width x height, in pixels). A static version of the
	/// method is also available for convenience to other classes (e.g., widgets).
	/// </summary>
	public virtual int SetConstrainedFontSize(vtkViewport arg0, int targetWidth, int targetHeight)
	{
		return vtkTextActor_SetConstrainedFontSize_32(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), targetWidth, targetHeight);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextActor_SetConstrainedFontSize_33(HandleRef arg0, HandleRef arg1, int targetWidth, int targetHeight);

	/// <summary>
	/// Set and return the font size required to make this mapper fit in a given
	/// target rectangle (width x height, in pixels). A static version of the
	/// method is also available for convenience to other classes (e.g., widgets).
	/// </summary>
	public static int SetConstrainedFontSize(vtkTextActor arg0, vtkViewport arg1, int targetWidth, int targetHeight)
	{
		return vtkTextActor_SetConstrainedFontSize_33(arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef), targetWidth, targetHeight);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetInput_34(HandleRef pThis, string inputString);

	/// <summary>
	/// Set the text string to be displayed. "\n" is recognized
	/// as a carriage return/linefeed (line separator).
	/// The characters must be in the UTF-8 encoding.
	/// Convenience method to the underlying mapper
	/// </summary>
	public void SetInput(string inputString)
	{
		vtkTextActor_SetInput_34(GetCppThis(), inputString);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetMaximumLineHeight_35(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the maximum height of a line of text as a
	/// percentage of the vertical area allocated to this
	/// scaled text actor. Defaults to 1.0.
	/// Only valid when TextScaleMode is PROP.
	/// </summary>
	public virtual void SetMaximumLineHeight(float _arg)
	{
		vtkTextActor_SetMaximumLineHeight_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetMinimumSize_36(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set/Get the minimum size in pixels for this actor.
	/// Defaults to 10,10.
	/// Only valid when TextScaleMode is PROP.
	/// </summary>
	public virtual void SetMinimumSize(int _arg1, int _arg2)
	{
		vtkTextActor_SetMinimumSize_36(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetMinimumSize_37(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the minimum size in pixels for this actor.
	/// Defaults to 10,10.
	/// Only valid when TextScaleMode is PROP.
	/// </summary>
	public void SetMinimumSize(IntPtr _arg)
	{
		vtkTextActor_SetMinimumSize_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetNonLinearFontScale_38(HandleRef pThis, double exponent, int target);

	/// <summary>
	/// Enable non-linear scaling of font sizes. This is useful in combination
	/// with scaled text. With small windows you want to use the entire scaled
	/// text area. With larger windows you want to reduce the font size some so
	/// that the entire area is not used. These values modify the computed font
	/// size as follows:
	/// newFontSize = pow(FontSize,exponent)*pow(target,1.0 - exponent)
	/// typically exponent should be around 0.7 and target should be around 10
	/// </summary>
	public virtual void SetNonLinearFontScale(double exponent, int target)
	{
		vtkTextActor_SetNonLinearFontScale_38(GetCppThis(), exponent, target);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetOrientation_39(HandleRef pThis, float orientation);

	/// <summary>
	/// Counterclockwise rotation around the Alignment point.
	/// Units are in degrees and defaults to 0.
	/// The orientation in the text property rotates the text in the
	/// texture map.  It will proba ly not give you the effect you
	/// desire.
	/// </summary>
	public void SetOrientation(float orientation)
	{
		vtkTextActor_SetOrientation_39(GetCppThis(), orientation);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetTextProperty_40(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual void SetTextProperty(vtkTextProperty p)
	{
		vtkTextActor_SetTextProperty_40(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetTextScaleMode_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Set how text should be scaled.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
	/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
	/// the text will be scaled to fit exactly in the prop as specified by the
	/// position 1 &amp; 2 coordinates.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
	/// the size of the viewport it is displayed in.
	/// </summary>
	public virtual void SetTextScaleMode(int _arg)
	{
		vtkTextActor_SetTextScaleMode_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetTextScaleModeToNone_42(HandleRef pThis);

	/// <summary>
	/// Set how text should be scaled.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
	/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
	/// the text will be scaled to fit exactly in the prop as specified by the
	/// position 1 &amp; 2 coordinates.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
	/// the size of the viewport it is displayed in.
	/// </summary>
	public void SetTextScaleModeToNone()
	{
		vtkTextActor_SetTextScaleModeToNone_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetTextScaleModeToProp_43(HandleRef pThis);

	/// <summary>
	/// Set how text should be scaled.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
	/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
	/// the text will be scaled to fit exactly in the prop as specified by the
	/// position 1 &amp; 2 coordinates.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
	/// the size of the viewport it is displayed in.
	/// </summary>
	public void SetTextScaleModeToProp()
	{
		vtkTextActor_SetTextScaleModeToProp_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetTextScaleModeToViewport_44(HandleRef pThis);

	/// <summary>
	/// Set how text should be scaled.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_NONE, the font size will be fixed by the
	/// size given in TextProperty.  If set to vtkTextActor::TEXT_SCALE_MODE_PROP,
	/// the text will be scaled to fit exactly in the prop as specified by the
	/// position 1 &amp; 2 coordinates.  If set to
	/// vtkTextActor::TEXT_SCALE_MODE_VIEWPORT, the text will be scaled based on
	/// the size of the viewport it is displayed in.
	/// </summary>
	public void SetTextScaleModeToViewport()
	{
		vtkTextActor_SetTextScaleModeToViewport_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SetUseBorderAlign_45(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on or off the UseBorderAlign option.
	/// When UseBorderAlign is on, the bounding rectangle is used to align the text,
	/// which is the proper behavior when using vtkTextRepresentation
	/// </summary>
	public virtual void SetUseBorderAlign(int _arg)
	{
		vtkTextActor_SetUseBorderAlign_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_ShallowCopy_46(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this text actor. Overloads the virtual
	/// vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkTextActor_ShallowCopy_46(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_SpecifiedToDisplay_47(HandleRef pThis, IntPtr pos, HandleRef vport, int specified);

	/// <summary>
	/// This is just a simple coordinate conversion method used in the render
	/// process.
	/// </summary>
	public void SpecifiedToDisplay(IntPtr pos, vtkViewport vport, int specified)
	{
		vtkTextActor_SpecifiedToDisplay_47(GetCppThis(), pos, vport?.GetCppThis() ?? default(HandleRef), specified);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_UseBorderAlignOff_48(HandleRef pThis);

	/// <summary>
	/// Turn on or off the UseBorderAlign option.
	/// When UseBorderAlign is on, the bounding rectangle is used to align the text,
	/// which is the proper behavior when using vtkTextRepresentation
	/// </summary>
	public virtual void UseBorderAlignOff()
	{
		vtkTextActor_UseBorderAlignOff_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextActor_UseBorderAlignOn_49(HandleRef pThis);

	/// <summary>
	/// Turn on or off the UseBorderAlign option.
	/// When UseBorderAlign is on, the bounding rectangle is used to align the text,
	/// which is the proper behavior when using vtkTextRepresentation
	/// </summary>
	public virtual void UseBorderAlignOn()
	{
		vtkTextActor_UseBorderAlignOn_49(GetCppThis());
	}
}
