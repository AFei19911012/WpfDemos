using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkFreeTypeTools
/// </summary>
/// <remarks>
///    FreeType library support
///
/// vtkFreeTypeTools provides a low-level interface to the FreeType2 library,
/// including font-cache and rasterization.
///
/// @warning
/// Internal use only.
/// </remarks>
public class vtkFreeTypeTools : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkFreeTypeTools";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkFreeTypeTools()
	{
		MRClassNameKey = "class vtkFreeTypeTools";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkFreeTypeTools"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkFreeTypeTools(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	/// <summary>
	/// Automatically generated protected Dispose method - called from
	/// public Dispose or the C# destructor. DO NOT call directly.
	/// </summary>
	protected override void Dispose(bool disposing)
	{
		base.Dispose(disposing);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_DebugTexturesOff_01(HandleRef pThis);

	/// <summary>
	/// If true, images produced by RenderString will have a transparent grey
	/// background and set the justification anchor texel to bright yellow.
	/// </summary>
	public virtual void DebugTexturesOff()
	{
		vtkFreeTypeTools_DebugTexturesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_DebugTexturesOn_02(HandleRef pThis);

	/// <summary>
	/// If true, images produced by RenderString will have a transparent grey
	/// background and set the justification anchor texel to bright yellow.
	/// </summary>
	public virtual void DebugTexturesOn()
	{
		vtkFreeTypeTools_DebugTexturesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_ForceCompiledFontsOff_03(HandleRef pThis);

	/// <summary>
	/// Force use of the fonts compiled into VTK, ignoring any FontConfig or
	/// embedded fonts. Useful for generating test images consistently across
	/// platforms. This flag is on by default.
	/// </summary>
	public virtual void ForceCompiledFontsOff()
	{
		vtkFreeTypeTools_ForceCompiledFontsOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_ForceCompiledFontsOn_04(HandleRef pThis);

	/// <summary>
	/// Force use of the fonts compiled into VTK, ignoring any FontConfig or
	/// embedded fonts. Useful for generating test images consistently across
	/// platforms. This flag is on by default.
	/// </summary>
	public virtual void ForceCompiledFontsOn()
	{
		vtkFreeTypeTools_ForceCompiledFontsOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFreeTypeTools_GetBoundingBox_05(HandleRef pThis, HandleRef tprop, string str, int dpi, IntPtr bbox);

	/// <summary>
	/// Given a text property and a string, get the bounding box {xmin, xmax,
	/// ymin, ymax} of the rendered string in pixels. The origin of the bounding
	/// box is the anchor point described by the horizontal and vertical
	/// justification text property variables.
	/// Returns true on success, false otherwise.
	/// @sa GetMetrics
	/// </summary>
	public bool GetBoundingBox(vtkTextProperty tprop, string str, int dpi, IntPtr bbox)
	{
		return (vtkFreeTypeTools_GetBoundingBox_05(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), str, dpi, bbox) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFreeTypeTools_GetConstrainedFontSize_06(HandleRef pThis, string str, HandleRef tprop, int dpi, int targetWidth, int targetHeight);

	/// <summary>
	/// This function returns the font size (in points) required to fit the string
	/// in the target rectangle. The font size of tprop is updated to the computed
	/// value as well. If an error occurs, -1 is returned.
	/// </summary>
	public int GetConstrainedFontSize(string str, vtkTextProperty tprop, int dpi, int targetWidth, int targetHeight)
	{
		return vtkFreeTypeTools_GetConstrainedFontSize_06(GetCppThis(), str, tprop?.GetCppThis() ?? default(HandleRef), dpi, targetWidth, targetHeight);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFreeTypeTools_GetDebugTextures_07(HandleRef pThis);

	/// <summary>
	/// If true, images produced by RenderString will have a transparent grey
	/// background and set the justification anchor texel to bright yellow.
	/// </summary>
	public virtual bool GetDebugTextures()
	{
		return (vtkFreeTypeTools_GetDebugTextures_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFreeTypeTools_GetForceCompiledFonts_08(HandleRef pThis);

	/// <summary>
	/// Force use of the fonts compiled into VTK, ignoring any FontConfig or
	/// embedded fonts. Useful for generating test images consistently across
	/// platforms. This flag is on by default.
	/// </summary>
	public virtual bool GetForceCompiledFonts()
	{
		return (vtkFreeTypeTools_GetForceCompiledFonts_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFreeTypeTools_GetInstance_09(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the singleton instance with no reference counting.
	/// </summary>
	public static vtkFreeTypeTools GetInstance()
	{
		vtkFreeTypeTools vtkFreeTypeTools2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFreeTypeTools_GetInstance_09(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFreeTypeTools2 = (vtkFreeTypeTools)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFreeTypeTools2.Register(null);
			}
		}
		return vtkFreeTypeTools2;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfBytes_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfBytes()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfBytes_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfBytesMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfBytesMaxValue()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfBytesMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfBytesMinValue_12(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfBytesMinValue()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfBytesMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfFaces_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfFaces()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfFaces_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfFacesMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfFacesMaxValue()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfFacesMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfFacesMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfFacesMinValue()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfFacesMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfSizes_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfSizes()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfSizes_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfSizesMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfSizesMaxValue()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfSizesMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_GetMaximumNumberOfSizesMinValue_18(HandleRef pThis);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual uint GetMaximumNumberOfSizesMinValue()
	{
		return vtkFreeTypeTools_GetMaximumNumberOfSizesMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFreeTypeTools_GetNumberOfGenerationsFromBase_19(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkFreeTypeTools_GetNumberOfGenerationsFromBase_19(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkFreeTypeTools_GetNumberOfGenerationsFromBaseType_20(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkFreeTypeTools_GetNumberOfGenerationsFromBaseType_20(type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFreeTypeTools_GetScaleToPowerTwo_21(HandleRef pThis);

	/// <summary>
	/// Set whether the image produced should be scaled up to the nearest power of
	/// 2. This is normally required for older graphics cards where all textures
	/// must be a power of 2. This defaults to false, and should be fine on modern
	/// hardware.
	/// </summary>
	public virtual bool GetScaleToPowerTwo()
	{
		return (vtkFreeTypeTools_GetScaleToPowerTwo_21(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkFreeTypeTools_HashBuffer_22(IntPtr buffer, ulong n, uint hash);

	/// <summary>
	/// Hash a buffer of a given length. This function hashes n bytes and does
	/// not depend on a terminating null character.
	/// </summary>
	public static uint HashBuffer(IntPtr buffer, ulong n, uint hash)
	{
		return vtkFreeTypeTools_HashBuffer_22(buffer, n, hash);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkFreeTypeTools_HashString_23(string str);

	/// <summary>
	/// Turn a string into a hash. This is not a general purpose hash
	/// function, and is only used to generate identifiers for cached fonts.
	/// </summary>
	public static ushort HashString(string str)
	{
		return vtkFreeTypeTools_HashString_23(str);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFreeTypeTools_IsA_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkFreeTypeTools_IsA_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkFreeTypeTools_IsTypeOf_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkFreeTypeTools_IsTypeOf_25(type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_MapIdToTextProperty_26(HandleRef pThis, ulong tprop_cache_id, HandleRef tprop);

	/// <summary>
	/// Given a text property 'tprop', get its unique ID in our cache framework.
	/// In the same way, given a unique ID in our cache, retrieve the
	/// corresponding text property and assign its parameters to 'tprop'.
	/// Warning: there is no one to one mapping between a single text property
	/// the corresponding ID, and vice-versa. The ID is just a fast hash, a
	/// binary mask concatenating the attributes of the text property that are
	/// relevant to our cache (Color, Opacity, Justification setting are not
	/// stored).
	/// </summary>
	public void MapIdToTextProperty(ulong tprop_cache_id, vtkTextProperty tprop)
	{
		vtkFreeTypeTools_MapIdToTextProperty_26(GetCppThis(), tprop_cache_id, tprop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_MapTextPropertyToId_27(HandleRef pThis, HandleRef tprop, IntPtr tprop_cache_id);

	/// <summary>
	/// Given a text property 'tprop', get its unique ID in our cache framework.
	/// In the same way, given a unique ID in our cache, retrieve the
	/// corresponding text property and assign its parameters to 'tprop'.
	/// Warning: there is no one to one mapping between a single text property
	/// the corresponding ID, and vice-versa. The ID is just a fast hash, a
	/// binary mask concatenating the attributes of the text property that are
	/// relevant to our cache (Color, Opacity, Justification setting are not
	/// stored).
	/// </summary>
	public void MapTextPropertyToId(vtkTextProperty tprop, IntPtr tprop_cache_id)
	{
		vtkFreeTypeTools_MapTextPropertyToId_27(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), tprop_cache_id);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFreeTypeTools_NewInstance_28(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkFreeTypeTools NewInstance()
	{
		vtkFreeTypeTools result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFreeTypeTools_NewInstance_28(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkFreeTypeTools)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFreeTypeTools_RenderString_29(HandleRef pThis, HandleRef tprop, string str, int dpi, HandleRef data, IntPtr textDims);

	/// <summary>
	/// Given a text property and a string, this function initializes the
	/// vtkImageData *data and renders it in a vtkImageData. textDims, if provided,
	/// will be overwritten by the pixel width and height of the rendered string.
	/// This is useful when ScaleToPowerOfTwo is true, and the image dimensions may
	/// not match the dimensions of the rendered text.
	/// The origin of the image's extents is aligned with the anchor point
	/// described by the text property's vertical and horizontal justification
	/// options.
	/// </summary>
	public bool RenderString(vtkTextProperty tprop, string str, int dpi, vtkImageData data, IntPtr textDims)
	{
		return (vtkFreeTypeTools_RenderString_29(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), str, dpi, data?.GetCppThis() ?? default(HandleRef), textDims) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkFreeTypeTools_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkFreeTypeTools SafeDownCast(vtkObjectBase o)
	{
		vtkFreeTypeTools vtkFreeTypeTools2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkFreeTypeTools_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFreeTypeTools2 = (vtkFreeTypeTools)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFreeTypeTools2.Register(null);
			}
		}
		return vtkFreeTypeTools2;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_ScaleToPowerTwoOff_31(HandleRef pThis);

	/// <summary>
	/// Set whether the image produced should be scaled up to the nearest power of
	/// 2. This is normally required for older graphics cards where all textures
	/// must be a power of 2. This defaults to false, and should be fine on modern
	/// hardware.
	/// </summary>
	public virtual void ScaleToPowerTwoOff()
	{
		vtkFreeTypeTools_ScaleToPowerTwoOff_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_ScaleToPowerTwoOn_32(HandleRef pThis);

	/// <summary>
	/// Set whether the image produced should be scaled up to the nearest power of
	/// 2. This is normally required for older graphics cards where all textures
	/// must be a power of 2. This defaults to false, and should be fine on modern
	/// hardware.
	/// </summary>
	public virtual void ScaleToPowerTwoOn()
	{
		vtkFreeTypeTools_ScaleToPowerTwoOn_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_SetDebugTextures_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, images produced by RenderString will have a transparent grey
	/// background and set the justification anchor texel to bright yellow.
	/// </summary>
	public virtual void SetDebugTextures(bool _arg)
	{
		vtkFreeTypeTools_SetDebugTextures_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_SetForceCompiledFonts_34(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force use of the fonts compiled into VTK, ignoring any FontConfig or
	/// embedded fonts. Useful for generating test images consistently across
	/// platforms. This flag is on by default.
	/// </summary>
	public virtual void SetForceCompiledFonts(bool _arg)
	{
		vtkFreeTypeTools_SetForceCompiledFonts_34(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_SetInstance_35(HandleRef instance);

	/// <summary>
	/// Supply a user defined instance. Call Delete() on the supplied
	/// instance after setting it to fix the reference count.
	/// </summary>
	public static void SetInstance(vtkFreeTypeTools instance)
	{
		vtkFreeTypeTools_SetInstance_35(instance?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_SetMaximumNumberOfBytes_36(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual void SetMaximumNumberOfBytes(uint _arg)
	{
		vtkFreeTypeTools_SetMaximumNumberOfBytes_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_SetMaximumNumberOfFaces_37(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual void SetMaximumNumberOfFaces(uint _arg)
	{
		vtkFreeTypeTools_SetMaximumNumberOfFaces_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_SetMaximumNumberOfSizes_38(HandleRef pThis, uint _arg);

	/// <summary>
	/// Set/Get the maximum number of faces (FT_Face), sizes (FT_Size) and
	/// bytes used by the cache. These settings can be changed as long as
	/// it is done prior to accessing any of the caches or the cache manager.
	/// </summary>
	public virtual void SetMaximumNumberOfSizes(uint _arg)
	{
		vtkFreeTypeTools_SetMaximumNumberOfSizes_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkFreeTypeTools_SetScaleToPowerTwo_39(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set whether the image produced should be scaled up to the nearest power of
	/// 2. This is normally required for older graphics cards where all textures
	/// must be a power of 2. This defaults to false, and should be fine on modern
	/// hardware.
	/// </summary>
	public virtual void SetScaleToPowerTwo(bool _arg)
	{
		vtkFreeTypeTools_SetScaleToPowerTwo_39(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkFreeTypeTools_StringToPath_40(HandleRef pThis, HandleRef tprop, string str, int dpi, HandleRef path);

	/// <summary>
	/// Given a text property and a string, this function populates the vtkPath
	/// path with the outline of the rendered string. The origin of the path
	/// coordinates is aligned with the anchor point described by the text
	/// property's horizontal and vertical justification options.
	/// </summary>
	public bool StringToPath(vtkTextProperty tprop, string str, int dpi, vtkPath path)
	{
		return (vtkFreeTypeTools_StringToPath_40(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), str, dpi, path?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}
}
