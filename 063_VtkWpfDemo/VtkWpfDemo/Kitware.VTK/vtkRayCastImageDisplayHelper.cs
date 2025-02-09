using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRayCastImageDisplayHelper
/// </summary>
/// <remarks>
///    helper class that draws the image to the screen
///
/// This is a helper class for drawing images created from ray casting on the screen.
/// This is the abstract device-independent superclass.
///
/// </remarks>
/// <seealso>
///
/// vtkUnstructuredGridVolumeRayCastMapper
/// vtkOpenGLRayCastImageDisplayHelper
/// </seealso>
public abstract class vtkRayCastImageDisplayHelper : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRayCastImageDisplayHelper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRayCastImageDisplayHelper()
	{
		MRClassNameKey = "class vtkRayCastImageDisplayHelper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRayCastImageDisplayHelper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRayCastImageDisplayHelper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRayCastImageDisplayHelper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRayCastImageDisplayHelper New()
	{
		vtkRayCastImageDisplayHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRayCastImageDisplayHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRayCastImageDisplayHelper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRayCastImageDisplayHelper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRayCastImageDisplayHelper_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRayCastImageDisplayHelper_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRayCastImageDisplayHelper_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRayCastImageDisplayHelper_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkRayCastImageDisplayHelper_GetPixelScale_03(HandleRef pThis);

	/// <summary>
	/// Set / Get the pixel scale to be applied to the image before display.
	/// Can be set to scale the incoming pixel values - for example the
	/// fixed point mapper uses the unsigned short API but with 15 bit
	/// values so needs a scale of 2.0.
	/// </summary>
	public virtual float GetPixelScale()
	{
		return vtkRayCastImageDisplayHelper_GetPixelScale_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColors_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetPreMultipliedColors()
	{
		return vtkRayCastImageDisplayHelper_GetPreMultipliedColors_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMaxValue_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetPreMultipliedColorsMaxValue()
	{
		return vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMinValue_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetPreMultipliedColorsMinValue()
	{
		return vtkRayCastImageDisplayHelper_GetPreMultipliedColorsMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRayCastImageDisplayHelper_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRayCastImageDisplayHelper_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRayCastImageDisplayHelper_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRayCastImageDisplayHelper_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRayCastImageDisplayHelper_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRayCastImageDisplayHelper NewInstance()
	{
		vtkRayCastImageDisplayHelper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRayCastImageDisplayHelper_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRayCastImageDisplayHelper_PreMultipliedColorsOff_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void PreMultipliedColorsOff()
	{
		vtkRayCastImageDisplayHelper_PreMultipliedColorsOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRayCastImageDisplayHelper_PreMultipliedColorsOn_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void PreMultipliedColorsOn()
	{
		vtkRayCastImageDisplayHelper_PreMultipliedColorsOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRayCastImageDisplayHelper_ReleaseGraphicsResources_13(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Derived class should implement this if needed
	/// </summary>
	public virtual void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkRayCastImageDisplayHelper_ReleaseGraphicsResources_13(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRayCastImageDisplayHelper_RenderTexture_14(HandleRef pThis, HandleRef vol, HandleRef ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void RenderTexture(vtkVolume vol, vtkRenderer ren, IntPtr imageMemorySize, IntPtr imageViewportSize, IntPtr imageInUseSize, IntPtr imageOrigin, float requestedDepth, IntPtr image)
	{
		vtkRayCastImageDisplayHelper_RenderTexture_14(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef), ren?.GetCppThis() ?? default(HandleRef), imageMemorySize, imageViewportSize, imageInUseSize, imageOrigin, requestedDepth, image);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRayCastImageDisplayHelper_RenderTexture_15(HandleRef pThis, HandleRef vol, HandleRef ren, HandleRef image, float requestedDepth);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void RenderTexture(vtkVolume vol, vtkRenderer ren, vtkFixedPointRayCastImage image, float requestedDepth)
	{
		vtkRayCastImageDisplayHelper_RenderTexture_15(GetCppThis(), vol?.GetCppThis() ?? default(HandleRef), ren?.GetCppThis() ?? default(HandleRef), image?.GetCppThis() ?? default(HandleRef), requestedDepth);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRayCastImageDisplayHelper_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRayCastImageDisplayHelper SafeDownCast(vtkObjectBase o)
	{
		vtkRayCastImageDisplayHelper vtkRayCastImageDisplayHelper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRayCastImageDisplayHelper_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRayCastImageDisplayHelper2 = (vtkRayCastImageDisplayHelper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRayCastImageDisplayHelper2.Register(null);
			}
		}
		return vtkRayCastImageDisplayHelper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRayCastImageDisplayHelper_SetPixelScale_17(HandleRef pThis, float _arg);

	/// <summary>
	/// Set / Get the pixel scale to be applied to the image before display.
	/// Can be set to scale the incoming pixel values - for example the
	/// fixed point mapper uses the unsigned short API but with 15 bit
	/// values so needs a scale of 2.0.
	/// </summary>
	public virtual void SetPixelScale(float _arg)
	{
		vtkRayCastImageDisplayHelper_SetPixelScale_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRayCastImageDisplayHelper_SetPreMultipliedColors_18(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetPreMultipliedColors(int _arg)
	{
		vtkRayCastImageDisplayHelper_SetPreMultipliedColors_18(GetCppThis(), _arg);
	}
}
