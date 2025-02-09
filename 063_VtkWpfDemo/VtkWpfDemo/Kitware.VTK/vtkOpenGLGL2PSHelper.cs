using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLGL2PSHelper
/// </summary>
/// <remarks>
///    Access GL2PS functionality.
///
///
/// This class provides convenience functions that can be used to draw into a
/// GL2PS context. Link to vtkRenderingGL2PSOpenGL2 to bring in the
/// vtkOpenGLGL2PSHelperImpl class, the object factory override that implements
/// this interface.
/// </remarks>
public abstract class vtkOpenGLGL2PSHelper : vtkObject
{
	/// <summary>
	/// Get the renderwindow that's being exported.
	/// </summary>
	public enum State
	{
		/// <summary>enum member</summary>
		Background = 1,
		/// <summary>enum member</summary>
		Capture = 2,
		/// <summary>enum member</summary>
		Inactive = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGL2PSHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLGL2PSHelper()
	{
		MRClassNameKey = "class vtkOpenGLGL2PSHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGL2PSHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLGL2PSHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGL2PSHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLGL2PSHelper New()
	{
		vtkOpenGLGL2PSHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGL2PSHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLGL2PSHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLGL2PSHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLGL2PSHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelper_Draw3DPath_01(HandleRef pThis, HandleRef path, HandleRef actorMatrix, IntPtr rasterPos, IntPtr actorColor, HandleRef ren, string label);

	/// <summary>
	/// Transform the path using the actor's matrix and current GL state, then
	/// draw it to GL2PS. The label string is inserted into the GL2PS output at the
	/// beginning of the path specification as a comment on supported backends.
	/// </summary>
	public virtual void Draw3DPath(vtkPath path, vtkMatrix4x4 actorMatrix, IntPtr rasterPos, IntPtr actorColor, vtkRenderer ren, string label)
	{
		vtkOpenGLGL2PSHelper_Draw3DPath_01(GetCppThis(), path?.GetCppThis() ?? default(HandleRef), actorMatrix?.GetCppThis() ?? default(HandleRef), rasterPos, actorColor, ren?.GetCppThis() ?? default(HandleRef), label);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelper_DrawImage_02(HandleRef pThis, HandleRef image, IntPtr pos);

	/// <summary>
	/// Draw the image at pos.
	/// Image must be RGB or RGBA with float scalars.
	/// </summary>
	public virtual void DrawImage(vtkImageData image, IntPtr pos)
	{
		vtkOpenGLGL2PSHelper_DrawImage_02(GetCppThis(), image?.GetCppThis() ?? default(HandleRef), pos);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelper_DrawPath_03(HandleRef pThis, HandleRef path, IntPtr rasterPos, IntPtr windowPos, IntPtr rgba, IntPtr scale, double rotateAngle, float strokeWidth, string label);

	/// <summary>
	/// Generate PS, EPS, or SVG markup from a vtkPath object, and then inject it
	/// into the output using the gl2psSpecial command. The path is translated
	/// uniformly in the scene by windowPos. It is scaled by scale and rotated
	/// counter-clockwise by rotateAngle. The rasterPos is in world coordinates
	/// and determines clipping and depth. If scale is NULL, no scaling is done.
	/// If strokeWidth is positive, the path will be stroked with the indicated
	/// width. If zero or negative, the path will be filled (default).
	/// The label string is inserted into the GL2PS output at the beginning of the
	/// path specification as a comment on supported backends.
	/// </summary>
	public virtual void DrawPath(vtkPath path, IntPtr rasterPos, IntPtr windowPos, IntPtr rgba, IntPtr scale, double rotateAngle, float strokeWidth, string label)
	{
		vtkOpenGLGL2PSHelper_DrawPath_03(GetCppThis(), path?.GetCppThis() ?? default(HandleRef), rasterPos, windowPos, rgba, scale, rotateAngle, strokeWidth, label);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelper_DrawString_04(HandleRef pThis, string str, HandleRef tprop, IntPtr pos, double backgroundDepth, HandleRef ren);

	/// <summary>
	/// Format the text in str according to tprop and instruct GL2PS to draw it at
	/// pixel coordinate pos. Background depth is the z value for the background
	/// quad, and should be in NDC space.
	/// The drawing is always done in the overlay plane.
	/// @sa TextAsPath
	/// </summary>
	public virtual void DrawString(string str, vtkTextProperty tprop, IntPtr pos, double backgroundDepth, vtkRenderer ren)
	{
		vtkOpenGLGL2PSHelper_DrawString_04(GetCppThis(), str, tprop?.GetCppThis() ?? default(HandleRef), pos, backgroundDepth, ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern State vtkOpenGLGL2PSHelper_GetActiveState_05(HandleRef pThis);

	/// <summary>
	/// Get the current export state. Vector images are rendered in two passes:
	/// First, all non-vectorizable props are rendered, and the resulting image
	/// is inserted as a raster image into the background of the exported file
	/// (ActiveState == Background). Next, all vectorizable props are drawn
	/// and captured into GL2PS, where they are drawn over the background image.
	/// Vectorizable props should not draw themselves during the background pass,
	/// and use the vtkOpenGLGL2PSHelper API to draw themselves during the capture
	/// pass.
	/// </summary>
	public virtual State GetActiveState()
	{
		return vtkOpenGLGL2PSHelper_GetActiveState_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGL2PSHelper_GetInstance_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The global instance. Only set during export.
	/// </summary>
	public static vtkOpenGLGL2PSHelper GetInstance()
	{
		vtkOpenGLGL2PSHelper vtkOpenGLGL2PSHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGL2PSHelper_GetInstance_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLGL2PSHelper2 = (vtkOpenGLGL2PSHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLGL2PSHelper2.Register(null);
			}
		}
		return vtkOpenGLGL2PSHelper2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkOpenGLGL2PSHelper_GetLineStipple_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the current line stipple pattern per OpenGL convention. Default is
	/// 0xffff.
	/// </summary>
	public virtual ushort GetLineStipple()
	{
		return vtkOpenGLGL2PSHelper_GetLineStipple_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLGL2PSHelper_GetLineWidth_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the current line width.
	/// </summary>
	public virtual float GetLineWidth()
	{
		return vtkOpenGLGL2PSHelper_GetLineWidth_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGL2PSHelper_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLGL2PSHelper_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGL2PSHelper_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLGL2PSHelper_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkOpenGLGL2PSHelper_GetPointSize_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the current point size.
	/// </summary>
	public virtual float GetPointSize()
	{
		return vtkOpenGLGL2PSHelper_GetPointSize_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGL2PSHelper_GetRenderWindow_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the renderwindow that's being exported.
	/// </summary>
	public virtual vtkRenderWindow GetRenderWindow()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGL2PSHelper_GetRenderWindow_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGL2PSHelper_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLGL2PSHelper_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGL2PSHelper_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLGL2PSHelper_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGL2PSHelper_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLGL2PSHelper NewInstance()
	{
		vtkOpenGLGL2PSHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGL2PSHelper_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLGL2PSHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGL2PSHelper_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLGL2PSHelper SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLGL2PSHelper vtkOpenGLGL2PSHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGL2PSHelper_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLGL2PSHelper2 = (vtkOpenGLGL2PSHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLGL2PSHelper2.Register(null);
			}
		}
		return vtkOpenGLGL2PSHelper2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelper_SetInstance_18(HandleRef arg0);

	/// <summary>
	/// The global instance. Only set during export.
	/// </summary>
	public static void SetInstance(vtkOpenGLGL2PSHelper arg0)
	{
		vtkOpenGLGL2PSHelper_SetInstance_18(arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelper_SetLineStipple_19(HandleRef pThis, ushort _arg);

	/// <summary>
	/// Set/Get the current line stipple pattern per OpenGL convention. Default is
	/// 0xffff.
	/// </summary>
	public virtual void SetLineStipple(ushort _arg)
	{
		vtkOpenGLGL2PSHelper_SetLineStipple_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelper_SetLineWidth_20(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the current line width.
	/// </summary>
	public virtual void SetLineWidth(float _arg)
	{
		vtkOpenGLGL2PSHelper_SetLineWidth_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGL2PSHelper_SetPointSize_21(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the current point size.
	/// </summary>
	public virtual void SetPointSize(float _arg)
	{
		vtkOpenGLGL2PSHelper_SetPointSize_21(GetCppThis(), _arg);
	}
}
