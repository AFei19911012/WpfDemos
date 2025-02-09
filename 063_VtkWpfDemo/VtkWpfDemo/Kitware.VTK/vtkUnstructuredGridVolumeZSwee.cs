using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkUnstructuredGridVolumeZSweepMapper
/// </summary>
/// <remarks>
///    Unstructured grid volume mapper based the ZSweep Algorithm
///
///
/// This is a volume mapper for unstructured grid implemented with the ZSweep
/// algorithm. This is a software projective method.
///
/// </remarks>
/// <seealso>
///
/// vtkVolumetMapper
///
/// @par Background:
/// The algorithm is described in the following paper:
/// Ricardo Farias, Joseph S. B. Mitchell and Claudio T. Silva.
/// ZSWEEP: An Efficient and Exact Projection Algorithm for Unstructured Volume
/// Rendering. In 2000 Volume Visualization Symposium, pages 91--99.
/// October 2000.
/// http://www.cse.ogi.edu/~csilva/papers/volvis2000.pdf
/// </seealso>
public class vtkUnstructuredGridVolumeZSweepMapper : vtkUnstructuredGridVolumeMapper
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkUnstructuredGridVolumeZSweepMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkUnstructuredGridVolumeZSweepMapper()
	{
		MRClassNameKey = "class vtkUnstructuredGridVolumeZSweepMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkUnstructuredGridVolumeZSweepMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkUnstructuredGridVolumeZSweepMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set MaxPixelListSize to 32.
	/// </summary>
	public new static vtkUnstructuredGridVolumeZSweepMapper New()
	{
		vtkUnstructuredGridVolumeZSweepMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Set MaxPixelListSize to 32.
	/// </summary>
	public vtkUnstructuredGridVolumeZSweepMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkUnstructuredGridVolumeZSweepMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOff_01(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOff()
	{
		vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOn_02(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void AutoAdjustSampleDistancesOn()
	{
		vtkUnstructuredGridVolumeZSweepMapper_AutoAdjustSampleDistancesOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistances_03(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistances()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistances_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMaxValue_04(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMaxValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMinValue_05(HandleRef pThis);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual int GetAutoAdjustSampleDistancesMinValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetAutoAdjustSampleDistancesMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_06(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public virtual int[] GetImageInUseSize()
	{
		IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_07(HandleRef pThis, IntPtr data);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public virtual void GetImageInUseSize(IntPtr data)
	{
		vtkUnstructuredGridVolumeZSweepMapper_GetImageInUseSize_07(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_08(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public virtual int[] GetImageOrigin()
	{
		IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public virtual void GetImageOrigin(IntPtr data)
	{
		vtkUnstructuredGridVolumeZSweepMapper_GetImageOrigin_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistance_10(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
	/// </summary>
	public virtual float GetImageSampleDistance()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistance_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
	/// </summary>
	public virtual float GetImageSampleDistanceMaxValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMinValue_12(HandleRef pThis);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
	/// </summary>
	public virtual float GetImageSampleDistanceMinValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetImageSampleDistanceMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_13(HandleRef pThis);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public virtual int[] GetImageViewportSize()
	{
		IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_13(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public virtual void GetImageViewportSize(IntPtr data)
	{
		vtkUnstructuredGridVolumeZSweepMapper_GetImageViewportSize_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometry_15(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometry()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometry_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMaxValue_16(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometryMaxValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMaxValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMinValue_17(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual int GetIntermixIntersectingGeometryMinValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetIntermixIntersectingGeometryMinValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_GetMaxPixelListSize_18(HandleRef pThis);

	/// <summary>
	/// Maximum size allowed for a pixel list. Default is 32.
	/// During the rendering, if a list of pixel is full, incremental compositing
	/// is performed. Even if it is a user setting, it is an advanced parameter.
	/// You have to understand how the algorithm works to change this value.
	/// </summary>
	public int GetMaxPixelListSize()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetMaxPixelListSize_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistance_19(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMaximumImageSampleDistance()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistance_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMaxValue_20(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMaximumImageSampleDistanceMaxValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMaxValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMinValue_21(HandleRef pThis);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMaximumImageSampleDistanceMinValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetMaximumImageSampleDistanceMinValue_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistance_22(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMinimumImageSampleDistance()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistance_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMaxValue_23(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMinimumImageSampleDistanceMaxValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern float vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMinValue_24(HandleRef pThis);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual float GetMinimumImageSampleDistanceMinValue()
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetMinimumImageSampleDistanceMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeZSweepMapper_GetNumberOfGenerationsFromBase_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetNumberOfGenerationsFromBase_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkUnstructuredGridVolumeZSweepMapper_GetNumberOfGenerationsFromBaseType_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkUnstructuredGridVolumeZSweepMapper_GetNumberOfGenerationsFromBaseType_26(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_GetRayIntegrator_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the helper class for integrating rays.  If set to NULL, a
	/// default integrator will be assigned.
	/// </summary>
	public virtual vtkUnstructuredGridVolumeRayIntegrator GetRayIntegrator()
	{
		vtkUnstructuredGridVolumeRayIntegrator vtkUnstructuredGridVolumeRayIntegrator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper_GetRayIntegrator_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeRayIntegrator2 = (vtkUnstructuredGridVolumeRayIntegrator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeRayIntegrator2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeRayIntegrator2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOff_28(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void IntermixIntersectingGeometryOff()
	{
		vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOff_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOn_29(HandleRef pThis);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void IntermixIntersectingGeometryOn()
	{
		vtkUnstructuredGridVolumeZSweepMapper_IntermixIntersectingGeometryOn_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_IsA_30(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkUnstructuredGridVolumeZSweepMapper_IsA_30(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkUnstructuredGridVolumeZSweepMapper_IsTypeOf_31(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkUnstructuredGridVolumeZSweepMapper_IsTypeOf_31(type);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_NewInstance_33(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkUnstructuredGridVolumeZSweepMapper NewInstance()
	{
		vtkUnstructuredGridVolumeZSweepMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper_NewInstance_33(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_Render_34(HandleRef pThis, HandleRef ren, HandleRef vol);

	/// <summary>
	/// WARNING: INTERNAL METHOD - NOT INTENDED FOR GENERAL USE
	/// DO NOT USE THIS METHOD OUTSIDE OF THE RENDERING PROCESS
	/// Render the volume
	/// </summary>
	public override void Render(vtkRenderer ren, vtkVolume vol)
	{
		vtkUnstructuredGridVolumeZSweepMapper_Render_34(GetCppThis(), ren?.GetCppThis() ?? default(HandleRef), vol?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkUnstructuredGridVolumeZSweepMapper_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkUnstructuredGridVolumeZSweepMapper SafeDownCast(vtkObjectBase o)
	{
		vtkUnstructuredGridVolumeZSweepMapper vtkUnstructuredGridVolumeZSweepMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkUnstructuredGridVolumeZSweepMapper_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnstructuredGridVolumeZSweepMapper2 = (vtkUnstructuredGridVolumeZSweepMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnstructuredGridVolumeZSweepMapper2.Register(null);
			}
		}
		return vtkUnstructuredGridVolumeZSweepMapper2;
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetAutoAdjustSampleDistances_36(HandleRef pThis, int _arg);

	/// <summary>
	/// If AutoAdjustSampleDistances is on, the ImageSampleDistance
	/// will be varied to achieve the allocated render time of this
	/// prop (controlled by the desired update rate and any culling in
	/// use).
	/// </summary>
	public virtual void SetAutoAdjustSampleDistances(int _arg)
	{
		vtkUnstructuredGridVolumeZSweepMapper_SetAutoAdjustSampleDistances_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetImageSampleDistance_37(HandleRef pThis, float _arg);

	/// <summary>
	/// Sampling distance in the XY image dimensions. Default value of 1 meaning
	/// 1 ray cast per pixel. If set to 0.5, 4 rays will be cast per pixel. If
	/// set to 2.0, 1 ray will be cast for every 4 (2 by 2) pixels.
	/// </summary>
	public virtual void SetImageSampleDistance(float _arg)
	{
		vtkUnstructuredGridVolumeZSweepMapper_SetImageSampleDistance_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetIntermixIntersectingGeometry_38(HandleRef pThis, int _arg);

	/// <summary>
	/// If IntermixIntersectingGeometry is turned on, the zbuffer will be
	/// captured and used to limit the traversal of the rays.
	/// </summary>
	public virtual void SetIntermixIntersectingGeometry(int _arg)
	{
		vtkUnstructuredGridVolumeZSweepMapper_SetIntermixIntersectingGeometry_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMaxPixelListSize_39(HandleRef pThis, int size);

	/// <summary>
	/// Change the maximum size allowed for a pixel list. It is an advanced
	/// parameter.
	/// \pre positive_size: size&gt;1
	/// </summary>
	public void SetMaxPixelListSize(int size)
	{
		vtkUnstructuredGridVolumeZSweepMapper_SetMaxPixelListSize_39(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMaximumImageSampleDistance_40(HandleRef pThis, float _arg);

	/// <summary>
	/// This is the maximum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual void SetMaximumImageSampleDistance(float _arg)
	{
		vtkUnstructuredGridVolumeZSweepMapper_SetMaximumImageSampleDistance_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetMinimumImageSampleDistance_41(HandleRef pThis, float _arg);

	/// <summary>
	/// This is the minimum image sample distance allow when the image
	/// sample distance is being automatically adjusted
	/// </summary>
	public virtual void SetMinimumImageSampleDistance(float _arg)
	{
		vtkUnstructuredGridVolumeZSweepMapper_SetMinimumImageSampleDistance_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingVolume.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkUnstructuredGridVolumeZSweepMapper_SetRayIntegrator_42(HandleRef pThis, HandleRef ri);

	/// <summary>
	/// Set/Get the helper class for integrating rays.  If set to NULL, a
	/// default integrator will be assigned.
	/// </summary>
	public virtual void SetRayIntegrator(vtkUnstructuredGridVolumeRayIntegrator ri)
	{
		vtkUnstructuredGridVolumeZSweepMapper_SetRayIntegrator_42(GetCppThis(), ri?.GetCppThis() ?? default(HandleRef));
	}
}
