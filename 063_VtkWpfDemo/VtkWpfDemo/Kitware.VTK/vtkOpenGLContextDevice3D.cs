using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLContextDevice3D
/// </summary>
/// <remarks>
///    OpenGL class drawing 3D primitives.
///
///
/// This defines the implementation of a 3D context device for drawing simple
/// primitives.
/// </remarks>
public class vtkOpenGLContextDevice3D : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLContextDevice3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLContextDevice3D()
	{
		MRClassNameKey = "class vtkOpenGLContextDevice3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLContextDevice3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLContextDevice3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLContextDevice3D New()
	{
		vtkOpenGLContextDevice3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLContextDevice3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLContextDevice3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLContextDevice3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOpenGLContextDevice3D_ApplyBrush_01(HandleRef pThis, HandleRef brush);

	/// <summary>
	/// Apply the supplied brush which controls the outlines of shapes, as well as
	/// lines, points and related primitives. This makes a deep copy of the vtkBrush
	/// object in the vtkContext2D, it does not hold a pointer to the supplied object.
	/// </summary>
	public virtual void ApplyBrush(vtkBrush brush)
	{
		vtkOpenGLContextDevice3D_ApplyBrush_01(GetCppThis(), brush?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_ApplyPen_02(HandleRef pThis, HandleRef pen);

	/// <summary>
	/// Apply the supplied pen which controls the outlines of shapes, as well as
	/// lines, points and related primitives. This makes a deep copy of the vtkPen
	/// object in the vtkContext2D, it does not hold a pointer to the supplied object.
	/// </summary>
	public virtual void ApplyPen(vtkPen pen)
	{
		vtkOpenGLContextDevice3D_ApplyPen_02(GetCppThis(), pen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_Begin_03(HandleRef pThis, HandleRef viewport);

	/// <summary>
	/// Begin drawing, pass in the viewport to set up the view.
	/// </summary>
	public virtual void Begin(vtkViewport viewport)
	{
		vtkOpenGLContextDevice3D_Begin_03(GetCppThis(), viewport?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_DisableClippingPlane_04(HandleRef pThis, int i);

	/// <summary>
	/// Enable/Disable the specified clipping plane.
	/// i is the index of the clipping plane being enabled or disabled (0 - 5).
	/// planeEquation points to the four coefficients of the equation for the
	/// clipping plane: Ax + By + Cz + D = 0.  This is the equation format
	/// expected by glClipPlane.
	/// </summary>
	public virtual void DisableClippingPlane(int i)
	{
		vtkOpenGLContextDevice3D_DisableClippingPlane_04(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_DrawLines_05(HandleRef pThis, IntPtr verts, int n, IntPtr colors, int nc);

	/// <summary>
	/// Draw lines defined by specified pair of points.
	/// \sa DrawPoly()
	/// </summary>
	public virtual void DrawLines(IntPtr verts, int n, IntPtr colors, int nc)
	{
		vtkOpenGLContextDevice3D_DrawLines_05(GetCppThis(), verts, n, colors, nc);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_DrawPoints_06(HandleRef pThis, IntPtr verts, int n, IntPtr colors, int nc);

	/// <summary>
	/// Draw points at the vertex positions specified.
	/// </summary>
	public virtual void DrawPoints(IntPtr verts, int n, IntPtr colors, int nc)
	{
		vtkOpenGLContextDevice3D_DrawPoints_06(GetCppThis(), verts, n, colors, nc);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_DrawPoly_07(HandleRef pThis, IntPtr verts, int n, IntPtr colors, int nc);

	/// <summary>
	/// Draw a polyline between the specified points.
	/// </summary>
	public virtual void DrawPoly(IntPtr verts, int n, IntPtr colors, int nc)
	{
		vtkOpenGLContextDevice3D_DrawPoly_07(GetCppThis(), verts, n, colors, nc);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_DrawTriangleMesh_08(HandleRef pThis, IntPtr mesh, int n, IntPtr colors, int nc);

	/// <summary>
	/// Draw triangles to generate the specified mesh.
	/// </summary>
	public virtual void DrawTriangleMesh(IntPtr mesh, int n, IntPtr colors, int nc)
	{
		vtkOpenGLContextDevice3D_DrawTriangleMesh_08(GetCppThis(), mesh, n, colors, nc);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_EnableClipping_09(HandleRef pThis, byte enable);

	/// <summary>
	/// Enable or disable the clipping of the scene.
	/// </summary>
	public virtual void EnableClipping(bool enable)
	{
		vtkOpenGLContextDevice3D_EnableClipping_09(GetCppThis(), (byte)(enable ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_EnableClippingPlane_10(HandleRef pThis, int i, IntPtr planeEquation);

	/// <summary>
	/// Enable/Disable the specified clipping plane.
	/// i is the index of the clipping plane being enabled or disabled (0 - 5).
	/// planeEquation points to the four coefficients of the equation for the
	/// clipping plane: Ax + By + Cz + D = 0.  This is the equation format
	/// expected by glClipPlane.
	/// </summary>
	public virtual void EnableClippingPlane(int i, IntPtr planeEquation)
	{
		vtkOpenGLContextDevice3D_EnableClippingPlane_10(GetCppThis(), i, planeEquation);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_GetMatrix_11(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Set the model view matrix for the display
	/// </summary>
	public virtual void GetMatrix(vtkMatrix4x4 m)
	{
		vtkOpenGLContextDevice3D_GetMatrix_11(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLContextDevice3D_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLContextDevice3D_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLContextDevice3D_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLContextDevice3D_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_Initialize_14(HandleRef pThis, HandleRef arg0, HandleRef arg1);

	/// <summary>
	/// This must be set during initialization
	/// </summary>
	public void Initialize(vtkRenderer arg0, vtkOpenGLContextDevice2D arg1)
	{
		vtkOpenGLContextDevice3D_Initialize_14(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLContextDevice3D_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLContextDevice3D_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLContextDevice3D_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLContextDevice3D_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_MultiplyMatrix_17(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Multiply the current model view matrix by the supplied one
	/// </summary>
	public virtual void MultiplyMatrix(vtkMatrix4x4 m)
	{
		vtkOpenGLContextDevice3D_MultiplyMatrix_17(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice3D_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLContextDevice3D NewInstance()
	{
		vtkOpenGLContextDevice3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice3D_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLContextDevice3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_PopMatrix_20(HandleRef pThis);

	/// <summary>
	/// Pop the current matrix off of the stack.
	/// </summary>
	public virtual void PopMatrix()
	{
		vtkOpenGLContextDevice3D_PopMatrix_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_PushMatrix_21(HandleRef pThis);

	/// <summary>
	/// Push the current matrix onto the stack.
	/// </summary>
	public virtual void PushMatrix()
	{
		vtkOpenGLContextDevice3D_PushMatrix_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextDevice3D_SafeDownCast_22(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLContextDevice3D SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLContextDevice3D vtkOpenGLContextDevice3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextDevice3D_SafeDownCast_22(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLContextDevice3D2 = (vtkOpenGLContextDevice3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLContextDevice3D2.Register(null);
			}
		}
		return vtkOpenGLContextDevice3D2;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_SetClipping_23(HandleRef pThis, HandleRef rect);

	/// <summary>
	/// Supply a float array of length 4 with x1, y1, width, height specifying
	/// clipping region for the device in pixels.
	/// </summary>
	public virtual void SetClipping(vtkRecti rect)
	{
		vtkOpenGLContextDevice3D_SetClipping_23(GetCppThis(), rect?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextDevice3D_SetMatrix_24(HandleRef pThis, HandleRef m);

	/// <summary>
	/// Set the model view matrix for the display
	/// </summary>
	public virtual void SetMatrix(vtkMatrix4x4 m)
	{
		vtkOpenGLContextDevice3D_SetMatrix_24(GetCppThis(), m?.GetCppThis() ?? default(HandleRef));
	}
}
