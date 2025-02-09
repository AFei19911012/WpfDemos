using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTexture
/// </summary>
/// <remarks>
///    handles properties associated with a texture map
///
/// vtkTexture is an image algorithm that handles loading and binding of
/// texture maps. It obtains its data from an input image data dataset type.
/// Thus you can create visualization pipelines to read, process, and
/// construct textures. Note that textures will only work if texture
/// coordinates are also defined, and if the rendering system supports
/// texture.
///
/// Instances of vtkTexture are associated with actors via the actor's
/// SetTexture() method. Actors can share texture maps (this is encouraged
/// to save memory resources.)
///
/// @warning
/// Currently only 2D texture maps are supported, even though the data pipeline
/// supports 1,2, and 3D texture coordinates.
///
/// @warning
/// Some renderers such as old OpenGL require that the texture map dimensions
/// are a power of two in each direction. If a non-power of two texture map is
/// used, it is automatically resampled to a power of two in one or more
/// directions, at the cost of an expensive computation. If the OpenGL
/// implementation is recent enough (OpenGL&gt;=2.0 or
/// extension GL_ARB_texture_non_power_of_two exists) there is no such
/// restriction and no extra computational cost.
/// </remarks>
/// <seealso>
///
/// vtkActor vtkRenderer vtkOpenGLTexture
/// </seealso>
public class vtkTexture : vtkImageAlgorithm
{
	/// <summary>
	/// Border Color (RGBA). The values can be any valid float value,
	/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
	/// as in the OpenGL spec.
	///
	/// \note
	/// This property is ignored for OpenGL ES &lt;= 3.2
	/// </summary>
	public enum ClampToBorder_WrapperEnum
	{
		/// <summary>enum member</summary>
		ClampToBorder = 3,
		/// <summary>enum member</summary>
		ClampToEdge = 0,
		/// <summary>enum member</summary>
		MirroredRepeat = 2,
		/// <summary>enum member</summary>
		NumberOfWrapModes = 4,
		/// <summary>enum member</summary>
		Repeat = 1
	}

