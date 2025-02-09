using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextRendererStringToImage
/// </summary>
/// <remarks>
///    uses vtkTextRenderer to render the
/// supplied text to an image.
/// </remarks>
public class vtkTextRendererStringToImage : vtkStringToImage
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextRendererStringToImage";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextRendererStringToImage()
	{
		MRClassNameKey = "class vtkTextRendererStringToImage";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextRendererStringToImage"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextRendererStringToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRendererStringToImage_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextRendererStringToImage New()
	{
		vtkTextRendererStringToImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRendererStringToImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextRendererStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTextRendererStringToImage()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextRendererStringToImage_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRendererStringToImage_DeepCopy_01(HandleRef pThis, HandleRef utility);

	/// <summary>
	/// Make a deep copy of the supplied utility class.
	/// </summary>
	public void DeepCopy(vtkTextRendererStringToImage utility)
	{
		vtkTextRendererStringToImage_DeepCopy_01(GetCppThis(), utility?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRendererStringToImage_GetBounds_02(HandleRef pThis, HandleRef property, string arg1, int dpi, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Given a text property and a string, get the bounding box [xmin, xmax] x
	/// [ymin, ymax]. Note that this is the bounding box of the area
	/// where actual pixels will be written, given a text/pen/baseline location
	/// of (0,0).
	/// For example, if the string starts with a 'space', or depending on the
	/// orientation, you can end up with a [-20, -10] x [5, 10] bbox (the math
	/// to get the real bbox is straightforward).
	/// Return 1 on success, 0 otherwise.
	/// You can use IsBoundingBoxValid() to test if the computed bbox
	/// is valid (it may not if GetBoundingBox() failed or if the string
	/// was empty).
	/// </summary>
	public override vtkVector2i GetBounds(vtkTextProperty property, string arg1, int dpi)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRendererStringToImage_GetBounds_02(GetCppThis(), property?.GetCppThis() ?? default(HandleRef), arg1, dpi, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextRendererStringToImage_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextRendererStringToImage_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextRendererStringToImage_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextRendererStringToImage_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRendererStringToImage_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextRendererStringToImage_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRendererStringToImage_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextRendererStringToImage_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRendererStringToImage_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTextRendererStringToImage NewInstance()
	{
		vtkTextRendererStringToImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRendererStringToImage_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextRendererStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRendererStringToImage_RenderString_09(HandleRef pThis, HandleRef property, string arg1, int dpi, HandleRef data, IntPtr textDims);

	/// <summary>
	/// Given a text property and a string, this function initializes the
	/// vtkImageData *data and renders it in a vtkImageData. textDims, if provided,
	/// will be overwritten by the pixel width and height of the rendered string.
	/// This is useful when ScaleToPowerOfTwo is true, and the image dimensions may
	/// not match the dimensions of the rendered text.
	/// </summary>
	public override int RenderString(vtkTextProperty property, string arg1, int dpi, vtkImageData data, IntPtr textDims)
	{
		return vtkTextRendererStringToImage_RenderString_09(GetCppThis(), property?.GetCppThis() ?? default(HandleRef), arg1, dpi, data?.GetCppThis() ?? default(HandleRef), textDims);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRendererStringToImage_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTextRendererStringToImage SafeDownCast(vtkObjectBase o)
	{
		vtkTextRendererStringToImage vtkTextRendererStringToImage2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRendererStringToImage_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextRendererStringToImage2 = (vtkTextRendererStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextRendererStringToImage2.Register(null);
			}
		}
		return vtkTextRendererStringToImage2;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRendererStringToImage_SetScaleToPowerOfTwo_11(HandleRef pThis, byte scale);

	/// <summary>
	/// Should we produce images at powers of 2, makes rendering on old OpenGL
	/// hardware easier. Default is false.
	/// </summary>
	public override void SetScaleToPowerOfTwo(bool scale)
	{
		vtkTextRendererStringToImage_SetScaleToPowerOfTwo_11(GetCppThis(), (byte)(scale ? 1u : 0u));
	}
}
