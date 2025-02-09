using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTextRenderer
/// </summary>
/// <remarks>
///    Interface for generating images and path data from
/// string data, using multiple backends.
///
///
/// vtkTextRenderer produces images, bounding boxes, and vtkPath
/// objects that represent text. The advantage of using this class is to easily
/// integrate mathematical expressions into renderings by automatically switching
/// between FreeType and MathText backends. If the input string contains at least
/// two "$" symbols separated by text, the MathText backend will be used.
/// Alternatively, the presence of unescaped "|" symbols defines multicolumn lines,
/// which are processed with the MathText backend.
///
/// If the string does not meet these criteria, or if no MathText implementation is
/// available, the faster FreeType rendering facilities are used. Literal $
/// symbols can be used by escaping them with backslashes, "\$" (or "\\$" if the
/// string is set programmatically).
///
/// For example, "Acceleration ($\\frac{m}{s^2}$)" will use MathText, but
/// "\\$500, \\$100" will use FreeType.
///
/// By default, the backend is set to Detect, which determines the backend based
/// on the contents of the string. This can be changed by setting the
/// DefaultBackend ivar.
///
/// Note that this class is abstract -- link to the vtkRenderingFreetype module
/// to get the default implementation.
/// </remarks>
public abstract class vtkTextRenderer : vtkObject
{
	/// <summary>
	/// Available backends. FreeType and MathText are provided in the default
	/// implementation of this interface. Enum values less than 16 are reserved.
	/// Custom overrides should define other backends starting at 16.
	/// </summary>
	public enum Backend
	{
		/// <summary>enum member</summary>
		Default = -1,
		/// <summary>enum member</summary>
		Detect = 0,
		/// <summary>enum member</summary>
		FreeType = 1,
		/// <summary>enum member</summary>
		MathText = 2,
		/// <summary>enum member</summary>
		UserBackend = 16
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTextRenderer";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTextRenderer()
	{
		MRClassNameKey = "class vtkTextRenderer";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextRenderer"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTextRenderer(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRenderer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is a singleton pattern New. There will be only ONE reference
	/// to a vtkTextRenderer subclass object per process. Clients that
	/// call this method must use Delete() on the object so that reference
	/// counting will work. The single instance will be unreferenced when
	/// the program exits. You should just use the static GetInstance() method
	/// anyway to get the singleton. This method may return NULL if the object
	/// factory cannot find an override.
	/// </summary>
	public new static vtkTextRenderer New()
	{
		vtkTextRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// This is a singleton pattern New. There will be only ONE reference
	/// to a vtkTextRenderer subclass object per process. Clients that
	/// call this method must use Delete() on the object so that reference
	/// counting will work. The single instance will be unreferenced when
	/// the program exits. You should just use the static GetInstance() method
	/// anyway to get the singleton. This method may return NULL if the object
	/// factory cannot find an override.
	/// </summary>
	public vtkTextRenderer()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTextRenderer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTextRenderer_DetectBackend_01(HandleRef pThis, string str);

	/// <summary>
	/// Determine the appropriate back end needed to render the given string.
	/// </summary>
	public virtual int DetectBackend(string str)
	{
		return vtkTextRenderer_DetectBackend_01(GetCppThis(), str);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTextRenderer_FreeTypeIsSupported_02(HandleRef pThis);

	/// <summary>
	/// Test for availability of various backends
	/// </summary>
	public virtual bool FreeTypeIsSupported()
	{
		return (vtkTextRenderer_FreeTypeIsSupported_02(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTextRenderer_GetBoundingBox_03(HandleRef pThis, HandleRef tprop, string str, IntPtr bbox, int dpi, int backend);

	/// <summary>
	/// Given a text property and a string, get the bounding box {xmin, xmax,
	/// ymin, ymax} of the rendered string in pixels. The origin of the bounding
	/// box is the anchor point described by the horizontal and vertical
	/// justification text property variables.
	/// Return true on success, false otherwise.
	/// </summary>
	public bool GetBoundingBox(vtkTextProperty tprop, string str, IntPtr bbox, int dpi, int backend)
	{
		return (vtkTextRenderer_GetBoundingBox_03(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), str, bbox, dpi, backend) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRenderer_GetConstrainedFontSize_04(HandleRef pThis, string str, HandleRef tprop, int targetWidth, int targetHeight, int dpi, int backend);

	/// <summary>
	/// This function returns the font size (in points) and sets the size in @a
	/// tprop that is required to fit the string in the target rectangle. The
	/// computed font size will be set in @a tprop as well. If an error occurs,
	/// this function will return -1.
	/// </summary>
	public int GetConstrainedFontSize(string str, vtkTextProperty tprop, int targetWidth, int targetHeight, int dpi, int backend)
	{
		return vtkTextRenderer_GetConstrainedFontSize_04(GetCppThis(), str, tprop?.GetCppThis() ?? default(HandleRef), targetWidth, targetHeight, dpi, backend);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRenderer_GetDefaultBackend_05(HandleRef pThis);

	/// <summary>
	/// The backend to use when none is specified. Default: Detect
	/// </summary>
	public virtual int GetDefaultBackend()
	{
		return vtkTextRenderer_GetDefaultBackend_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRenderer_GetInstance_06(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the singleton instance with no reference counting. May return NULL
	/// if the object factory cannot find an override.
	/// </summary>
	public static vtkTextRenderer GetInstance()
	{
		vtkTextRenderer vtkTextRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRenderer_GetInstance_06(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextRenderer2 = (vtkTextRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextRenderer2.Register(null);
			}
		}
		return vtkTextRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextRenderer_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             @}
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTextRenderer_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTextRenderer_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             @}
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTextRenderer_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRenderer_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             @}
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTextRenderer_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTextRenderer_IsTypeOf_10(string type);

	/// <summary>
	///             @}
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTextRenderer_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTextRenderer_MathTextIsSupported_11(HandleRef pThis);

	/// <summary>
	/// Test for availability of various backends
	/// </summary>
	public virtual bool MathTextIsSupported()
	{
		return (vtkTextRenderer_MathTextIsSupported_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRenderer_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             @}
	/// </summary>
	public new vtkTextRenderer NewInstance()
	{
		vtkTextRenderer result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRenderer_NewInstance_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTextRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTextRenderer_RenderString_14(HandleRef pThis, HandleRef tprop, string str, HandleRef data, IntPtr textDims, int dpi, int backend);

	/// <summary>
	/// Given a text property and a string, this function initializes the
	/// vtkImageData *data and renders it in a vtkImageData.
	/// Return true on success, false otherwise. If using the overload that
	/// specifies "textDims", the array will be overwritten with the pixel width
	/// and height defining a tight bounding box around the text in the image,
	/// starting from the upper-right corner. This is used when rendering for a
	/// texture on graphics hardware that requires texture image dimensions to be
	/// a power of two; textDims can be used to determine the texture coordinates
	/// needed to cleanly fit the text on the target.
	/// The origin of the image's extents is aligned with the anchor point
	/// described by the text property's vertical and horizontal justification
	/// options.
	/// </summary>
	public bool RenderString(vtkTextProperty tprop, string str, vtkImageData data, IntPtr textDims, int dpi, int backend)
	{
		return (vtkTextRenderer_RenderString_14(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), str, data?.GetCppThis() ?? default(HandleRef), textDims, dpi, backend) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTextRenderer_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             @}
	/// </summary>
	public new static vtkTextRenderer SafeDownCast(vtkObjectBase o)
	{
		vtkTextRenderer vtkTextRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTextRenderer_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTextRenderer2 = (vtkTextRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTextRenderer2.Register(null);
			}
		}
		return vtkTextRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRenderer_SetDefaultBackend_16(HandleRef pThis, int _arg);

	/// <summary>
	/// The backend to use when none is specified. Default: Detect
	/// </summary>
	public virtual void SetDefaultBackend(int _arg)
	{
		vtkTextRenderer_SetDefaultBackend_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTextRenderer_SetScaleToPowerOfTwo_17(HandleRef pThis, byte scale);

	/// <summary>
	/// Set to true if the graphics implementation requires texture image dimensions
	/// to be a power of two. Default is true, but this member will be set
	/// appropriately by vtkOpenGLRenderWindow::OpenGLInitContext when GL is
	/// inited.
	/// </summary>
	public void SetScaleToPowerOfTwo(bool scale)
	{
		vtkTextRenderer_SetScaleToPowerOfTwo_17(GetCppThis(), (byte)(scale ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTextRenderer_StringToPath_18(HandleRef pThis, HandleRef tprop, string str, HandleRef path, int dpi, int backend);

	/// <summary>
	/// Given a text property and a string, this function populates the vtkPath
	/// path with the outline of the rendered string. The origin of the path
	/// coordinates is aligned with the anchor point described by the text
	/// property's horizontal and vertical justification options.
	/// Return true on success, false otherwise.
	/// </summary>
	public bool StringToPath(vtkTextProperty tprop, string str, vtkPath path, int dpi, int backend)
	{
		return (vtkTextRenderer_StringToPath_18(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), str, path?.GetCppThis() ?? default(HandleRef), dpi, backend) != 0) ? true : false;
	}
}
