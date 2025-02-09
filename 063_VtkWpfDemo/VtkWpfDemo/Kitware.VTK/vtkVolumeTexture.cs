using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///   vtkVolumeTexture
/// </summary>
/// <remarks>
///   Creates and manages the volume texture rendered by
/// vtkOpenGLGPUVolumeRayCastMapper.
///
/// Wraps a vtkTextureObject for which it selects the appropriate format
/// (depending on the input vtkDataArray type, number of components, etc.) and
/// loads input data. The class maintains a set of members of interest to the
/// parent mapper, such as:
///
/// * Active vtkDataArray scalar range.
/// * Volume's scale and bias (pixel transfer functions).
/// * HandleLargeDataType flag.
/// * Texture to data transformations.
/// * Block extents
/// * Block loaded bounds
///
/// This class supports streaming the volume data in separate blocks to make it
/// fit in graphics memory (sometimes referred to as bricking). The data is split
/// into a user-defined number of blocks in such a way that a single sub-block
/// (brick) fits completely into GPU memory.  A stride is passed to OpenGL so
/// that it can access the underlying vtkDataArray adequately for each of the
/// blocks to be streamed into GPU memory (back-to-front for correct
/// composition).
///
/// Streaming the volume as separate texture bricks certainly imposes a
/// performance trade-off but acts as a graphics memory expansion scheme for
/// devices that would not be able to render higher resoulution volumes
/// otherwise.
///
/// @warning There are certain caveats when texture streaming is enabled, given
/// the locality constraint that rendering a single block imposes.
///
/// - Quality might suffer near the block seams with ShadeOn() (gradient
/// computation at the boundaries needs adjustment).
///
/// - Not all of the features supported by the mapper currently work correctly.
///   This is a list of known issues:
///   - Blending modes such as average and additive might compute a different
///      value near the edges.
///
/// - Future work will extend the API to be able to compute an ideal number of
///   partitions and extents based on the platform capabilities.
///
/// @warning This is an internal class of vtkOpenGLGPUVolumeRayCastMapper. It
/// assumes there is an active OpenGL context in methods involving GL calls
/// (MakeCurrent() is expected to be called in the mapper beforehand).
/// </remarks>
public class vtkVolumeTexture : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolumeTexture()
	{
		MRClassNameKey = "class vtkVolumeTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolumeTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeTexture New()
	{
		vtkVolumeTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkVolumeTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVolumeTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkVolumeTexture_GetLoadedScalars_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the scale and bias values given a VTK scalar type and a finite range.
	/// The scale and bias values computed using this method can be useful for
	/// custom shader code. For example, when looking up color values through the
	/// transfer function texture, the scalar value must be scaled and offset.
	/// </summary>
	public vtkDataArray GetLoadedScalars()
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeTexture_GetLoadedScalars_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeTexture_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	/// LoadedBounds are corrected for cell-data (if that is the case). So they
	/// are not equivalent to vtkDataSet::GetBounds().
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolumeTexture_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeTexture_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	/// LoadedBounds are corrected for cell-data (if that is the case). So they
	/// are not equivalent to vtkDataSet::GetBounds().
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolumeTexture_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeTexture_GetScaleAndBias_04(int scalarType, IntPtr scalarRange, ref float scale, ref float bias);

	/// <summary>
	/// Get the scale and bias values given a VTK scalar type and a finite range.
	/// The scale and bias values computed using this method can be useful for
	/// custom shader code. For example, when looking up color values through the
	/// transfer function texture, the scalar value must be scaled and offset.
	/// </summary>
	public static void GetScaleAndBias(int scalarType, IntPtr scalarRange, ref float scale, ref float bias)
	{
		vtkVolumeTexture_GetScaleAndBias_04(scalarType, scalarRange, ref scale, ref bias);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeTexture_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// LoadedBounds are corrected for cell-data (if that is the case). So they
	/// are not equivalent to vtkDataSet::GetBounds().
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolumeTexture_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeTexture_IsTypeOf_06(string type);

	/// <summary>
	/// LoadedBounds are corrected for cell-data (if that is the case). So they
	/// are not equivalent to vtkDataSet::GetBounds().
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolumeTexture_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkVolumeTexture_LoadVolume_07(HandleRef pThis, HandleRef ren, HandleRef data, HandleRef scalars, int isCell, int interpolation);

	/// <summary>
	/// Loads the data array into the texture in the case only a single block is
	/// is defined. Does not load when the input data is divided in multiple blocks
	/// (in which case they will be loaded into GPU memory by GetNextBlock()).
	/// Requires an active OpenGL context.
	/// </summary>
	public bool LoadVolume(vtkRenderer ren, vtkDataSet data, vtkDataArray scalars, int isCell, int interpolation)
	{
		return (vtkVolumeTexture_LoadVolume_07(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), data?.GetCppThis() ?? default(HandleRef), scalars?.GetCppThis() ?? default(HandleRef), isCell, interpolation) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeTexture_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// LoadedBounds are corrected for cell-data (if that is the case). So they
	/// are not equivalent to vtkDataSet::GetBounds().
	/// </summary>
	public new vtkVolumeTexture NewInstance()
	{
		vtkVolumeTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeTexture_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeTexture_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Clean-up acquired graphics resources.
	/// </summary>
	public void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkVolumeTexture_ReleaseGraphicsResources_10(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeTexture_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// LoadedBounds are corrected for cell-data (if that is the case). So they
	/// are not equivalent to vtkDataSet::GetBounds().
	/// </summary>
	public new static vtkVolumeTexture SafeDownCast(vtkObjectBase o)
	{
		vtkVolumeTexture vtkVolumeTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeTexture_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeTexture2 = (vtkVolumeTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeTexture2.Register(null);
			}
		}
		return vtkVolumeTexture2;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeTexture_SetPartitions_12(HandleRef pThis, int x, int y, int z);

	/// <summary>
	///  Set a number of blocks per axis.
	/// </summary>
	public void SetPartitions(int x, int y, int z)
	{
		vtkVolumeTexture_SetPartitions_12(GetCppThis(), x, y, z);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeTexture_SortBlocksBackToFront_13(HandleRef pThis, HandleRef ren, HandleRef volumeMat);

	/// <summary>
	/// If streaming the data array as separate blocks, sort them back to front.
	/// This method does nothing if there is a single block.
	/// </summary>
	public void SortBlocksBackToFront(vtkRenderer ren, vtkMatrix4x4 volumeMat)
	{
		vtkVolumeTexture_SortBlocksBackToFront_13(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), volumeMat?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeTexture_UpdateVolume_14(HandleRef pThis, HandleRef property);

	/// <summary>
	/// It currently only calls SetInterpolation internally. Requires an active OpenGL
	/// context.
	/// </summary>
	public void UpdateVolume(vtkVolumeProperty property)
	{
		vtkVolumeTexture_UpdateVolume_14(GetCppThis(), property?.GetCppThis() ?? default(HandleRef));
	}
}
