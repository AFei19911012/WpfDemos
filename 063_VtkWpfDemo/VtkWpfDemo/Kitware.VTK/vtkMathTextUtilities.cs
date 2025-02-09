using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMathTextUtilities
/// </summary>
/// <remarks>
///    Abstract interface to equation rendering.
///
/// vtkMathTextUtilities defines an interface for equation rendering. Intended
/// for use with the python matplotlib.mathtext module (implemented in the
/// vtkMatplotlib module).
/// </remarks>
public abstract class vtkMathTextUtilities : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMathTextUtilities";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMathTextUtilities()
	{
		MRClassNameKey = "class vtkMathTextUtilities";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMathTextUtilities"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMathTextUtilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMathTextUtilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// This is a singleton pattern New. There will be only ONE reference
	/// to a vtkMathTextUtilities object per process.  Clients that
	/// call this method must use Delete() on the object so that reference
	/// counting will work. The single instance will be unreferenced when
	/// the program exits. You should just use the static GetInstance() method
	/// anyway to get the singleton.
	/// </summary>
	public new static vtkMathTextUtilities New()
	{
		vtkMathTextUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMathTextUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMathTextUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// This is a singleton pattern New. There will be only ONE reference
	/// to a vtkMathTextUtilities object per process.  Clients that
	/// call this method must use Delete() on the object so that reference
	/// counting will work. The single instance will be unreferenced when
	/// the program exits. You should just use the static GetInstance() method
	/// anyway to get the singleton.
	/// </summary>
	public vtkMathTextUtilities()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMathTextUtilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkMathTextUtilities_GetBoundingBox_01(HandleRef pThis, HandleRef tprop, string str, int dpi, IntPtr bbox);

	/// <summary>
	/// Determine the dimensions of the image that RenderString will produce for
	/// a given str, tprop, and dpi
	/// </summary>
	public virtual bool GetBoundingBox(vtkTextProperty tprop, string str, int dpi, IntPtr bbox)
	{
		return (vtkMathTextUtilities_GetBoundingBox_01(GetCppThis(), tprop?.GetCppThis() ?? default(HandleRef), str, dpi, bbox) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMathTextUtilities_GetConstrainedFontSize_02(HandleRef pThis, string str, HandleRef tprop, int targetWidth, int targetHeight, int dpi);

	/// <summary>
	/// This function returns the font size (in points) required to fit the string
	/// in the target rectangle. The font size of tprop is updated to the computed
	/// value as well. If an error occurs (e.g. an improperly formatted MathText
	/// string), -1 is returned.
	/// </summary>
	public virtual int GetConstrainedFontSize(string str, vtkTextProperty tprop, int targetWidth, int targetHeight, int dpi)
	{
		return vtkMathTextUtilities_GetConstrainedFontSize_02(GetCppThis(), str, tprop?.GetCppThis() ?? default(HandleRef), targetWidth, targetHeight, dpi);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMathTextUtilities_GetInstance_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Return the singleton instance with no reference counting.
	/// </summary>
	public static vtkMathTextUtilities GetInstance()
	{
		vtkMathTextUtilities vtkMathTextUtilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMathTextUtilities_GetInstance_03(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMathTextUtilities2 = (vtkMathTextUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMathTextUtilities2.Register(null);
			}
		}
		return vtkMathTextUtilities2;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMathTextUtilities_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMathTextUtilities_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMathTextUtilities_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMathTextUtilities_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMathTextUtilities_GetScaleToPowerOfTwo_06(HandleRef pThis);

	/// <summary>
	/// Set to true if the graphics implementation requires texture image dimensions
	/// to be a power of two. Default is true, but this member will be set
	/// appropriately when GL is inited.
	/// </summary>
	public virtual bool GetScaleToPowerOfTwo()
	{
		return (vtkMathTextUtilities_GetScaleToPowerOfTwo_06(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMathTextUtilities_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMathTextUtilities_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMathTextUtilities_IsAvailable_08(HandleRef pThis);

	/// <summary>
	/// Returns true if mathtext rendering is available.
	/// </summary>
	public virtual bool IsAvailable()
	{
		return (vtkMathTextUtilities_IsAvailable_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMathTextUtilities_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMathTextUtilities_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMathTextUtilities_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMathTextUtilities NewInstance()
	{
		vtkMathTextUtilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMathTextUtilities_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMathTextUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMathTextUtilities_RenderString_12(HandleRef pThis, string str, HandleRef data, HandleRef tprop, int dpi, IntPtr textDims);

	/// <summary>
	/// Render the given string @a str into the vtkImageData @a data with a
	/// resolution of @a dpi. textDims, will be overwritten by the pixel width and
	/// height of the rendered string. This is useful when ScaleToPowerOfTwo is
	/// set to true, and the image dimensions may not match the dimensions of the
	/// rendered text.
	/// </summary>
	public virtual bool RenderString(string str, vtkImageData data, vtkTextProperty tprop, int dpi, IntPtr textDims)
	{
		return (vtkMathTextUtilities_RenderString_12(GetCppThis(), str, data?.GetCppThis() ?? default(HandleRef), tprop?.GetCppThis() ?? default(HandleRef), dpi, textDims) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMathTextUtilities_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMathTextUtilities SafeDownCast(vtkObjectBase o)
	{
		vtkMathTextUtilities vtkMathTextUtilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMathTextUtilities_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMathTextUtilities2 = (vtkMathTextUtilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMathTextUtilities2.Register(null);
			}
		}
		return vtkMathTextUtilities2;
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMathTextUtilities_SetInstance_14(HandleRef instance);

	/// <summary>
	/// Supply a user defined instance. Call Delete() on the supplied
	/// instance after setting it to fix the reference count.
	/// </summary>
	public static void SetInstance(vtkMathTextUtilities instance)
	{
		vtkMathTextUtilities_SetInstance_14(instance?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMathTextUtilities_SetScaleToPowerOfTwo_15(HandleRef pThis, byte scale);

	/// <summary>
	/// Set to true if the graphics implementation requires texture image dimensions
	/// to be a power of two. Default is true, but this member will be set
	/// appropriately when GL is inited.
	/// </summary>
	public virtual void SetScaleToPowerOfTwo(bool scale)
	{
		vtkMathTextUtilities_SetScaleToPowerOfTwo_15(GetCppThis(), (byte)(scale ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingFreeType.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkMathTextUtilities_StringToPath_16(HandleRef pThis, string str, HandleRef path, HandleRef tprop, int dpi);

	/// <summary>
	/// Parse the MathText expression in str and fill path with a contour of the
	/// glyphs.
	/// </summary>
	public virtual bool StringToPath(string str, vtkPath path, vtkTextProperty tprop, int dpi)
	{
		return (vtkMathTextUtilities_StringToPath_16(GetCppThis(), str, path?.GetCppThis() ?? default(HandleRef), tprop?.GetCppThis() ?? default(HandleRef), dpi) != 0) ? true : false;
	}
}
