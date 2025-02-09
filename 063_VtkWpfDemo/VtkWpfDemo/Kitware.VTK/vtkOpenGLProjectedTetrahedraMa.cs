using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOpenGLProjectedTetrahedraMapper
/// </summary>
/// <remarks>
///    OpenGL implementation of PT
///
/// @bug
/// This mapper relies highly on the implementation of the OpenGL pipeline.
/// A typical hardware driver has lots of options and some settings can
/// cause this mapper to produce artifacts.
///
/// </remarks>
public class vtkOpenGLProjectedTetrahedraMapper : vtkProjectedTetrahedraMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOpenGLProjectedTetrahedraMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOpenGLProjectedTetrahedraMapper()
	{
		MRClassNameKey = "class vtkOpenGLProjectedTetrahedraMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOpenGLProjectedTetrahedraMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOpenGLProjectedTetrahedraMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLProjectedTetrahedraMapper New()
	{
		vtkOpenGLProjectedTetrahedraMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOpenGLProjectedTetrahedraMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOpenGLProjectedTetrahedraMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkOpenGLProjectedTetrahedraMapper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOpenGLProjectedTetrahedraMapper_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOpenGLProjectedTetrahedraMapper_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOpenGLProjectedTetrahedraMapper_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLProjectedTetrahedraMapper_GetUseFloatingPointFrameBuffer_03(HandleRef pThis);

	/// <summary>
	/// Set/get whether to use floating-point rendering buffers rather
	/// than the default.
	/// </summary>
	public virtual bool GetUseFloatingPointFrameBuffer()
	{
		return (vtkOpenGLProjectedTetrahedraMapper_GetUseFloatingPointFrameBuffer_03(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLProjectedTetrahedraMapper_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOpenGLProjectedTetrahedraMapper_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkOpenGLProjectedTetrahedraMapper_IsSupported_05(HandleRef pThis, HandleRef context);

	/// <summary>
	/// Return true if the rendering context provides
	/// the nececessary functionality to use this class.
	/// </summary>
	public override bool IsSupported(vtkRenderWindow context)
	{
		return (vtkOpenGLProjectedTetrahedraMapper_IsSupported_05(GetCppThis(), context?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOpenGLProjectedTetrahedraMapper_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOpenGLProjectedTetrahedraMapper_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOpenGLProjectedTetrahedraMapper NewInstance()
	{
		vtkOpenGLProjectedTetrahedraMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLProjectedTetrahedraMapper_ReleaseGraphicsResources_09(HandleRef pThis, HandleRef window);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow window)
	{
		vtkOpenGLProjectedTetrahedraMapper_ReleaseGraphicsResources_09(GetCppThis(), window?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLProjectedTetrahedraMapper_Render_10(HandleRef pThis, HandleRef renderer, HandleRef volume);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Render(vtkRenderer renderer, vtkVolume volume)
	{
		vtkOpenGLProjectedTetrahedraMapper_Render_10(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef), volume?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOpenGLProjectedTetrahedraMapper_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOpenGLProjectedTetrahedraMapper SafeDownCast(vtkObjectBase o)
	{
		vtkOpenGLProjectedTetrahedraMapper vtkOpenGLProjectedTetrahedraMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOpenGLProjectedTetrahedraMapper_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOpenGLProjectedTetrahedraMapper2 = (vtkOpenGLProjectedTetrahedraMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOpenGLProjectedTetrahedraMapper2.Register(null);
			}
		}
		return vtkOpenGLProjectedTetrahedraMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLProjectedTetrahedraMapper_SetUseFloatingPointFrameBuffer_12(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get whether to use floating-point rendering buffers rather
	/// than the default.
	/// </summary>
	public virtual void SetUseFloatingPointFrameBuffer(bool _arg)
	{
		vtkOpenGLProjectedTetrahedraMapper_SetUseFloatingPointFrameBuffer_12(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLProjectedTetrahedraMapper_UseFloatingPointFrameBufferOff_13(HandleRef pThis);

	/// <summary>
	/// Set/get whether to use floating-point rendering buffers rather
	/// than the default.
	/// </summary>
	public virtual void UseFloatingPointFrameBufferOff()
	{
		vtkOpenGLProjectedTetrahedraMapper_UseFloatingPointFrameBufferOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolumeOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOpenGLProjectedTetrahedraMapper_UseFloatingPointFrameBufferOn_14(HandleRef pThis);

	/// <summary>
	/// Set/get whether to use floating-point rendering buffers rather
	/// than the default.
	/// </summary>
	public virtual void UseFloatingPointFrameBufferOn()
	{
		vtkOpenGLProjectedTetrahedraMapper_UseFloatingPointFrameBufferOn_14(GetCppThis());
	}
}
