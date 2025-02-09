using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLShaderProperty
/// </summary>
/// <remarks>
///    represent GPU shader properties
///
/// vtkOpenGLShaderProperty is used to hold user-defined modifications of a
/// GPU shader program used in a mapper.
///
/// </remarks>
/// <seealso>
///
/// vtkShaderProperty vtkUniforms vtkOpenGLUniform
///
/// @par Thanks:
/// Developed by Simon Drouin (sdrouin2@bwh.harvard.edu) at Brigham and Women's Hospital.
///
/// </seealso>
public class vtkOpenGLShaderProperty : vtkShaderProperty
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLShaderProperty";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLShaderProperty()
	{
		MRClassNameKey = "class vtkOpenGLShaderProperty";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLShaderProperty"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLShaderProperty(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLShaderProperty_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with no shader replacements
	/// </summary>
	public new static vtkOpenGLShaderProperty New()
	{
		vtkOpenGLShaderProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLShaderProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLShaderProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with no shader replacements
	/// </summary>
	public vtkOpenGLShaderProperty()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLShaderProperty_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkOpenGLShaderProperty_AddFragmentShaderReplacement_01(HandleRef pThis, string originalValue, byte replaceFirst, string replacementValue, byte replaceAll);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void AddFragmentShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
	{
		vtkOpenGLShaderProperty_AddFragmentShaderReplacement_01(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u), replacementValue, (byte)(replaceAll ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_AddGeometryShaderReplacement_02(HandleRef pThis, string originalValue, byte replaceFirst, string replacementValue, byte replaceAll);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void AddGeometryShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
	{
		vtkOpenGLShaderProperty_AddGeometryShaderReplacement_02(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u), replacementValue, (byte)(replaceAll ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_AddShaderReplacement_03(HandleRef pThis, vtkShader.Type shaderType, string originalValue, byte replaceFirst, string replacementValue, byte replaceAll);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public void AddShaderReplacement(vtkShader.Type shaderType, string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
	{
		vtkOpenGLShaderProperty_AddShaderReplacement_03(GetCppThis(), shaderType, originalValue, (byte)(replaceFirst ? 1u : 0u), replacementValue, (byte)(replaceAll ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_AddVertexShaderReplacement_04(HandleRef pThis, string originalValue, byte replaceFirst, string replacementValue, byte replaceAll);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void AddVertexShaderReplacement(string originalValue, bool replaceFirst, string replacementValue, bool replaceAll)
	{
		vtkOpenGLShaderProperty_AddVertexShaderReplacement_04(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u), replacementValue, (byte)(replaceAll ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearAllFragmentShaderReplacements_05(HandleRef pThis);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void ClearAllFragmentShaderReplacements()
	{
		vtkOpenGLShaderProperty_ClearAllFragmentShaderReplacements_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearAllGeometryShaderReplacements_06(HandleRef pThis);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void ClearAllGeometryShaderReplacements()
	{
		vtkOpenGLShaderProperty_ClearAllGeometryShaderReplacements_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearAllShaderReplacements_07(HandleRef pThis);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void ClearAllShaderReplacements()
	{
		vtkOpenGLShaderProperty_ClearAllShaderReplacements_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearAllShaderReplacements_08(HandleRef pThis, vtkShader.Type shaderType);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public void ClearAllShaderReplacements(vtkShader.Type shaderType)
	{
		vtkOpenGLShaderProperty_ClearAllShaderReplacements_08(GetCppThis(), shaderType);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearAllVertexShaderReplacements_09(HandleRef pThis);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void ClearAllVertexShaderReplacements()
	{
		vtkOpenGLShaderProperty_ClearAllVertexShaderReplacements_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearFragmentShaderReplacement_10(HandleRef pThis, string originalValue, byte replaceFirst);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void ClearFragmentShaderReplacement(string originalValue, bool replaceFirst)
	{
		vtkOpenGLShaderProperty_ClearFragmentShaderReplacement_10(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearGeometryShaderReplacement_11(HandleRef pThis, string originalValue, byte replaceFirst);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void ClearGeometryShaderReplacement(string originalValue, bool replaceFirst)
	{
		vtkOpenGLShaderProperty_ClearGeometryShaderReplacement_11(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearShaderReplacement_12(HandleRef pThis, vtkShader.Type shaderType, string originalValue, byte replaceFirst);

	/// <summary>
	/// This function enables you to apply your own substitutions
	/// to the shader creation process. The shader code in this class
	/// is created by applying a bunch of string replacements to a
	/// shader template. Using this function you can apply your
	/// own string replacements to add features you desire.
	/// </summary>
	public void ClearShaderReplacement(vtkShader.Type shaderType, string originalValue, bool replaceFirst)
	{
		vtkOpenGLShaderProperty_ClearShaderReplacement_12(GetCppThis(), shaderType, originalValue, (byte)(replaceFirst ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_ClearVertexShaderReplacement_13(HandleRef pThis, string originalValue, byte replaceFirst);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void ClearVertexShaderReplacement(string originalValue, bool replaceFirst)
	{
		vtkOpenGLShaderProperty_ClearVertexShaderReplacement_13(GetCppThis(), originalValue, (byte)(replaceFirst ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_DeepCopy_14(HandleRef pThis, HandleRef p);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public void DeepCopy(vtkOpenGLShaderProperty p)
	{
		vtkOpenGLShaderProperty_DeepCopy_14(GetCppThis(), p?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLShaderProperty_GetNthShaderReplacement_15(HandleRef pThis, long index, string name, ref byte replaceFirst, string replacementValue, ref byte replaceAll);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override void GetNthShaderReplacement(long index, string name, ref byte replaceFirst, string replacementValue, ref byte replaceAll)
	{
		vtkOpenGLShaderProperty_GetNthShaderReplacement_15(GetCppThis(), index, name, ref replaceFirst, replacementValue, ref replaceAll);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkOpenGLShaderProperty_GetNthShaderReplacementTypeAsString_16(HandleRef pThis, long index);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override string GetNthShaderReplacementTypeAsString(long index)
	{
		return vtkOpenGLShaderProperty_GetNthShaderReplacementTypeAsString_16(GetCppThis(), index);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLShaderProperty_GetNumberOfGenerationsFromBase_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLShaderProperty_GetNumberOfGenerationsFromBase_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLShaderProperty_GetNumberOfGenerationsFromBaseType_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLShaderProperty_GetNumberOfGenerationsFromBaseType_18(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLShaderProperty_GetNumberOfShaderReplacements_19(HandleRef pThis);

	/// <summary>
	/// Assign one property to another.
	/// </summary>
	public override int GetNumberOfShaderReplacements()
	{
		return vtkOpenGLShaderProperty_GetNumberOfShaderReplacements_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLShaderProperty_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLShaderProperty_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLShaderProperty_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLShaderProperty_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLShaderProperty_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLShaderProperty NewInstance()
	{
		vtkOpenGLShaderProperty result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLShaderProperty_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLShaderProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLShaderProperty_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLShaderProperty SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLShaderProperty vtkOpenGLShaderProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLShaderProperty_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLShaderProperty2 = (vtkOpenGLShaderProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLShaderProperty2.Register(null);
			}
		}
		return vtkOpenGLShaderProperty2;
	}
}
