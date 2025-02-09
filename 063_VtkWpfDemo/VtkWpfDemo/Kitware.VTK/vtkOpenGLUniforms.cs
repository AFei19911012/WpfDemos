using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLUniforms
/// </summary>
/// <remarks>
///    helper class to set custom uniform variables in GLSL shaders.
///
/// This class implements all SetUniform* functions supported by vtkShaderProgram but instead of
/// directly calling the underlying OpenGL functions, it caches the name and value of the variable
/// and provides a mechanism for client mappers to set all cached variables at once in a generic way.
///
/// The basic types of GLSL uniform variables supported by the class are the following: int, float,
/// vec2i, vec3, vec4, mat3, mat4, int[], float[], vec2i[], vec3[], vec4[], mat4[]. All other
/// types supported by Set* functions undergo the same type conversions implemented in
/// vtkShaderProgram.
///
/// @par Thanks:
/// Developed by Simon Drouin (sdrouin2@bwh.harvard.edu) at Brigham and Women's Hospital.
/// </remarks>
public class vtkOpenGLUniforms : vtkUniforms
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLUniforms";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLUniforms()
	{
		MRClassNameKey = "class vtkOpenGLUniforms";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLUniforms"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLUniforms(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLUniforms_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLUniforms New()
	{
		vtkOpenGLUniforms result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLUniforms_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLUniforms)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLUniforms()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLUniforms_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern string vtkOpenGLUniforms_GetDeclarations_01(HandleRef pThis);

	/// <summary>
	///             all stored uniform variables. This is typically called
	/// </summary>
	public string GetDeclarations()
	{
		return vtkOpenGLUniforms_GetDeclarations_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLUniforms_GetNthUniformName_02(HandleRef pThis, long uniformIndex);

	/// <summary>
	/// Get number of all uniforms stored in this clas
	/// </summary>
	public override string GetNthUniformName(long uniformIndex)
	{
		return Marshal.PtrToStringAnsi(vtkOpenGLUniforms_GetNthUniformName_02(GetCppThis(), uniformIndex));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLUniforms_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLUniforms_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLUniforms_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLUniforms_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLUniforms_GetNumberOfUniforms_05(HandleRef pThis);

	/// <summary>
	/// Get number of all uniforms stored in this class 
	/// </summary>
	public override int GetNumberOfUniforms()
	{
		return vtkOpenGLUniforms_GetNumberOfUniforms_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniform2f_06(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public override bool GetUniform2f(string name, IntPtr v)
	{
		return (vtkOpenGLUniforms_GetUniform2f_06(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniform2i_07(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public override bool GetUniform2i(string name, IntPtr v)
	{
		return (vtkOpenGLUniforms_GetUniform2i_07(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniform3f_08(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public override bool GetUniform3f(string name, IntPtr v)
	{
		return (vtkOpenGLUniforms_GetUniform3f_08(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniform3uc_09(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public override bool GetUniform3uc(string name, IntPtr v)
	{
		return (vtkOpenGLUniforms_GetUniform3uc_09(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniform4f_10(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public override bool GetUniform4f(string name, IntPtr v)
	{
		return (vtkOpenGLUniforms_GetUniform4f_10(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniform4uc_11(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public override bool GetUniform4uc(string name, IntPtr v)
	{
		return (vtkOpenGLUniforms_GetUniform4uc_11(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkOpenGLUniforms_GetUniformListMTime_12(HandleRef pThis);

	/// <summary>
	///  which is typically used to check whether the shader
	///  needs to be recompiled. The time stamp is not affected
	///  by the modification of the value of an existing variable
	/// </summary>
	public override ulong GetUniformListMTime()
	{
		return vtkOpenGLUniforms_GetUniformListMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniformMatrix_13(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public override bool GetUniformMatrix(string name, vtkMatrix3x3 v)
	{
		return (vtkOpenGLUniforms_GetUniformMatrix_13(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniformMatrix_14(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public override bool GetUniformMatrix(string name, vtkMatrix4x4 v)
	{
		return (vtkOpenGLUniforms_GetUniformMatrix_14(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniformMatrix3x3_15(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public override bool GetUniformMatrix3x3(string name, IntPtr v)
	{
		return (vtkOpenGLUniforms_GetUniformMatrix3x3_15(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniformMatrix4x4_16(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public override bool GetUniformMatrix4x4(string name, IntPtr v)
	{
		return (vtkOpenGLUniforms_GetUniformMatrix4x4_16(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLUniforms_GetUniformNumberOfComponents_17(HandleRef pThis, string name);

	/// <summary>
	/// for example, a uniform with tuples of matrix type and 9 components
	/// </summary>
	public override int GetUniformNumberOfComponents(string name)
	{
		return vtkOpenGLUniforms_GetUniformNumberOfComponents_17(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLUniforms_GetUniformNumberOfTuples_18(HandleRef pThis, string name);

	/// <summary>
	/// Get length of a uniform @p name that contains a variable-size vecto
	/// </summary>
	public override int GetUniformNumberOfTuples(string name)
	{
		return vtkOpenGLUniforms_GetUniformNumberOfTuples_18(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLUniforms_GetUniformScalarType_19(HandleRef pThis, string name);

	/// <summary>
	/// Get type of scalars stored in uniform @p name 
	/// </summary>
	public override int GetUniformScalarType(string name)
	{
		return vtkOpenGLUniforms_GetUniformScalarType_19(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern TupleType vtkOpenGLUniforms_GetUniformTupleType_20(HandleRef pThis, string name);

	/// <summary>
	/// Get the tuple type stored in uniform @p name. This can be a scala
	/// </summary>
	public override TupleType GetUniformTupleType(string name)
	{
		return vtkOpenGLUniforms_GetUniformTupleType_20(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniformf_21(HandleRef pThis, string name, ref float v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public override bool GetUniformf(string name, ref float v)
	{
		return (vtkOpenGLUniforms_GetUniformf_21(GetCppThis(), name, ref v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_GetUniformi_22(HandleRef pThis, string name, ref int v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public override bool GetUniformi(string name, ref int v)
	{
		return (vtkOpenGLUniforms_GetUniformi_22(GetCppThis(), name, ref v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLUniforms_IsA_23(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLUniforms_IsA_23(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLUniforms_IsTypeOf_24(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLUniforms_IsTypeOf_24(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLUniforms_NewInstance_26(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLUniforms NewInstance()
	{
		vtkOpenGLUniforms result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLUniforms_NewInstance_26(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLUniforms)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_RemoveAllUniforms_27(HandleRef pThis);

	/// <summary>
	/// Remove all uniform variables 
	/// </summary>
	public override void RemoveAllUniforms()
	{
		vtkOpenGLUniforms_RemoveAllUniforms_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_RemoveUniform_28(HandleRef pThis, string name);

	/// <summary>
	/// Remove uniform variable named @p name 
	/// </summary>
	public override void RemoveUniform(string name)
	{
		vtkOpenGLUniforms_RemoveUniform_28(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLUniforms_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLUniforms SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLUniforms vtkOpenGLUniforms2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLUniforms_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLUniforms2 = (vtkOpenGLUniforms)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLUniforms2.Register(null);
			}
		}
		return vtkOpenGLUniforms2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniform1fv_30(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public override void SetUniform1fv(string name, int count, IntPtr f)
	{
		vtkOpenGLUniforms_SetUniform1fv_30(GetCppThis(), name, count, f);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniform1iv_31(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public override void SetUniform1iv(string name, int count, IntPtr f)
	{
		vtkOpenGLUniforms_SetUniform1iv_31(GetCppThis(), name, count, f);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniform2f_32(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public override void SetUniform2f(string name, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniform2f_32(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniform2i_33(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public override void SetUniform2i(string name, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniform2i_33(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniform3f_34(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public override void SetUniform3f(string name, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniform3f_34(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniform3uc_35(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public override void SetUniform3uc(string name, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniform3uc_35(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniform4f_36(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public override void SetUniform4f(string name, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniform4f_36(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniform4uc_37(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public override void SetUniform4uc(string name, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniform4uc_37(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniformMatrix_38(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public override void SetUniformMatrix(string name, vtkMatrix3x3 v)
	{
		vtkOpenGLUniforms_SetUniformMatrix_38(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniformMatrix_39(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public override void SetUniformMatrix(string name, vtkMatrix4x4 v)
	{
		vtkOpenGLUniforms_SetUniformMatrix_39(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniformMatrix3x3_40(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public override void SetUniformMatrix3x3(string name, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniformMatrix3x3_40(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniformMatrix4x4_41(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public override void SetUniformMatrix4x4(string name, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniformMatrix4x4_41(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniformMatrix4x4v_42(HandleRef pThis, string name, int count, IntPtr v);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public override void SetUniformMatrix4x4v(string name, int count, IntPtr v)
	{
		vtkOpenGLUniforms_SetUniformMatrix4x4v_42(GetCppThis(), name, count, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniformf_43(HandleRef pThis, string name, float v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public override void SetUniformf(string name, float v)
	{
		vtkOpenGLUniforms_SetUniformf_43(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLUniforms_SetUniformi_44(HandleRef pThis, string name, int v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public override void SetUniformi(string name, int v)
	{
		vtkOpenGLUniforms_SetUniformi_44(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLUniforms_SetUniforms_45(HandleRef pThis, HandleRef p);

	/// <summary>
	///  in the shader program @p p. This is called
	/// </summary>
	public bool SetUniforms(vtkShaderProgram p)
	{
		return (vtkOpenGLUniforms_SetUniforms_45(GetCppThis(), p?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}
}
