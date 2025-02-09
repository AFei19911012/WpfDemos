using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUniforms
/// </summary>
/// <remarks>
///    helper class to set custom uniform variables in GPU shaders.
///
/// This class implements a generic mechanism to declare and set the value of custom uniform
/// variables to be used in GPU shader programs used by mappers. It allows users who specify
/// custom shader code for mappers to change the value of the variable they define without
/// triggering a costly rebuild of the shader. This class is used mostly as an interface and
/// the implementation is found in graphics api specific derived classes (e.g.: vtkOpenGLUniforms).
///
/// </remarks>
/// <seealso>
///
/// vtkOpenGLUniforms vtkShaderProperty
///
/// @par Thanks:
/// Developed by Simon Drouin (sdrouin2@bwh.harvard.edu) at Brigham and Women's Hospital.
/// </seealso>
public abstract class vtkUniforms : vtkObject
{
	/// <summary>
	/// Types of tuples that can be stored : scalar, vector, matrix
	/// </summary>
	public enum TupleType
	{
		/// <summary>enum member</summary>
		NumberOfTupleTypes = 4,
		/// <summary>enum member</summary>
		TupleTypeInvalid = 0,
		/// <summary>enum member</summary>
		TupleTypeMatrix = 3,
		/// <summary>enum member</summary>
		TupleTypeScalar = 1,
		/// <summary>enum member</summary>
		TupleTypeVector = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUniforms";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUniforms()
	{
		MRClassNameKey = "class vtkUniforms";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUniforms"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUniforms(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniforms_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUniforms New()
	{
		vtkUniforms result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniforms_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniforms)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkUniforms()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUniforms_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkUniforms_GetNthUniformName_01(HandleRef pThis, long uniformIndex);

	/// <summary>
	/// Get number of all uniforms stored in this clas
	/// </summary>
	public virtual string GetNthUniformName(long uniformIndex)
	{
		return Marshal.PtrToStringAnsi(vtkUniforms_GetNthUniformName_01(GetCppThis(), uniformIndex));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniforms_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUniforms_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUniforms_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUniforms_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniforms_GetNumberOfUniforms_04(HandleRef pThis);

	/// <summary>
	/// Get number of all uniforms stored in this class 
	/// </summary>
	public virtual int GetNumberOfUniforms()
	{
		return vtkUniforms_GetNumberOfUniforms_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniform2f_05(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public virtual bool GetUniform2f(string name, IntPtr v)
	{
		return (vtkUniforms_GetUniform2f_05(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniform2i_06(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public virtual bool GetUniform2i(string name, IntPtr v)
	{
		return (vtkUniforms_GetUniform2i_06(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniform3f_07(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public virtual bool GetUniform3f(string name, IntPtr v)
	{
		return (vtkUniforms_GetUniform3f_07(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniform3uc_08(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public virtual bool GetUniform3uc(string name, IntPtr v)
	{
		return (vtkUniforms_GetUniform3uc_08(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniform4f_09(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public virtual bool GetUniform4f(string name, IntPtr v)
	{
		return (vtkUniforms_GetUniform4f_09(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniform4uc_10(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public virtual bool GetUniform4uc(string name, IntPtr v)
	{
		return (vtkUniforms_GetUniform4uc_10(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkUniforms_GetUniformListMTime_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual ulong GetUniformListMTime()
	{
		return vtkUniforms_GetUniformListMTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniformMatrix_12(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public virtual bool GetUniformMatrix(string name, vtkMatrix3x3 v)
	{
		return (vtkUniforms_GetUniformMatrix_12(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniformMatrix_13(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public virtual bool GetUniformMatrix(string name, vtkMatrix4x4 v)
	{
		return (vtkUniforms_GetUniformMatrix_13(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniformMatrix3x3_14(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public virtual bool GetUniformMatrix3x3(string name, IntPtr v)
	{
		return (vtkUniforms_GetUniformMatrix3x3_14(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniformMatrix4x4_15(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public virtual bool GetUniformMatrix4x4(string name, IntPtr v)
	{
		return (vtkUniforms_GetUniformMatrix4x4_15(GetCppThis(), name, v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniforms_GetUniformNumberOfComponents_16(HandleRef pThis, string name);

	/// <summary>
	///  for example, a uniform with tuples of matrix type and 9 components
	/// </summary>
	public virtual int GetUniformNumberOfComponents(string name)
	{
		return vtkUniforms_GetUniformNumberOfComponents_16(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniforms_GetUniformNumberOfTuples_17(HandleRef pThis, string name);

	/// <summary>
	///  For example, for 3 components uniforms of type vector, this is the number
	/// </summary>
	public virtual int GetUniformNumberOfTuples(string name)
	{
		return vtkUniforms_GetUniformNumberOfTuples_17(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniforms_GetUniformScalarType_18(HandleRef pThis, string name);

	/// <summary>
	/// Get type of scalars stored in uniform @p name 
	/// </summary>
	public virtual int GetUniformScalarType(string name)
	{
		return vtkUniforms_GetUniformScalarType_18(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern TupleType vtkUniforms_GetUniformTupleType_19(HandleRef pThis, string name);

	/// <summary>
	/// Get the tuple type stored in uniform @p name. This can be a scala
	/// </summary>
	public virtual TupleType GetUniformTupleType(string name)
	{
		return vtkUniforms_GetUniformTupleType_19(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniformf_20(HandleRef pThis, string name, ref float v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public virtual bool GetUniformf(string name, ref float v)
	{
		return (vtkUniforms_GetUniformf_20(GetCppThis(), name, ref v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkUniforms_GetUniformi_21(HandleRef pThis, string name, ref int v);

	/// <summary>
	/// Get the @p name uniform value. Returns true on success. 
	/// </summary>
	public virtual bool GetUniformi(string name, ref int v)
	{
		return (vtkUniforms_GetUniformi_21(GetCppThis(), name, ref v) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniforms_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUniforms_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniforms_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUniforms_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniforms_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUniforms NewInstance()
	{
		vtkUniforms result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniforms_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUniforms)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_RemoveAllUniforms_26(HandleRef pThis);

	/// <summary>
	/// Remove all uniform variables 
	/// </summary>
	public virtual void RemoveAllUniforms()
	{
		vtkUniforms_RemoveAllUniforms_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_RemoveUniform_27(HandleRef pThis, string name);

	/// <summary>
	/// Remove uniform variable named @p name 
	/// </summary>
	public virtual void RemoveUniform(string name)
	{
		vtkUniforms_RemoveUniform_27(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUniforms_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUniforms SafeDownCast(vtkObjectBase o)
	{
		vtkUniforms vtkUniforms2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUniforms_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUniforms2 = (vtkUniforms)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUniforms2.Register(null);
			}
		}
		return vtkUniforms2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkUniforms_ScalarTypeToString_29(int scalarType);

	/// <summary>
	/// Convert between scalar types an string 
	/// </summary>
	public static string ScalarTypeToString(int scalarType)
	{
		return vtkUniforms_ScalarTypeToString_29(scalarType);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniform1fv_30(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public virtual void SetUniform1fv(string name, int count, IntPtr f)
	{
		vtkUniforms_SetUniform1fv_30(GetCppThis(), name, count, f);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniform1iv_31(HandleRef pThis, string name, int count, IntPtr f);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public virtual void SetUniform1iv(string name, int count, IntPtr f)
	{
		vtkUniforms_SetUniform1iv_31(GetCppThis(), name, count, f);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniform2f_32(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public virtual void SetUniform2f(string name, IntPtr v)
	{
		vtkUniforms_SetUniform2f_32(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniform2i_33(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public virtual void SetUniform2i(string name, IntPtr v)
	{
		vtkUniforms_SetUniform2i_33(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniform3f_34(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public virtual void SetUniform3f(string name, IntPtr v)
	{
		vtkUniforms_SetUniform3f_34(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniform3uc_35(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public virtual void SetUniform3uc(string name, IntPtr v)
	{
		vtkUniforms_SetUniform3uc_35(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniform4f_36(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public virtual void SetUniform4f(string name, IntPtr v)
	{
		vtkUniforms_SetUniform4f_36(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniform4uc_37(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public virtual void SetUniform4uc(string name, IntPtr v)
	{
		vtkUniforms_SetUniform4uc_37(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniformMatrix_38(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public virtual void SetUniformMatrix(string name, vtkMatrix3x3 v)
	{
		vtkUniforms_SetUniformMatrix_38(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniformMatrix_39(HandleRef pThis, string name, HandleRef v);

	/// <summary>
	///  The following are convenience functions and do not reflect
	///  the way the data is stored and sent to OpenGL. Data is
	/// </summary>
	public virtual void SetUniformMatrix(string name, vtkMatrix4x4 v)
	{
		vtkUniforms_SetUniformMatrix_39(GetCppThis(), name, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniformMatrix3x3_40(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public virtual void SetUniformMatrix3x3(string name, IntPtr v)
	{
		vtkUniforms_SetUniformMatrix3x3_40(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniformMatrix4x4_41(HandleRef pThis, string name, IntPtr v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public virtual void SetUniformMatrix4x4(string name, IntPtr v)
	{
		vtkUniforms_SetUniformMatrix4x4_41(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniformMatrix4x4v_42(HandleRef pThis, string name, int count, IntPtr v);

	/// <summary>
	/// Set the @p name uniform array to @p f with @p count elements 
	/// </summary>
	public virtual void SetUniformMatrix4x4v(string name, int count, IntPtr v)
	{
		vtkUniforms_SetUniformMatrix4x4v_42(GetCppThis(), name, count, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniformf_43(HandleRef pThis, string name, float v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public virtual void SetUniformf(string name, float v)
	{
		vtkUniforms_SetUniformf_43(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUniforms_SetUniformi_44(HandleRef pThis, string name, int v);

	/// <summary>
	/// Set the @p name uniform value to @p v. 
	/// </summary>
	public virtual void SetUniformi(string name, int v)
	{
		vtkUniforms_SetUniformi_44(GetCppThis(), name, v);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUniforms_StringToScalarType_45(string s);

	/// <summary>
	/// Convert between scalar types an string 
	/// </summary>
	public static int StringToScalarType(string s)
	{
		return vtkUniforms_StringToScalarType_45(s);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern TupleType vtkUniforms_StringToTupleType_46(string s);

	/// <summary>
	/// Convert between TupleType and string 
	/// </summary>
	public static TupleType StringToTupleType(string s)
	{
		return vtkUniforms_StringToTupleType_46(s);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkUniforms_TupleTypeToString_47(TupleType tt);

	/// <summary>
	/// Convert between TupleType and string 
	/// </summary>
	public static string TupleTypeToString(TupleType tt)
	{
		return vtkUniforms_TupleTypeToString_47(tt);
	}
}
