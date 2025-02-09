using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///  vtkOpenGLGPUVolumeRayCastMapper
/// </summary>
/// <remarks>
///  OpenGL implementation of volume rendering through ray-casting.
///
/// @section multi Multiple Inputs
///
/// When multiple inputs are rendered simultaneously, it is possible to
/// composite overlapping areas correctly. Inputs are connected directly to
/// the mapper and their parameters (transfer functions, transformations, etc.)
/// are specified through standard vtkVolume instances. These vtkVolume
/// instances are to be registered in a special vtkProp3D, vtkMultiVolume.
///
/// Structures related to a particular active input are stored in a helper
/// class (vtkVolumeInputHelper) and helper structures are kept in a
/// port-referenced map (VolumeInputMap). The order of the inputs in the
/// map is important as it defines the order in which parameters are
/// bound to uniform variables (transformation matrices, bias, scale and every
/// other required rendering parameter).
///
/// A separate code path is used when rendering multiple-inputs in order to
/// facilitate the co-existance of these two modes (single/multiple), due to
/// current feature incompatibilities with multiple inputs (e.g. texture-streaming,
/// cropping, etc.).
///
/// @note A limited set of the mapper features are currently supported for
/// multiple inputs:
///
/// - Blending
///   - Composite (front-to-back)
///
/// - Transfer functions (defined separately for per input)
///   - 1D color
///   - 1D scalar opacity
///   - 1D gradient magnitude opacity
///   - 2D scalar-gradient magnitude
///
/// - Point and cell data
///   - With the limitation that all of the inputs are assumed to share the same
///     name/id.
///
/// </remarks>
/// <seealso>
///  vtkGPUVolumeRayCastMapper vtkVolumeInputHelper vtkVolumeTexture
/// vtkMultiVolume
///
/// </seealso>
public class vtkOpenGLGPUVolumeRayCastMapper : vtkGPUVolumeRayCastMapper
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum Passes
	{
		/// <summary>enum member</summary>
		DepthPass = 1,
		/// <summary>enum member</summary>
		RenderPass = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLGPUVolumeRayCastMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLGPUVolumeRayCastMapper()
	{
		MRClassNameKey = "class vtkOpenGLGPUVolumeRayCastMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLGPUVolumeRayCastMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLGPUVolumeRayCastMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLGPUVolumeRayCastMapper New()
	{
		vtkOpenGLGPUVolumeRayCastMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLGPUVolumeRayCastMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLGPUVolumeRayCastMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGPUVolumeRayCastMapper_GetColorImage_01(HandleRef pThis, HandleRef im);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void GetColorImage(vtkImageData im)
	{
		vtkOpenGLGPUVolumeRayCastMapper_GetColorImage_01(GetCppThis(), im?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGPUVolumeRayCastMapper_GetCurrentPass_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetCurrentPass()
	{
		return vtkOpenGLGPUVolumeRayCastMapper_GetCurrentPass_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGPUVolumeRayCastMapper_GetDepthImage_03(HandleRef pThis, HandleRef im);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void GetDepthImage(vtkImageData im)
	{
		vtkOpenGLGPUVolumeRayCastMapper_GetDepthImage_03(GetCppThis(), im?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLGPUVolumeRayCastMapper_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGPUVolumeRayCastMapper_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLGPUVolumeRayCastMapper_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLGPUVolumeRayCastMapper_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLGPUVolumeRayCastMapper_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLGPUVolumeRayCastMapper NewInstance()
	{
		vtkOpenGLGPUVolumeRayCastMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLGPUVolumeRayCastMapper_PreLoadData_10(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	///  Load the volume texture into GPU memory.  Actual loading occurs
	///  in vtkVolumeTexture::LoadVolume.  The mapper by default loads data
	///  lazily (at render time), so it is most commonly not necessary to call
	///  this function.  This method is only exposed in order to support on-site
	///  loading which is useful in cases where the user needs to know a-priori
	///  whether loading will succeed or not.
	/// </summary>
	public bool PreLoadData(vtkRenderer ren, vtkVolume vol)
	{
		return (vtkOpenGLGPUVolumeRayCastMapper_PreLoadData_10(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGPUVolumeRayCastMapper_ReleaseGraphicsResources_11(HandleRef pThis, HandleRef window);

	/// <summary>
	///  Load the volume texture into GPU memory.  Actual loading occurs
	///  in vtkVolumeTexture::LoadVolume.  The mapper by default loads data
	///  lazily (at render time), so it is most commonly not necessary to call
	///  this function.  This method is only exposed in order to support on-site
	///  loading which is useful in cases where the user needs to know a-priori
	///  whether loading will succeed or not.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkOpenGLGPUVolumeRayCastMapper_ReleaseGraphicsResources_11(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLGPUVolumeRayCastMapper_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLGPUVolumeRayCastMapper SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLGPUVolumeRayCastMapper vtkOpenGLGPUVolumeRayCastMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLGPUVolumeRayCastMapper_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLGPUVolumeRayCastMapper2 = (vtkOpenGLGPUVolumeRayCastMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLGPUVolumeRayCastMapper2.Register(null);
			}
		}
		return vtkOpenGLGPUVolumeRayCastMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLGPUVolumeRayCastMapper_SetPartitions_13(HandleRef pThis, ushort x, ushort y, ushort z);

	/// <summary>
	/// Set a fixed number of partitions in which to split the volume
	/// during rendring. This will force by-block rendering without
	/// trying to compute an optimum number of partitions.
	/// </summary>
	public void SetPartitions(ushort x, ushort y, ushort z)
	{
		vtkOpenGLGPUVolumeRayCastMapper_SetPartitions_13(GetCppThis(), x, y, z);
	}
}
