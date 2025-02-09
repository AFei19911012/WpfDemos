using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFixedPointRayCastImage
/// </summary>
/// <remarks>
///    helper class for a ray cast image
///
/// This is a helper class for storing the ray cast image including the
/// underlying data and the size of the image. This class is not intended
/// to be used directly - just as an internal class in the
/// vtkFixedPointVolumeRayCastMapper so that multiple mappers can share
/// the same image. This class also stored the ZBuffer (if necessary due
/// to intermixed geometry). Perhaps this class could be generalized
/// in the future to be used for other ray cast methods other than the
/// fixed point method.
///
/// </remarks>
/// <seealso>
///
/// vtkFixedPointVolumeRayCastMapper
/// </seealso>
public class vtkFixedPointRayCastImage : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFixedPointRayCastImage";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFixedPointRayCastImage()
	{
		MRClassNameKey = "class vtkFixedPointRayCastImage";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedPointRayCastImage"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFixedPointRayCastImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointRayCastImage New()
	{
		vtkFixedPointRayCastImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointRayCastImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkFixedPointRayCastImage()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkFixedPointRayCastImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_AllocateImage_01(HandleRef pThis);

	/// <summary>
	/// Call this method once the ImageMemorySize has been set
	/// the allocate the image. If an image already exists,
	/// it will be deleted first.
	/// </summary>
	public void AllocateImage()
	{
		vtkFixedPointRayCastImage_AllocateImage_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_AllocateZBuffer_02(HandleRef pThis);

	/// <summary>
	/// Get the ZBuffer. The size of the ZBuffer should be specific
	/// with SetZBufferSize, and AllocateZBuffer method should be called
	/// before getting the ZBuffer.
	/// </summary>
	public void AllocateZBuffer()
	{
		vtkFixedPointRayCastImage_AllocateZBuffer_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_ClearImage_03(HandleRef pThis);

	/// <summary>
	/// Clear the image to (0,0,0,0) for each pixel.
	/// </summary>
	public void ClearImage()
	{
		vtkFixedPointRayCastImage_ClearImage_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_GetImage_04(HandleRef pThis);

	/// <summary>
	/// Get the internal storage for the image. It is a pointer to
	/// unsigned short with four components (RGBA) per pixel. This
	/// memory is allocated when the AllocateImage method is called.
	/// </summary>
	public IntPtr GetImage()
	{
		return vtkFixedPointRayCastImage_GetImage_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_GetImageInUseSize_05(HandleRef pThis);

	/// <summary>
	/// Set / Get the size of the image we are actually using. As
	/// long as the memory size is big enough, but not too big,
	/// we won't bother deleting and re-allocated, we'll just
	/// continue to use the memory size we have. This size will
	/// always be equal to or less than the ImageMemorySize.
	/// </summary>
	public virtual int[] GetImageInUseSize()
	{
		IntPtr intPtr = vtkFixedPointRayCastImage_GetImageInUseSize_05(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_GetImageInUseSize_06(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / Get the size of the image we are actually using. As
	/// long as the memory size is big enough, but not too big,
	/// we won't bother deleting and re-allocated, we'll just
	/// continue to use the memory size we have. This size will
	/// always be equal to or less than the ImageMemorySize.
	/// </summary>
	public virtual void GetImageInUseSize(IntPtr data)
	{
		vtkFixedPointRayCastImage_GetImageInUseSize_06(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_GetImageMemorySize_07(HandleRef pThis);

	/// <summary>
	/// Set / Get the ImageMemorySize. This is the size in pixels
	/// of the Image ivar. This will be a power of two in order
	/// to ensure that the texture can be rendered by graphics
	/// hardware that requires power of two textures.
	/// </summary>
	public virtual int[] GetImageMemorySize()
	{
		IntPtr intPtr = vtkFixedPointRayCastImage_GetImageMemorySize_07(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_GetImageMemorySize_08(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / Get the ImageMemorySize. This is the size in pixels
	/// of the Image ivar. This will be a power of two in order
	/// to ensure that the texture can be rendered by graphics
	/// hardware that requires power of two textures.
	/// </summary>
	public virtual void GetImageMemorySize(IntPtr data)
	{
		vtkFixedPointRayCastImage_GetImageMemorySize_08(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_GetImageOrigin_09(HandleRef pThis);

	/// <summary>
	/// Set / Get the origin of the image. This is the starting
	/// pixel within the whole viewport that our Image starts on.
	/// That is, we could be generating just a subregion of the
	/// whole viewport due to the fact that our volume occupies
	/// only a portion of the viewport. The Image pixels will
	/// start from this location.
	/// </summary>
	public virtual int[] GetImageOrigin()
	{
		IntPtr intPtr = vtkFixedPointRayCastImage_GetImageOrigin_09(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_GetImageOrigin_10(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / Get the origin of the image. This is the starting
	/// pixel within the whole viewport that our Image starts on.
	/// That is, we could be generating just a subregion of the
	/// whole viewport due to the fact that our volume occupies
	/// only a portion of the viewport. The Image pixels will
	/// start from this location.
	/// </summary>
	public virtual void GetImageOrigin(IntPtr data)
	{
		vtkFixedPointRayCastImage_GetImageOrigin_10(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointRayCastImage_GetImageSampleDistance_11(HandleRef pThis);

	/// <summary>
	/// Set / Get the ImageSampleDistance that will be used for
	/// rendering. This is a copy of the value stored in the
	/// mapper. It is stored here for sharing between all mappers
	/// that are participating in the creation of this image.
	/// </summary>
	public virtual float GetImageSampleDistance()
	{
		return vtkFixedPointRayCastImage_GetImageSampleDistance_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_GetImageViewportSize_12(HandleRef pThis);

	/// <summary>
	/// Set / Get the ImageViewportSize. This is the size of the
	/// whole viewport in pixels.
	/// </summary>
	public virtual int[] GetImageViewportSize()
	{
		IntPtr intPtr = vtkFixedPointRayCastImage_GetImageViewportSize_12(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_GetImageViewportSize_13(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / Get the ImageViewportSize. This is the size of the
	/// whole viewport in pixels.
	/// </summary>
	public virtual void GetImageViewportSize(IntPtr data)
	{
		vtkFixedPointRayCastImage_GetImageViewportSize_13(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointRayCastImage_GetNumberOfGenerationsFromBase_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFixedPointRayCastImage_GetNumberOfGenerationsFromBase_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFixedPointRayCastImage_GetNumberOfGenerationsFromBaseType_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFixedPointRayCastImage_GetNumberOfGenerationsFromBaseType_15(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointRayCastImage_GetUseZBuffer_16(HandleRef pThis);

	/// <summary>
	/// The UseZBuffer flag indicates whether the ZBuffer is in use.
	/// The ZBuffer is captured and used when IntermixIntersectingGeometry
	/// is on in the mapper, and when there are props that have been
	/// rendered before the current volume.
	/// </summary>
	public virtual int GetUseZBuffer()
	{
		return vtkFixedPointRayCastImage_GetUseZBuffer_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointRayCastImage_GetUseZBufferMaxValue_17(HandleRef pThis);

	/// <summary>
	/// The UseZBuffer flag indicates whether the ZBuffer is in use.
	/// The ZBuffer is captured and used when IntermixIntersectingGeometry
	/// is on in the mapper, and when there are props that have been
	/// rendered before the current volume.
	/// </summary>
	public virtual int GetUseZBufferMaxValue()
	{
		return vtkFixedPointRayCastImage_GetUseZBufferMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointRayCastImage_GetUseZBufferMinValue_18(HandleRef pThis);

	/// <summary>
	/// The UseZBuffer flag indicates whether the ZBuffer is in use.
	/// The ZBuffer is captured and used when IntermixIntersectingGeometry
	/// is on in the mapper, and when there are props that have been
	/// rendered before the current volume.
	/// </summary>
	public virtual int GetUseZBufferMinValue()
	{
		return vtkFixedPointRayCastImage_GetUseZBufferMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_GetZBuffer_19(HandleRef pThis);

	/// <summary>
	/// Get the ZBuffer. The size of the ZBuffer should be specific
	/// with SetZBufferSize, and AllocateZBuffer method should be called
	/// before getting the ZBuffer.
	/// </summary>
	public IntPtr GetZBuffer()
	{
		return vtkFixedPointRayCastImage_GetZBuffer_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_GetZBufferOrigin_20(HandleRef pThis);

	/// <summary>
	/// Set / Get the origin of the ZBuffer. This is the distance
	/// from the lower left corner of the viewport where the ZBuffer
	/// started (multiply the ImageOrigin by the ImageSampleDistance)
	/// This is the pixel location on the full resolution viewport
	/// where the ZBuffer capture will start. These values are used
	/// to convert the (x,y) pixel location within the ImageInUseSize
	/// image into a ZBuffer location.
	/// </summary>
	public virtual int[] GetZBufferOrigin()
	{
		IntPtr intPtr = vtkFixedPointRayCastImage_GetZBufferOrigin_20(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_GetZBufferOrigin_21(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / Get the origin of the ZBuffer. This is the distance
	/// from the lower left corner of the viewport where the ZBuffer
	/// started (multiply the ImageOrigin by the ImageSampleDistance)
	/// This is the pixel location on the full resolution viewport
	/// where the ZBuffer capture will start. These values are used
	/// to convert the (x,y) pixel location within the ImageInUseSize
	/// image into a ZBuffer location.
	/// </summary>
	public virtual void GetZBufferOrigin(IntPtr data)
	{
		vtkFixedPointRayCastImage_GetZBufferOrigin_21(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_GetZBufferSize_22(HandleRef pThis);

	/// <summary>
	/// Set / Get the size of the ZBuffer in pixels. The zbuffer will
	/// be captured for the region of the screen covered by the
	/// ImageInUseSize image. However, due to subsampling, the size
	/// of the ImageInUseSize image may be smaller than this ZBuffer
	/// image which will be captured at screen resolution.
	/// </summary>
	public virtual int[] GetZBufferSize()
	{
		IntPtr intPtr = vtkFixedPointRayCastImage_GetZBufferSize_22(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_GetZBufferSize_23(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set / Get the size of the ZBuffer in pixels. The zbuffer will
	/// be captured for the region of the screen covered by the
	/// ImageInUseSize image. However, due to subsampling, the size
	/// of the ImageInUseSize image may be smaller than this ZBuffer
	/// image which will be captured at screen resolution.
	/// </summary>
	public virtual void GetZBufferSize(IntPtr data)
	{
		vtkFixedPointRayCastImage_GetZBufferSize_23(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkFixedPointRayCastImage_GetZBufferValue_24(HandleRef pThis, int x, int y);

	/// <summary>
	/// Get the ZBuffer value corresponding to location (x,y) where (x,y)
	/// are indexing into the ImageInUse image. This must be converted to
	/// the zbuffer image coordinates. Nearest neighbor value is returned.
	/// If UseZBuffer is off, then 1.0 is always returned.
	/// </summary>
	public float GetZBufferValue(int x, int y)
	{
		return vtkFixedPointRayCastImage_GetZBufferValue_24(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointRayCastImage_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFixedPointRayCastImage_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFixedPointRayCastImage_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFixedPointRayCastImage_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFixedPointRayCastImage NewInstance()
	{
		vtkFixedPointRayCastImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointRayCastImage_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFixedPointRayCastImage_SafeDownCast_29(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFixedPointRayCastImage SafeDownCast(vtkObjectBase o)
	{
		vtkFixedPointRayCastImage vtkFixedPointRayCastImage2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFixedPointRayCastImage_SafeDownCast_29(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFixedPointRayCastImage2 = (vtkFixedPointRayCastImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFixedPointRayCastImage2.Register(null);
			}
		}
		return vtkFixedPointRayCastImage2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageInUseSize_30(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set / Get the size of the image we are actually using. As
	/// long as the memory size is big enough, but not too big,
	/// we won't bother deleting and re-allocated, we'll just
	/// continue to use the memory size we have. This size will
	/// always be equal to or less than the ImageMemorySize.
	/// </summary>
	public virtual void SetImageInUseSize(int _arg1, int _arg2)
	{
		vtkFixedPointRayCastImage_SetImageInUseSize_30(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageInUseSize_31(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the size of the image we are actually using. As
	/// long as the memory size is big enough, but not too big,
	/// we won't bother deleting and re-allocated, we'll just
	/// continue to use the memory size we have. This size will
	/// always be equal to or less than the ImageMemorySize.
	/// </summary>
	public void SetImageInUseSize(IntPtr _arg)
	{
		vtkFixedPointRayCastImage_SetImageInUseSize_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageMemorySize_32(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set / Get the ImageMemorySize. This is the size in pixels
	/// of the Image ivar. This will be a power of two in order
	/// to ensure that the texture can be rendered by graphics
	/// hardware that requires power of two textures.
	/// </summary>
	public virtual void SetImageMemorySize(int _arg1, int _arg2)
	{
		vtkFixedPointRayCastImage_SetImageMemorySize_32(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageMemorySize_33(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the ImageMemorySize. This is the size in pixels
	/// of the Image ivar. This will be a power of two in order
	/// to ensure that the texture can be rendered by graphics
	/// hardware that requires power of two textures.
	/// </summary>
	public void SetImageMemorySize(IntPtr _arg)
	{
		vtkFixedPointRayCastImage_SetImageMemorySize_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageOrigin_34(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set / Get the origin of the image. This is the starting
	/// pixel within the whole viewport that our Image starts on.
	/// That is, we could be generating just a subregion of the
	/// whole viewport due to the fact that our volume occupies
	/// only a portion of the viewport. The Image pixels will
	/// start from this location.
	/// </summary>
	public virtual void SetImageOrigin(int _arg1, int _arg2)
	{
		vtkFixedPointRayCastImage_SetImageOrigin_34(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageOrigin_35(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the origin of the image. This is the starting
	/// pixel within the whole viewport that our Image starts on.
	/// That is, we could be generating just a subregion of the
	/// whole viewport due to the fact that our volume occupies
	/// only a portion of the viewport. The Image pixels will
	/// start from this location.
	/// </summary>
	public void SetImageOrigin(IntPtr _arg)
	{
		vtkFixedPointRayCastImage_SetImageOrigin_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageSampleDistance_36(HandleRef pThis, float _arg);

	/// <summary>
	/// Set / Get the ImageSampleDistance that will be used for
	/// rendering. This is a copy of the value stored in the
	/// mapper. It is stored here for sharing between all mappers
	/// that are participating in the creation of this image.
	/// </summary>
	public virtual void SetImageSampleDistance(float _arg)
	{
		vtkFixedPointRayCastImage_SetImageSampleDistance_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageViewportSize_37(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set / Get the ImageViewportSize. This is the size of the
	/// whole viewport in pixels.
	/// </summary>
	public virtual void SetImageViewportSize(int _arg1, int _arg2)
	{
		vtkFixedPointRayCastImage_SetImageViewportSize_37(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetImageViewportSize_38(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the ImageViewportSize. This is the size of the
	/// whole viewport in pixels.
	/// </summary>
	public void SetImageViewportSize(IntPtr _arg)
	{
		vtkFixedPointRayCastImage_SetImageViewportSize_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetUseZBuffer_39(HandleRef pThis, int _arg);

	/// <summary>
	/// The UseZBuffer flag indicates whether the ZBuffer is in use.
	/// The ZBuffer is captured and used when IntermixIntersectingGeometry
	/// is on in the mapper, and when there are props that have been
	/// rendered before the current volume.
	/// </summary>
	public virtual void SetUseZBuffer(int _arg)
	{
		vtkFixedPointRayCastImage_SetUseZBuffer_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetZBufferOrigin_40(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set / Get the origin of the ZBuffer. This is the distance
	/// from the lower left corner of the viewport where the ZBuffer
	/// started (multiply the ImageOrigin by the ImageSampleDistance)
	/// This is the pixel location on the full resolution viewport
	/// where the ZBuffer capture will start. These values are used
	/// to convert the (x,y) pixel location within the ImageInUseSize
	/// image into a ZBuffer location.
	/// </summary>
	public virtual void SetZBufferOrigin(int _arg1, int _arg2)
	{
		vtkFixedPointRayCastImage_SetZBufferOrigin_40(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetZBufferOrigin_41(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the origin of the ZBuffer. This is the distance
	/// from the lower left corner of the viewport where the ZBuffer
	/// started (multiply the ImageOrigin by the ImageSampleDistance)
	/// This is the pixel location on the full resolution viewport
	/// where the ZBuffer capture will start. These values are used
	/// to convert the (x,y) pixel location within the ImageInUseSize
	/// image into a ZBuffer location.
	/// </summary>
	public void SetZBufferOrigin(IntPtr _arg)
	{
		vtkFixedPointRayCastImage_SetZBufferOrigin_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetZBufferSize_42(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set / Get the size of the ZBuffer in pixels. The zbuffer will
	/// be captured for the region of the screen covered by the
	/// ImageInUseSize image. However, due to subsampling, the size
	/// of the ImageInUseSize image may be smaller than this ZBuffer
	/// image which will be captured at screen resolution.
	/// </summary>
	public virtual void SetZBufferSize(int _arg1, int _arg2)
	{
		vtkFixedPointRayCastImage_SetZBufferSize_42(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_SetZBufferSize_43(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set / Get the size of the ZBuffer in pixels. The zbuffer will
	/// be captured for the region of the screen covered by the
	/// ImageInUseSize image. However, due to subsampling, the size
	/// of the ImageInUseSize image may be smaller than this ZBuffer
	/// image which will be captured at screen resolution.
	/// </summary>
	public void SetZBufferSize(IntPtr _arg)
	{
		vtkFixedPointRayCastImage_SetZBufferSize_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_UseZBufferOff_44(HandleRef pThis);

	/// <summary>
	/// The UseZBuffer flag indicates whether the ZBuffer is in use.
	/// The ZBuffer is captured and used when IntermixIntersectingGeometry
	/// is on in the mapper, and when there are props that have been
	/// rendered before the current volume.
	/// </summary>
	public virtual void UseZBufferOff()
	{
		vtkFixedPointRayCastImage_UseZBufferOff_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFixedPointRayCastImage_UseZBufferOn_45(HandleRef pThis);

	/// <summary>
	/// The UseZBuffer flag indicates whether the ZBuffer is in use.
	/// The ZBuffer is captured and used when IntermixIntersectingGeometry
	/// is on in the mapper, and when there are props that have been
	/// rendered before the current volume.
	/// </summary>
	public virtual void UseZBufferOn()
	{
		vtkFixedPointRayCastImage_UseZBufferOn_45(GetCppThis());
	}
}
