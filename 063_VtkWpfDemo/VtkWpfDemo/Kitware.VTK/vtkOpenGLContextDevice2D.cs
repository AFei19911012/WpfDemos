using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLContextDevice2D
/// </summary>
/// <remarks>
///    Class for drawing 2D primitives using OpenGL
/// 1.1+.
///
///
/// This class takes care of drawing the 2D primitives for the vtkContext2D class.
/// In general this class should not be used directly, but called by vtkContext2D
/// which takes care of many of the higher level details.
///
/// </remarks>
/// <seealso>
///
/// vtkOpenGL2ContextDevice2D
/// </seealso>
public class vtkOpenGLContextDevice2D : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLContextDevice2D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLContextDevice2D()
	{
		MRClassNameKey = "class vtkOpenGLContextDevice2D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLContextDevice2D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLContextDevice2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Painter object.
	/// </summary>
	public new static vtkOpenGLContextDevice2D New()
	{
		vtkOpenGLContextDevice2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLContextDevice2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Painter object.
	/// </summary>
	public vtkOpenGLContextDevice2D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLContextDevice2D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_Begin_01(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Begin drawing, pass in the viewport to set up the view.
	/// </summary>
	public virtual void Begin(vtkViewport viewport)
	{
		vtkOpenGLContextDevice2D_Begin_01(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_BufferIdModeBegin_02(HandleRef pThis, HandleRef bufferId);

	/// <summary>
	/// Start BufferId creation Mode.
	/// The default implementation is empty.
	/// \pre not_yet: !GetBufferIdMode()
	/// \pre bufferId_exists: bufferId!=0
	/// \post started: GetBufferIdMode()
	/// </summary>
	public virtual void BufferIdModeBegin(vtkAbstractContextBufferId bufferId)
	{
		vtkOpenGLContextDevice2D_BufferIdModeBegin_02(GetCppThis(), bufferId?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_BufferIdModeEnd_03(HandleRef pThis);

	/// <summary>
	/// Finalize BufferId creation Mode. It makes sure that the content of the
	/// bufferId passed in argument of BufferIdModeBegin() is correctly set.
	/// The default implementation is empty.
	/// \pre started: GetBufferIdMode()
	/// \post done: !GetBufferIdMode()
	/// </summary>
	public virtual void BufferIdModeEnd()
	{
		vtkOpenGLContextDevice2D_BufferIdModeEnd_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_ComputeJustifiedStringBounds_04(HandleRef pThis, string arg0, IntPtr bounds);

	/// <summary>
	/// Compute the bounds of the supplied string while taking into account the
	/// justification of the currently applied text property. Simple rotations
	/// (0, 90, 180, 270 degrees) are also properly taken into account.
	/// </summary>
	public virtual void ComputeJustifiedStringBounds(string arg0, IntPtr bounds)
	{
		vtkOpenGLContextDevice2D_ComputeJustifiedStringBounds_04(GetCppThis(), arg0, bounds);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_ComputeStringBounds_05(HandleRef pThis, string arg0, IntPtr bounds);

	/// <summary>
	/// Compute the bounds of the supplied string. The bounds will be copied to the
	/// supplied bounds variable, the first two elements are the bottom corner of
	/// the string, and the second two elements are the width and height of the
	/// bounding box. An empty bounding box (0, 0, 0, 0) is returned for an
	/// empty string or string with only characters that cannot be rendered.
	/// NOTE: This function does not take account of the text rotation.
	/// </summary>
	public virtual void ComputeStringBounds(string arg0, IntPtr bounds)
	{
		vtkOpenGLContextDevice2D_ComputeStringBounds_05(GetCppThis(), arg0, bounds);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawColoredPolygon_06(HandleRef pThis, IntPtr points, int numPoints, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw a polygon using the specified number of points.
	/// </summary>
	public virtual void DrawColoredPolygon(IntPtr points, int numPoints, IntPtr colors, int nc_comps)
	{
		vtkOpenGLContextDevice2D_DrawColoredPolygon_06(GetCppThis(), points, numPoints, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawEllipseWedge_07(HandleRef pThis, float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle);

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
	public virtual void DrawEllipseWedge(float x, float y, float outRx, float outRy, float inRx, float inRy, float startAngle, float stopAngle)
	{
		vtkOpenGLContextDevice2D_DrawEllipseWedge_07(GetCppThis(), x, y, outRx, outRy, inRx, inRy, startAngle, stopAngle);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawEllipticArc_08(HandleRef pThis, float x, float y, float rX, float rY, float startAngle, float stopAngle);

	/// <summary>
	/// Draw an elliptic arc with center at x,y with radii rX and rY between
	/// angles startAngle and stopAngle (expressed in degrees).
	/// \pre positive_rX: rX&gt;=0
	/// \pre positive_rY: rY&gt;=0
	/// </summary>
	public virtual void DrawEllipticArc(float x, float y, float rX, float rY, float startAngle, float stopAngle)
	{
		vtkOpenGLContextDevice2D_DrawEllipticArc_08(GetCppThis(), x, y, rX, rY, startAngle, stopAngle);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawImage_09(HandleRef pThis, IntPtr p, float scale, HandleRef image);

	/// <summary>
	/// Draw the supplied image at the given x, y (p[0], p[1]) (bottom corner),
	/// scaled by scale (1.0 would match the image).
	/// </summary>
	public virtual void DrawImage(IntPtr p, float scale, vtkImageData image)
	{
		vtkOpenGLContextDevice2D_DrawImage_09(GetCppThis(), p, scale, image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawImage_10(HandleRef pThis, HandleRef pos, HandleRef image);

	/// <summary>
	/// Draw the supplied image at the given position. The origin, width, and
	/// height are specified by the supplied vtkRectf variable pos. The image
	/// will be drawn scaled to that size.
	/// </summary>
	public virtual void DrawImage(vtkRectf pos, vtkImageData image)
	{
		vtkOpenGLContextDevice2D_DrawImage_10(GetCppThis(), pos?.GetCppThis() ?? default(HandleRef), image?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawLines_11(HandleRef pThis, IntPtr f, int n, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw lines using the points - memory layout is as follows:
	/// l1p1,l1p2,l2p1,l2p2... The lines will be colored by colors array
	/// which has nc_comps components.
	/// \sa DrawPoly()
	/// </summary>
	public virtual void DrawLines(IntPtr f, int n, IntPtr colors, int nc_comps)
	{
		vtkOpenGLContextDevice2D_DrawLines_11(GetCppThis(), f, n, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawMarkers_12(HandleRef pThis, int shape, byte highlight, IntPtr points, int n, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw a series of markers centered at the points supplied. The \a shape
	/// argument controls the marker shape, and can be one of
	/// - VTK_MARKER_CROSS
	/// - VTK_MARKER_PLUS
	/// - VTK_MARKER_SQUARE
	/// - VTK_MARKER_CIRCLE
	/// - VTK_MARKER_DIAMOND
	/// \param shape the shape of the marker
	/// \param highlight whether to highlight the marker or not
	/// \param points where to draw the sprites
	/// \param n the number of points
	/// \param colors is an optional array of colors.
	/// \param nc_comps is the number of components for the color.
	/// </summary>
	public virtual void DrawMarkers(int shape, bool highlight, IntPtr points, int n, IntPtr colors, int nc_comps)
	{
		vtkOpenGLContextDevice2D_DrawMarkers_12(GetCppThis(), shape, (byte)(highlight ? 1u : 0u), points, n, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawMathTextString_13(HandleRef pThis, IntPtr point, string arg1);

	/// <summary>
	/// Draw text using MathText markup for mathematical equations. See
	/// http://matplotlib.sourceforge.net/users/mathtext.html for more information.
	/// </summary>
	public virtual void DrawMathTextString(IntPtr point, string arg1)
	{
		vtkOpenGLContextDevice2D_DrawMathTextString_13(GetCppThis(), point, arg1);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawPointSprites_14(HandleRef pThis, HandleRef sprite, IntPtr points, int n, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw a series of point sprites, images centred at the points supplied.
	/// The supplied vtkImageData is the sprite to be drawn, only squares will be
	/// drawn and the size is set using SetPointSize. Points are colored by colors
	/// array which has nc_comps components - this part is optional.
	/// </summary>
	public virtual void DrawPointSprites(vtkImageData sprite, IntPtr points, int n, IntPtr colors, int nc_comps)
	{
		vtkOpenGLContextDevice2D_DrawPointSprites_14(GetCppThis(), sprite?.GetCppThis() ?? default(HandleRef), points, n, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawPoints_15(HandleRef pThis, IntPtr points, int n, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw a series of points - fastest code path due to memory
	/// layout of the coordinates. Points are colored by colors array
	/// which has nc_comps components
	/// </summary>
	public virtual void DrawPoints(IntPtr points, int n, IntPtr colors, int nc_comps)
	{
		vtkOpenGLContextDevice2D_DrawPoints_15(GetCppThis(), points, n, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawPoly_16(HandleRef pThis, IntPtr f, int n, IntPtr colors, int nc_comps);

	/// <summary>
	/// Draw a poly line using the points - fastest code path due to memory
	/// layout of the coordinates. The line will be colored by colors array
	/// which has nc_comps components
	/// </summary>
	public virtual void DrawPoly(IntPtr f, int n, IntPtr colors, int nc_comps)
	{
		vtkOpenGLContextDevice2D_DrawPoly_16(GetCppThis(), f, n, colors, nc_comps);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawPolyData_17(HandleRef pThis, IntPtr p, float scale, HandleRef polyData, HandleRef colors, int scalarMode);

	/// <summary>
	/// Draw the supplied PolyData at the given x, y (p[0], p[1]) (bottom corner),
	/// scaled by scale (1.0 would match the actual dataset).
	/// </summary>
	public virtual void DrawPolyData(IntPtr p, float scale, vtkPolyData polyData, vtkUnsignedCharArray colors, int scalarMode)
	{
		vtkOpenGLContextDevice2D_DrawPolyData_17(GetCppThis(), p, scale, polyData?.GetCppThis() ?? default(HandleRef), colors?.GetCppThis() ?? default(HandleRef), scalarMode);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawPolygon_18(HandleRef pThis, IntPtr arg0, int arg1);

	/// <summary>
	/// Draw a polygon using the specified number of points.
	/// </summary>
	public virtual void DrawPolygon(IntPtr arg0, int arg1)
	{
		vtkOpenGLContextDevice2D_DrawPolygon_18(GetCppThis(), arg0, arg1);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawQuad_19(HandleRef pThis, IntPtr points, int n);

	/// <summary>
	/// Draws a rectangle
	/// </summary>
	public virtual void DrawQuad(IntPtr points, int n)
	{
		vtkOpenGLContextDevice2D_DrawQuad_19(GetCppThis(), points, n);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawQuadStrip_20(HandleRef pThis, IntPtr points, int n);

	/// <summary>
	/// Draws a rectangle
	/// </summary>
	public virtual void DrawQuadStrip(IntPtr points, int n)
	{
		vtkOpenGLContextDevice2D_DrawQuadStrip_20(GetCppThis(), points, n);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_DrawString_21(HandleRef pThis, IntPtr point, string arg1);

	/// <summary>
	/// Draw some text to the screen!
	/// </summary>
	public virtual void DrawString(IntPtr point, string arg1)
	{
		vtkOpenGLContextDevice2D_DrawString_21(GetCppThis(), point, arg1);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_EnableClipping_22(HandleRef pThis, byte enable);

	/// <summary>
	/// Disable clipping of the display.
	/// </summary>
	public virtual void EnableClipping(bool enable)
	{
		vtkOpenGLContextDevice2D_EnableClipping_22(GetCppThis(), (byte)(enable ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_End_23(HandleRef pThis);

	/// <summary>
	/// End drawing, clean up the view.
	/// </summary>
	public virtual void End()
	{
		vtkOpenGLContextDevice2D_End_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_GetMatrix_24(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Set the model view matrix for the display
	/// </summary>
	public virtual void GetMatrix(vtkMatrix3x3 m)
	{
		vtkOpenGLContextDevice2D_GetMatrix_24(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLContextDevice2D_GetMaximumMarkerCacheSize_25(HandleRef pThis);

	/// <summary>
	/// Adjust the size of the MarkerCache. This implementation generates point
	/// sprites for each mark size/shape and uses DrawPointSprites to render them.
	/// The number of cached markers can be accessed with this function.
	/// </summary>
	public virtual int GetMaximumMarkerCacheSize()
	{
		return vtkOpenGLContextDevice2D_GetMaximumMarkerCacheSize_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice2D_GetModelMatrix_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the projection matrix this is needed
	/// </summary>
	public vtkMatrix4x4 GetModelMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice2D_GetModelMatrix_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLContextDevice2D_GetNumberOfGenerationsFromBase_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLContextDevice2D_GetNumberOfGenerationsFromBase_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLContextDevice2D_GetNumberOfGenerationsFromBaseType_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLContextDevice2D_GetNumberOfGenerationsFromBaseType_28(type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice2D_GetProjectionMatrix_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the projection matrix this is needed
	/// </summary>
	public vtkMatrix4x4 GetProjectionMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice2D_GetProjectionMatrix_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice2D_GetRenderWindow_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the active RenderWindow of the device. Will return null if not active.
	/// </summary>
	public virtual vtkOpenGLRenderWindow GetRenderWindow()
	{
		vtkOpenGLRenderWindow vtkOpenGLRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice2D_GetRenderWindow_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLRenderWindow2 = (vtkOpenGLRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLRenderWindow2.Register(null);
			}
		}
		return vtkOpenGLRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLContextDevice2D_HasGLSL_31(HandleRef pThis);

	/// <summary>
	/// Check whether the current context device has support for GLSL.
	/// </summary>
	public bool HasGLSL()
	{
		return (vtkOpenGLContextDevice2D_HasGLSL_31(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLContextDevice2D_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLContextDevice2D_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLContextDevice2D_IsTypeOf_33(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLContextDevice2D_IsTypeOf_33(type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_MultiplyMatrix_34(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Multiply the current model view matrix by the supplied one.
	/// </summary>
	public virtual void MultiplyMatrix(vtkMatrix3x3 m)
	{
		vtkOpenGLContextDevice2D_MultiplyMatrix_34(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice2D_NewInstance_36(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLContextDevice2D NewInstance()
	{
		vtkOpenGLContextDevice2D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice2D_NewInstance_36(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLContextDevice2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_PopMatrix_37(HandleRef pThis);

	/// <summary>
	/// Pop the current matrix off of the stack.
	/// </summary>
	public virtual void PopMatrix()
	{
		vtkOpenGLContextDevice2D_PopMatrix_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_PushMatrix_38(HandleRef pThis);

	/// <summary>
	/// Push the current matrix onto the stack.
	/// </summary>
	public virtual void PushMatrix()
	{
		vtkOpenGLContextDevice2D_PushMatrix_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_ReleaseGraphicsResources_39(HandleRef pThis, HandleRef window);

	/// <summary>
	/// Release any graphics resources that are being consumed by this device.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkOpenGLContextDevice2D_ReleaseGraphicsResources_39(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice2D_SafeDownCast_40(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLContextDevice2D SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLContextDevice2D vtkOpenGLContextDevice2D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice2D_SafeDownCast_40(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLContextDevice2D2 = (vtkOpenGLContextDevice2D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLContextDevice2D2.Register(null);
			}
		}
		return vtkOpenGLContextDevice2D2;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetClipping_41(HandleRef pThis, IntPtr x);

	/// <summary>
	/// Pop the current matrix off of the stack.
	/// </summary>
	public virtual void SetClipping(IntPtr x)
	{
		vtkOpenGLContextDevice2D_SetClipping_41(GetCppThis(), x);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetColor_42(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Set the color for the device using unsigned char of length 3, RGB.
	/// </summary>
	public virtual void SetColor(IntPtr color)
	{
		vtkOpenGLContextDevice2D_SetColor_42(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetColor4_43(HandleRef pThis, IntPtr color);

	/// <summary>
	/// Set the color for the device using unsigned char of length 4, RGBA.
	/// </summary>
	public virtual void SetColor4(IntPtr color)
	{
		vtkOpenGLContextDevice2D_SetColor4_43(GetCppThis(), color);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetLineType_44(HandleRef pThis, int type);

	/// <summary>
	/// Set the line type type (using anonymous enum in vtkPen).
	/// </summary>
	public virtual void SetLineType(int type)
	{
		vtkOpenGLContextDevice2D_SetLineType_44(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetLineWidth_45(HandleRef pThis, float width);

	/// <summary>
	/// Set the line width for glyphs/sprites.
	/// </summary>
	public virtual void SetLineWidth(float width)
	{
		vtkOpenGLContextDevice2D_SetLineWidth_45(GetCppThis(), width);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetMatrix_46(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Set the model view matrix for the display
	/// </summary>
	public virtual void SetMatrix(vtkMatrix3x3 m)
	{
		vtkOpenGLContextDevice2D_SetMatrix_46(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetMaximumMarkerCacheSize_47(HandleRef pThis, int _arg);

	/// <summary>
	/// Adjust the size of the MarkerCache. This implementation generates point
	/// sprites for each mark size/shape and uses DrawPointSprites to render them.
	/// The number of cached markers can be accessed with this function.
	/// </summary>
	public virtual void SetMaximumMarkerCacheSize(int _arg)
	{
		vtkOpenGLContextDevice2D_SetMaximumMarkerCacheSize_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetPointSize_48(HandleRef pThis, float size);

	/// <summary>
	/// Set the point size for glyphs/sprites.
	/// </summary>
	public virtual void SetPointSize(float size)
	{
		vtkOpenGLContextDevice2D_SetPointSize_48(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLContextDevice2D_SetStringRendererToFreeType_49(HandleRef pThis);

	/// <summary>
	/// Force the use of the freetype based render strategy. If Qt is available
	/// then freetype will be used preferentially, otherwise this has no effect.
	/// Returns true on success.
	/// </summary>
	public bool SetStringRendererToFreeType()
	{
		return (vtkOpenGLContextDevice2D_SetStringRendererToFreeType_49(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLContextDevice2D_SetStringRendererToQt_50(HandleRef pThis);

	/// <summary>
	/// Force the use of the Qt based string render strategy. If Qt is not available
	/// then freetype will be used and this will return false.
	/// </summary>
	public bool SetStringRendererToQt()
	{
		return (vtkOpenGLContextDevice2D_SetStringRendererToQt_50(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice2D_SetTexture_51(HandleRef pThis, HandleRef image, int properties);

	/// <summary>
	/// Set the texture for the device, it is used to fill the polygons
	/// </summary>
	public virtual void SetTexture(vtkImageData image, int properties)
	{
		vtkOpenGLContextDevice2D_SetTexture_51(GetCppThis(), image?.GetCppThis() ?? default(HandleRef), properties);
	}
}
