using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkShaderProgram
/// </summary>
/// <remarks>
///    a glsl shader program
///
/// This class contains the vertex, fragment, geometry shaders that combine to make a shader program
/// </remarks>
public class vtkShaderProgram : vtkObject
{
	/// <summary>
	/// Options for attribute normalization. 
	/// </summary>
	public enum NormalizeOption
	{
		/// <summary>enum member</summary>
		NoNormalize = 1,
		/// <summary>enum member</summary>
		Normalize = 0
	}

	/// <summary>
	/// Set/Get times that can be used to track when a set of
	/// uniforms was last updated. This can be used to reduce
	/// redundant SetUniformCalls
	/// </summary>
	public enum UniformGroups
	{
		/// <summary>enum member</summary>
		CameraGroup,
		/// <summary>enum member</summary>
		LightingGroup,
		/// <summary>enum member</summary>
		UserGroup
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkShaderProgram";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkShaderProgram()
	{
		MRClassNameKey = "class vtkShaderProgram";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkShaderProgram"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkShaderProgram(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProgram_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkShaderProgram New()
	{
		vtkShaderProgram result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProgram_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkShaderProgram()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkShaderProgram_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkShaderProgram_CompiledOff_01(HandleRef pThis);

	/// <summary>
	/// Set/Get flag for if this program is compiled
	/// </summary>
	public virtual void CompiledOff()
	{
		vtkShaderProgram_CompiledOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_CompiledOn_02(HandleRef pThis);

	/// <summary>
	/// Set/Get flag for if this program is compiled
	/// </summary>
	public virtual void CompiledOn()
	{
		vtkShaderProgram_CompiledOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_DisableAttributeArray_03(HandleRef pThis, string name);

	/// <summary>
	/// Disable the named attribute array. Return false if the attribute array is
	/// not contained in the linked shader program.
	/// </summary>
	public bool DisableAttributeArray(string name)
	{
		return (vtkShaderProgram_DisableAttributeArray_03(GetCppThis(), name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_EnableAttributeArray_04(HandleRef pThis, string name);

	/// <summary>
	/// Enable the named attribute array. Return false if the attribute array is
	/// not contained in the linked shader program.
	/// </summary>
	public bool EnableAttributeArray(string name)
	{
		return (vtkShaderProgram_EnableAttributeArray_04(GetCppThis(), name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShaderProgram_FindAttributeArray_05(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get times that can be used to track when a set of
	/// uniforms was last updated. This can be used to reduce
	/// redundant SetUniformCalls
	/// </summary>
	public int FindAttributeArray(string name)
	{
		return vtkShaderProgram_FindAttributeArray_05(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShaderProgram_FindUniform_06(HandleRef pThis, string name);

	/// <summary>
	/// Set/Get times that can be used to track when a set of
	/// uniforms was last updated. This can be used to reduce
	/// redundant SetUniformCalls
	/// </summary>
	public int FindUniform(string name)
	{
		return vtkShaderProgram_FindUniform_06(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_GetCompiled_07(HandleRef pThis);

	/// <summary>
	/// Set/Get flag for if this program is compiled
	/// </summary>
	public virtual bool GetCompiled()
	{
		return (vtkShaderProgram_GetCompiled_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkShaderProgram_GetError_08(HandleRef pThis);

	/// <summary>
	/// Get the error message (empty if none) for the shader program. 
	/// </summary>
	public string GetError()
	{
		return vtkShaderProgram_GetError_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProgram_GetFileNamePrefixForDebugging_09(HandleRef pThis);

	/// <summary>
	/// When developing shaders, it's often convenient to tweak the shader and
	/// re-render incrementally. This provides a mechanism to do the same. To debug
	/// any shader program, set `FileNamePrefixForDebugging` to a file path e.g.
	/// `/tmp/myshaders`. Subsequently, when `Bind()` is called on the shader
	/// program, it will check for files named `&lt;FileNamePrefixForDebugging&gt;VS.glsl`,
	/// `&lt;FileNamePrefixForDebugging&gt;GS.glsl` and `&lt;FileNamePrefixForDebugging&gt;FS.glsl` for
	/// vertex shader, geometry shader and fragment shader codes respectively. If
	/// a file doesn't exist, then it dumps out the current code to that file.
	/// If the file exists, then the shader is recompiled to use the contents of that file.
	/// Thus, after the files have been dumped in the first render, you can open the files
	/// in a text editor and update as needed. On following render, the modified
	/// contexts from the file will be used.
	///
	/// This is only intended for debugging during development and should not be
	/// used in production.
	/// </summary>
	public virtual string GetFileNamePrefixForDebugging()
	{
		return Marshal.PtrToStringAnsi(vtkShaderProgram_GetFileNamePrefixForDebugging_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProgram_GetFragmentShader_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the fragment shader for this program
	/// </summary>
	public virtual vtkShader GetFragmentShader()
	{
		vtkShader vtkShader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProgram_GetFragmentShader_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShader2 = (vtkShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShader2.Register(null);
			}
		}
		return vtkShader2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProgram_GetGeometryShader_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the geometry shader for this program
	/// </summary>
	public virtual vtkShader GetGeometryShader()
	{
		vtkShader vtkShader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProgram_GetGeometryShader_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShader2 = (vtkShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShader2.Register(null);
			}
		}
		return vtkShader2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShaderProgram_GetHandle_12(HandleRef pThis);

	/// <summary>
	/// Get the handle of the shader program. 
	/// </summary>
	public int GetHandle()
	{
		return vtkShaderProgram_GetHandle_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkShaderProgram_GetMD5Hash_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the md5 hash of this program
	/// </summary>
	public string GetMD5Hash()
	{
		return vtkShaderProgram_GetMD5Hash_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShaderProgram_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkShaderProgram_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShaderProgram_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkShaderProgram_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkShaderProgram_GetUniformGroupUpdateTime_16(HandleRef pThis, int arg0);

	/// <summary>
	/// Set/Get times that can be used to track when a set of
	/// uniforms was last updated. This can be used to reduce
	/// redundant SetUniformCalls
	/// </summary>
	public ulong GetUniformGroupUpdateTime(int arg0)
	{
		return vtkShaderProgram_GetUniformGroupUpdateTime_16(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProgram_GetVertexShader_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vertex shader for this program
	/// </summary>
	public virtual vtkShader GetVertexShader()
	{
		vtkShader vtkShader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProgram_GetVertexShader_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShader2 = (vtkShader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShader2.Register(null);
			}
		}
		return vtkShader2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShaderProgram_IsA_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkShaderProgram_IsA_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_IsAttributeUsed_19(HandleRef pThis, string name);

	/// <summary>
	/// Return true if the compiled and linked shader has an attribute matching @a
	/// name.
	/// </summary>
	public bool IsAttributeUsed(string name)
	{
		return (vtkShaderProgram_IsAttributeUsed_19(GetCppThis(), name) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShaderProgram_IsTypeOf_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkShaderProgram_IsTypeOf_20(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_IsUniformUsed_21(HandleRef pThis, string arg0);

	/// <summary>
	/// methods to inquire as to what uniforms/attributes are used by
	/// this shader.  This can save some compute time if the uniforms
	/// or attributes are expensive to compute
	/// </summary>
	public bool IsUniformUsed(string arg0)
	{
		return (vtkShaderProgram_IsUniformUsed_21(GetCppThis(), arg0) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProgram_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkShaderProgram NewInstance()
	{
		vtkShaderProgram result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProgram_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef win);

	/// <summary>
	/// release any graphics resources this class is using.
	/// </summary>
	public void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkShaderProgram_ReleaseGraphicsResources_24(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProgram_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkShaderProgram SafeDownCast(vtkObjectBase o)
	{
		vtkShaderProgram vtkShaderProgram2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProgram_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShaderProgram2 = (vtkShaderProgram)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShaderProgram2.Register(null);
			}
		}
		return vtkShaderProgram2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_SetCompiled_26(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get flag for if this program is compiled
	/// </summary>
	public virtual void SetCompiled(bool _arg)
	{
		vtkShaderProgram_SetCompiled_26(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_SetFileNamePrefixForDebugging_27(HandleRef pThis, string _arg);

	/// <summary>
	/// When developing shaders, it's often convenient to tweak the shader and
	/// re-render incrementally. This provides a mechanism to do the same. To debug
	/// any shader program, set `FileNamePrefixForDebugging` to a file path e.g.
	/// `/tmp/myshaders`. Subsequently, when `Bind()` is called on the shader
	/// program, it will check for files named `&lt;FileNamePrefixForDebugging&gt;VS.glsl`,
	/// `&lt;FileNamePrefixForDebugging&gt;GS.glsl` and `&lt;FileNamePrefixForDebugging&gt;FS.glsl` for
	/// vertex shader, geometry shader and fragment shader codes respectively. If
	/// a file doesn't exist, then it dumps out the current code to that file.
	/// If the file exists, then the shader is recompiled to use the contents of that file.
	/// Thus, after the files have been dumped in the first render, you can open the files
	/// in a text editor and update as needed. On following render, the modified
	/// contexts from the file will be used.
	///
	/// This is only intended for debugging during development and should not be
	/// used in production.
	/// </summary>
	public virtual void SetFileNamePrefixForDebugging(string _arg)
	{
		vtkShaderProgram_SetFileNamePrefixForDebugging_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_SetFragmentShader_28(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get the fragment shader for this program
	/// </summary>
	public void SetFragmentShader(vtkShader arg0)
	{
		vtkShaderProgram_SetFragmentShader_28(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_SetGeometryShader_29(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get the geometry shader for this program
	/// </summary>
	public void SetGeometryShader(vtkShader arg0)
	{
		vtkShaderProgram_SetGeometryShader_29(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_SetMD5Hash_30(HandleRef pThis, string hash);

	/// <summary>
	/// Set/Get the md5 hash of this program
	/// </summary>
	public void SetMD5Hash(string hash)
	{
		vtkShaderProgram_SetMD5Hash_30(GetCppThis(), hash);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_SetNumberOfOutputs_31(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public virtual void SetNumberOfOutputs(uint _arg)
	{
		vtkShaderProgram_SetNumberOfOutputs_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform1fv_32(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public bool SetUniform1fv(string name, int count, IntPtr f)
	{
		return (vtkShaderProgram_SetUniform1fv_32(GetCppThis(), name, count, f) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform1iv_33(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public bool SetUniform1iv(string name, int count, IntPtr f)
	{
		return (vtkShaderProgram_SetUniform1iv_33(GetCppThis(), name, count, f) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform2f_34(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniform2f(string name, IntPtr v)
	{
		return (vtkShaderProgram_SetUniform2f_34(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform2fv_35(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public bool SetUniform2fv(string name, int count, IntPtr f)
	{
		return (vtkShaderProgram_SetUniform2fv_35(GetCppThis(), name, count, f) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform2i_36(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniform2i(string name, IntPtr v)
	{
		return (vtkShaderProgram_SetUniform2i_36(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform3f_37(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniform3f(string name, IntPtr v)
	{
		return (vtkShaderProgram_SetUniform3f_37(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform3fv_38(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public bool SetUniform3fv(string name, int count, IntPtr f)
	{
		return (vtkShaderProgram_SetUniform3fv_38(GetCppThis(), name, count, f) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform3uc_39(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniform3uc(string name, IntPtr v)
	{
		return (vtkShaderProgram_SetUniform3uc_39(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform4f_40(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniform4f(string name, IntPtr v)
	{
		return (vtkShaderProgram_SetUniform4f_40(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform4fv_41(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public bool SetUniform4fv(string name, int count, IntPtr f)
	{
		return (vtkShaderProgram_SetUniform4fv_41(GetCppThis(), name, count, f) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniform4uc_42(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniform4uc(string name, IntPtr v)
	{
		return (vtkShaderProgram_SetUniform4uc_42(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_SetUniformGroupUpdateTime_43(HandleRef pThis, int arg0, ulong tm);

	/// <summary>
	/// Set/Get times that can be used to track when a set of
	/// uniforms was last updated. This can be used to reduce
	/// redundant SetUniformCalls
	/// </summary>
	public void SetUniformGroupUpdateTime(int arg0, ulong tm)
	{
		vtkShaderProgram_SetUniformGroupUpdateTime_43(GetCppThis(), arg0, tm);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniformMatrix_44(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniformMatrix(string name, vtkMatrix3x3 v)
	{
		return (vtkShaderProgram_SetUniformMatrix_44(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniformMatrix_45(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniformMatrix(string name, vtkMatrix4x4 v)
	{
		return (vtkShaderProgram_SetUniformMatrix_45(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniformMatrix3x3_46(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniformMatrix3x3(string name, IntPtr v)
	{
		return (vtkShaderProgram_SetUniformMatrix3x3_46(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniformMatrix4x4_47(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniformMatrix4x4(string name, IntPtr v)
	{
		return (vtkShaderProgram_SetUniformMatrix4x4_47(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniformMatrix4x4v_48(HandleRef pThis, string name, int count, IntPtr v);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public bool SetUniformMatrix4x4v(string name, int count, IntPtr v)
	{
		return (vtkShaderProgram_SetUniformMatrix4x4v_48(GetCppThis(), name, count, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniformf_49(HandleRef pThis, string name, float v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniformf(string name, float v)
	{
		return (vtkShaderProgram_SetUniformf_49(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_SetUniformi_50(HandleRef pThis, string name, int v);

	/// <summary>
	/// Set the @p name uniform value to int @p v. 
	/// </summary>
	public bool SetUniformi(string name, int v)
	{
		return (vtkShaderProgram_SetUniformi_50(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProgram_SetVertexShader_51(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Get the vertex shader for this program
	/// </summary>
	public void SetVertexShader(vtkShader arg0)
	{
		vtkShaderProgram_SetVertexShader_51(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_Substitute_52(string source, string search, string replace, byte all);

	/// <summary>
	/// perform in place string substitutions, indicate if a substitution was done
	/// this is useful for building up shader strings which typically involve
	/// lots of string substitutions.
	///
	/// \param[in] source  The source code to perform substitutions on
	/// \param[in] search  The string to search for
	/// \param[in] replace The string replacement
	/// \param[in] all     Whether to replace all matches or just the first one
	/// \return    A boolean indicating whether the replacement was successful
	/// </summary>
	public static bool Substitute(string source, string search, string replace, bool all)
	{
		return (vtkShaderProgram_Substitute_52(source, search, replace, (byte)(all ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_Substitute_53(HandleRef shader, string search, string replace, byte all);

	/// <summary>
	/// Perform in-place string substitutions on the shader source string and
	/// indicate if one or all substitutions were done. This is useful for building
	/// up shader strings which typically involve a lot of string substitutions.
	///
	/// \param[in] shader  The source shader object to perform substitutions on
	/// \param[in] search  The string to search for
	/// \param[in] replace The string replacement
	/// \param[in] all     Whether to replace all matches or just the first one
	/// \return    A boolean indicating whether the replacement was successful
	/// </summary>
	public static bool Substitute(vtkShader shader, string search, string replace, bool all)
	{
		return (vtkShaderProgram_Substitute_53(shader?.GetCppThis() ?? default(HandleRef), search, replace, (byte)(all ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_UseAttributeArray_54(HandleRef pThis, string name, int offset, ulong stride, int elementType, int elementTupleSize, NormalizeOption normalize);

	/// <summary>
	/// Use the named attribute array with the bound BufferObject.
	/// @param name of the attribute (as seen in the shader program).
	/// @param offset into the bound BufferObject.
	/// @param stride The stride of the element access (i.e. the size of each
	/// element in the currently bound BufferObject). 0 may be used to indicate
	/// tightly packed data.
	/// @param elementType Tag identifying the memory representation of the
	/// element.
	/// @param elementTupleSize The number of elements per vertex (e.g. a 3D
	/// position attribute would be 3).
	/// @param normalize Indicates the range used by the attribute data.
	/// See NormalizeOption for more information.
	/// @return false if the attribute array does not exist.
	/// </summary>
	public bool UseAttributeArray(string name, int offset, ulong stride, int elementType, int elementTupleSize, NormalizeOption normalize)
	{
		return (vtkShaderProgram_UseAttributeArray_54(GetCppThis(), name, offset, stride, elementType, elementTupleSize, normalize) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProgram_isBound_55(HandleRef pThis);

	/// <summary>
	/// Check if the program is currently bound, or not.
	/// @return True if the program is bound, false otherwise.
	/// </summary>
	public bool isBound()
	{
		return (vtkShaderProgram_isBound_55(GetCppThis()) != 0) ? true : false;
	}
}
