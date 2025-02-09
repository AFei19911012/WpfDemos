using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkCaptionActor2D
/// </summary>
/// <remarks>
///    draw text label associated with a point
///
/// vtkCaptionActor2D is a hybrid 2D/3D actor that is used to associate text
/// with a point (the AttachmentPoint) in the scene. The caption can be
/// drawn with a rectangular border and a leader connecting
/// the caption to the attachment point. Optionally, the leader can be
/// glyphed at its endpoint to create arrow heads or other indicators.
///
/// To use the caption actor, you normally specify the Position and Position2
/// coordinates (these are inherited from the vtkActor2D superclass). (Note
/// that Position2 can be set using vtkActor2D's SetWidth() and SetHeight()
/// methods.)  Position and Position2 define the size of the caption, and a
/// third point, the AttachmentPoint, defines a point that the caption is
/// associated with.  You must also define the caption text,
/// whether you want a border around the caption, and whether you want a
/// leader from the caption to the attachment point. The font attributes of
/// the text can be set through the vtkTextProperty associated to this actor.
/// You also indicate whether you want
/// the leader to be 2D or 3D. (2D leaders are always drawn over the
/// underlying geometry. 3D leaders may be occluded by the geometry.) The
/// leader may also be terminated by an optional glyph (e.g., arrow).
///
/// The trickiest part about using this class is setting Position, Position2,
/// and AttachmentPoint correctly. These instance variables are
/// vtkCoordinates, and can be set up in various ways. In default usage, the
/// AttachmentPoint is defined in the world coordinate system, Position is the
/// lower-left corner of the caption and relative to AttachmentPoint (defined
/// in display coordaintes, i.e., pixels), and Position2 is relative to
/// Position and is the upper-right corner (also in display
/// coordinates). However, the user has full control over the coordinates, and
/// can do things like place the caption in a fixed position in the renderer,
/// with the leader moving with the AttachmentPoint.
///
/// </remarks>
/// <seealso>
///
/// vtkLegendBoxActor vtkTextMapper vtkTextActor vtkTextProperty
/// vtkCoordinate
/// </seealso>
public class vtkCaptionActor2D : vtkActor2D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkCaptionActor2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkCaptionActor2D()
	{
		MRClassNameKey = "class vtkCaptionActor2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkCaptionActor2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkCaptionActor2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCaptionActor2D New()
	{
		vtkCaptionActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkCaptionActor2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkCaptionActor2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkCaptionActor2D_AttachEdgeOnlyOff_01(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether to attach the arrow only to the edge,
	/// NOT the vertices of the caption border.
	/// </summary>
	public virtual void AttachEdgeOnlyOff()
	{
		vtkCaptionActor2D_AttachEdgeOnlyOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_AttachEdgeOnlyOn_02(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether to attach the arrow only to the edge,
	/// NOT the vertices of the caption border.
	/// </summary>
	public virtual void AttachEdgeOnlyOn()
	{
		vtkCaptionActor2D_AttachEdgeOnlyOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_BorderOff_03(HandleRef pThis);

	/// <summary>
	/// Enable/disable the placement of a border around the text.
	/// </summary>
	public virtual void BorderOff()
	{
		vtkCaptionActor2D_BorderOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_BorderOn_04(HandleRef pThis);

	/// <summary>
	/// Enable/disable the placement of a border around the text.
	/// </summary>
	public virtual void BorderOn()
	{
		vtkCaptionActor2D_BorderOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetAttachEdgeOnly_05(HandleRef pThis);

	/// <summary>
	/// Enable/disable whether to attach the arrow only to the edge,
	/// NOT the vertices of the caption border.
	/// </summary>
	public virtual int GetAttachEdgeOnly()
	{
		return vtkCaptionActor2D_GetAttachEdgeOnly_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_GetAttachmentPoint_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the attachment point for the caption. By default, the attachment
	/// point is defined in world coordinates, but this can be changed using
	/// vtkCoordinate methods.
	/// </summary>
	public virtual double[] GetAttachmentPoint()
	{
		IntPtr intPtr = vtkCaptionActor2D_GetAttachmentPoint_06(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_GetAttachmentPointCoordinate_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the attachment point for the caption. By default, the attachment
	/// point is defined in world coordinates, but this can be changed using
	/// vtkCoordinate methods.
	/// </summary>
	public virtual vtkCoordinate GetAttachmentPointCoordinate()
	{
		vtkCoordinate vtkCoordinate2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionActor2D_GetAttachmentPointCoordinate_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCoordinate2 = (vtkCoordinate)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCoordinate2.Register(null);
			}
		}
		return vtkCoordinate2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetBorder_08(HandleRef pThis);

	/// <summary>
	/// Enable/disable the placement of a border around the text.
	/// </summary>
	public virtual int GetBorder()
	{
		return vtkCaptionActor2D_GetBorder_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_GetCaption_09(HandleRef pThis);

	/// <summary>
	/// Define the text to be placed in the caption. The text can be multiple
	/// lines (separated by "\n").
	/// </summary>
	public virtual string GetCaption()
	{
		return Marshal.PtrToStringAnsi(vtkCaptionActor2D_GetCaption_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_GetCaptionTextProperty_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual vtkTextProperty GetCaptionTextProperty()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionActor2D_GetCaptionTextProperty_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkCaptionActor2D_GetLeader_11(HandleRef pThis);

	/// <summary>
	/// Enable/disable drawing a "line" from the caption to the
	/// attachment point.
	/// </summary>
	public virtual int GetLeader()
	{
		return vtkCaptionActor2D_GetLeader_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_GetLeaderGlyph_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a glyph to be used as the leader "head". This could be something
	/// like an arrow or sphere. If not specified, no glyph is drawn. Note that
	/// the glyph is assumed to be aligned along the x-axis and is rotated about
	/// the origin. SetLeaderGlyphData() directly uses the polydata without
	/// setting a pipeline connection. SetLeaderGlyphConnection() sets up a
	/// pipeline connection and causes an update to the input during render.
	/// </summary>
	public virtual vtkPolyData GetLeaderGlyph()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionActor2D_GetLeaderGlyph_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCaptionActor2D_GetLeaderGlyphSize_13(HandleRef pThis);

	/// <summary>
	/// Specify the relative size of the leader head. This is expressed as a
	/// fraction of the size (diagonal length) of the renderer. The leader
	/// head is automatically scaled so that window resize, zooming or other
	/// camera motion results in proportional changes in size to the leader
	/// glyph.
	/// </summary>
	public virtual double GetLeaderGlyphSize()
	{
		return vtkCaptionActor2D_GetLeaderGlyphSize_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCaptionActor2D_GetLeaderGlyphSizeMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Specify the relative size of the leader head. This is expressed as a
	/// fraction of the size (diagonal length) of the renderer. The leader
	/// head is automatically scaled so that window resize, zooming or other
	/// camera motion results in proportional changes in size to the leader
	/// glyph.
	/// </summary>
	public virtual double GetLeaderGlyphSizeMaxValue()
	{
		return vtkCaptionActor2D_GetLeaderGlyphSizeMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkCaptionActor2D_GetLeaderGlyphSizeMinValue_15(HandleRef pThis);

	/// <summary>
	/// Specify the relative size of the leader head. This is expressed as a
	/// fraction of the size (diagonal length) of the renderer. The leader
	/// head is automatically scaled so that window resize, zooming or other
	/// camera motion results in proportional changes in size to the leader
	/// glyph.
	/// </summary>
	public virtual double GetLeaderGlyphSizeMinValue()
	{
		return vtkCaptionActor2D_GetLeaderGlyphSizeMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSize_16(HandleRef pThis);

	/// <summary>
	/// Specify the maximum size of the leader head (if any) in pixels. This
	/// is used in conjunction with LeaderGlyphSize to cap the maximum size of
	/// the LeaderGlyph.
	/// </summary>
	public virtual int GetMaximumLeaderGlyphSize()
	{
		return vtkCaptionActor2D_GetMaximumLeaderGlyphSize_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Specify the maximum size of the leader head (if any) in pixels. This
	/// is used in conjunction with LeaderGlyphSize to cap the maximum size of
	/// the LeaderGlyph.
	/// </summary>
	public virtual int GetMaximumLeaderGlyphSizeMaxValue()
	{
		return vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMinValue_18(HandleRef pThis);

	/// <summary>
	/// Specify the maximum size of the leader head (if any) in pixels. This
	/// is used in conjunction with LeaderGlyphSize to cap the maximum size of
	/// the LeaderGlyph.
	/// </summary>
	public virtual int GetMaximumLeaderGlyphSizeMinValue()
	{
		return vtkCaptionActor2D_GetMaximumLeaderGlyphSizeMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCaptionActor2D_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkCaptionActor2D_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkCaptionActor2D_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkCaptionActor2D_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetPadding_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the caption and the border. The value
	/// is specified in pixels.
	/// </summary>
	public virtual int GetPadding()
	{
		return vtkCaptionActor2D_GetPadding_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetPaddingMaxValue_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the caption and the border. The value
	/// is specified in pixels.
	/// </summary>
	public virtual int GetPaddingMaxValue()
	{
		return vtkCaptionActor2D_GetPaddingMaxValue_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetPaddingMinValue_23(HandleRef pThis);

	/// <summary>
	/// Set/Get the padding between the caption and the border. The value
	/// is specified in pixels.
	/// </summary>
	public virtual int GetPaddingMinValue()
	{
		return vtkCaptionActor2D_GetPaddingMinValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_GetTextActor_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the text actor used by the caption. This is useful if you want to control
	/// justification and other characteristics of the text actor.
	/// </summary>
	public virtual vtkTextActor GetTextActor()
	{
		vtkTextActor vtkTextActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionActor2D_GetTextActor_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_GetThreeDimensionalLeader_25(HandleRef pThis);

	/// <summary>
	/// Indicate whether the leader is 2D (no hidden line) or 3D (z-buffered).
	/// </summary>
	public virtual int GetThreeDimensionalLeader()
	{
		return vtkCaptionActor2D_GetThreeDimensionalLeader_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_HasTranslucentPolygonalGeometry_26(HandleRef pThis);

	/// <summary>
	/// Does this prop have some translucent polygonal geometry?
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkCaptionActor2D_HasTranslucentPolygonalGeometry_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkCaptionActor2D_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkCaptionActor2D_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_LeaderOff_29(HandleRef pThis);

	/// <summary>
	/// Enable/disable drawing a "line" from the caption to the
	/// attachment point.
	/// </summary>
	public virtual void LeaderOff()
	{
		vtkCaptionActor2D_LeaderOff_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_LeaderOn_30(HandleRef pThis);

	/// <summary>
	/// Enable/disable drawing a "line" from the caption to the
	/// attachment point.
	/// </summary>
	public virtual void LeaderOn()
	{
		vtkCaptionActor2D_LeaderOn_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_NewInstance_32(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkCaptionActor2D NewInstance()
	{
		vtkCaptionActor2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionActor2D_NewInstance_32(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_ReleaseGraphicsResources_33(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Release any graphics resources that are being consumed by this actor.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkCaptionActor2D_ReleaseGraphicsResources_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_RenderOpaqueGeometry_34(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the legend box to the screen.
	/// </summary>
	public override int RenderOpaqueGeometry(vtkViewport viewport)
	{
		return vtkCaptionActor2D_RenderOpaqueGeometry_34(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_RenderOverlay_35(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the legend box to the screen.
	/// </summary>
	public override int RenderOverlay(vtkViewport viewport)
	{
		return vtkCaptionActor2D_RenderOverlay_35(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkCaptionActor2D_RenderTranslucentPolygonalGeometry_36(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS.
	/// Draw the legend box to the screen.
	/// </summary>
	public override int RenderTranslucentPolygonalGeometry(vtkViewport arg0)
	{
		return vtkCaptionActor2D_RenderTranslucentPolygonalGeometry_36(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkCaptionActor2D_SafeDownCast_37(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkCaptionActor2D SafeDownCast(vtkObjectBase o)
	{
		vtkCaptionActor2D vtkCaptionActor2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkCaptionActor2D_SafeDownCast_37(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCaptionActor2D2 = (vtkCaptionActor2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCaptionActor2D2.Register(null);
			}
		}
		return vtkCaptionActor2D2;
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetAttachEdgeOnly_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable whether to attach the arrow only to the edge,
	/// NOT the vertices of the caption border.
	/// </summary>
	public virtual void SetAttachEdgeOnly(int _arg)
	{
		vtkCaptionActor2D_SetAttachEdgeOnly_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetAttachmentPoint_39(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Set/Get the attachment point for the caption. By default, the attachment
	/// point is defined in world coordinates, but this can be changed using
	/// vtkCoordinate methods.
	/// </summary>
	public virtual void SetAttachmentPoint(IntPtr x)
	{
		vtkCaptionActor2D_SetAttachmentPoint_39(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetAttachmentPoint_40(HandleRef pThis, double x, double y, double z);

	/// <summary>
	/// Set/Get the attachment point for the caption. By default, the attachment
	/// point is defined in world coordinates, but this can be changed using
	/// vtkCoordinate methods.
	/// </summary>
	public virtual void SetAttachmentPoint(double x, double y, double z)
	{
		vtkCaptionActor2D_SetAttachmentPoint_40(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetBorder_41(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable the placement of a border around the text.
	/// </summary>
	public virtual void SetBorder(int _arg)
	{
		vtkCaptionActor2D_SetBorder_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetCaption_42(HandleRef pThis, string caption);

	/// <summary>
	/// Define the text to be placed in the caption. The text can be multiple
	/// lines (separated by "\n").
	/// </summary>
	public virtual void SetCaption(string caption)
	{
		vtkCaptionActor2D_SetCaption_42(GetCppThis(), caption);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetCaptionTextProperty_43(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Set/Get the text property.
	/// </summary>
	public virtual void SetCaptionTextProperty(vtkTextProperty p)
	{
		vtkCaptionActor2D_SetCaptionTextProperty_43(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetLeader_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable/disable drawing a "line" from the caption to the
	/// attachment point.
	/// </summary>
	public virtual void SetLeader(int _arg)
	{
		vtkCaptionActor2D_SetLeader_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetLeaderGlyphConnection_45(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a glyph to be used as the leader "head". This could be something
	/// like an arrow or sphere. If not specified, no glyph is drawn. Note that
	/// the glyph is assumed to be aligned along the x-axis and is rotated about
	/// the origin. SetLeaderGlyphData() directly uses the polydata without
	/// setting a pipeline connection. SetLeaderGlyphConnection() sets up a
	/// pipeline connection and causes an update to the input during render.
	/// </summary>
	public virtual void SetLeaderGlyphConnection(vtkAlgorithmOutput arg0)
	{
		vtkCaptionActor2D_SetLeaderGlyphConnection_45(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetLeaderGlyphData_46(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a glyph to be used as the leader "head". This could be something
	/// like an arrow or sphere. If not specified, no glyph is drawn. Note that
	/// the glyph is assumed to be aligned along the x-axis and is rotated about
	/// the origin. SetLeaderGlyphData() directly uses the polydata without
	/// setting a pipeline connection. SetLeaderGlyphConnection() sets up a
	/// pipeline connection and causes an update to the input during render.
	/// </summary>
	public virtual void SetLeaderGlyphData(vtkPolyData arg0)
	{
		vtkCaptionActor2D_SetLeaderGlyphData_46(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetLeaderGlyphSize_47(HandleRef pThis, double _arg);

	/// <summary>
	/// Specify the relative size of the leader head. This is expressed as a
	/// fraction of the size (diagonal length) of the renderer. The leader
	/// head is automatically scaled so that window resize, zooming or other
	/// camera motion results in proportional changes in size to the leader
	/// glyph.
	/// </summary>
	public virtual void SetLeaderGlyphSize(double _arg)
	{
		vtkCaptionActor2D_SetLeaderGlyphSize_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetMaximumLeaderGlyphSize_48(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the maximum size of the leader head (if any) in pixels. This
	/// is used in conjunction with LeaderGlyphSize to cap the maximum size of
	/// the LeaderGlyph.
	/// </summary>
	public virtual void SetMaximumLeaderGlyphSize(int _arg)
	{
		vtkCaptionActor2D_SetMaximumLeaderGlyphSize_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetPadding_49(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the padding between the caption and the border. The value
	/// is specified in pixels.
	/// </summary>
	public virtual void SetPadding(int _arg)
	{
		vtkCaptionActor2D_SetPadding_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_SetThreeDimensionalLeader_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Indicate whether the leader is 2D (no hidden line) or 3D (z-buffered).
	/// </summary>
	public virtual void SetThreeDimensionalLeader(int _arg)
	{
		vtkCaptionActor2D_SetThreeDimensionalLeader_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_ShallowCopy_51(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Shallow copy of this scaled text actor. Overloads the virtual
	/// vtkProp method.
	/// </summary>
	public override void ShallowCopy(vtkProp prop)
	{
		vtkCaptionActor2D_ShallowCopy_51(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_ThreeDimensionalLeaderOff_52(HandleRef pThis);

	/// <summary>
	/// Indicate whether the leader is 2D (no hidden line) or 3D (z-buffered).
	/// </summary>
	public virtual void ThreeDimensionalLeaderOff()
	{
		vtkCaptionActor2D_ThreeDimensionalLeaderOff_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingAnnotation.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkCaptionActor2D_ThreeDimensionalLeaderOn_53(HandleRef pThis);

	/// <summary>
	/// Indicate whether the leader is 2D (no hidden line) or 3D (z-buffered).
	/// </summary>
	public virtual void ThreeDimensionalLeaderOn()
	{
		vtkCaptionActor2D_ThreeDimensionalLeaderOn_53(GetCppThis());
	}
}
