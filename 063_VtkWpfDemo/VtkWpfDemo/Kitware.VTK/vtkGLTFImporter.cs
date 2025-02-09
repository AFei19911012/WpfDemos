using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkGLTFImporter
/// </summary>
/// <remarks>
///    Import a GLTF file.
///
/// vtkGLTFImporter is a concrete subclass of vtkImporter that reads glTF 2.0
/// files.
///
/// The GL Transmission Format (glTF) is an API-neutral runtime asset delivery format.
/// A glTF asset is represented by:
/// - A JSON-formatted file (.gltf) containing a full scene description: node hierarchy, materials,
///   cameras, as well as descriptor information for meshes, animations, and other constructs
/// - Binary files (.bin) containing geometry and animation data, and other buffer-based data
/// - Image files (.jpg, .png) for textures
///
/// This importer supports all physically-based rendering material features, with the exception of
/// alpha masking and mirrored texture wrapping, which are not supported.
///
///
/// This importer does not support materials that use multiple
/// sets of texture coordinates. Only the first set will be used in this case.
///
/// This importer does not support animations, morphing and skinning. If you would like to use
/// animations, morphing or skinning, please consider using vtkGLTFReader.
///
/// This importer only supports assets that use the 2.x version of the glTF specification.
///
/// For the full glTF specification, see:
/// https://github.com/KhronosGroup/glTF/tree/master/specification/2.0
///
/// Note: array sizes should not exceed INT_MAX
///
/// Supported extensions:
/// - KHR_lights_punctual :
///   The importer supports the KHR_lights_punctual extension except for this feature:
///   - VTK does not support changing the falloff of the cone with innerConeAngle and outerConeAngle.
///     The importer uses outerConeAngle and ignores innerConeAngle as specified for this situation.
///
/// </remarks>
/// <seealso>
///
/// vtkImporter
/// vtkGLTFReader
/// </seealso>
public class vtkGLTFImporter : vtkImporter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkGLTFImporter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkGLTFImporter()
	{
		MRClassNameKey = "class vtkGLTFImporter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkGLTFImporter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkGLTFImporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFImporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFImporter New()
	{
		vtkGLTFImporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkGLTFImporter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkGLTFImporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFImporter_DisableAnimation_01(HandleRef pThis, long animationIndex);

	/// <summary>
	/// Enable/Disable/Get the status of specific animations
	/// </summary>
	public override void DisableAnimation(long animationIndex)
	{
		vtkGLTFImporter_DisableAnimation_01(GetCppThis(), animationIndex);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFImporter_EnableAnimation_02(HandleRef pThis, long animationIndex);

	/// <summary>
	/// Enable/Disable/Get the status of specific animations
	/// </summary>
	public override void EnableAnimation(long animationIndex)
	{
		vtkGLTFImporter_EnableAnimation_02(GetCppThis(), animationIndex);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkGLTFImporter_GetAnimationName_03(HandleRef pThis, long animationIndex);

	/// <summary>
	/// Return the name of the animation.
	/// </summary>
	public override string GetAnimationName(long animationIndex)
	{
		return vtkGLTFImporter_GetAnimationName_03(GetCppThis(), animationIndex);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkGLTFImporter_GetCameraName_04(HandleRef pThis, long camIndex);

	/// <summary>
	/// Get the name of a camera.
	/// </summary>
	public override string GetCameraName(long camIndex)
	{
		return vtkGLTFImporter_GetCameraName_04(GetCppThis(), camIndex);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFImporter_GetFileName_05(HandleRef pThis);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkGLTFImporter_GetFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFImporter_GetNumberOfAnimations_06(HandleRef pThis);

	/// <summary>
	/// Get the number of available animations.
	/// </summary>
	public override long GetNumberOfAnimations()
	{
		return vtkGLTFImporter_GetNumberOfAnimations_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFImporter_GetNumberOfCameras_07(HandleRef pThis);

	/// <summary>
	/// Get the number of available cameras.
	/// </summary>
	public override long GetNumberOfCameras()
	{
		return vtkGLTFImporter_GetNumberOfCameras_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFImporter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkGLTFImporter_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkGLTFImporter_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkGLTFImporter_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkGLTFImporter_GetOutputsDescription_10(HandleRef pThis);

	/// <summary>
	/// Get a printable string describing all outputs
	/// </summary>
	public override string GetOutputsDescription()
	{
		return vtkGLTFImporter_GetOutputsDescription_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFImporter_GetTemporalInformation_11(HandleRef pThis, long animationIndex, double frameRate, ref int nbTimeSteps, IntPtr timeRange, HandleRef timeSteps);

	/// <summary>
	/// Get temporal information for the currently enabled animations.
	/// frameRate is used to define the number of frames for one second of simulation.
	/// the three return arguments are defined in this implementation.
	/// </summary>
	public override bool GetTemporalInformation(long animationIndex, double frameRate, ref int nbTimeSteps, IntPtr timeRange, vtkDoubleArray timeSteps)
	{
		return (vtkGLTFImporter_GetTemporalInformation_11(GetCppThis(), animationIndex, frameRate, ref nbTimeSteps, timeRange, timeSteps?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFImporter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkGLTFImporter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkGLTFImporter_IsAnimationEnabled_13(HandleRef pThis, long animationIndex);

	/// <summary>
	/// Enable/Disable/Get the status of specific animations
	/// </summary>
	public override bool IsAnimationEnabled(long animationIndex)
	{
		return (vtkGLTFImporter_IsAnimationEnabled_13(GetCppThis(), animationIndex) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkGLTFImporter_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkGLTFImporter_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFImporter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkGLTFImporter NewInstance()
	{
		vtkGLTFImporter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFImporter_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkGLTFImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkGLTFImporter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkGLTFImporter SafeDownCast(vtkObjectBase o)
	{
		vtkGLTFImporter vtkGLTFImporter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkGLTFImporter_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkGLTFImporter2 = (vtkGLTFImporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkGLTFImporter2.Register(null);
			}
		}
		return vtkGLTFImporter2;
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFImporter_SetCamera_18(HandleRef pThis, long camIndex);

	/// <summary>
	/// Enable a specific camera.
	/// If a negative index is provided, no camera from the importer is used.
	/// </summary>
	public override void SetCamera(long camIndex)
	{
		vtkGLTFImporter_SetCamera_18(GetCppThis(), camIndex);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFImporter_SetFileName_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the name of the file to read.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkGLTFImporter_SetFileName_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkGLTFImporter_UpdateTimeStep_20(HandleRef pThis, double timestep);

	/// <summary>
	/// update timestep
	/// </summary>
	public override void UpdateTimeStep(double timestep)
	{
		vtkGLTFImporter_UpdateTimeStep_20(GetCppThis(), timestep);
	}
}
