using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSimpleMotionBlurPass
/// </summary>
/// <remarks>
///    Avergae frames to simulate motion blur.
///
/// A slow and simple approach that simply renders multiple frames
/// and accumulates them before displaying them. As such it causes the
/// render process to be SubFrames times slower than normal but handles
/// all types of motion correctly as it is actually rendering all the
/// sub frames.
///
/// </remarks>
/// <seealso>
///
/// vtkRenderPass
/// </seealso>
public class vtkSimpleMotionBlurPass : vtkDepthImageProcessingPass
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSimpleMotionBlurPass";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSimpleMotionBlurPass()
	{
		MRClassNameKey = "class vtkSimpleMotionBlurPass";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimpleMotionBlurPass"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSimpleMotionBlurPass(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleMotionBlurPass_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimpleMotionBlurPass New()
	{
		vtkSimpleMotionBlurPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleMotionBlurPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleMotionBlurPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSimpleMotionBlurPass()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSimpleMotionBlurPass_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkSimpleMotionBlurPass_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSimpleMotionBlurPass_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSimpleMotionBlurPass_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSimpleMotionBlurPass_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleMotionBlurPass_GetSubFrames_03(HandleRef pThis);

	/// <summary>
	/// Set the number of sub frames for doing motion blur.
	/// Once this is set greater than one, you will no longer see a new frame
	/// for every Render().  If you set this to five, you will need to do
	/// five Render() invocations before seeing the result. This isn't
	/// very impressive unless something is changing between the Renders.
	/// Changing this value may reset the current subframe count.
	/// </summary>
	public virtual int GetSubFrames()
	{
		return vtkSimpleMotionBlurPass_GetSubFrames_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleMotionBlurPass_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSimpleMotionBlurPass_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSimpleMotionBlurPass_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSimpleMotionBlurPass_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleMotionBlurPass_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSimpleMotionBlurPass NewInstance()
	{
		vtkSimpleMotionBlurPass result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleMotionBlurPass_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSimpleMotionBlurPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleMotionBlurPass_ReleaseGraphicsResources_08(HandleRef pThis, HandleRef w);

	/// <summary>
	/// Release graphics resources and ask components to release their own
	/// resources.
	/// \pre w_exists: w!=0
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow w)
	{
		vtkSimpleMotionBlurPass_ReleaseGraphicsResources_08(GetCppThis(), w?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSimpleMotionBlurPass_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSimpleMotionBlurPass SafeDownCast(vtkObjectBase o)
	{
		vtkSimpleMotionBlurPass vtkSimpleMotionBlurPass2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSimpleMotionBlurPass_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSimpleMotionBlurPass2 = (vtkSimpleMotionBlurPass)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSimpleMotionBlurPass2.Register(null);
			}
		}
		return vtkSimpleMotionBlurPass2;
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleMotionBlurPass_SetColorFormat_10(HandleRef pThis, int _arg);

	/// <summary>
	///  Set the format to use for the color texture
	///  vtkTextureObject::Float16 vtkTextureObject::Float32
	///  and vtkTextureObject::Fixed8 are supported. Fixed8
	///  is the default.
	/// </summary>
	public virtual void SetColorFormat(int _arg)
	{
		vtkSimpleMotionBlurPass_SetColorFormat_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleMotionBlurPass_SetDepthFormat_11(HandleRef pThis, int _arg);

	/// <summary>
	///  Set the format to use for the depth texture
	/// e.g. vtkTextureObject::Float32
	/// </summary>
	public virtual void SetDepthFormat(int _arg)
	{
		vtkSimpleMotionBlurPass_SetDepthFormat_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingOpenGL2.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSimpleMotionBlurPass_SetSubFrames_12(HandleRef pThis, int subFrames);

	/// <summary>
	/// Set the number of sub frames for doing motion blur.
	/// Once this is set greater than one, you will no longer see a new frame
	/// for every Render().  If you set this to five, you will need to do
	/// five Render() invocations before seeing the result. This isn't
	/// very impressive unless something is changing between the Renders.
	/// Changing this value may reset the current subframe count.
	/// </summary>
	public virtual void SetSubFrames(int subFrames)
	{
		vtkSimpleMotionBlurPass_SetSubFrames_12(GetCppThis(), subFrames);
	}
}
