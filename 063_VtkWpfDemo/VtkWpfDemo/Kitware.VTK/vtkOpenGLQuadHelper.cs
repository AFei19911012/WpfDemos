using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLQuadHelper
/// </summary>
/// <remarks>
///    Class to make rendering a full screen quad easier
///
/// vtkOpenGLQuadHelper is designed to be used by classes in VTK that
/// need to render a quad to the screen with a shader program. This happens
/// often with render passes or other advanced rendering techniques.
///
/// Note that when releasing graphics resources instances of this
/// class should be destroyed. A common use pattern is to conditionally
/// create the instance where used and delete it in ReleaseGraphicsResources
/// and the destructor.
///
/// It is possible to flip the Y direction of the quad texture coordinate by
/// turning on the flipY option in the constructor. This can be useful when
/// rendering in an external context having a different convention than OpenGL
/// e.g. OpenGL-D3D shared textures. Off by default if unspecified.
///
/// Example usage:
/// @code
/// if (!this-&gt;QuadHelper)
/// {
///   this-&gt;QuadHelper = vtkOpenGLQualHelper(renWin, vs, fs, gs);
/// }
/// renWin-&gt;GetShaderCache()-&gt;ReadyShaderProgram(this-&gt;QuadHelper-&gt;Program);
/// aTexture-&gt;Activate();
/// this-&gt;QuadHelper-&gt;Program-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
/// this-&gt;QuadHelper-&gt;Render();
/// aTexture-&gt;Deactivate();
/// @endcode
///
/// </remarks>
/// <seealso>
///  vtkOpenGLRenderUtilities
/// </seealso>
public class vtkOpenGLQuadHelper : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLQuadHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLQuadHelper()
	{
		MRClassNameKey = "class vtkOpenGLQuadHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLQuadHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLQuadHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern void vtkOpenGLQuadHelper_ReleaseGraphicsResources_01(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release graphics resources. In general, there's no need to call this
	/// explicitly, since vtkOpenGLQuadHelper will invoke it appropriately when
	/// needed.
	/// </summary>
	public void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkOpenGLQuadHelper_ReleaseGraphicsResources_01(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLQuadHelper_Render_02(HandleRef pThis);

	/// <summary>
	/// Create a quadhelper with the provided shaders.
	/// If the vertex is nullptr then the default is used.
	/// Turning on the flipY option reverts the y component of the quad texture coordinates in
	/// order to flip the rendered texture.
	/// Note that this class should be destroyed upon ReleaseGraphicsResources.
	/// </summary>
	public void Render()
	{
		vtkOpenGLQuadHelper_Render_02(GetCppThis());
	}
}
