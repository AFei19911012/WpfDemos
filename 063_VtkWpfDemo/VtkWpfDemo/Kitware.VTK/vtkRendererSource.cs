using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkRendererSource
/// </summary>
/// <remarks>
///    take a renderer's image and/or depth map into the pipeline
///
///
/// vtkRendererSource is a source object whose input is a renderer's image
/// and/or depth map, which is then used to produce an output image. This
/// output can then be used in the visualization pipeline. You must explicitly
/// send a Modify() to this object to get it to reload its data from the
/// renderer. Consider also using vtkWindowToImageFilter instead of this
/// class.
///
/// By default, the data placed into the output is the renderer's image RGB
/// values (these color scalars are represented by unsigned chars, one per
/// color channel). Optionally, you can also grab the image depth (e.g.,
/// z-buffer) values, and include it in the output in one of three ways. 1)
/// First, when the data member DepthValues is enabled, a separate float array
/// of these depth values is included in the output point data with array name
/// "ZBuffer". 2) If DepthValuesInScalars is enabled, then the z-buffer values
/// are shifted and scaled to fit into an unsigned char and included in the
/// output image (so the output image pixels are four components RGBZ). Note
/// that DepthValues and and DepthValuesInScalars can be enabled
/// simultaneously if desired. Finally 3) if DepthValuesOnly is enabled, then
/// the output image consists only of the z-buffer values represented by a
/// single component float array; and the data members DepthValues and
/// DepthValuesInScalars are ignored.
///
/// </remarks>
/// <seealso>
///
/// vtkWindowToImageFilter vtkRendererPointCloudSource vtkRenderer
/// vtkImageData vtkDepthImageToPointCloud
/// </seealso>
public class vtkRendererSource : vtkAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkRendererSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkRendererSource()
	{
		MRClassNameKey = "class vtkRendererSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkRendererSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkRendererSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRendererSource New()
	{
		vtkRendererSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkRendererSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkRendererSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkRendererSource_DepthValuesInScalarsOff_01(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab z-buffer
	/// (i.e., depth values) along with the image data. The z-buffer data
	/// is placed in the scalars as a fourth Z component (shift and scaled
	/// to map the full 0..255 range).
	/// </summary>
	public virtual void DepthValuesInScalarsOff()
	{
		vtkRendererSource_DepthValuesInScalarsOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_DepthValuesInScalarsOn_02(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab z-buffer
	/// (i.e., depth values) along with the image data. The z-buffer data
	/// is placed in the scalars as a fourth Z component (shift and scaled
	/// to map the full 0..255 range).
	/// </summary>
	public virtual void DepthValuesInScalarsOn()
	{
		vtkRendererSource_DepthValuesInScalarsOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_DepthValuesOff_03(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab z-buffer
	/// (i.e., depth values) along with the image data. The z-buffer data
	/// is placed into a field data attributes named "ZBuffer" .
	/// </summary>
	public virtual void DepthValuesOff()
	{
		vtkRendererSource_DepthValuesOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_DepthValuesOn_04(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab z-buffer
	/// (i.e., depth values) along with the image data. The z-buffer data
	/// is placed into a field data attributes named "ZBuffer" .
	/// </summary>
	public virtual void DepthValuesOn()
	{
		vtkRendererSource_DepthValuesOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_DepthValuesOnlyOff_05(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab only the z-buffer (i.e.,
	/// depth values) without the associated image (color scalars) data. If
	/// enabled, the output data contains only a depth image which is the
	/// z-buffer values represented by float values. By default, this is
	/// disabled. Note that if enabled, then the DepthValues and
	/// DepthValuesInScalars are ignored.
	/// </summary>
	public virtual void DepthValuesOnlyOff()
	{
		vtkRendererSource_DepthValuesOnlyOff_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_DepthValuesOnlyOn_06(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab only the z-buffer (i.e.,
	/// depth values) without the associated image (color scalars) data. If
	/// enabled, the output data contains only a depth image which is the
	/// z-buffer values represented by float values. By default, this is
	/// disabled. Note that if enabled, then the DepthValues and
	/// DepthValuesInScalars are ignored.
	/// </summary>
	public virtual void DepthValuesOnlyOn()
	{
		vtkRendererSource_DepthValuesOnlyOn_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererSource_GetDepthValues_07(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab z-buffer
	/// (i.e., depth values) along with the image data. The z-buffer data
	/// is placed into a field data attributes named "ZBuffer" .
	/// </summary>
	public virtual int GetDepthValues()
	{
		return vtkRendererSource_GetDepthValues_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererSource_GetDepthValuesInScalars_08(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab z-buffer
	/// (i.e., depth values) along with the image data. The z-buffer data
	/// is placed in the scalars as a fourth Z component (shift and scaled
	/// to map the full 0..255 range).
	/// </summary>
	public virtual int GetDepthValuesInScalars()
	{
		return vtkRendererSource_GetDepthValuesInScalars_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererSource_GetDepthValuesOnly_09(HandleRef pThis);

	/// <summary>
	/// A boolean value to control whether to grab only the z-buffer (i.e.,
	/// depth values) without the associated image (color scalars) data. If
	/// enabled, the output data contains only a depth image which is the
	/// z-buffer values represented by float values. By default, this is
	/// disabled. Note that if enabled, then the DepthValues and
	/// DepthValuesInScalars are ignored.
	/// </summary>
	public virtual int GetDepthValuesOnly()
	{
		return vtkRendererSource_GetDepthValuesOnly_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererSource_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns which renderer is being used as the source for the pixel data.
	/// </summary>
	public virtual vtkRenderer GetInput()
	{
		vtkRenderer vtkRenderer2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererSource_GetInput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRenderer2 = (vtkRenderer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRenderer2.Register(null);
			}
		}
		return vtkRenderer2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkRendererSource_GetMTime_11(HandleRef pThis);

	/// <summary>
	/// Return the MTime also considering the Renderer.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkRendererSource_GetMTime_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRendererSource_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkRendererSource_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkRendererSource_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkRendererSource_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererSource_GetOutput_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the output data object for a port on this algorithm.
	/// </summary>
	public vtkImageData GetOutput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererSource_GetOutput_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererSource_GetRenderFlag_15(HandleRef pThis);

	/// <summary>
	/// If this flag is on, then filter execution causes a render first.
	/// </summary>
	public virtual int GetRenderFlag()
	{
		return vtkRendererSource_GetRenderFlag_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererSource_GetWholeWindow_16(HandleRef pThis);

	/// <summary>
	/// Use the entire RenderWindow as a data source or just the Renderer.
	/// The default is zero, just the Renderer.
	/// </summary>
	public virtual int GetWholeWindow()
	{
		return vtkRendererSource_GetWholeWindow_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererSource_IsA_17(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkRendererSource_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkRendererSource_IsTypeOf_18(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkRendererSource_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererSource_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkRendererSource NewInstance()
	{
		vtkRendererSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererSource_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_RenderFlagOff_21(HandleRef pThis);

	/// <summary>
	/// If this flag is on, then filter execution causes a render first.
	/// </summary>
	public virtual void RenderFlagOff()
	{
		vtkRendererSource_RenderFlagOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_RenderFlagOn_22(HandleRef pThis);

	/// <summary>
	/// If this flag is on, then filter execution causes a render first.
	/// </summary>
	public virtual void RenderFlagOn()
	{
		vtkRendererSource_RenderFlagOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkRendererSource_SafeDownCast_23(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkRendererSource SafeDownCast(vtkObjectBase o)
	{
		vtkRendererSource vtkRendererSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkRendererSource_SafeDownCast_23(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkRendererSource2 = (vtkRendererSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkRendererSource2.Register(null);
			}
		}
		return vtkRendererSource2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_SetDepthValues_24(HandleRef pThis, int _arg);

	/// <summary>
	/// A boolean value to control whether to grab z-buffer
	/// (i.e., depth values) along with the image data. The z-buffer data
	/// is placed into a field data attributes named "ZBuffer" .
	/// </summary>
	public virtual void SetDepthValues(int _arg)
	{
		vtkRendererSource_SetDepthValues_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_SetDepthValuesInScalars_25(HandleRef pThis, int _arg);

	/// <summary>
	/// A boolean value to control whether to grab z-buffer
	/// (i.e., depth values) along with the image data. The z-buffer data
	/// is placed in the scalars as a fourth Z component (shift and scaled
	/// to map the full 0..255 range).
	/// </summary>
	public virtual void SetDepthValuesInScalars(int _arg)
	{
		vtkRendererSource_SetDepthValuesInScalars_25(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_SetDepthValuesOnly_26(HandleRef pThis, int _arg);

	/// <summary>
	/// A boolean value to control whether to grab only the z-buffer (i.e.,
	/// depth values) without the associated image (color scalars) data. If
	/// enabled, the output data contains only a depth image which is the
	/// z-buffer values represented by float values. By default, this is
	/// disabled. Note that if enabled, then the DepthValues and
	/// DepthValuesInScalars are ignored.
	/// </summary>
	public virtual void SetDepthValuesOnly(int _arg)
	{
		vtkRendererSource_SetDepthValuesOnly_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_SetInput_27(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Indicates what renderer to get the pixel data from.
	/// </summary>
	public void SetInput(vtkRenderer arg0)
	{
		vtkRendererSource_SetInput_27(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_SetRenderFlag_28(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is on, then filter execution causes a render first.
	/// </summary>
	public virtual void SetRenderFlag(int _arg)
	{
		vtkRendererSource_SetRenderFlag_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_SetWholeWindow_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Use the entire RenderWindow as a data source or just the Renderer.
	/// The default is zero, just the Renderer.
	/// </summary>
	public virtual void SetWholeWindow(int _arg)
	{
		vtkRendererSource_SetWholeWindow_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_WholeWindowOff_30(HandleRef pThis);

	/// <summary>
	/// Use the entire RenderWindow as a data source or just the Renderer.
	/// The default is zero, just the Renderer.
	/// </summary>
	public virtual void WholeWindowOff()
	{
		vtkRendererSource_WholeWindowOff_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkRendererSource_WholeWindowOn_31(HandleRef pThis);

	/// <summary>
	/// Use the entire RenderWindow as a data source or just the Renderer.
	/// The default is zero, just the Renderer.
	/// </summary>
	public virtual void WholeWindowOn()
	{
		vtkRendererSource_WholeWindowOn_31(GetCppThis());
	}
}
