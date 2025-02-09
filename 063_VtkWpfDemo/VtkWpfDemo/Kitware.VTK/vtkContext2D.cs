using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkContext2D
/// </summary>
/// <remarks>
///    Class for drawing 2D primitives to a graphical context.
///
///
/// This defines the interface for drawing onto a 2D context. The context must
/// be set up with a vtkContextDevice2D derived class that provides the functions
/// to facilitate the low level calls to the context. Currently only an OpenGL
/// based device is provided, but this could be extended in the future.
/// </remarks>
public class vtkContext2D : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkContext2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkContext2D()
	{
		MRClassNameKey = "class vtkContext2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkContext2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkContext2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContext2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Painter object.
	/// </summary>
	public new static vtkContext2D New()
	{
		vtkContext2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContext2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Painter object.
	/// </summary>
	public vtkContext2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkContext2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkContext2D_AppendTransform_01(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Append the transform for the context, the underlying device will use the
	/// matrix of the transform. Note, this is set immediately, later changes to
	/// the matrix will have no effect until it is set again. The matrix of the
	/// transform will multiply the current context transform.
	/// </summary>
	public void AppendTransform(vtkTransform2D transform)
	{
		vtkContext2D_AppendTransform_01(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_ApplyBrush_02(HandleRef pThis, HandleRef brush);

	/// <summary>
	/// Apply the supplied brush which controls the outlines of shapes, as well as
	/// lines, points and related primitives. This makes a deep copy of the vtkBrush
	/// object in the vtkContext2D, it does not hold a pointer to the supplied object.
	/// </summary>
	public void ApplyBrush(vtkBrush brush)
	{
		vtkContext2D_ApplyBrush_02(GetCppThis(), brush?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_ApplyId_03(HandleRef pThis, long id);

	/// <summary>
	/// Apply id as a color.
	/// </summary>
	public void ApplyId(long id)
	{
		vtkContext2D_ApplyId_03(GetCppThis(), id);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_ApplyPen_04(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Apply the supplied pen which controls the outlines of shapes, as well as
	/// lines, points and related primitives. This makes a deep copy of the vtkPen
	/// object in the vtkContext2D, it does not hold a pointer to the supplied object.
	/// </summary>
	public void ApplyPen(vtkPen pen)
	{
		vtkContext2D_ApplyPen_04(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_ApplyTextProp_05(HandleRef pThis, HandleRef prop);

	/// <summary>
	/// Apply the supplied text property which controls how text is rendered.
	/// This makes a deep copy of the vtkTextProperty object in the vtkContext2D,
	/// it does not hold a pointer to the supplied object.
	/// </summary>
	public void ApplyTextProp(vtkTextProperty prop)
	{
		vtkContext2D_ApplyTextProp_05(GetCppThis(), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_BufferIdModeBegin_06(HandleRef pThis, HandleRef bufferId);

	/// <summary>
	/// Start BufferId creation Mode.
	/// \pre not_yet: !GetBufferIdMode()
	/// \pre bufferId_exists: bufferId!=0
	/// \post started: GetBufferIdMode()
	/// </summary>
	public void BufferIdModeBegin(vtkAbstractContextBufferId bufferId)
	{
		vtkContext2D_BufferIdModeBegin_06(GetCppThis(), bufferId?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_BufferIdModeEnd_07(HandleRef pThis);

	/// <summary>
	/// Finalize BufferId creation Mode. It makes sure that the content of the
	/// bufferId passed in argument of BufferIdModeBegin() is correctly set.
	/// \pre started: GetBufferIdMode()
	/// \post done: !GetBufferIdMode()
	/// </summary>
	public void BufferIdModeEnd()
	{
		vtkContext2D_BufferIdModeEnd_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContext2D_ComputeFontSizeForBoundedString_08(HandleRef pThis, string arg0, float width, float height);

	/// <summary>
	/// Calculate the largest possible font size where the supplied string will fit
	/// within the specified bounds.  In addition to being returned, this font size
	/// is also used to update the vtkTextProperty used by this object.
	/// NOTE: text rotation is ignored for the purposes of this function.
	/// </summary>
	public int ComputeFontSizeForBoundedString(string arg0, float width, float height)
	{
		return vtkContext2D_ComputeFontSizeForBoundedString_08(GetCppThis(), arg0, width, height);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_ComputeJustifiedStringBounds_09(HandleRef pThis, string arg0, IntPtr bounds);

	/// <summary>
	/// Compute the bounds of the supplied string while taking into account the
	/// justification and rotation of the currently applied text property.
	/// </summary>
	public void ComputeJustifiedStringBounds(string arg0, IntPtr bounds)
	{
		vtkContext2D_ComputeJustifiedStringBounds_09(GetCppThis(), arg0, bounds);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_ComputeStringBounds_10(HandleRef pThis, string arg0, HandleRef bounds);

	/// <summary>
	/// Compute the bounds of the supplied string. The bounds will be copied to the
	/// supplied bounds variable, the first two elements are the bottom corner of
	/// the string, and the second two elements are the width and height of the
	/// bounding box.
	///
	/// NOTE:the text justification from the current text property is
	/// NOT considered when computing these bounds.
	/// </summary>
	public void ComputeStringBounds(string arg0, vtkPoints2D bounds)
	{
		vtkContext2D_ComputeStringBounds_10(GetCppThis(), arg0, bounds?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_ComputeStringBounds_11(HandleRef pThis, string arg0, IntPtr bounds);

	/// <summary>
	/// Compute the bounds of the supplied string. The bounds will be copied to the
	/// supplied bounds variable, the first two elements are the bottom corner of
	/// the string, and the second two elements are the width and height of the
	/// bounding box.
	///
	/// NOTE:the text justification from the current text property is
	/// NOT considered when computing these bounds.
	/// </summary>
	public void ComputeStringBounds(string arg0, IntPtr bounds)
	{
		vtkContext2D_ComputeStringBounds_11(GetCppThis(), arg0, bounds);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawArc_12(HandleRef pThis, float x, float y, float r, float startAngle, float stopAngle);

	/// <summary>
	/// Draw a circular arc with center at x,y with radius r between angles
	/// startAngle and stopAngle (expressed in degrees).
	/// \pre positive_radius: r&gt;=0
	/// </summary>
	public void DrawArc(float x, float y, float r, float startAngle, float stopAngle)
	{
		vtkContext2D_DrawArc_12(GetCppThis(), x, y, r, startAngle, stopAngle);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawEllipse_13(HandleRef pThis, float x, float y, float rx, float ry);

	/// <summary>
	/// Draw an ellipse with center at x, y and radii rx, ry.
	/// \pre positive_rx: rx&gt;=0
	/// \pre positive_ry: ry&gt;=0
	/// </summary>
	public void DrawEllipse(float x, float y, float rx, float ry)
	{
		vtkContext2D_DrawEllipse_13(GetCppThis(), x, y, rx, ry);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawEllipseWedge_14(HandleRef pThis, float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle);

	/// <summary>
	/// Draw an elliptic wedge with center at x, y, outer radii outRx, outRy,
	/// inner radii inRx, inRy between angles startAngle and stopAngle
	/// (expressed in degrees).
	/// \pre positive_outRx: outRx&gt;=0
	/// \pre positive_outRy: outRy&gt;=0
	/// \pre positive_inRx: inRx&gt;=0
	/// \pre positive_inRy: inRy&gt;=0
	/// \pre ordered_rx: inRx&lt;=outRx
	/// \pre ordered_ry: inRy&lt;=outRy
	/// </summary>
	public void DrawEllipseWedge(float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle)
	{
		vtkContext2D_DrawEllipseWedge_14(GetCppThis(), x, y, outRx, outRy, inRx, inRy, startAngle, stopAngle);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawEllipticArc_15(HandleRef pThis, float x, float y, float rX, float rY, float startAngle, float stopAngle);

	/// <summary>
	/// Draw an elliptic arc with center at x,y with radii rX and rY between
	/// angles startAngle and stopAngle (expressed in degrees).
	/// \pre positive_rX: rX&gt;=0
	/// \pre positive_rY: rY&gt;=0
	/// </summary>
	public void DrawEllipticArc(float x, float y, float rX, float rY, float startAngle, float stopAngle)
	{
		vtkContext2D_DrawEllipticArc_15(GetCppThis(), x, y, rX, rY, startAngle, stopAngle);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawImage_16(HandleRef pThis, float x, float y, HandleRef image);

	/// <summary>
	/// Draw the supplied image at the given x, y location (bottom corner).
	/// </summary>
	public void DrawImage(float x, float y, vtkImageData image)
	{
		vtkContext2D_DrawImage_16(GetCppThis(), x, y, image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawImage_17(HandleRef pThis, float x, float y, float scale, HandleRef image);

	/// <summary>
	/// Draw the supplied image at the given x, y location (bottom corner).
	/// Scale the supplied image by scale.
	/// </summary>
	public void DrawImage(float x, float y, float scale, vtkImageData image)
	{
		vtkContext2D_DrawImage_17(GetCppThis(), x, y, scale, image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawImage_18(HandleRef pThis, HandleRef pos, HandleRef image);

	/// <summary>
	/// Draw the supplied image at the given position. The origin, width, and
	/// height are specified by the supplied vtkRectf variable pos. The image
	/// will be drawn scaled to that size.
	/// </summary>
	public void DrawImage(vtkRectf pos, vtkImageData image)
	{
		vtkContext2D_DrawImage_18(GetCppThis(), pos?.GetCppThis() ?? default(HandleRef), image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawLine_19(HandleRef pThis, float x1, float y1, float x2, float y2);

	/// <summary>
	/// Draw a line between the specified points.
	/// </summary>
	public void DrawLine(float x1, float y1, float x2, float y2)
	{
		vtkContext2D_DrawLine_19(GetCppThis(), x1, y1, x2, y2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawLine_20(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Draw a line between the specified points.
	/// </summary>
	public void DrawLine(IntPtr p)
	{
		vtkContext2D_DrawLine_20(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawLine_21(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Draw a line between the specified points.
	/// Note: Fastest path - points packed in x and y.
	/// </summary>
	public void DrawLine(vtkPoints2D points)
	{
		vtkContext2D_DrawLine_21(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawLines_22(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Draw multiple lines between the specified pairs of points.
	/// \sa DrawPoly()
	/// </summary>
	public void DrawLines(vtkPoints2D points)
	{
		vtkContext2D_DrawLines_22(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawLines_23(HandleRef pThis, IntPtr points, int n);

	/// <summary>
	/// Draw multiple lines between the specified pairs of points
	/// \sa DrawPoly()
	/// </summary>
	public void DrawLines(IntPtr points, int n)
	{
		vtkContext2D_DrawLines_23(GetCppThis(), points, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawMarkers_24(HandleRef pThis, int shape, byte highlight, IntPtr points, int n, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw a series of markers centered at the points supplied. The \a shape
	/// argument controls the marker shape, and can be one of
	/// - VTK_MARKER_CROSS
	/// - VTK_MARKER_PLUS
	/// - VTK_MARKER_SQUARE
	/// - VTK_MARKER_CIRCLE
	/// - VTK_MARKER_DIAMOND
	/// Marker size is determined by the current pen width.
	/// \param shape the shape of the marker
	/// \param highlight whether to highlight the marker or not
	/// \param points where to draw the markers
	/// \param n number of points
	/// \param colors is an optional array of colors.
	/// \param nc_comps is the number of components for the color.
	/// </summary>
	public virtual void DrawMarkers(int shape, bool highlight, IntPtr points, int n, IntPtr colors, int nc_comps)
	{
		vtkContext2D_DrawMarkers_24(GetCppThis(), shape, (byte)(highlight ? 1u : 0u), points, n, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawMarkers_25(HandleRef pThis, int shape, byte highlight, IntPtr points, int n);

	/// <summary>
	/// Draw a series of markers centered at the points supplied. The \a shape
	/// argument controls the marker shape, and can be one of
	/// - VTK_MARKER_CROSS
	/// - VTK_MARKER_PLUS
	/// - VTK_MARKER_SQUARE
	/// - VTK_MARKER_CIRCLE
	/// - VTK_MARKER_DIAMOND
	/// Marker size is determined by the current pen width.
	/// \param shape the shape of the marker
	/// \param highlight whether to highlight the marker or not
	/// \param points where to draw the markers
	/// \param n number of points
	/// \param colors is an optional array of colors.
	/// \param nc_comps is the number of components for the color.
	/// </summary>
	public virtual void DrawMarkers(int shape, bool highlight, IntPtr points, int n)
	{
		vtkContext2D_DrawMarkers_25(GetCppThis(), shape, (byte)(highlight ? 1u : 0u), points, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawMarkers_26(HandleRef pThis, int shape, byte highlight, HandleRef points);

	/// <summary>
	/// Draw a series of markers centered at the points supplied. The \a shape
	/// argument controls the marker shape, and can be one of
	/// - VTK_MARKER_CROSS
	/// - VTK_MARKER_PLUS
	/// - VTK_MARKER_SQUARE
	/// - VTK_MARKER_CIRCLE
	/// - VTK_MARKER_DIAMOND
	/// Marker size is determined by the current pen width.
	/// \param shape the shape of the marker
	/// \param highlight whether to highlight the marker or not
	/// \param points where to draw the markers
	/// \param n number of points
	/// \param colors is an optional array of colors.
	/// \param nc_comps is the number of components for the color.
	/// </summary>
	public virtual void DrawMarkers(int shape, bool highlight, vtkPoints2D points)
	{
		vtkContext2D_DrawMarkers_26(GetCppThis(), shape, (byte)(highlight ? 1u : 0u), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawMarkers_27(HandleRef pThis, int shape, byte highlight, HandleRef points, HandleRef colors);

	/// <summary>
	/// Draw a series of markers centered at the points supplied. The \a shape
	/// argument controls the marker shape, and can be one of
	/// - VTK_MARKER_CROSS
	/// - VTK_MARKER_PLUS
	/// - VTK_MARKER_SQUARE
	/// - VTK_MARKER_CIRCLE
	/// - VTK_MARKER_DIAMOND
	/// Marker size is determined by the current pen width.
	/// \param shape the shape of the marker
	/// \param highlight whether to highlight the marker or not
	/// \param points where to draw the markers
	/// \param n number of points
	/// \param colors is an optional array of colors.
	/// \param nc_comps is the number of components for the color.
	/// </summary>
	public virtual void DrawMarkers(int shape, bool highlight, vtkPoints2D points, vtkUnsignedCharArray colors)
	{
		vtkContext2D_DrawMarkers_27(GetCppThis(), shape, (byte)(highlight ? 1u : 0u), points?.GetCppThis() ?? default(HandleRef), colors?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawMathTextString_28(HandleRef pThis, HandleRef point, string arg1);

	/// <summary>
	/// Draw a MathText formatted equation to the screen. See
	/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
	/// MathText requires matplotlib and python, and the vtkMatplotlib module must
	/// be enabled manually during build configuration. This method will do nothing
	/// but print a warning if vtkMathTextUtilities::GetInstance() returns NULL.
	/// </summary>
	public void DrawMathTextString(vtkPoints2D point, string arg1)
	{
		vtkContext2D_DrawMathTextString_28(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), arg1);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawMathTextString_29(HandleRef pThis, float x, float y, string arg2);

	/// <summary>
	/// Draw a MathText formatted equation to the screen. See
	/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
	/// MathText requires matplotlib and python, and the vtkMatplotlib module must
	/// be enabled manually during build configuration. This method will do nothing
	/// but print a warning if vtkMathTextUtilities::GetInstance() returns NULL.
	/// </summary>
	public void DrawMathTextString(float x, float y, string arg2)
	{
		vtkContext2D_DrawMathTextString_29(GetCppThis(), x, y, arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawMathTextString_30(HandleRef pThis, HandleRef point, string arg1, string fallback);

	/// <summary>
	/// Draw a MathText formatted equation to the screen. See
	/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
	/// MathText requires matplotlib and python, and the vtkMatplotlib module must
	/// be enabled manually during build configuration.
	/// If MathText is not available on the target device the non-MathText string
	/// in "fallback" is rendered using DrawString.
	/// </summary>
	public void DrawMathTextString(vtkPoints2D point, string arg1, string fallback)
	{
		vtkContext2D_DrawMathTextString_30(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), arg1, fallback);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawMathTextString_31(HandleRef pThis, float x, float y, string arg2, string fallback);

	/// <summary>
	/// Draw a MathText formatted equation to the screen. See
	/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
	/// MathText requires matplotlib and python, and the vtkMatplotlib module must
	/// be enabled manually during build configuration.
	/// If MathText is not available on the target device the non-MathText string
	/// in "fallback" is rendered using DrawString.
	/// </summary>
	public void DrawMathTextString(float x, float y, string arg2, string fallback)
	{
		vtkContext2D_DrawMathTextString_31(GetCppThis(), x, y, arg2, fallback);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPoint_32(HandleRef pThis, float x, float y);

	/// <summary>
	/// Draw a point at the supplied x and y coordinate
	/// </summary>
	public void DrawPoint(float x, float y)
	{
		vtkContext2D_DrawPoint_32(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPointSprites_33(HandleRef pThis, HandleRef sprite, HandleRef points);

	/// <summary>
	/// Draw a series of point sprites, images centred at the points supplied.
	/// The supplied vtkImageData is the sprite to be drawn, only squares will be
	/// drawn and the size is set using SetPointSize.
	/// </summary>
	public void DrawPointSprites(vtkImageData sprite, vtkPoints2D points)
	{
		vtkContext2D_DrawPointSprites_33(GetCppThis(), sprite?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPointSprites_34(HandleRef pThis, HandleRef sprite, HandleRef points, HandleRef colors);

	/// <summary>
	/// Draw a series of point sprites, images centred at the points supplied.
	/// The supplied vtkImageData is the sprite to be drawn, only squares will be
	/// drawn and the size is set using SetPointSize. Points will be colored by
	/// the colors array, which must be the same length as points.
	/// </summary>
	public void DrawPointSprites(vtkImageData sprite, vtkPoints2D points, vtkUnsignedCharArray colors)
	{
		vtkContext2D_DrawPointSprites_34(GetCppThis(), sprite?.GetCppThis() ?? default(HandleRef), points?.GetCppThis() ?? default(HandleRef), colors?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPointSprites_35(HandleRef pThis, HandleRef sprite, IntPtr points, int n, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw a series of point sprites, images centred at the points supplied.
	/// The supplied vtkImageData is the sprite to be drawn, only squares will be
	/// drawn and the size is set using SetPointSize. Points will be colored by
	/// the colors array, which must be the same length as points.
	/// </summary>
	public void DrawPointSprites(vtkImageData sprite, IntPtr points, int n, IntPtr colors, int nc_comps)
	{
		vtkContext2D_DrawPointSprites_35(GetCppThis(), sprite?.GetCppThis() ?? default(HandleRef), points, n, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPointSprites_36(HandleRef pThis, HandleRef sprite, IntPtr points, int n);

	/// <summary>
	/// Draw a series of point sprites, images centred at the points supplied.
	/// The supplied vtkImageData is the sprite to be drawn, only squares will be
	/// drawn and the size is set using SetPointSize.
	/// </summary>
	public void DrawPointSprites(vtkImageData sprite, IntPtr points, int n)
	{
		vtkContext2D_DrawPointSprites_36(GetCppThis(), sprite?.GetCppThis() ?? default(HandleRef), points, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPoints_37(HandleRef pThis, IntPtr x, IntPtr y, int n);

	/// <summary>
	/// Draw the specified number of points using the x and y arrays supplied
	/// </summary>
	public void DrawPoints(IntPtr x, IntPtr y, int n)
	{
		vtkContext2D_DrawPoints_37(GetCppThis(), x, y, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPoints_38(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Draw a poly line between the specified points - fastest code path due to
	/// memory layout of the coordinates.
	/// </summary>
	public void DrawPoints(vtkPoints2D points)
	{
		vtkContext2D_DrawPoints_38(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPoints_39(HandleRef pThis, IntPtr points, int n);

	/// <summary>
	/// Draw a poly line between the specified points, where the float array is of
	/// size 2*n and the points are packed x1, y1, x2, y2 etc.
	/// Note: Fastest code path - points packed in x and y.
	/// </summary>
	public void DrawPoints(IntPtr points, int n)
	{
		vtkContext2D_DrawPoints_39(GetCppThis(), points, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPoly_40(HandleRef pThis, IntPtr x, IntPtr y, int n);

	/// <summary>
	/// Draw a poly line between the specified points.
	/// </summary>
	public void DrawPoly(IntPtr x, IntPtr y, int n)
	{
		vtkContext2D_DrawPoly_40(GetCppThis(), x, y, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPoly_41(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Draw a poly line between the specified points - fastest code path due to
	/// memory layout of the coordinates.
	/// </summary>
	public void DrawPoly(vtkPoints2D points)
	{
		vtkContext2D_DrawPoly_41(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPoly_42(HandleRef pThis, IntPtr points, int n);

	/// <summary>
	/// Draw a poly line between the specified points, where the float array is of
	/// size 2*n and the points are packed x1, y1, x2, y2 etc.
	/// Note: Fastest code path - points packed in x and y.
	/// </summary>
	public void DrawPoly(IntPtr points, int n)
	{
		vtkContext2D_DrawPoly_42(GetCppThis(), points, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPoly_43(HandleRef pThis, IntPtr points, int n, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw a poly line between the specified points, where the float array is of
	/// size 2*n and the points are packed x1, y1, x2, y2 etc. The line will be colored by
	/// the colors array, which must have nc_comps components (defining a single color).
	/// Note: Fastest code path - points packed in x and y.
	/// </summary>
	public void DrawPoly(IntPtr points, int n, IntPtr colors, int nc_comps)
	{
		vtkContext2D_DrawPoly_43(GetCppThis(), points, n, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPolyData_44(HandleRef pThis, float x, float y, HandleRef polyData, HandleRef colors, int scalarMode);

	/// <summary>
	/// Draw the supplied polyData at the given x, y position (bottom corner).
	/// \note Supports only 2D meshes.
	/// </summary>
	public void DrawPolyData(float x, float y, vtkPolyData polyData, vtkUnsignedCharArray colors, int scalarMode)
	{
		vtkContext2D_DrawPolyData_44(GetCppThis(), x, y, polyData?.GetCppThis() ?? default(HandleRef), colors?.GetCppThis() ?? default(HandleRef), scalarMode);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPolygon_45(HandleRef pThis, IntPtr x, IntPtr y, int n);

	/// <summary>
	/// Draw a polygon specified specified by the points using the x and y arrays
	/// supplied
	/// </summary>
	public void DrawPolygon(IntPtr x, IntPtr y, int n)
	{
		vtkContext2D_DrawPolygon_45(GetCppThis(), x, y, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPolygon_46(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Draw a polygon defined by the specified points - fastest code path due to
	/// memory layout of the coordinates.
	/// </summary>
	public void DrawPolygon(vtkPoints2D points)
	{
		vtkContext2D_DrawPolygon_46(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPolygon_47(HandleRef pThis, IntPtr points, int n);

	/// <summary>
	/// Draw a polygon defined by the specified points, where the float array is
	/// of size 2*n and the points are packed x1, y1, x2, y2 etc.
	/// Note: Fastest code path - points packed in x and y.
	/// </summary>
	public void DrawPolygon(IntPtr points, int n)
	{
		vtkContext2D_DrawPolygon_47(GetCppThis(), points, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPolygon_48(HandleRef pThis, IntPtr x, IntPtr y, int n, IntPtr color, int nc_comps);

	/// <summary>
	/// Draw a polygon specified specified by the points using the x and y arrays
	/// supplied
	/// </summary>
	public void DrawPolygon(IntPtr x, IntPtr y, int n, IntPtr color, int nc_comps)
	{
		vtkContext2D_DrawPolygon_48(GetCppThis(), x, y, n, color, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPolygon_49(HandleRef pThis, HandleRef points, IntPtr color, int nc_comps);

	/// <summary>
	/// Draw a polygon defined by the specified points - fastest code path due to
	/// memory layout of the coordinates.
	/// </summary>
	public void DrawPolygon(vtkPoints2D points, IntPtr color, int nc_comps)
	{
		vtkContext2D_DrawPolygon_49(GetCppThis(), points?.GetCppThis() ?? default(HandleRef), color, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawPolygon_50(HandleRef pThis, IntPtr points, int n, IntPtr color, int nc_comps);

	/// <summary>
	/// Draw a polygon defined by the specified points, where the float array is
	/// of size 2*n and the points are packed x1, y1, x2, y2 etc.
	/// Note: Fastest code path - points packed in x and y.
	/// </summary>
	public void DrawPolygon(IntPtr points, int n, IntPtr color, int nc_comps)
	{
		vtkContext2D_DrawPolygon_50(GetCppThis(), points, n, color, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawQuad_51(HandleRef pThis, float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4);

	/// <summary>
	/// Draw a quadrilateral at the specified points (4 points, 8 floats in x, y).
	/// </summary>
	public void DrawQuad(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4)
	{
		vtkContext2D_DrawQuad_51(GetCppThis(), x1, y1, x2, y2, x3, y3, x4, y4);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawQuad_52(HandleRef pThis, IntPtr p);

	/// <summary>
	/// Draw a quadrilateral at the specified points (4 points, 8 floats in x, y).
	/// </summary>
	public void DrawQuad(IntPtr p)
	{
		vtkContext2D_DrawQuad_52(GetCppThis(), p);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawQuadStrip_53(HandleRef pThis, HandleRef points);

	/// <summary>
	/// Draw a strip of quads
	/// </summary>
	public void DrawQuadStrip(vtkPoints2D points)
	{
		vtkContext2D_DrawQuadStrip_53(GetCppThis(), points?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawQuadStrip_54(HandleRef pThis, IntPtr p, int n);

	/// <summary>
	/// Draw a strip of quads
	/// </summary>
	public void DrawQuadStrip(IntPtr p, int n)
	{
		vtkContext2D_DrawQuadStrip_54(GetCppThis(), p, n);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawRect_55(HandleRef pThis, float x, float y, float w, float h);

	/// <summary>
	/// Draw a rectangle with origin at x, y and width w, height h
	/// </summary>
	public void DrawRect(float x, float y, float w, float h)
	{
		vtkContext2D_DrawRect_55(GetCppThis(), x, y, w, h);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawString_56(HandleRef pThis, HandleRef point, string arg1);

	/// <summary>
	/// Draw some text to the screen.
	/// </summary>
	public void DrawString(vtkPoints2D point, string arg1)
	{
		vtkContext2D_DrawString_56(GetCppThis(), point?.GetCppThis() ?? default(HandleRef), arg1);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawString_57(HandleRef pThis, float x, float y, string arg2);

	/// <summary>
	/// Draw some text to the screen.
	/// </summary>
	public void DrawString(float x, float y, string arg2)
	{
		vtkContext2D_DrawString_57(GetCppThis(), x, y, arg2);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawStringRect_58(HandleRef pThis, HandleRef rect, string arg1);

	/// <summary>
	/// Draw some text to the screen in a bounding rectangle with the alignment
	/// of the text properties respecting the rectangle. The points should be
	/// supplied as bottom corner (x, y), width, height.
	/// </summary>
	public void DrawStringRect(vtkPoints2D rect, string arg1)
	{
		vtkContext2D_DrawStringRect_58(GetCppThis(), rect?.GetCppThis() ?? default(HandleRef), arg1);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawStringRect_59(HandleRef pThis, IntPtr rect, string arg1);

	/// <summary>
	/// Draw some text to the screen in a bounding rectangle with the alignment
	/// of the text properties respecting the rectangle. The points should be
	/// supplied as bottom corner (x, y), width, height.
	/// </summary>
	public void DrawStringRect(IntPtr rect, string arg1)
	{
		vtkContext2D_DrawStringRect_59(GetCppThis(), rect, arg1);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_DrawWedge_60(HandleRef pThis, float x, float y, float outRadius, float inRadius, float startAngle, float stopAngle);

	/// <summary>
	/// Draw a circular wedge with center at x, y, outer radius outRadius,
	/// inner radius inRadius between angles startAngle and stopAngle
	/// (expressed in degrees).
	/// \pre positive_outRadius: outRadius&gt;=0
	/// \pre positive_inRadius: inRadius&gt;=0
	/// \pre ordered_radii: inRadius&lt;=outRadius
	/// </summary>
	public void DrawWedge(float x, float y, float outRadius, float inRadius, float startAngle, float stopAngle)
	{
		vtkContext2D_DrawWedge_60(GetCppThis(), x, y, outRadius, inRadius, startAngle, stopAngle);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContext2D_End_61(HandleRef pThis);

	/// <summary>
	/// Ends painting on the device, you would not usually need to call this as it
	/// should be called by the destructor. Returns true if the painter is no
	/// longer active, otherwise false.
	/// </summary>
	public bool End()
	{
		return (vtkContext2D_End_61(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContext2D_FloatToInt_62(float x);

	/// <summary>
	/// Float to int conversion, performs truncation but with a rounding
	/// tolerance for float values that are within 1/256 of their closest
	/// integer.
	/// </summary>
	public static int FloatToInt(float x)
	{
		return vtkContext2D_FloatToInt_62(x);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContext2D_GetBrush_63(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the pen which controls the outlines of shapes as well as lines, points
	/// and related primitives.
	/// </summary>
	public vtkBrush GetBrush()
	{
		vtkBrush vtkBrush2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContext2D_GetBrush_63(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkContext2D_GetBufferIdMode_64(HandleRef pThis);

	/// <summary>
	/// Tell if the context is in BufferId creation mode. Initial value is false.
	/// </summary>
	public bool GetBufferIdMode()
	{
		return (vtkContext2D_GetBufferIdMode_64(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContext2D_GetNumberOfGenerationsFromBase_65(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkContext2D_GetNumberOfGenerationsFromBase_65(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkContext2D_GetNumberOfGenerationsFromBaseType_66(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkContext2D_GetNumberOfGenerationsFromBaseType_66(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContext2D_GetPen_67(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the pen which controls the outlines of shapes, as well as lines,
	/// points and related primitives. This object can be modified and the changes
	/// will be reflected in subsequent drawing operations.
	/// </summary>
	public vtkPen GetPen()
	{
		vtkPen vtkPen2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContext2D_GetPen_67(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkContext2D_GetTextProp_68(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the text properties object for the vtkContext2D.
	/// </summary>
	public vtkTextProperty GetTextProp()
	{
		vtkTextProperty vtkTextProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContext2D_GetTextProp_68(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContext2D_GetTransform_69(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compute the current transform applied to the context.
	/// </summary>
	public vtkTransform2D GetTransform()
	{
		vtkTransform2D vtkTransform2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContext2D_GetTransform_69(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2D2 = (vtkTransform2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2D2.Register(null);
			}
		}
		return vtkTransform2D2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContext2D_IsA_70(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkContext2D_IsA_70(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkContext2D_IsTypeOf_71(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkContext2D_IsTypeOf_71(type);
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkContext2D_MathTextIsSupported_72(HandleRef pThis);

	/// <summary>
	/// Return true if MathText rendering available on the current device.
	/// </summary>
	public bool MathTextIsSupported()
	{
		return (vtkContext2D_MathTextIsSupported_72(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContext2D_NewInstance_74(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkContext2D NewInstance()
	{
		vtkContext2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContext2D_NewInstance_74(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_PopMatrix_75(HandleRef pThis);

	/// <summary>
	/// Push/pop the transformation matrix for the painter (sets the underlying
	/// matrix for the device when available).
	/// </summary>
	public void PopMatrix()
	{
		vtkContext2D_PopMatrix_75(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_PushMatrix_76(HandleRef pThis);

	/// <summary>
	/// Push/pop the transformation matrix for the painter (sets the underlying
	/// matrix for the device when available).
	/// </summary>
	public void PushMatrix()
	{
		vtkContext2D_PushMatrix_76(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkContext2D_SafeDownCast_77(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkContext2D SafeDownCast(vtkObjectBase o)
	{
		vtkContext2D vtkContext2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkContext2D_SafeDownCast_77(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkContext2D2 = (vtkContext2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkContext2D2.Register(null);
			}
		}
		return vtkContext2D2;
	}

	[DllImport("Kitware.VTK.RenderingContext2D.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkContext2D_SetTransform_78(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Set the transform for the context, the underlying device will use the
	/// matrix of the transform. Note, this is set immediately, later changes to
	/// the matrix will have no effect until it is set again.
	/// </summary>
	public void SetTransform(vtkTransform2D transform)
	{
		vtkContext2D_SetTransform_78(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}
}
