using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGLTFDocumentLoader
/// </summary>
/// <remarks>
///    Deserialize a GLTF model file.
///
///
/// vtkGLTFDocument loader is an internal utility class which defines data structures and functions
/// with the purpose of deserializing a glTF model from a glTF file, loading its data from binary
/// buffers and creating vtk objects with the extracted geometry.
/// It contains an internal Model structure into which all loading is performed.
///
/// The GL Transmission Format (glTF) is an API-neutral runtime asset delivery format.
/// A glTF asset is represented by:
/// - A JSON-formatted file (.gltf) containing a full scene description: node hierarchy, materials,
///   cameras, as well as descriptor information for meshes, animations, and other constructs
/// - Binary files (.bin) containing geometry and animation data, and other buffer-based data
/// - Image files (.jpg, .png) for textures
///
/// For the full specification, see:
/// https://github.com/KhronosGroup/glTF/tree/master/specification/2.0
/// </remarks>
public class vtkGLTFDocumentLoader : vtkObject
{
	/// <summary>
	/// Defines an accessor's type. These are defined as strings in the glTF specification.
	/// Each type implies a specific number of components.
	/// </summary>
	public enum AccessorType
	{
		/// <summary>enum member</summary>
		INVALID = 7,
		/// <summary>enum member</summary>
		MAT2 = 4,
		/// <summary>enum member</summary>
		MAT3 = 5,
		/// <summary>enum member</summary>
		MAT4 = 6,
		/// <summary>enum member</summary>
		SCALAR = 0,
		/// <summary>enum member</summary>
		VEC2 = 1,
		/// <summary>enum member</summary>
		VEC3 = 2,
		/// <summary>enum member</summary>
		VEC4 = 3
	}

	/// <summary>
	/// Define a type for different data components. Values match with the corresponding GLenum, as
	/// they are used in the glTF specification.
	/// </summary>
	public enum ComponentType
	{
		/// <summary>enum member</summary>
		BYTE = 5120,
		/// <summary>enum member</summary>
		FLOAT = 5126,
		/// <summary>enum member</summary>
		SHORT = 5122,
		/// <summary>enum member</summary>
		UNSIGNED_BYTE = 5121,
		/// <summary>enum member</summary>
		UNSIGNED_INT = 5125,
		/// <summary>enum member</summary>
		UNSIGNED_SHORT = 5123
	}

	/// <summary>
	/// Define an openGL draw target.
	/// </summary>
	public enum Target
	{
		/// <summary>enum member</summary>
		ARRAY_BUFFER = 34962,
		/// <summary>enum member</summary>
		ELEMENT_ARRAY_BUFFER
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFDocumentLoader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGLTFDocumentLoader()
	{
		MRClassNameKey = "class vtkGLTFDocumentLoader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFDocumentLoader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGLTFDocumentLoader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFDocumentLoader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFDocumentLoader New()
	{
		vtkGLTFDocumentLoader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFDocumentLoader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFDocumentLoader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGLTFDocumentLoader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGLTFDocumentLoader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFDocumentLoader_ApplyAnimation_01(HandleRef pThis, float t, int animationId, byte forceStep);

	/// <summary>
	/// Apply the specified animation, at the specified time, to the internal Model. Changes node
	/// transforms and morphing weights.
	/// </summary>
	public bool ApplyAnimation(float t, int animationId, bool forceStep)
	{
		return (vtkGLTFDocumentLoader_ApplyAnimation_01(GetCppThis(), t, animationId, (byte)(forceStep ? 1u : 0u)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFDocumentLoader_BuildGlobalTransforms_02(HandleRef pThis);

	/// <summary>
	/// Build all global transforms
	/// </summary>
	public void BuildGlobalTransforms()
	{
		vtkGLTFDocumentLoader_BuildGlobalTransforms_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFDocumentLoader_BuildModelVTKGeometry_03(HandleRef pThis);

	/// <summary>
	/// Converts the internal Model's loaded data into more convenient vtk objects.
	/// </summary>
	public bool BuildModelVTKGeometry()
	{
		return (vtkGLTFDocumentLoader_BuildModelVTKGeometry_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkGLTFDocumentLoader_GetNumberOfComponentsForType_04(AccessorType type);

	/// <summary>
	/// Returns the number of components for a given accessor type.
	/// </summary>
	public static uint GetNumberOfComponentsForType(AccessorType type)
	{
		return vtkGLTFDocumentLoader_GetNumberOfComponentsForType_04(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFDocumentLoader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGLTFDocumentLoader_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFDocumentLoader_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGLTFDocumentLoader_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFDocumentLoader_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGLTFDocumentLoader_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFDocumentLoader_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGLTFDocumentLoader_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFDocumentLoader_LoadModelMetaDataFromFile_09(HandleRef pThis, string FileName);

	/// <summary>
	/// Reset internal Model struct, and serialize glTF metadata (all json information) into it.
	/// To load buffers, use LoadModelData
	/// </summary>
	public bool LoadModelMetaDataFromFile(string FileName)
	{
		return (vtkGLTFDocumentLoader_LoadModelMetaDataFromFile_09(GetCppThis(), FileName) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFDocumentLoader_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGLTFDocumentLoader NewInstance()
	{
		vtkGLTFDocumentLoader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFDocumentLoader_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFDocumentLoader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFDocumentLoader_ResetAnimation_12(HandleRef pThis, int animationId);

	/// <summary>
	/// Restore the transforms that were modified by an animation to their initial state
	/// </summary>
	public void ResetAnimation(int animationId)
	{
		vtkGLTFDocumentLoader_ResetAnimation_12(GetCppThis(), animationId);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFDocumentLoader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFDocumentLoader SafeDownCast(vtkObjectBase o)
	{
		vtkGLTFDocumentLoader vtkGLTFDocumentLoader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFDocumentLoader_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGLTFDocumentLoader2 = (vtkGLTFDocumentLoader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGLTFDocumentLoader2.Register(null);
			}
		}
		return vtkGLTFDocumentLoader2;
	}
}