	/// <summary>
	/// Used to specify how the texture will blend its RGB and Alpha values
	/// with other textures and the fragment the texture is rendered upon.
	/// </summary>
	public enum VTKTextureBlendingMode
	{
		/// <summary>enum member</summary>
		VTK_TEXTURE_BLENDING_MODE_ADD = 3,
		/// <summary>enum member</summary>
		VTK_TEXTURE_BLENDING_MODE_ADD_SIGNED = 4,
		/// <summary>enum member</summary>
		VTK_TEXTURE_BLENDING_MODE_INTERPOLATE = 5,
		/// <summary>enum member</summary>
		VTK_TEXTURE_BLENDING_MODE_MODULATE = 2,
		/// <summary>enum member</summary>
		VTK_TEXTURE_BLENDING_MODE_NONE = 0,
		/// <summary>enum member</summary>
		VTK_TEXTURE_BLENDING_MODE_REPLACE = 1,
		/// <summary>enum member</summary>
		VTK_TEXTURE_BLENDING_MODE_SUBTRACT = 6
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTexture";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTexture()
	{
		MRClassNameKey = "class vtkTexture";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTexture"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTexture(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTexture New()
	{
		vtkTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTexture()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTexture_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkTexture_CubeMapOff_01(HandleRef pThis);

	/// <summary>
	/// Is this texture a cube map, if so it needs 6 inputs
	/// one for each side of the cube. You must set this before
	/// connecting the inputs. The inputs must all have the same
	/// size, data type, and depth
	/// </summary>
	public virtual void CubeMapOff()
	{
		vtkTexture_CubeMapOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_CubeMapOn_02(HandleRef pThis);

	/// <summary>
	/// Is this texture a cube map, if so it needs 6 inputs
	/// one for each side of the cube. You must set this before
	/// connecting the inputs. The inputs must all have the same
	/// size, data type, and depth
	/// </summary>
	public virtual void CubeMapOn()
	{
		vtkTexture_CubeMapOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_EdgeClampOff_03(HandleRef pThis);

	/// <summary>
	/// Convenience functions to maintain backwards compatibility.
	/// For new code, use the SetWrap API.
	/// </summary>
	public virtual void EdgeClampOff()
	{
		vtkTexture_EdgeClampOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_EdgeClampOn_04(HandleRef pThis);

	/// <summary>
	/// Convenience functions to maintain backwards compatibility.
	/// For new code, use the SetWrap API.
	/// </summary>
	public virtual void EdgeClampOn()
	{
		vtkTexture_EdgeClampOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetBlendingMode_05(HandleRef pThis);

	/// <summary>
	/// Used to specify how the texture will blend its RGB and Alpha values
	/// with other textures and the fragment the texture is rendered upon.
	/// </summary>
	public virtual int GetBlendingMode()
	{
		return vtkTexture_GetBlendingMode_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_GetBorderColor_06(HandleRef pThis);

	/// <summary>
	/// Border Color (RGBA). The values can be any valid float value,
	/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
	/// as in the OpenGL spec.
	///
	/// \note
	/// This property is ignored for OpenGL ES &lt;= 3.2
	/// </summary>
	public virtual float[] GetBorderColor()
	{
		IntPtr intPtr = vtkTexture_GetBorderColor_06(GetCppThis());
		float[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new float[4];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_GetBorderColor_07(HandleRef pThis, ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4);

	/// <summary>
	/// Border Color (RGBA). The values can be any valid float value,
	/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
	/// as in the OpenGL spec.
	///
	/// \note
	/// This property is ignored for OpenGL ES &lt;= 3.2
	/// </summary>
	public virtual void GetBorderColor(ref float _arg1, ref float _arg2, ref float _arg3, ref float _arg4)
	{
		vtkTexture_GetBorderColor_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_GetBorderColor_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Border Color (RGBA). The values can be any valid float value,
	/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
	/// as in the OpenGL spec.
	///
	/// \note
	/// This property is ignored for OpenGL ES &lt;= 3.2
	/// </summary>
	public virtual void GetBorderColor(IntPtr _arg)
	{
		vtkTexture_GetBorderColor_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetColorMode_09(HandleRef pThis);

	/// <summary>
	/// Default: ColorModeToDefault. unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
	/// while other kinds of scalars are. ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkTexture_GetColorMode_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTexture_GetCubeMap_10(HandleRef pThis);

	/// <summary>
	/// Is this texture a cube map, if so it needs 6 inputs
	/// one for each side of the cube. You must set this before
	/// connecting the inputs. The inputs must all have the same
	/// size, data type, and depth
	/// </summary>
	public virtual bool GetCubeMap()
	{
		return (vtkTexture_GetCubeMap_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetEdgeClamp_11(HandleRef pThis);

	/// <summary>
	/// Convenience functions to maintain backwards compatibility.
	/// For new code, use the SetWrap API.
	/// </summary>
	public virtual int GetEdgeClamp()
	{
		return vtkTexture_GetEdgeClamp_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_GetInput_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input as a vtkImageData object.  This method is for
	/// backwards compatibility.
	/// </summary>
	public new vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexture_GetInput_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetInterpolate_13(HandleRef pThis);

	/// <summary>
	/// Turn on/off linear interpolation of the texture map when rendering.
	/// </summary>
	public virtual int GetInterpolate()
	{
		return vtkTexture_GetInterpolate_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_GetLookupTable_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the lookup table to convert scalars if necessary
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexture_GetLookupTable_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_GetMappedScalars_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get Mapped Scalars
	/// </summary>
	public virtual vtkUnsignedCharArray GetMappedScalars()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexture_GetMappedScalars_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkTexture_GetMaximumAnisotropicFiltering_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum anisotropic filtering to use. 1.0 means use no
	/// anisotropic filtering. The default value is 4.0 and a high value would
	/// be 16. This setting is only applied when mipmaps are used. This might
	/// not be supported on all machines.
	/// </summary>
	public virtual float GetMaximumAnisotropicFiltering()
	{
		return vtkTexture_GetMaximumAnisotropicFiltering_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTexture_GetMipmap_17(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of mipmaps when rendering.
	/// </summary>
	public virtual bool GetMipmap()
	{
		return (vtkTexture_GetMipmap_17(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTexture_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTexture_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTexture_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTexture_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTexture_GetPremultipliedAlpha_20(HandleRef pThis);

	/// <summary>
	/// Whether the texture colors are premultiplied by alpha.
	/// Initial value is false.
	/// </summary>
	public virtual bool GetPremultipliedAlpha()
	{
		return (vtkTexture_GetPremultipliedAlpha_20(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetQuality_21(HandleRef pThis);

	/// <summary>
	/// Force texture quality to 16-bit or 32-bit.
	/// This might not be supported on all machines.
	/// </summary>
	public virtual int GetQuality()
	{
		return vtkTexture_GetQuality_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetRepeat_22(HandleRef pThis);

	/// <summary>
	/// Convenience functions to maintain backwards compatibility.
	/// For new code, use the SetWrap API.
	/// </summary>
	public virtual int GetRepeat()
	{
		return vtkTexture_GetRepeat_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetRestrictPowerOf2ImageSmaller_23(HandleRef pThis);

	/// <summary>
	/// When the texture is forced to be a power of 2, the default behavior is
	/// for the "new" image's dimensions to be greater than or equal to with
	/// respects to the original.  Setting RestrictPowerOf2ImageSmaller to be
	/// 1 (or ON) with force the new image's dimensions to be less than or equal
	/// to with respects to the original.
	/// </summary>
	public virtual int GetRestrictPowerOf2ImageSmaller()
	{
		return vtkTexture_GetRestrictPowerOf2ImageSmaller_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetTextureUnit_24(HandleRef pThis);

	/// <summary>
	/// Return the texture unit used for this texture
	/// </summary>
	public virtual int GetTextureUnit()
	{
		return vtkTexture_GetTextureUnit_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_GetTransform_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a transform on the texture which allows one to scale,
	/// rotate and translate the texture.
	/// </summary>
	public virtual vtkTransform GetTransform()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexture_GetTransform_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTexture_GetUseSRGBColorSpace_26(HandleRef pThis);

	/// <summary>
	/// Is this texture using the sRGB color space. If you are using a
	/// sRGB framebuffer or window then you probably also want to be
	/// using sRGB color textures for proper handling of gamma and
	/// associated color mixing.
	/// </summary>
	public virtual bool GetUseSRGBColorSpace()
	{
		return (vtkTexture_GetUseSRGBColorSpace_26(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetWrap_27(HandleRef pThis);

	/// <summary>
	/// Wrap mode for the texture coordinates
	/// Valid values are:
	/// - ClampToEdge
	/// - Repeat
	/// - MirroredRepeat
	/// - ClampToBorder
	/// Initial value is Repeat (as in OpenGL spec)
	///
	/// \note
	/// ClampToBorder is not supported with OpenGL ES &lt;= 3.2.
	/// Wrap will default to ClampToEdge if it is set to ClampToBorder in this case.
	/// </summary>
	public virtual int GetWrap()
	{
		return vtkTexture_GetWrap_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetWrapMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Wrap mode for the texture coordinates
	/// Valid values are:
	/// - ClampToEdge
	/// - Repeat
	/// - MirroredRepeat
	/// - ClampToBorder
	/// Initial value is Repeat (as in OpenGL spec)
	///
	/// \note
	/// ClampToBorder is not supported with OpenGL ES &lt;= 3.2.
	/// Wrap will default to ClampToEdge if it is set to ClampToBorder in this case.
	/// </summary>
	public virtual int GetWrapMaxValue()
	{
		return vtkTexture_GetWrapMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_GetWrapMinValue_29(HandleRef pThis);

	/// <summary>
	/// Wrap mode for the texture coordinates
	/// Valid values are:
	/// - ClampToEdge
	/// - Repeat
	/// - MirroredRepeat
	/// - ClampToBorder
	/// Initial value is Repeat (as in OpenGL spec)
	///
	/// \note
	/// ClampToBorder is not supported with OpenGL ES &lt;= 3.2.
	/// Wrap will default to ClampToEdge if it is set to ClampToBorder in this case.
	/// </summary>
	public virtual int GetWrapMinValue()
	{
		return vtkTexture_GetWrapMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_InterpolateOff_30(HandleRef pThis);

	/// <summary>
	/// Turn on/off linear interpolation of the texture map when rendering.
	/// </summary>
	public virtual void InterpolateOff()
	{
		vtkTexture_InterpolateOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_InterpolateOn_31(HandleRef pThis);

	/// <summary>
	/// Turn on/off linear interpolation of the texture map when rendering.
	/// </summary>
	public virtual void InterpolateOn()
	{
		vtkTexture_InterpolateOn_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_IsA_32(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTexture_IsA_32(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_IsTranslucent_33(HandleRef pThis);

	/// <summary>
	/// Is this Texture Translucent?
	/// returns false (0) if the texture is either fully opaque or has
	/// only fully transparent pixels and fully opaque pixels and the
	/// Interpolate flag is turn off.
	/// </summary>
	public virtual int IsTranslucent()
	{
		return vtkTexture_IsTranslucent_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTexture_IsTypeOf_34(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTexture_IsTypeOf_34(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_Load_35(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Abstract interface to renderer. Each concrete subclass of
	/// vtkTexture will load its data into graphics system in response
	/// to this method invocation.
	/// </summary>
	public virtual void Load(vtkRenderer arg0)
	{
		vtkTexture_Load_35(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_MapScalarsToColors_36(HandleRef pThis, HandleRef scalars);

	/// <summary>
	/// Map scalar values into color scalars.
	/// </summary>
	public IntPtr MapScalarsToColors(vtkDataArray scalars)
	{
		return vtkTexture_MapScalarsToColors_36(GetCppThis(), scalars?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_MipmapOff_37(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of mipmaps when rendering.
	/// </summary>
	public virtual void MipmapOff()
	{
		vtkTexture_MipmapOff_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_MipmapOn_38(HandleRef pThis);

	/// <summary>
	/// Turn on/off use of mipmaps when rendering.
	/// </summary>
	public virtual void MipmapOn()
	{
		vtkTexture_MipmapOn_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_NewInstance_40(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTexture NewInstance()
	{
		vtkTexture result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexture_NewInstance_40(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_PostRender_41(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Cleans up after the texture rendering to restore the state of the
	/// graphics context.
	/// </summary>
	public virtual void PostRender(vtkRenderer arg0)
	{
		vtkTexture_PostRender_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_PremultipliedAlphaOff_42(HandleRef pThis);

	/// <summary>
	/// Whether the texture colors are premultiplied by alpha.
	/// Initial value is false.
	/// </summary>
	public virtual void PremultipliedAlphaOff()
	{
		vtkTexture_PremultipliedAlphaOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_PremultipliedAlphaOn_43(HandleRef pThis);

	/// <summary>
	/// Whether the texture colors are premultiplied by alpha.
	/// Initial value is false.
	/// </summary>
	public virtual void PremultipliedAlphaOn()
	{
		vtkTexture_PremultipliedAlphaOn_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_ReleaseGraphicsResources_44(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by this texture.
	/// The parameter window could be used to determine which graphic
	/// resources to release.
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkTexture_ReleaseGraphicsResources_44(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_Render_45(HandleRef pThis, HandleRef ren);

	/// <summary>
	/// Renders a texture map. It first checks the object's modified time
	/// to make sure the texture maps Input is valid, then it invokes the
	/// Load() method.
	/// </summary>
	public virtual void Render(vtkRenderer ren)
	{
		vtkTexture_Render_45(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_RepeatOff_46(HandleRef pThis);

	/// <summary>
	/// Convenience functions to maintain backwards compatibility.
	/// For new code, use the SetWrap API.
	/// </summary>
	public virtual void RepeatOff()
	{
		vtkTexture_RepeatOff_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_RepeatOn_47(HandleRef pThis);

	/// <summary>
	/// Convenience functions to maintain backwards compatibility.
	/// For new code, use the SetWrap API.
	/// </summary>
	public virtual void RepeatOn()
	{
		vtkTexture_RepeatOn_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_RestrictPowerOf2ImageSmallerOff_48(HandleRef pThis);

	/// <summary>
	/// When the texture is forced to be a power of 2, the default behavior is
	/// for the "new" image's dimensions to be greater than or equal to with
	/// respects to the original.  Setting RestrictPowerOf2ImageSmaller to be
	/// 1 (or ON) with force the new image's dimensions to be less than or equal
	/// to with respects to the original.
	/// </summary>
	public virtual void RestrictPowerOf2ImageSmallerOff()
	{
		vtkTexture_RestrictPowerOf2ImageSmallerOff_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_RestrictPowerOf2ImageSmallerOn_49(HandleRef pThis);

	/// <summary>
	/// When the texture is forced to be a power of 2, the default behavior is
	/// for the "new" image's dimensions to be greater than or equal to with
	/// respects to the original.  Setting RestrictPowerOf2ImageSmaller to be
	/// 1 (or ON) with force the new image's dimensions to be less than or equal
	/// to with respects to the original.
	/// </summary>
	public virtual void RestrictPowerOf2ImageSmallerOn()
	{
		vtkTexture_RestrictPowerOf2ImageSmallerOn_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTexture_SafeDownCast_50(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTexture SafeDownCast(vtkObjectBase o)
	{
		vtkTexture vtkTexture2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTexture_SafeDownCast_50(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTexture2 = (vtkTexture)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTexture2.Register(null);
			}
		}
		return vtkTexture2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetBlendingMode_51(HandleRef pThis, int _arg);

	/// <summary>
	/// Used to specify how the texture will blend its RGB and Alpha values
	/// with other textures and the fragment the texture is rendered upon.
	/// </summary>
	public virtual void SetBlendingMode(int _arg)
	{
		vtkTexture_SetBlendingMode_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetBorderColor_52(HandleRef pThis, float _arg1, float _arg2, float _arg3, float _arg4);

	/// <summary>
	/// Border Color (RGBA). The values can be any valid float value,
	/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
	/// as in the OpenGL spec.
	///
	/// \note
	/// This property is ignored for OpenGL ES &lt;= 3.2
	/// </summary>
	public virtual void SetBorderColor(float _arg1, float _arg2, float _arg3, float _arg4)
	{
		vtkTexture_SetBorderColor_52(GetCppThis(), _arg1, _arg2, _arg3, _arg4);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetBorderColor_53(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Border Color (RGBA). The values can be any valid float value,
	/// if the gpu supports it. Initial value is (0.0f, 0.0f, 0.0f, 0.0f),
	/// as in the OpenGL spec.
	///
	/// \note
	/// This property is ignored for OpenGL ES &lt;= 3.2
	/// </summary>
	public virtual void SetBorderColor(IntPtr _arg)
	{
		vtkTexture_SetBorderColor_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetColorMode_54(HandleRef pThis, int _arg);

	/// <summary>
	/// Default: ColorModeToDefault. unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
	/// while other kinds of scalars are. ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkTexture_SetColorMode_54(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetColorModeToDefault_55(HandleRef pThis);

	/// <summary>
	/// Default: ColorModeToDefault. unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
	/// while other kinds of scalars are. ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.
	/// </summary>
	public void SetColorModeToDefault()
	{
		vtkTexture_SetColorModeToDefault_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetColorModeToDirectScalars_56(HandleRef pThis);

	/// <summary>
	/// Default: ColorModeToDefault. unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
	/// while other kinds of scalars are. ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.
	/// </summary>
	public void SetColorModeToDirectScalars()
	{
		vtkTexture_SetColorModeToDirectScalars_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetColorModeToMapScalars_57(HandleRef pThis);

	/// <summary>
	/// Default: ColorModeToDefault. unsigned char scalars are treated
	/// as colors, and NOT mapped through the lookup table (set with SetLookupTable),
	/// while other kinds of scalars are. ColorModeToDirectScalar extends
	/// ColorModeToDefault such that all integer types are treated as
	/// colors with values in the range 0-255 and floating types are
	/// treated as colors with values in the range 0.0-1.0. Setting
	/// ColorModeToMapScalars means that all scalar data will be mapped
	/// through the lookup table.
	/// </summary>
	public void SetColorModeToMapScalars()
	{
		vtkTexture_SetColorModeToMapScalars_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetCubeMap_58(HandleRef pThis, byte val);

	/// <summary>
	/// Is this texture a cube map, if so it needs 6 inputs
	/// one for each side of the cube. You must set this before
	/// connecting the inputs. The inputs must all have the same
	/// size, data type, and depth
	/// </summary>
	public void SetCubeMap(bool val)
	{
		vtkTexture_SetCubeMap_58(GetCppThis(), (byte)(val ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetEdgeClamp_59(HandleRef pThis, int arg0);

	/// <summary>
	/// Convenience functions to maintain backwards compatibility.
	/// For new code, use the SetWrap API.
	/// </summary>
	public virtual void SetEdgeClamp(int arg0)
	{
		vtkTexture_SetEdgeClamp_59(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetInterpolate_60(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off linear interpolation of the texture map when rendering.
	/// </summary>
	public virtual void SetInterpolate(int _arg)
	{
		vtkTexture_SetInterpolate_60(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetLookupTable_61(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the lookup table to convert scalars if necessary
	/// </summary>
	public void SetLookupTable(vtkScalarsToColors arg0)
	{
		vtkTexture_SetLookupTable_61(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetMaximumAnisotropicFiltering_62(HandleRef pThis, float _arg);

	/// <summary>
	/// Set/Get the maximum anisotropic filtering to use. 1.0 means use no
	/// anisotropic filtering. The default value is 4.0 and a high value would
	/// be 16. This setting is only applied when mipmaps are used. This might
	/// not be supported on all machines.
	/// </summary>
	public virtual void SetMaximumAnisotropicFiltering(float _arg)
	{
		vtkTexture_SetMaximumAnisotropicFiltering_62(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetMipmap_63(HandleRef pThis, byte _arg);

	/// <summary>
	/// Turn on/off use of mipmaps when rendering.
	/// </summary>
	public virtual void SetMipmap(bool _arg)
	{
		vtkTexture_SetMipmap_63(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetPremultipliedAlpha_64(HandleRef pThis, byte _arg);

	/// <summary>
	/// Whether the texture colors are premultiplied by alpha.
	/// Initial value is false.
	/// </summary>
	public virtual void SetPremultipliedAlpha(bool _arg)
	{
		vtkTexture_SetPremultipliedAlpha_64(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetQuality_65(HandleRef pThis, int _arg);

	/// <summary>
	/// Force texture quality to 16-bit or 32-bit.
	/// This might not be supported on all machines.
	/// </summary>
	public virtual void SetQuality(int _arg)
	{
		vtkTexture_SetQuality_65(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetQualityTo16Bit_66(HandleRef pThis);

	/// <summary>
	/// Force texture quality to 16-bit or 32-bit.
	/// This might not be supported on all machines.
	/// </summary>
	public void SetQualityTo16Bit()
	{
		vtkTexture_SetQualityTo16Bit_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetQualityTo32Bit_67(HandleRef pThis);

	/// <summary>
	/// Force texture quality to 16-bit or 32-bit.
	/// This might not be supported on all machines.
	/// </summary>
	public void SetQualityTo32Bit()
	{
		vtkTexture_SetQualityTo32Bit_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetQualityToDefault_68(HandleRef pThis);

	/// <summary>
	/// Force texture quality to 16-bit or 32-bit.
	/// This might not be supported on all machines.
	/// </summary>
	public void SetQualityToDefault()
	{
		vtkTexture_SetQualityToDefault_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetRepeat_69(HandleRef pThis, int r);

	/// <summary>
	/// Convenience functions to maintain backwards compatibility.
	/// For new code, use the SetWrap API.
	/// </summary>
	public virtual void SetRepeat(int r)
	{
		vtkTexture_SetRepeat_69(GetCppThis(), r);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetRestrictPowerOf2ImageSmaller_70(HandleRef pThis, int _arg);

	/// <summary>
	/// When the texture is forced to be a power of 2, the default behavior is
	/// for the "new" image's dimensions to be greater than or equal to with
	/// respects to the original.  Setting RestrictPowerOf2ImageSmaller to be
	/// 1 (or ON) with force the new image's dimensions to be less than or equal
	/// to with respects to the original.
	/// </summary>
	public virtual void SetRestrictPowerOf2ImageSmaller(int _arg)
	{
		vtkTexture_SetRestrictPowerOf2ImageSmaller_70(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetTransform_71(HandleRef pThis, HandleRef transform);

	/// <summary>
	/// Set a transform on the texture which allows one to scale,
	/// rotate and translate the texture.
	/// </summary>
	public void SetTransform(vtkTransform transform)
	{
		vtkTexture_SetTransform_71(GetCppThis(), transform?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetUseSRGBColorSpace_72(HandleRef pThis, byte _arg);

	/// <summary>
	/// Is this texture using the sRGB color space. If you are using a
	/// sRGB framebuffer or window then you probably also want to be
	/// using sRGB color textures for proper handling of gamma and
	/// associated color mixing.
	/// </summary>
	public virtual void SetUseSRGBColorSpace(bool _arg)
	{
		vtkTexture_SetUseSRGBColorSpace_72(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_SetWrap_73(HandleRef pThis, int _arg);

	/// <summary>
	/// Wrap mode for the texture coordinates
	/// Valid values are:
	/// - ClampToEdge
	/// - Repeat
	/// - MirroredRepeat
	/// - ClampToBorder
	/// Initial value is Repeat (as in OpenGL spec)
	///
	/// \note
	/// ClampToBorder is not supported with OpenGL ES &lt;= 3.2.
	/// Wrap will default to ClampToEdge if it is set to ClampToBorder in this case.
	/// </summary>
	public virtual void SetWrap(int _arg)
	{
		vtkTexture_SetWrap_73(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_UseSRGBColorSpaceOff_74(HandleRef pThis);

	/// <summary>
	/// Is this texture using the sRGB color space. If you are using a
	/// sRGB framebuffer or window then you probably also want to be
	/// using sRGB color textures for proper handling of gamma and
	/// associated color mixing.
	/// </summary>
	public virtual void UseSRGBColorSpaceOff()
	{
		vtkTexture_UseSRGBColorSpaceOff_74(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTexture_UseSRGBColorSpaceOn_75(HandleRef pThis);

	/// <summary>
	/// Is this texture using the sRGB color space. If you are using a
	/// sRGB framebuffer or window then you probably also want to be
	/// using sRGB color textures for proper handling of gamma and
	/// associated color mixing.
	/// </summary>
	public virtual void UseSRGBColorSpaceOn()
	{
		vtkTexture_UseSRGBColorSpaceOn_75(GetCppThis());
	}
}
