using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkValuePass
///
/// Renders geometry using the values of a field array as fragment colors. The
/// output can be used for deferred color mapping. It supports using arrays of
/// either point or cell data. The target array can be selected by setting an
/// array name/id and a component number. Only opaque geometry is supported.
///
/// There are two rendering modes available:
///
/// * INVERTIBLE_LUT  Encodes array values as RGB data and renders the result to
/// the default framebuffer.  It uses a texture as a color LUT to map the values
/// to RGB data. Texture size constraints limit its precision (currently 12-bit).
/// The implementation of this mode is in vtkInternalsInvertible. This option
/// is deprecated now that the SGI patent on floating point textures has
/// expired and Mesa and other OpenGL's always supports it.
///
/// * FLOATING_POINT  Renders actual array values as floating point data to an
/// internal RGBA32F framebuffer.  This class binds and unbinds the framebuffer
/// on each render pass. Resources are allocated on demand. When rendering point
/// data values are uploaded to the GPU as vertex attributes. When rendering cell
/// data values are uploaded as a texture buffer. Custom vertex and fragment
/// shaders are defined in order to adjust its behavior for either type of data.
///
/// </summary>
/// <seealso>
///
/// vtkRenderPass vtkOpenGLRenderPass
/// </seealso>
public class vtkValuePass : vtkOpenGLRenderPass
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum Mode
	{
		/// <summary>enum member</summary>
		FLOATING_POINT = 2,
		/// <summary>enum member</summary>
		INVERTIBLE_LUT = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkValuePass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkValuePass()
	{
		MRClassNameKey = "class vtkValuePass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkValuePass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkValuePass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkValuePass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkValuePass New()
	{
		vtkValuePass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkValuePass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkValuePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkValuePass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkValuePass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkValuePass_GetFloatImageData_01(HandleRef pThis, int format, int width, int height, IntPtr data);

	/// <summary>
	/// Interface to get the rendered image in FLOATING_POINT mode.  Low level API,
	/// a format for the internal glReadPixels call can be specified. 'data' is expected
	/// to be allocated and cleaned-up by the caller.
	/// </summary>
	public void GetFloatImageData(int format, int width, int height, IntPtr data)
	{
		vtkValuePass_GetFloatImageData_01(GetCppThis(), format, width, height, data);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkValuePass_GetFloatImageDataArray_02(HandleRef pThis, HandleRef ren, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Interface to get the rendered image in FLOATING_POINT mode.  Returns a
	/// single component array containing the rendered values.
	/// \warning The returned array is owned by this class.
	/// </summary>
	public vtkFloatArray GetFloatImageDataArray(vtkRenderer ren)
	{
		vtkFloatArray vtkFloatArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkValuePass_GetFloatImageDataArray_02(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFloatArray2 = (vtkFloatArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFloatArray2.Register(null);
			}
		}
		return vtkFloatArray2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkValuePass_GetFloatImageExtents_03(HandleRef pThis);

	/// <summary>
	/// Interface to get the rendered image in FLOATING_POINT mode.  Image extents of
	/// the value array.
	/// </summary>
	public IntPtr GetFloatImageExtents()
	{
		return vtkValuePass_GetFloatImageExtents_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkValuePass_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkValuePass_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkValuePass_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkValuePass_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkValuePass_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkValuePass_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkValuePass_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkValuePass_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkValuePass_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkValuePass NewInstance()
	{
		vtkValuePass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkValuePass_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkValuePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkValuePass_ReleaseGraphicsResources_10(HandleRef pThis, HandleRef win);

	/// <summary>
	/// Interface to get the rendered image in FLOATING_POINT mode.  Image extents of
	/// the value array.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkValuePass_ReleaseGraphicsResources_10(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkValuePass_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkValuePass SafeDownCast(vtkObjectBase o)
	{
		vtkValuePass vtkValuePass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkValuePass_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkValuePass2 = (vtkValuePass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkValuePass2.Register(null);
			}
		}
		return vtkValuePass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkValuePass_SetInputArrayToProcess_12(HandleRef pThis, int fieldAssociation, string name);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInputArrayToProcess(int fieldAssociation, string name)
	{
		vtkValuePass_SetInputArrayToProcess_12(GetCppThis(), fieldAssociation, name);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkValuePass_SetInputArrayToProcess_13(HandleRef pThis, int fieldAssociation, int fieldId);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInputArrayToProcess(int fieldAssociation, int fieldId)
	{
		vtkValuePass_SetInputArrayToProcess_13(GetCppThis(), fieldAssociation, fieldId);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkValuePass_SetInputComponentToProcess_14(HandleRef pThis, int component);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInputComponentToProcess(int component)
	{
		vtkValuePass_SetInputComponentToProcess_14(GetCppThis(), component);
	}
}
