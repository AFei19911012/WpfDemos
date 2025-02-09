using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkShaderProperty
/// </summary>
/// <remarks>
///    represent GPU shader properties
///
/// vtkShaderProperty is used to hold user-defined modifications of a
/// GPU shader program used in a mapper.
///
/// </remarks>
/// <seealso>
///
/// vtkVolume vtkOpenGLUniform
///
/// @par Thanks:
/// Developed by Simon Drouin (sdrouin2@bwh.harvard.edu) at Brigham and Women's Hospital.
///
/// </seealso>
public abstract class vtkShaderProperty : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkShaderProperty";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkShaderProperty()
	{
		MRClassNameKey = "class vtkShaderProperty";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkShaderProperty"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkShaderProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with no shader replacements
	/// </summary>
	public new static vtkShaderProperty New()
	{
		vtkShaderProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShaderProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with no shader replacements
	/// </summary>
	public vtkShaderProperty()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkShaderProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkShaderProperty_AddFragmentShaderReplacement_01(HandleRef pThis, string originalValue, byte replaceFirst, string replacementValue, byte replaceAll);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void AddFragmentShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
	{
		vtkShaderProperty_AddFragmentShaderReplacement_01(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u), replacementValue, (byte)(replaceAll ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_AddGeometryShaderReplacement_02(HandleRef pThis, string originalValue, byte replaceFirst, string replacementValue, byte replaceAll);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void AddGeometryShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
	{
		vtkShaderProperty_AddGeometryShaderReplacement_02(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u), replacementValue, (byte)(replaceAll ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_AddVertexShaderReplacement_03(HandleRef pThis, string originalValue, byte replaceFirst, string replacementValue, byte replaceAll);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void AddVertexShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
	{
		vtkShaderProperty_AddVertexShaderReplacement_03(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u), replacementValue, (byte)(replaceAll ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_ClearAllFragmentShaderReplacements_04(HandleRef pThis);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void ClearAllFragmentShaderReplacements()
	{
		vtkShaderProperty_ClearAllFragmentShaderReplacements_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_ClearAllGeometryShaderReplacements_05(HandleRef pThis);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void ClearAllGeometryShaderReplacements()
	{
		vtkShaderProperty_ClearAllGeometryShaderReplacements_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_ClearAllShaderReplacements_06(HandleRef pThis);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void ClearAllShaderReplacements()
	{
		vtkShaderProperty_ClearAllShaderReplacements_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_ClearAllVertexShaderReplacements_07(HandleRef pThis);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void ClearAllVertexShaderReplacements()
	{
		vtkShaderProperty_ClearAllVertexShaderReplacements_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_ClearFragmentShaderReplacement_08(HandleRef pThis, string originalValue, byte replaceFirst);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void ClearFragmentShaderReplacement(string originalValue, bool replaceFirst)
	{
		vtkShaderProperty_ClearFragmentShaderReplacement_08(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_ClearGeometryShaderReplacement_09(HandleRef pThis, string originalValue, byte replaceFirst);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void ClearGeometryShaderReplacement(string originalValue, bool replaceFirst)
	{
		vtkShaderProperty_ClearGeometryShaderReplacement_09(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_ClearVertexShaderReplacement_10(HandleRef pThis, string originalValue, byte replaceFirst);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void ClearVertexShaderReplacement(string originalValue, bool replaceFirst)
	{
		vtkShaderProperty_ClearVertexShaderReplacement_10(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_DeepCopy_11(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public void DeepCopy(vtkShaderProperty p)
	{
		vtkShaderProperty_DeepCopy_11(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProperty_GetFragmentCustomUniforms_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The Uniforms object allows to set custom uniform variables
	/// that are used in replacement shader code.
	/// </summary>
	public virtual vtkUniforms GetFragmentCustomUniforms()
	{
		vtkUniforms vtkUniforms2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProperty_GetFragmentCustomUniforms_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkShaderProperty_GetFragmentShaderCode_13(HandleRef pThis);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public virtual string GetFragmentShaderCode()
	{
		return Marshal.PtrToStringAnsi(vtkShaderProperty_GetFragmentShaderCode_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProperty_GetGeometryCustomUniforms_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The Uniforms object allows to set custom uniform variables
	/// that are used in replacement shader code.
	/// </summary>
	public virtual vtkUniforms GetGeometryCustomUniforms()
	{
		vtkUniforms vtkUniforms2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProperty_GetGeometryCustomUniforms_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkShaderProperty_GetGeometryShaderCode_15(HandleRef pThis);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public virtual string GetGeometryShaderCode()
	{
		return Marshal.PtrToStringAnsi(vtkShaderProperty_GetGeometryShaderCode_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_GetNthShaderReplacement_16(HandleRef pThis, long index, string name, ref byte replaceFirst, string replacementValue, ref byte replaceAll);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual void GetNthShaderReplacement(long index, string name, ref byte replaceFirst, string replacementValue, ref byte replaceAll)
	{
		vtkShaderProperty_GetNthShaderReplacement_16(GetCppThis(), index, name, ref replaceFirst, replacementValue, ref replaceAll);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkShaderProperty_GetNthShaderReplacementTypeAsString_17(HandleRef pThis, long index);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual string GetNthShaderReplacementTypeAsString(long index)
	{
		return vtkShaderProperty_GetNthShaderReplacementTypeAsString_17(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShaderProperty_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkShaderProperty_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkShaderProperty_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkShaderProperty_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShaderProperty_GetNumberOfShaderReplacements_20(HandleRef pThis);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public virtual int GetNumberOfShaderReplacements()
	{
		return vtkShaderProperty_GetNumberOfShaderReplacements_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkShaderProperty_GetShaderMTime_21(HandleRef pThis);

	/// <summary>
	/// @brief GetShaderMTime returns the last time a modification
	/// was made that affected the code of the shader (either code
	/// replacement was changed or one or more uniform variables were
	/// added or removed. This timestamp can be used by mappers to
	/// determine if the shader must be recompiled. Simply changing
	/// the value of an existing uniform variable doesn't affect this
	/// timestamp as it doesn't change the shader code.
	/// @return timestamp of the last modification
	/// </summary>
	public ulong GetShaderMTime()
	{
		return vtkShaderProperty_GetShaderMTime_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProperty_GetVertexCustomUniforms_22(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// The Uniforms object allows to set custom uniform variables
	/// that are used in replacement shader code.
	/// </summary>
	public virtual vtkUniforms GetVertexCustomUniforms()
	{
		vtkUniforms vtkUniforms2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProperty_GetVertexCustomUniforms_22(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkShaderProperty_GetVertexShaderCode_23(HandleRef pThis);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public virtual string GetVertexShaderCode()
	{
		return Marshal.PtrToStringAnsi(vtkShaderProperty_GetVertexShaderCode_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProperty_HasFragmentShaderCode_24(HandleRef pThis);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public bool HasFragmentShaderCode()
	{
		return (vtkShaderProperty_HasFragmentShaderCode_24(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProperty_HasGeometryShaderCode_25(HandleRef pThis);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public bool HasGeometryShaderCode()
	{
		return (vtkShaderProperty_HasGeometryShaderCode_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkShaderProperty_HasVertexShaderCode_26(HandleRef pThis);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public bool HasVertexShaderCode()
	{
		return (vtkShaderProperty_HasVertexShaderCode_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShaderProperty_IsA_27(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkShaderProperty_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkShaderProperty_IsTypeOf_28(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkShaderProperty_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProperty_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkShaderProperty NewInstance()
	{
		vtkShaderProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProperty_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkShaderProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkShaderProperty_SafeDownCast_31(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkShaderProperty SafeDownCast(vtkObjectBase o)
	{
		vtkShaderProperty vtkShaderProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkShaderProperty_SafeDownCast_31(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkShaderProperty2 = (vtkShaderProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkShaderProperty2.Register(null);
			}
		}
		return vtkShaderProperty2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_SetFragmentShaderCode_32(HandleRef pThis, string _arg);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public virtual void SetFragmentShaderCode(string _arg)
	{
		vtkShaderProperty_SetFragmentShaderCode_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_SetGeometryShaderCode_33(HandleRef pThis, string _arg);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public virtual void SetGeometryShaderCode(string _arg)
	{
		vtkShaderProperty_SetGeometryShaderCode_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkShaderProperty_SetVertexShaderCode_34(HandleRef pThis, string _arg);

	/// <summary>
	/// Allow the program to set the shader codes used directly
	/// instead of using the built in templates. Be aware, if
	/// set, this template will be used for all cases,
	/// primitive types, picking etc.
	/// </summary>
	public virtual void SetVertexShaderCode(string _arg)
	{
		vtkShaderProperty_SetVertexShaderCode_34(GetCppThis(), _arg);
	}
}
