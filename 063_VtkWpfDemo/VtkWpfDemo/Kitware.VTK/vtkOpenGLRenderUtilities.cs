using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLRenderUtilities
/// </summary>
/// <remarks>
///    OpenGL rendering utility functions
///
/// vtkOpenGLRenderUtilities provides functions to help render primitives.
///
/// See also the vtkOpenGLQuadHelper class which may be easier to use.
///
/// </remarks>
public class vtkOpenGLRenderUtilities : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRenderUtilities";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLRenderUtilities()
	{
		MRClassNameKey = "class vtkOpenGLRenderUtilities";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRenderUtilities"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLRenderUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern void vtkOpenGLRenderUtilities_DrawFullScreenQuad_01();

	/// <summary>
	/// Draw a full-screen quad:
	///
	/// * VertexShader and GeometryShader should be used as-is when building the
	/// ShaderProgram.
	/// * FragmentShaderTemplate supports the replacements @code //VTK::FSQ::Decl @endcode and
	/// @code //VTK::FSQ::Impl @endcode for declaring variables and the shader body,
	/// respectively.
	/// * The varying texCoord is available to the fragment shader for texture
	/// lookups into full-screen textures, ie. texture2D(textureName, texCoord).
	/// * PrepFullScreenVAO initializes a new VAO for drawing a quad.
	/// * DrawFullScreenQuad actually draws the quad.
	///
	/// Example usage:
	/// @code
	/// typedef vtkOpenGLRenderUtilities GLUtil;
	///
	/// // Prep fragment shader source:
	/// std::string fragShader = GLUtil::GetFullScreenQuadFragmentShaderTemplate();
	/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Decl",
	/// "uniform sampler2D aTexture;");
	/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Impl",
	/// "gl_FragData[0] = texture2D(aTexture, texCoord);");
	///
	/// // Create shader program:
	/// vtkShaderProgram *prog = shaderCache-&gt;ReadyShaderProgram(
	/// GLUtil::GetFullScreenQuadVertexShader().c_str(),
	/// fragShader.c_str(),
	/// GLUtil::GetFullScreenQuadGeometryShader().c_str());
	///
	/// // Initialize new VAO/vertex buffer. This is only done once:
	/// vtkNew&lt;vtkOpenGLVertexArrayObject&gt; vao;
	/// GLUtil::PrepFullScreenVAO(renWin, vao.Get(), prog);
	///
	/// // Setup shader program to sample vtkTextureObject aTexture:
	/// aTexture-&gt;Activate();
	/// prog-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
	///
	/// // Render the full-screen quad:
	/// vao-&gt;Bind();
	/// GLUtil::DrawFullScreenQuad();
	/// vao-&gt;Release();
	/// aTexture-&gt;Deactivate();
	/// @endcode
	/// </summary>
	public static void DrawFullScreenQuad()
	{
		vtkOpenGLRenderUtilities_DrawFullScreenQuad_01();
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkOpenGLRenderUtilities_GetFullScreenQuadFragmentShaderTemplate_02();

	/// <summary>
	/// Draw a full-screen quad:
	///
	/// * VertexShader and GeometryShader should be used as-is when building the
	/// ShaderProgram.
	/// * FragmentShaderTemplate supports the replacements @code //VTK::FSQ::Decl @endcode and
	/// @code //VTK::FSQ::Impl @endcode for declaring variables and the shader body,
	/// respectively.
	/// * The varying texCoord is available to the fragment shader for texture
	/// lookups into full-screen textures, ie. texture2D(textureName, texCoord).
	/// * PrepFullScreenVAO initializes a new VAO for drawing a quad.
	/// * DrawFullScreenQuad actually draws the quad.
	///
	/// Example usage:
	/// @code
	/// typedef vtkOpenGLRenderUtilities GLUtil;
	///
	/// // Prep fragment shader source:
	/// std::string fragShader = GLUtil::GetFullScreenQuadFragmentShaderTemplate();
	/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Decl",
	/// "uniform sampler2D aTexture;");
	/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Impl",
	/// "gl_FragData[0] = texture2D(aTexture, texCoord);");
	///
	/// // Create shader program:
	/// vtkShaderProgram *prog = shaderCache-&gt;ReadyShaderProgram(
	/// GLUtil::GetFullScreenQuadVertexShader().c_str(),
	/// fragShader.c_str(),
	/// GLUtil::GetFullScreenQuadGeometryShader().c_str());
	///
	/// // Initialize new VAO/vertex buffer. This is only done once:
	/// vtkNew&lt;vtkOpenGLVertexArrayObject&gt; vao;
	/// GLUtil::PrepFullScreenVAO(renWin, vao.Get(), prog);
	///
	/// // Setup shader program to sample vtkTextureObject aTexture:
	/// aTexture-&gt;Activate();
	/// prog-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
	///
	/// // Render the full-screen quad:
	/// vao-&gt;Bind();
	/// GLUtil::DrawFullScreenQuad();
	/// vao-&gt;Release();
	/// aTexture-&gt;Deactivate();
	/// @endcode
	/// </summary>
	public static string GetFullScreenQuadFragmentShaderTemplate()
	{
		return vtkOpenGLRenderUtilities_GetFullScreenQuadFragmentShaderTemplate_02();
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkOpenGLRenderUtilities_GetFullScreenQuadGeometryShader_03();

	/// <summary>
	/// Draw a full-screen quad:
	///
	/// * VertexShader and GeometryShader should be used as-is when building the
	/// ShaderProgram.
	/// * FragmentShaderTemplate supports the replacements @code //VTK::FSQ::Decl @endcode and
	/// @code //VTK::FSQ::Impl @endcode for declaring variables and the shader body,
	/// respectively.
	/// * The varying texCoord is available to the fragment shader for texture
	/// lookups into full-screen textures, ie. texture2D(textureName, texCoord).
	/// * PrepFullScreenVAO initializes a new VAO for drawing a quad.
	/// * DrawFullScreenQuad actually draws the quad.
	///
	/// Example usage:
	/// @code
	/// typedef vtkOpenGLRenderUtilities GLUtil;
	///
	/// // Prep fragment shader source:
	/// std::string fragShader = GLUtil::GetFullScreenQuadFragmentShaderTemplate();
	/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Decl",
	/// "uniform sampler2D aTexture;");
	/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Impl",
	/// "gl_FragData[0] = texture2D(aTexture, texCoord);");
	///
	/// // Create shader program:
	/// vtkShaderProgram *prog = shaderCache-&gt;ReadyShaderProgram(
	/// GLUtil::GetFullScreenQuadVertexShader().c_str(),
	/// fragShader.c_str(),
	/// GLUtil::GetFullScreenQuadGeometryShader().c_str());
	///
	/// // Initialize new VAO/vertex buffer. This is only done once:
	/// vtkNew&lt;vtkOpenGLVertexArrayObject&gt; vao;
	/// GLUtil::PrepFullScreenVAO(renWin, vao.Get(), prog);
	///
	/// // Setup shader program to sample vtkTextureObject aTexture:
	/// aTexture-&gt;Activate();
	/// prog-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
	///
	/// // Render the full-screen quad:
	/// vao-&gt;Bind();
	/// GLUtil::DrawFullScreenQuad();
	/// vao-&gt;Release();
	/// aTexture-&gt;Deactivate();
	/// @endcode
	/// </summary>
	public static string GetFullScreenQuadGeometryShader()
	{
		return vtkOpenGLRenderUtilities_GetFullScreenQuadGeometryShader_03();
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkOpenGLRenderUtilities_GetFullScreenQuadVertexShader_04();

	/// <summary>
	/// Draw a full-screen quad:
	///
	/// * VertexShader and GeometryShader should be used as-is when building the
	/// ShaderProgram.
	/// * FragmentShaderTemplate supports the replacements @code //VTK::FSQ::Decl @endcode and
	/// @code //VTK::FSQ::Impl @endcode for declaring variables and the shader body,
	/// respectively.
	/// * The varying texCoord is available to the fragment shader for texture
	/// lookups into full-screen textures, ie. texture2D(textureName, texCoord).
	/// * PrepFullScreenVAO initializes a new VAO for drawing a quad.
	/// * DrawFullScreenQuad actually draws the quad.
	///
	/// Example usage:
	/// @code
	/// typedef vtkOpenGLRenderUtilities GLUtil;
	///
	/// // Prep fragment shader source:
	/// std::string fragShader = GLUtil::GetFullScreenQuadFragmentShaderTemplate();
	/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Decl",
	/// "uniform sampler2D aTexture;");
	/// vtkShaderProgram::Substitute(fragShader, "//VTK::FSQ::Impl",
	/// "gl_FragData[0] = texture2D(aTexture, texCoord);");
	///
	/// // Create shader program:
	/// vtkShaderProgram *prog = shaderCache-&gt;ReadyShaderProgram(
	/// GLUtil::GetFullScreenQuadVertexShader().c_str(),
	/// fragShader.c_str(),
	/// GLUtil::GetFullScreenQuadGeometryShader().c_str());
	///
	/// // Initialize new VAO/vertex buffer. This is only done once:
	/// vtkNew&lt;vtkOpenGLVertexArrayObject&gt; vao;
	/// GLUtil::PrepFullScreenVAO(renWin, vao.Get(), prog);
	///
	/// // Setup shader program to sample vtkTextureObject aTexture:
	/// aTexture-&gt;Activate();
	/// prog-&gt;SetUniformi("aTexture", aTexture-&gt;GetTextureUnit());
	///
	/// // Render the full-screen quad:
	/// vao-&gt;Bind();
	/// GLUtil::DrawFullScreenQuad();
	/// vao-&gt;Release();
	/// aTexture-&gt;Deactivate();
	/// @endcode
	/// </summary>
	public static string GetFullScreenQuadVertexShader()
	{
		return vtkOpenGLRenderUtilities_GetFullScreenQuadVertexShader_04();
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderUtilities_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLRenderUtilities_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRenderUtilities_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLRenderUtilities_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderUtilities_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLRenderUtilities_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRenderUtilities_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLRenderUtilities_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRenderUtilities_MarkDebugEvent_09(string arg0);

	/// <summary>
	/// Pass a debugging mark to the render engine to assist development via tools
	/// like apitrace. This calls glDebugMessageInsert to insert the event string
	/// into the OpenGL command stream.
	///
	/// Note that this method only works when glDebugMessageInsert is bound, which
	/// it may not be on certain platforms.
	/// </summary>
	public static void MarkDebugEvent(string arg0)
	{
		vtkOpenGLRenderUtilities_MarkDebugEvent_09(arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderUtilities_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLRenderUtilities NewInstance()
	{
		vtkOpenGLRenderUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderUtilities_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRenderUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRenderUtilities_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRenderUtilities SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLRenderUtilities vtkOpenGLRenderUtilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRenderUtilities_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLRenderUtilities2 = (vtkOpenGLRenderUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLRenderUtilities2.Register(null);
			}
		}
		return vtkOpenGLRenderUtilities2;
	}
}
