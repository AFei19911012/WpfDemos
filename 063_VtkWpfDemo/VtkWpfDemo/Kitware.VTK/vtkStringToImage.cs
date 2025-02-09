using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkStringToImage
/// </summary>
/// <remarks>
///    base class for classes that render supplied text
/// to an image.
///
///
///
/// </remarks>
public abstract class vtkStringToImage : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkStringToImage";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkStringToImage()
	{
		MRClassNameKey = "class vtkStringToImage";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToImage"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkStringToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringToImage_GetBounds_01(HandleRef pThis, HandleRef property, string arg1, int dpi, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

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
	public virtual vtkVector2i GetBounds(vtkTextProperty property, string arg1, int dpi)
	{
		vtkVector2i result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringToImage_GetBounds_01(GetCppThis(), property?.GetCppThis() ?? default(HandleRef), arg1, dpi, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVector2i)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringToImage_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkStringToImage_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkStringToImage_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkStringToImage_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkStringToImage_GetScaleToPowerOfTwo_04(HandleRef pThis);

	/// <summary>
	/// Should we produce images at powers of 2, makes rendering on old OpenGL
	/// hardware easier. Default is false.
	/// </summary>
	public virtual bool GetScaleToPowerOfTwo()
	{
		return (vtkStringToImage_GetScaleToPowerOfTwo_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringToImage_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkStringToImage_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringToImage_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkStringToImage_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringToImage_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkStringToImage NewInstance()
	{
		vtkStringToImage result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringToImage_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkStringToImage_RenderString_08(HandleRef pThis, HandleRef property, string arg1, int dpi, HandleRef data, IntPtr text_dims);

	/// <summary>
	/// Given a text property and a string, this function initializes the
	/// vtkImageData *data and renders it in a vtkImageData. textDims, if provided,
	/// will be overwritten by the pixel width and height of the rendered string.
	/// This is useful when ScaleToPowerOfTwo is true, and the image dimensions may
	/// not match the dimensions of the rendered text.
	/// </summary>
	public virtual int RenderString(vtkTextProperty property, string arg1, int dpi, vtkImageData data, IntPtr text_dims)
	{
		return vtkStringToImage_RenderString_08(GetCppThis(), property?.GetCppThis() ?? default(HandleRef), arg1, dpi, data?.GetCppThis() ?? default(HandleRef), text_dims);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkStringToImage_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkStringToImage SafeDownCast(vtkObjectBase o)
	{
		vtkStringToImage vtkStringToImage2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkStringToImage_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringToImage2 = (vtkStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringToImage2.Register(null);
			}
		}
		return vtkStringToImage2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkStringToImage_SetScaleToPowerOfTwo_10(HandleRef pThis, byte scale);

	/// <summary>
	/// Should we produce images at powers of 2, makes rendering on old OpenGL
	/// hardware easier. Default is false.
	/// </summary>
	public virtual void SetScaleToPowerOfTwo(bool scale)
	{
		vtkStringToImage_SetScaleToPowerOfTwo_10(GetCppThis(), (byte)(scale ? 1u : 0u));
	}
}
