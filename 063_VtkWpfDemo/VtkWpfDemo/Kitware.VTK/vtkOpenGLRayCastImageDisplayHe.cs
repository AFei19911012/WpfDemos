using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLRayCastImageDisplayHelper
/// </summary>
/// <remarks>
///    OpenGL subclass that draws the image to the screen
///
/// This is the concrete implementation of a ray cast image display helper -
/// a helper class responsible for drawing the image to the screen.
///
/// </remarks>
/// <seealso>
///
/// vtkRayCastImageDisplayHelper
/// </seealso>
public class vtkOpenGLRayCastImageDisplayHelper : vtkRayCastImageDisplayHelper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLRayCastImageDisplayHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLRayCastImageDisplayHelper()
	{
		MRClassNameKey = "class vtkOpenGLRayCastImageDisplayHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLRayCastImageDisplayHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLRayCastImageDisplayHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRayCastImageDisplayHelper New()
	{
		vtkOpenGLRayCastImageDisplayHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLRayCastImageDisplayHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLRayCastImageDisplayHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkOpenGLRayCastImageDisplayHelper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLRayCastImageDisplayHelper_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLRayCastImageDisplayHelper_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLRayCastImageDisplayHelper_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRayCastImageDisplayHelper_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLRayCastImageDisplayHelper_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLRayCastImageDisplayHelper_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLRayCastImageDisplayHelper_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLRayCastImageDisplayHelper NewInstance()
	{
		vtkOpenGLRayCastImageDisplayHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRayCastImageDisplayHelper_ReleaseGraphicsResources_07(HandleRef pThis, HandleRef win);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow win)
	{
		vtkOpenGLRayCastImageDisplayHelper_ReleaseGraphicsResources_07(GetCppThis(), win?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRayCastImageDisplayHelper_RenderTexture_08(HandleRef pThis, HandleRef vol, HandleRef ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void RenderTexture(vtkVolume vol, vtkRenderer ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image)
	{
		vtkOpenGLRayCastImageDisplayHelper_RenderTexture_08(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef), ren?.GetCppThis() ?? default(HandleRef), imageMemorySize, imageViewportSize, imageInUseSize, imageOrigin, requestedDepth, image);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLRayCastImageDisplayHelper_RenderTexture_09(HandleRef pThis, HandleRef vol, HandleRef ren, HandleRef image, float requestedDepth);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void RenderTexture(vtkVolume vol, vtkRenderer ren, vtkFixedPointRayCastImage image, float requestedDepth)
	{
		vtkOpenGLRayCastImageDisplayHelper_RenderTexture_09(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef), ren?.GetCppThis() ?? default(HandleRef), image?.GetCppThis() ?? default(HandleRef), requestedDepth);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLRayCastImageDisplayHelper_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLRayCastImageDisplayHelper SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLRayCastImageDisplayHelper vtkOpenGLRayCastImageDisplayHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLRayCastImageDisplayHelper_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLRayCastImageDisplayHelper2 = (vtkOpenGLRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLRayCastImageDisplayHelper2.Register(null);
			}
		}
		return vtkOpenGLRayCastImageDisplayHelper2;
	}
}
