using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLContextBufferId
/// </summary>
/// <remarks>
///    2D array of ids stored in VRAM.
///
///
/// An 2D array where each element is the id of an entity drawn at the given
/// pixel.
/// </remarks>
public class vtkOpenGLContextBufferId : vtkAbstractContextBufferId
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLContextBufferId";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLContextBufferId()
	{
		MRClassNameKey = "class vtkOpenGLContextBufferId";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLContextBufferId"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLContextBufferId(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextBufferId_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Creates a 2D Painter object.
	/// </summary>
	public new static vtkOpenGLContextBufferId New()
	{
		vtkOpenGLContextBufferId result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextBufferId_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLContextBufferId)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Creates a 2D Painter object.
	/// </summary>
	public vtkOpenGLContextBufferId()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLContextBufferId_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextBufferId_Allocate_01(HandleRef pThis);

	/// <summary>
	/// Allocate the memory for at least Width*Height elements.
	/// \pre positive_width: GetWidth()&gt;0
	/// \pre positive_height: GetHeight()&gt;0
	/// \pre context_is_set: this-&gt;GetContext()!=0
	/// </summary>
	public override void Allocate()
	{
		vtkOpenGLContextBufferId_Allocate_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextBufferId_GetContext_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the OpenGL context owning the texture object resource.
	/// </summary>
	public override vtkRenderWindow GetContext()
	{
		vtkRenderWindow vtkRenderWindow2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextBufferId_GetContext_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderWindow2 = (vtkRenderWindow)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderWindow2.Register(null);
			}
		}
		return vtkRenderWindow2;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLContextBufferId_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLContextBufferId_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLContextBufferId_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLContextBufferId_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLContextBufferId_GetPickedItem_05(HandleRef pThis, int x, int y);

	/// <summary>
	/// Return item under abscissa x and ordinate y.
	/// Abscissa go from left to right.
	/// Ordinate go from bottom to top.
	/// The return value is -1 if there is no item.
	/// \pre is_allocated: IsAllocated()
	/// \post valid_result: result&gt;=-1
	/// </summary>
	public override long GetPickedItem(int x, int y)
	{
		return vtkOpenGLContextBufferId_GetPickedItem_05(GetCppThis(), x, y);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLContextBufferId_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLContextBufferId_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLContextBufferId_IsAllocated_07(HandleRef pThis);

	/// <summary>
	/// Tell if the buffer has been allocated.
	/// </summary>
	public override bool IsAllocated()
	{
		return (vtkOpenGLContextBufferId_IsAllocated_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLContextBufferId_IsSupported_08(HandleRef pThis);

	/// <summary>
	/// Returns if the context supports the required extensions.
	/// \pre context_is_set: this-&gt;GetContext()!=0
	/// </summary>
	public override bool IsSupported()
	{
		return (vtkOpenGLContextBufferId_IsSupported_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLContextBufferId_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLContextBufferId_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextBufferId_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLContextBufferId NewInstance()
	{
		vtkOpenGLContextBufferId result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextBufferId_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLContextBufferId)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextBufferId_ReleaseGraphicsResources_12(HandleRef pThis);

	/// <summary>
	/// Release any graphics resources that are being consumed by this object.
	/// </summary>
	public override void ReleaseGraphicsResources()
	{
		vtkOpenGLContextBufferId_ReleaseGraphicsResources_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLContextBufferId_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLContextBufferId SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLContextBufferId vtkOpenGLContextBufferId2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLContextBufferId_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLContextBufferId2 = (vtkOpenGLContextBufferId)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLContextBufferId2.Register(null);
			}
		}
		return vtkOpenGLContextBufferId2;
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextBufferId_SetContext_14(HandleRef pThis, HandleRef context);

	/// <summary>
	/// Set/Get the OpenGL context owning the texture object resource.
	/// </summary>
	public override void SetContext(vtkRenderWindow context)
	{
		vtkOpenGLContextBufferId_SetContext_14(GetCppThis(), context?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingContextOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLContextBufferId_SetValues_15(HandleRef pThis, int srcXmin, int srcYmin);

	/// <summary>
	/// Copy the contents of the current read buffer to the internal texture
	/// starting at lower left corner of the framebuffer (srcXmin,srcYmin).
	/// \pre is_allocated: this-&gt;IsAllocated()
	/// </summary>
	public override void SetValues(int srcXmin, int srcYmin)
	{
		vtkOpenGLContextBufferId_SetValues_15(GetCppThis(), srcXmin, srcYmin);
	}
}
