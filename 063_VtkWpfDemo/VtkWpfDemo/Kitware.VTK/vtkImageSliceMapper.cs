using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSliceMapper
/// </summary>
/// <remarks>
///    map a slice of a vtkImageData to the screen
///
/// vtkImageSliceMapper is a mapper that will draw a 2D image, or a slice
/// of a 3D image.  For 3D images, the slice may be oriented in the X, Y,
/// or Z direction.  This mapper works via 2D textures with accelerated
/// zoom and pan operations.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImageSlice vtkImageProperty vtkImageResliceMapper
/// </seealso>
public class vtkImageSliceMapper : vtkImageMapper3D
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSliceMapper";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSliceMapper()
	{
		MRClassNameKey = "class vtkImageSliceMapper";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSliceMapper"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSliceMapper(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSliceMapper_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSliceMapper New()
	{
		vtkImageSliceMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSliceMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSliceMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageSliceMapper()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSliceMapper_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageSliceMapper_CroppingOff_01(HandleRef pThis);

	/// <summary>
	/// Use the specified CroppingRegion.  The default is to display
	/// the full slice.
	/// </summary>
	public virtual void CroppingOff()
	{
		vtkImageSliceMapper_CroppingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_CroppingOn_02(HandleRef pThis);

	/// <summary>
	/// Use the specified CroppingRegion.  The default is to display
	/// the full slice.
	/// </summary>
	public virtual void CroppingOn()
	{
		vtkImageSliceMapper_CroppingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSliceMapper_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// The bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkImageSliceMapper_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_GetBounds_04(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// The bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override void GetBounds(IntPtr bounds)
	{
		vtkImageSliceMapper_GetBounds_04(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_GetCropping_05(HandleRef pThis);

	/// <summary>
	/// Use the specified CroppingRegion.  The default is to display
	/// the full slice.
	/// </summary>
	public virtual int GetCropping()
	{
		return vtkImageSliceMapper_GetCropping_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSliceMapper_GetCroppingRegion_06(HandleRef pThis);

	/// <summary>
	/// Set the display extent.  This is ignored unless Cropping
	/// is set.
	/// </summary>
	public virtual int[] GetCroppingRegion()
	{
		IntPtr intPtr = vtkImageSliceMapper_GetCroppingRegion_06(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_GetCroppingRegion_07(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Set the display extent.  This is ignored unless Cropping
	/// is set.
	/// </summary>
	public virtual void GetCroppingRegion(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageSliceMapper_GetCroppingRegion_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_GetCroppingRegion_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the display extent.  This is ignored unless Cropping
	/// is set.
	/// </summary>
	public virtual void GetCroppingRegion(IntPtr _arg)
	{
		vtkImageSliceMapper_GetCroppingRegion_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_GetIndexBounds_09(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// The bounding box (array of six doubles) of data expressed as
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override void GetIndexBounds(IntPtr extent)
	{
		vtkImageSliceMapper_GetIndexBounds_09(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkImageSliceMapper_GetMTime_10(HandleRef pThis);

	/// <summary>
	/// Get the mtime for the mapper.
	/// </summary>
	public override ulong GetMTime()
	{
		return vtkImageSliceMapper_GetMTime_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSliceMapper_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSliceMapper_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSliceMapper_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSliceMapper_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_GetOrientation_13(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public virtual int GetOrientation()
	{
		return vtkImageSliceMapper_GetOrientation_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_GetOrientationMaxValue_14(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public virtual int GetOrientationMaxValue()
	{
		return vtkImageSliceMapper_GetOrientationMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_GetOrientationMinValue_15(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public virtual int GetOrientationMinValue()
	{
		return vtkImageSliceMapper_GetOrientationMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_GetSliceNumber_16(HandleRef pThis);

	/// <summary>
	/// The slice to display, if there are multiple slices.
	/// </summary>
	public virtual int GetSliceNumber()
	{
		return vtkImageSliceMapper_GetSliceNumber_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_GetSliceNumberMaxValue_17(HandleRef pThis);

	/// <summary>
	/// Use GetSliceNumberMinValue() and GetSliceNumberMaxValue()
	/// to get the range of allowed slices.  These methods call
	/// UpdateInformation as a side-effect.
	/// </summary>
	public virtual int GetSliceNumberMaxValue()
	{
		return vtkImageSliceMapper_GetSliceNumberMaxValue_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_GetSliceNumberMinValue_18(HandleRef pThis);

	/// <summary>
	/// Use GetSliceNumberMinValue() and GetSliceNumberMaxValue()
	/// to get the range of allowed slices.  These methods call
	/// UpdateInformation as a side-effect.
	/// </summary>
	public virtual int GetSliceNumberMinValue()
	{
		return vtkImageSliceMapper_GetSliceNumberMinValue_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_GetSlicePlaneInDataCoords_19(HandleRef pThis, HandleRef propMatrix, IntPtr plane);

	/// <summary>
	/// Get the plane as a homogeneous 4-vector that gives the plane
	/// equation coefficients.  It is computed from the Orientation
	/// and SliceNumber, the propMatrix is unused and can be zero.
	/// </summary>
	public override void GetSlicePlaneInDataCoords(vtkMatrix4x4 propMatrix, IntPtr plane)
	{
		vtkImageSliceMapper_GetSlicePlaneInDataCoords_19(GetCppThis(), propMatrix?.GetCppThis() ?? default(HandleRef), plane);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_IsA_20(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSliceMapper_IsA_20(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSliceMapper_IsTypeOf_21(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSliceMapper_IsTypeOf_21(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSliceMapper_NewInstance_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSliceMapper NewInstance()
	{
		vtkImageSliceMapper result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSliceMapper_NewInstance_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSliceMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_ReleaseGraphicsResources_24(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Release any graphics resources that are being consumed by
	/// this mapper.  The parameter window is used to determine
	/// which graphic resources to release.
	/// </summary>
	public override void ReleaseGraphicsResources(vtkWindow arg0)
	{
		vtkImageSliceMapper_ReleaseGraphicsResources_24(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_Render_25(HandleRef pThis, HandleRef renderer, HandleRef prop);

	/// <summary>
	/// This should only be called by the renderer.
	/// </summary>
	public override void Render(vtkRenderer renderer, vtkImageSlice prop)
	{
		vtkImageSliceMapper_Render_25(GetCppThis(), renderer?.GetCppThis() ?? default(HandleRef), prop?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSliceMapper_SafeDownCast_26(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSliceMapper SafeDownCast(vtkObjectBase o)
	{
		vtkImageSliceMapper vtkImageSliceMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSliceMapper_SafeDownCast_26(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSliceMapper2 = (vtkImageSliceMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSliceMapper2.Register(null);
			}
		}
		return vtkImageSliceMapper2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetCropping_27(HandleRef pThis, int _arg);

	/// <summary>
	/// Use the specified CroppingRegion.  The default is to display
	/// the full slice.
	/// </summary>
	public virtual void SetCropping(int _arg)
	{
		vtkImageSliceMapper_SetCropping_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetCroppingRegion_28(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Set the display extent.  This is ignored unless Cropping
	/// is set.
	/// </summary>
	public virtual void SetCroppingRegion(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkImageSliceMapper_SetCroppingRegion_28(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetCroppingRegion_29(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the display extent.  This is ignored unless Cropping
	/// is set.
	/// </summary>
	public virtual void SetCroppingRegion(IntPtr _arg)
	{
		vtkImageSliceMapper_SetCroppingRegion_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetDisplayExtent_30(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// Set the display extent.  For when this mapper is used as a helper
	/// class.
	/// </summary>
	public void SetDisplayExtent(IntPtr extent)
	{
		vtkImageSliceMapper_SetDisplayExtent_30(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetOrientation_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public virtual void SetOrientation(int _arg)
	{
		vtkImageSliceMapper_SetOrientation_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetOrientationToI_32(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public void SetOrientationToI()
	{
		vtkImageSliceMapper_SetOrientationToI_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetOrientationToJ_33(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public void SetOrientationToJ()
	{
		vtkImageSliceMapper_SetOrientationToJ_33(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetOrientationToK_34(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public void SetOrientationToK()
	{
		vtkImageSliceMapper_SetOrientationToK_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetOrientationToX_35(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public void SetOrientationToX()
	{
		vtkImageSliceMapper_SetOrientationToX_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetOrientationToY_36(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public void SetOrientationToY()
	{
		vtkImageSliceMapper_SetOrientationToY_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetOrientationToZ_37(HandleRef pThis);

	/// <summary>
	/// Set the orientation of the slices to display.  The default
	/// orientation is 2, which is K. Not the orientaiton here
	/// is in index space. Not physical or world.
	/// </summary>
	public void SetOrientationToZ()
	{
		vtkImageSliceMapper_SetOrientationToZ_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSliceMapper_SetSliceNumber_38(HandleRef pThis, int slice);

	/// <summary>
	/// The slice to display, if there are multiple slices.
	/// </summary>
	public virtual void SetSliceNumber(int slice)
	{
		vtkImageSliceMapper_SetSliceNumber_38(GetCppThis(), slice);
	}
}
