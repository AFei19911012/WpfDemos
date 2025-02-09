using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageResliceMapper
/// </summary>
/// <remarks>
///    map a slice of a vtkImageData to the screen
///
/// vtkImageResliceMapper will cut a 3D image with an arbitrary slice plane
/// and draw the results on the screen.  The slice can be set to automatically
/// follow the camera, so that the camera controls the slicing.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImageSlice vtkImageProperty vtkImageSliceMapper
/// </seealso>
public class vtkImageResliceMapper : vtkImageMapper3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageResliceMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageResliceMapper()
	{
		MRClassNameKey = "class vtkImageResliceMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageResliceMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageResliceMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageResliceMapper New()
	{
		vtkImageResliceMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResliceMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageResliceMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageResliceMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageResliceMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_AutoAdjustImageQualityOff_01(HandleRef pThis);

	/// <summary>
	/// Automatically reduce the rendering quality for greater speed
	/// when doing an interactive render.  This is on by default.
	/// </summary>
	public virtual void AutoAdjustImageQualityOff()
	{
		vtkImageResliceMapper_AutoAdjustImageQualityOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_AutoAdjustImageQualityOn_02(HandleRef pThis);

	/// <summary>
	/// Automatically reduce the rendering quality for greater speed
	/// when doing an interactive render.  This is on by default.
	/// </summary>
	public virtual void AutoAdjustImageQualityOn()
	{
		vtkImageResliceMapper_AutoAdjustImageQualityOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetAutoAdjustImageQuality_03(HandleRef pThis);

	/// <summary>
	/// Automatically reduce the rendering quality for greater speed
	/// when doing an interactive render.  This is on by default.
	/// </summary>
	public virtual int GetAutoAdjustImageQuality()
	{
		return vtkImageResliceMapper_GetAutoAdjustImageQuality_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceMapper_GetBounds_04(HandleRef pThis);

	/// <summary>
	/// The bounding box (array of six doubles) of the data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkImageResliceMapper_GetBounds_04(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_GetBounds_05(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// The bounding box (array of six doubles) of the data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkImageResliceMapper_GetBounds_05(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetImageSampleFactor_06(HandleRef pThis);

	/// <summary>
	/// Set the reslice sample frequency as in relation to the input image
	/// sample frequency.  The default value is 1, but higher values can be
	/// used to improve the results.  This is cheaper than turning on
	/// ResampleToScreenPixels.
	/// </summary>
	public virtual int GetImageSampleFactor()
	{
		return vtkImageResliceMapper_GetImageSampleFactor_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetImageSampleFactorMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set the reslice sample frequency as in relation to the input image
	/// sample frequency.  The default value is 1, but higher values can be
	/// used to improve the results.  This is cheaper than turning on
	/// ResampleToScreenPixels.
	/// </summary>
	public virtual int GetImageSampleFactorMaxValue()
	{
		return vtkImageResliceMapper_GetImageSampleFactorMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetImageSampleFactorMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set the reslice sample frequency as in relation to the input image
	/// sample frequency.  The default value is 1, but higher values can be
	/// used to improve the results.  This is cheaper than turning on
	/// ResampleToScreenPixels.
	/// </summary>
	public virtual int GetImageSampleFactorMinValue()
	{
		return vtkImageResliceMapper_GetImageSampleFactorMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_GetIndexBounds_09(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Handle requests from the pipeline executive.
	/// </summary>
	public override void GetIndexBounds(IntPtr extent)
	{
		vtkImageResliceMapper_GetIndexBounds_09(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceMapper_GetInterpolator_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a custom interpolator.  This will only be used if the
	/// ResampleToScreenPixels option is on.
	/// </summary>
	public virtual vtkAbstractImageInterpolator GetInterpolator()
	{
		vtkAbstractImageInterpolator vtkAbstractImageInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResliceMapper_GetInterpolator_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractImageInterpolator2 = (vtkAbstractImageInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractImageInterpolator2.Register(null);
			}
		}
		return vtkAbstractImageInterpolator2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetJumpToNearestSlice_11(HandleRef pThis);

	/// <summary>
	/// When using SliceAtFocalPoint, this causes the slicing to occur at
	/// the closest slice to the focal point, instead of the default behavior
	/// where a new slice is interpolated between the original slices.  This
	/// flag is ignored if the slicing is oblique to the original slices.
	/// </summary>
	public virtual int GetJumpToNearestSlice()
	{
		return vtkImageResliceMapper_GetJumpToNearestSlice_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageResliceMapper_GetMTime_12(HandleRef pThis);

	/// <summary>
	/// Get the mtime for the mapper.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageResliceMapper_GetMTime_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageResliceMapper_GetNumberOfGenerationsFromBase_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageResliceMapper_GetNumberOfGenerationsFromBase_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageResliceMapper_GetNumberOfGenerationsFromBaseType_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageResliceMapper_GetNumberOfGenerationsFromBaseType_14(type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetResampleToScreenPixels_15(HandleRef pThis);

	/// <summary>
	/// Resample the image directly to the screen pixels, instead of
	/// using a texture to scale the image after resampling.  This is
	/// slower and uses more memory, but provides high-quality results.
	/// It is On by default.
	/// </summary>
	public virtual int GetResampleToScreenPixels()
	{
		return vtkImageResliceMapper_GetResampleToScreenPixels_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetSeparateWindowLevelOperation_16(HandleRef pThis);

	/// <summary>
	/// Keep the color mapping stage distinct from the reslicing stage.
	/// This will improve the quality and possibly the speed of interactive
	/// window/level operations, but it uses more memory and might slow down
	/// interactive slicing operations.  On by default.
	/// </summary>
	public virtual int GetSeparateWindowLevelOperation()
	{
		return vtkImageResliceMapper_GetSeparateWindowLevelOperation_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetSlabSampleFactor_17(HandleRef pThis);

	/// <summary>
	/// Set the number of slab samples to use as a factor of the number
	/// of input slices within the slab thickness.  The default value
	/// is 2, but 1 will increase speed with very little loss of quality.
	/// </summary>
	public virtual int GetSlabSampleFactor()
	{
		return vtkImageResliceMapper_GetSlabSampleFactor_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetSlabSampleFactorMaxValue_18(HandleRef pThis);

	/// <summary>
	/// Set the number of slab samples to use as a factor of the number
	/// of input slices within the slab thickness.  The default value
	/// is 2, but 1 will increase speed with very little loss of quality.
	/// </summary>
	public virtual int GetSlabSampleFactorMaxValue()
	{
		return vtkImageResliceMapper_GetSlabSampleFactorMaxValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetSlabSampleFactorMinValue_19(HandleRef pThis);

	/// <summary>
	/// Set the number of slab samples to use as a factor of the number
	/// of input slices within the slab thickness.  The default value
	/// is 2, but 1 will increase speed with very little loss of quality.
	/// </summary>
	public virtual int GetSlabSampleFactorMinValue()
	{
		return vtkImageResliceMapper_GetSlabSampleFactorMinValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageResliceMapper_GetSlabThickness_20(HandleRef pThis);

	/// <summary>
	/// The slab thickness, for thick slicing (default: zero)
	/// </summary>
	public virtual double GetSlabThickness()
	{
		return vtkImageResliceMapper_GetSlabThickness_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetSlabType_21(HandleRef pThis);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public virtual int GetSlabType()
	{
		return vtkImageResliceMapper_GetSlabType_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceMapper_GetSlabTypeAsString_22(HandleRef pThis);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public virtual string GetSlabTypeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageResliceMapper_GetSlabTypeAsString_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetSlabTypeMaxValue_23(HandleRef pThis);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public virtual int GetSlabTypeMaxValue()
	{
		return vtkImageResliceMapper_GetSlabTypeMaxValue_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_GetSlabTypeMinValue_24(HandleRef pThis);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public virtual int GetSlabTypeMinValue()
	{
		return vtkImageResliceMapper_GetSlabTypeMinValue_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_IsA_25(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageResliceMapper_IsA_25(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageResliceMapper_IsTypeOf_26(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageResliceMapper_IsTypeOf_26(type);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_JumpToNearestSliceOff_27(HandleRef pThis);

	/// <summary>
	/// When using SliceAtFocalPoint, this causes the slicing to occur at
	/// the closest slice to the focal point, instead of the default behavior
	/// where a new slice is interpolated between the original slices.  This
	/// flag is ignored if the slicing is oblique to the original slices.
	/// </summary>
	public virtual void JumpToNearestSliceOff()
	{
		vtkImageResliceMapper_JumpToNearestSliceOff_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_JumpToNearestSliceOn_28(HandleRef pThis);

	/// <summary>
	/// When using SliceAtFocalPoint, this causes the slicing to occur at
	/// the closest slice to the focal point, instead of the default behavior
	/// where a new slice is interpolated between the original slices.  This
	/// flag is ignored if the slicing is oblique to the original slices.
	/// </summary>
	public virtual void JumpToNearestSliceOn()
	{
		vtkImageResliceMapper_JumpToNearestSliceOn_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceMapper_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageResliceMapper NewInstance()
	{
		vtkImageResliceMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResliceMapper_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageResliceMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_ReleaseGraphicsResources_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by
	/// this mapper.  The parameter window is used to determine
	/// which graphic resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkImageResliceMapper_ReleaseGraphicsResources_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_Render_32(HandleRef pThis, HandleRef renderer, HandleRef prop);

	/// <summary>
	/// This should only be called by the renderer.
	/// </summary>
	public override void Render(vtkRenderer renderer, vtkImageSlice prop)
	{
		vtkImageResliceMapper_Render_32(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_ResampleToScreenPixelsOff_33(HandleRef pThis);

	/// <summary>
	/// Resample the image directly to the screen pixels, instead of
	/// using a texture to scale the image after resampling.  This is
	/// slower and uses more memory, but provides high-quality results.
	/// It is On by default.
	/// </summary>
	public virtual void ResampleToScreenPixelsOff()
	{
		vtkImageResliceMapper_ResampleToScreenPixelsOff_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_ResampleToScreenPixelsOn_34(HandleRef pThis);

	/// <summary>
	/// Resample the image directly to the screen pixels, instead of
	/// using a texture to scale the image after resampling.  This is
	/// slower and uses more memory, but provides high-quality results.
	/// It is On by default.
	/// </summary>
	public virtual void ResampleToScreenPixelsOn()
	{
		vtkImageResliceMapper_ResampleToScreenPixelsOn_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageResliceMapper_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageResliceMapper SafeDownCast(vtkObjectBase o)
	{
		vtkImageResliceMapper vtkImageResliceMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageResliceMapper_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageResliceMapper2 = (vtkImageResliceMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageResliceMapper2.Register(null);
			}
		}
		return vtkImageResliceMapper2;
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SeparateWindowLevelOperationOff_36(HandleRef pThis);

	/// <summary>
	/// Keep the color mapping stage distinct from the reslicing stage.
	/// This will improve the quality and possibly the speed of interactive
	/// window/level operations, but it uses more memory and might slow down
	/// interactive slicing operations.  On by default.
	/// </summary>
	public virtual void SeparateWindowLevelOperationOff()
	{
		vtkImageResliceMapper_SeparateWindowLevelOperationOff_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SeparateWindowLevelOperationOn_37(HandleRef pThis);

	/// <summary>
	/// Keep the color mapping stage distinct from the reslicing stage.
	/// This will improve the quality and possibly the speed of interactive
	/// window/level operations, but it uses more memory and might slow down
	/// interactive slicing operations.  On by default.
	/// </summary>
	public virtual void SeparateWindowLevelOperationOn()
	{
		vtkImageResliceMapper_SeparateWindowLevelOperationOn_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetAutoAdjustImageQuality_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Automatically reduce the rendering quality for greater speed
	/// when doing an interactive render.  This is on by default.
	/// </summary>
	public virtual void SetAutoAdjustImageQuality(int _arg)
	{
		vtkImageResliceMapper_SetAutoAdjustImageQuality_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetImageSampleFactor_39(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the reslice sample frequency as in relation to the input image
	/// sample frequency.  The default value is 1, but higher values can be
	/// used to improve the results.  This is cheaper than turning on
	/// ResampleToScreenPixels.
	/// </summary>
	public virtual void SetImageSampleFactor(int _arg)
	{
		vtkImageResliceMapper_SetImageSampleFactor_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetInterpolator_40(HandleRef pThis, HandleRef interpolator);

	/// <summary>
	/// Set a custom interpolator.  This will only be used if the
	/// ResampleToScreenPixels option is on.
	/// </summary>
	public virtual void SetInterpolator(vtkAbstractImageInterpolator interpolator)
	{
		vtkImageResliceMapper_SetInterpolator_40(GetCppThis(), interpolator?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetJumpToNearestSlice_41(HandleRef pThis, int _arg);

	/// <summary>
	/// When using SliceAtFocalPoint, this causes the slicing to occur at
	/// the closest slice to the focal point, instead of the default behavior
	/// where a new slice is interpolated between the original slices.  This
	/// flag is ignored if the slicing is oblique to the original slices.
	/// </summary>
	public virtual void SetJumpToNearestSlice(int _arg)
	{
		vtkImageResliceMapper_SetJumpToNearestSlice_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetResampleToScreenPixels_42(HandleRef pThis, int _arg);

	/// <summary>
	/// Resample the image directly to the screen pixels, instead of
	/// using a texture to scale the image after resampling.  This is
	/// slower and uses more memory, but provides high-quality results.
	/// It is On by default.
	/// </summary>
	public virtual void SetResampleToScreenPixels(int _arg)
	{
		vtkImageResliceMapper_SetResampleToScreenPixels_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSeparateWindowLevelOperation_43(HandleRef pThis, int _arg);

	/// <summary>
	/// Keep the color mapping stage distinct from the reslicing stage.
	/// This will improve the quality and possibly the speed of interactive
	/// window/level operations, but it uses more memory and might slow down
	/// interactive slicing operations.  On by default.
	/// </summary>
	public virtual void SetSeparateWindowLevelOperation(int _arg)
	{
		vtkImageResliceMapper_SetSeparateWindowLevelOperation_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSlabSampleFactor_44(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the number of slab samples to use as a factor of the number
	/// of input slices within the slab thickness.  The default value
	/// is 2, but 1 will increase speed with very little loss of quality.
	/// </summary>
	public virtual void SetSlabSampleFactor(int _arg)
	{
		vtkImageResliceMapper_SetSlabSampleFactor_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSlabThickness_45(HandleRef pThis, double _arg);

	/// <summary>
	/// The slab thickness, for thick slicing (default: zero)
	/// </summary>
	public virtual void SetSlabThickness(double _arg)
	{
		vtkImageResliceMapper_SetSlabThickness_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSlabType_46(HandleRef pThis, int _arg);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public virtual void SetSlabType(int _arg)
	{
		vtkImageResliceMapper_SetSlabType_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSlabTypeToMax_47(HandleRef pThis);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public void SetSlabTypeToMax()
	{
		vtkImageResliceMapper_SetSlabTypeToMax_47(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSlabTypeToMean_48(HandleRef pThis);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public void SetSlabTypeToMean()
	{
		vtkImageResliceMapper_SetSlabTypeToMean_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSlabTypeToMin_49(HandleRef pThis);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public void SetSlabTypeToMin()
	{
		vtkImageResliceMapper_SetSlabTypeToMin_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSlabTypeToSum_50(HandleRef pThis);

	/// <summary>
	/// The slab type, for thick slicing (default: Mean).
	/// The resulting view is a parallel projection through the volume.  This
	/// method can be used to generate a facsimile of a digitally-reconstructed
	/// radiograph or a minimum-intensity projection as long as perspective
	/// geometry is not required.  Note that the Sum mode provides an output
	/// with units of intensity times distance, while all other modes provide
	/// an output with units of intensity.
	/// </summary>
	public void SetSlabTypeToSum()
	{
		vtkImageResliceMapper_SetSlabTypeToSum_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageResliceMapper_SetSlicePlane_51(HandleRef pThis, HandleRef plane);

	/// <summary>
	/// Set the slice that will be used to cut through the image.
	/// This slice should be in world coordinates, rather than
	/// data coordinates.  Use SliceFacesCamera and SliceAtFocalPoint
	/// if you want the slice to automatically follow the camera.
	/// </summary>
	public virtual void SetSlicePlane(vtkPlane plane)
	{
		vtkImageResliceMapper_SetSlicePlane_51(GetCppThis(), plane?.GetCppThis() ?? default(HandleRef));
	}
}
