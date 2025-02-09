using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGLTFReader
/// </summary>
/// <remarks>
///    Read a GLTF file.
///
/// vtkGLTFReader is a concrete subclass of vtkMultiBlockDataSetAlgorithm that reads glTF 2.0 files.
///
/// The GL Transmission Format (glTF) is an API-neutral runtime asset delivery format.
/// A glTF asset is represented by:
/// - A JSON-formatted file (.gltf) containing a full scene description: node hierarchy, materials,
///   cameras, as well as descriptor information for meshes, animations, and other constructs
/// - Binary files (.bin) containing geometry and animation data, and other buffer-based data
/// - Image files (.jpg, .png) for textures
///
/// This reader currently outputs a vtkMultiBlockDataSet containing geometry information
/// for the current selected scene, with animations, skins and morph targets applied, unless
/// configured not to (see ApplyDeformationsToGeometry).
///
/// It is possible to get information about available scenes and animations by using the
/// corresponding accessors.
/// To use animations, first call SetFramerate with a non-zero value,
/// then use EnableAnimation or DisableAnimation to configure which animations you would like to
/// apply to the geometry.
/// Finally, use UPDATE_TIME_STEPS to choose which frame to apply.
/// If ApplyDeformationsToGeometry is set to true, the reader will apply the deformations, otherwise,
/// animation transformation information will be saved to the dataset's FieldData.
///
/// Materials are currently not supported in this reader. If you would like to display materials,
/// please try using vtkGLTFImporter.
/// You could also use vtkGLTFReader::GetGLTFTexture, to access the image data that was loaded from
/// the glTF 2.0 document.
///
/// This reader only supports assets that use the 2.x version of the glTF specification.
///
/// For the full glTF specification, see:
/// https://github.com/KhronosGroup/glTF/tree/master/specification/2.0
///
/// Note: array sizes should not exceed INT_MAX
///
/// </remarks>
/// <seealso>
///
/// vtkMultiBlockDataSetAlgorithm
/// vtkGLTFImporter
/// </seealso>
public class vtkGLTFReader : vtkMultiBlockDataSetAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGLTFReader()
	{
		MRClassNameKey = "class vtkGLTFReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGLTFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFReader New()
	{
		vtkGLTFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGLTFReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGLTFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkGLTFReader_ApplyDeformationsToGeometryOff_01(HandleRef pThis);

	/// <summary>
	/// The model's skinning transforms are computed and added to the different vtkPolyData objects'
	/// field data.
	/// If this flag is set to true, the reader will apply those skinning transforms to the model's
	/// geometry.
	/// </summary>
	public virtual void ApplyDeformationsToGeometryOff()
	{
		vtkGLTFReader_ApplyDeformationsToGeometryOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFReader_ApplyDeformationsToGeometryOn_02(HandleRef pThis);

	/// <summary>
	/// The model's skinning transforms are computed and added to the different vtkPolyData objects'
	/// field data.
	/// If this flag is set to true, the reader will apply those skinning transforms to the model's
	/// geometry.
	/// </summary>
	public virtual void ApplyDeformationsToGeometryOn()
	{
		vtkGLTFReader_ApplyDeformationsToGeometryOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFReader_DisableAnimation_03(HandleRef pThis, long animationIndex);

	/// <summary>
	/// Enable/Disable an animation. The reader will apply all enabled animations to the model's
	/// transformations, at the specified time step. Use UPDATE_TIME_STEP to select which frame should
	/// be applied.
	/// </summary>
	public void DisableAnimation(long animationIndex)
	{
		vtkGLTFReader_DisableAnimation_03(GetCppThis(), animationIndex);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFReader_EnableAnimation_04(HandleRef pThis, long animationIndex);

	/// <summary>
	/// Enable/Disable an animation. The reader will apply all enabled animations to the model's
	/// transformations, at the specified time step. Use UPDATE_TIME_STEP to select which frame should
	/// be applied.
	/// </summary>
	public void EnableAnimation(long animationIndex)
	{
		vtkGLTFReader_EnableAnimation_04(GetCppThis(), animationIndex);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFReader_GetAllSceneNames_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a list all scenes names as a vtkStringArray, with duplicate names numbered and empty names
	/// replaced by a generic name. All names are guaranteed to be unique, and their index in the array
	/// matches the glTF document's scene indices.
	/// </summary>
	public vtkStringArray GetAllSceneNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFReader_GetAllSceneNames_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkGLTFReader_GetAnimationDuration_06(HandleRef pThis, long animationIndex);

	/// <summary>
	/// glTF models can contain multiple animations, with various names and duration. glTF does not
	/// specify however any runtime behavior (order of playing, auto-start, loops, mapping of
	/// timelines, etc), which is why no animation is enabled by default.
	/// These accessors expose metadata information about a model's available animations.
	/// </summary>
	public float GetAnimationDuration(long animationIndex)
	{
		return vtkGLTFReader_GetAnimationDuration_06(GetCppThis(), animationIndex);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkGLTFReader_GetAnimationName_07(HandleRef pThis, long animationIndex);

	/// <summary>
	/// glTF models can contain multiple animations, with various names and duration. glTF does not
	/// specify however any runtime behavior (order of playing, auto-start, loops, mapping of
	/// timelines, etc), which is why no animation is enabled by default.
	/// These accessors expose metadata information about a model's available animations.
	/// </summary>
	public string GetAnimationName(long animationIndex)
	{
		return vtkGLTFReader_GetAnimationName_07(GetCppThis(), animationIndex);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFReader_GetAnimationSelection_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the vtkDataArraySelection object to enable/disable animations.
	/// </summary>
	public vtkDataArraySelection GetAnimationSelection()
	{
		vtkDataArraySelection vtkDataArraySelection2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFReader_GetAnimationSelection_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArraySelection2 = (vtkDataArraySelection)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArraySelection2.Register(null);
			}
		}
		return vtkDataArraySelection2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFReader_GetApplyDeformationsToGeometry_09(HandleRef pThis);

	/// <summary>
	/// The model's skinning transforms are computed and added to the different vtkPolyData objects'
	/// field data.
	/// If this flag is set to true, the reader will apply those skinning transforms to the model's
	/// geometry.
	/// </summary>
	public virtual bool GetApplyDeformationsToGeometry()
	{
		return (vtkGLTFReader_GetApplyDeformationsToGeometry_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFReader_GetCurrentScene_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the scene to be used by the reader
	/// </summary>
	public virtual long GetCurrentScene()
	{
		return vtkGLTFReader_GetCurrentScene_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFReader_GetFileName_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the name of the file from which to read points.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkGLTFReader_GetFileName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkGLTFReader_GetFrameRate_12(HandleRef pThis);

	/// <summary>
	/// Get/Set the rate at which animations will be sampled:
	/// the glTF format does not have the concept of static timesteps.
	/// TimeSteps are generated, during the REQUEST_INFORMATION pass,
	/// as linearly interpolated time values between 0s and the animations' maximum durations,
	/// sampled at the specified frame rate.
	/// Use the TIME_STEPS information key to obtain integer indices to each of these steps.
	/// </summary>
	public virtual uint GetFrameRate()
	{
		return vtkGLTFReader_GetFrameRate_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFReader_GetNumberOfAnimations_13(HandleRef pThis);

	/// <summary>
	/// glTF models can contain multiple animations, with various names and duration. glTF does not
	/// specify however any runtime behavior (order of playing, auto-start, loops, mapping of
	/// timelines, etc), which is why no animation is enabled by default.
	/// These accessors expose metadata information about a model's available animations.
	/// </summary>
	public virtual long GetNumberOfAnimations()
	{
		return vtkGLTFReader_GetNumberOfAnimations_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFReader_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGLTFReader_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFReader_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGLTFReader_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFReader_GetNumberOfScenes_16(HandleRef pThis);

	/// <summary>
	/// glTF models can contain multiple scene descriptions.
	/// These accessors expose metadata information about a model's available scenes.
	/// </summary>
	public virtual long GetNumberOfScenes()
	{
		return vtkGLTFReader_GetNumberOfScenes_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFReader_GetNumberOfTextures_17(HandleRef pThis);

	/// <summary>
	/// Materials are not directly applied to this reader's output.
	/// Use GetGLTFTexture to access a specific texture's image data, and the indices present in the
	/// output dataset's field data to create vtkTextures and apply them to the geometry.
	/// </summary>
	public long GetNumberOfTextures()
	{
		return vtkGLTFReader_GetNumberOfTextures_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkGLTFReader_GetSceneName_18(HandleRef pThis, long sceneIndex);

	/// <summary>
	/// glTF models can contain multiple scene descriptions.
	/// These accessors expose metadata information about a model's available scenes.
	/// </summary>
	public string GetSceneName(long sceneIndex)
	{
		return vtkGLTFReader_GetSceneName_18(GetCppThis(), sceneIndex);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFReader_IsA_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGLTFReader_IsA_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFReader_IsAnimationEnabled_20(HandleRef pThis, long animationIndex);

	/// <summary>
	/// Enable/Disable an animation. The reader will apply all enabled animations to the model's
	/// transformations, at the specified time step. Use UPDATE_TIME_STEP to select which frame should
	/// be applied.
	/// </summary>
	public bool IsAnimationEnabled(long animationIndex)
	{
		return (vtkGLTFReader_IsAnimationEnabled_20(GetCppThis(), animationIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFReader_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGLTFReader_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFReader_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGLTFReader NewInstance()
	{
		vtkGLTFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFReader_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFReader_SafeDownCast_24(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFReader SafeDownCast(vtkObjectBase o)
	{
		vtkGLTFReader vtkGLTFReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFReader_SafeDownCast_24(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGLTFReader2 = (vtkGLTFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGLTFReader2.Register(null);
			}
		}
		return vtkGLTFReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFReader_SetApplyDeformationsToGeometry_25(HandleRef pThis, byte flag);

	/// <summary>
	/// The model's skinning transforms are computed and added to the different vtkPolyData objects'
	/// field data.
	/// If this flag is set to true, the reader will apply those skinning transforms to the model's
	/// geometry.
	/// </summary>
	public void SetApplyDeformationsToGeometry(bool flag)
	{
		vtkGLTFReader_SetApplyDeformationsToGeometry_25(GetCppThis(), (byte)(flag ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFReader_SetCurrentScene_26(HandleRef pThis, long _arg);

	/// <summary>
	/// Get/Set the scene to be used by the reader
	/// </summary>
	public virtual void SetCurrentScene(long _arg)
	{
		vtkGLTFReader_SetCurrentScene_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFReader_SetFileName_27(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the name of the file from which to read points.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkGLTFReader_SetFileName_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFReader_SetFrameRate_28(HandleRef pThis, uint _arg);

	/// <summary>
	/// Get/Set the rate at which animations will be sampled:
	/// the glTF format does not have the concept of static timesteps.
	/// TimeSteps are generated, during the REQUEST_INFORMATION pass,
	/// as linearly interpolated time values between 0s and the animations' maximum durations,
	/// sampled at the specified frame rate.
	/// Use the TIME_STEPS information key to obtain integer indices to each of these steps.
	/// </summary>
	public virtual void SetFrameRate(uint _arg)
	{
		vtkGLTFReader_SetFrameRate_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFReader_SetScene_29(HandleRef pThis, string scene);

	/// <summary>
	/// Get/Set the scene to be used by the reader
	/// </summary>
	public void SetScene(string scene)
	{
		vtkGLTFReader_SetScene_29(GetCppThis(), scene);
	}
}
