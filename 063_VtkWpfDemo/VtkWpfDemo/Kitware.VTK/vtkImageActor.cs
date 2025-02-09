using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageActor
/// </summary>
/// <remarks>
///    draw an image in a rendered 3D scene
///
/// vtkImageActor is used to render an image in a 3D scene.  The image
/// is placed at the origin of the image, and its size is controlled by the
/// image dimensions and image spacing. The orientation of the image is
/// orthogonal to one of the x-y-z axes depending on which plane the
/// image is defined in.  This class has been mostly superseded by
/// the vtkImageSlice class, which provides more functionality than
/// vtkImageActor.
///
/// </remarks>
/// <seealso>
///
/// vtkImageData vtkImageSliceMapper vtkImageProperty
/// </seealso>
public class vtkImageActor : vtkImageSlice
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageActor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageActor()
	{
		MRClassNameKey = "class vtkImageActor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageActor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageActor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Instantiate the image actor.
	/// </summary>
	public new static vtkImageActor New()
	{
		vtkImageActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Instantiate the image actor.
	/// </summary>
	public vtkImageActor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageActor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageActor_ForceOpaqueOff_01(HandleRef pThis);

	/// <summary>
	/// Force the actor to be rendered during the opaque rendering pass.
	/// Default is false.
	/// See also: ForceTranslucentOn() to use translucent rendering pass.
	/// </summary>
	public virtual void ForceOpaqueOff()
	{
		vtkImageActor_ForceOpaqueOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_ForceOpaqueOn_02(HandleRef pThis);

	/// <summary>
	/// Force the actor to be rendered during the opaque rendering pass.
	/// Default is false.
	/// See also: ForceTranslucentOn() to use translucent rendering pass.
	/// </summary>
	public virtual void ForceOpaqueOn()
	{
		vtkImageActor_ForceOpaqueOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActor_GetBounds_03(HandleRef pThis);

	/// <summary>
	/// Get the bounds of this image actor. Either copy the bounds
	/// into a user provided array or return a pointer to an array.
	/// In either case the bounds is expressed as a 6-vector
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public override double[] GetBounds()
	{
		IntPtr intPtr = vtkImageActor_GetBounds_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_GetBounds_04(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds of this image actor. Either copy the bounds
	/// into a user provided array or return a pointer to an array.
	/// In either case the bounds is expressed as a 6-vector
	/// (xmin,xmax, ymin,ymax, zmin,zmax).
	/// </summary>
	public new void GetBounds(IntPtr bounds)
	{
		vtkImageActor_GetBounds_04(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActor_GetDisplayBounds_05(HandleRef pThis);

	/// <summary>
	/// Get the bounds of the data that is displayed by this image
	/// actor.  If the transformation matrix for this actor is the
	/// identity matrix, this will return the same value as
	/// GetBounds.
	/// </summary>
	public IntPtr GetDisplayBounds()
	{
		return vtkImageActor_GetDisplayBounds_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_GetDisplayBounds_06(HandleRef pThis, IntPtr bounds);

	/// <summary>
	/// Get the bounds of the data that is displayed by this image
	/// actor.  If the transformation matrix for this actor is the
	/// identity matrix, this will return the same value as
	/// GetBounds.
	/// </summary>
	public void GetDisplayBounds(IntPtr bounds)
	{
		vtkImageActor_GetDisplayBounds_06(GetCppThis(), bounds);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_GetDisplayExtent_07(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// The image extent is generally set explicitly, but if not set
	/// it will be determined from the input image data.
	/// </summary>
	public void GetDisplayExtent(IntPtr extent)
	{
		vtkImageActor_GetDisplayExtent_07(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActor_GetDisplayExtent_08(HandleRef pThis);

	/// <summary>
	/// The image extent is generally set explicitly, but if not set
	/// it will be determined from the input image data.
	/// </summary>
	public int[] GetDisplayExtent()
	{
		IntPtr intPtr = vtkImageActor_GetDisplayExtent_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageActor_GetForceOpaque_09(HandleRef pThis);

	/// <summary>
	/// Force the actor to be rendered during the opaque rendering pass.
	/// Default is false.
	/// See also: ForceTranslucentOn() to use translucent rendering pass.
	/// </summary>
	public virtual bool GetForceOpaque()
	{
		return (vtkImageActor_GetForceOpaque_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActor_GetInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the image data input for the image actor.  This is for
	/// backwards compatibility, for a proper pipeline connection you
	/// should use GetMapper()-&gt;SetInputConnection() instead.
	/// </summary>
	public virtual vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageActor_GetInput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageActor_GetInterpolate_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off linear interpolation of the image when rendering.
	/// More options are available in the Property of the image actor.
	/// </summary>
	public virtual int GetInterpolate()
	{
		return vtkImageActor_GetInterpolate_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageActor_GetNumberOfGenerationsFromBase_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageActor_GetNumberOfGenerationsFromBase_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageActor_GetNumberOfGenerationsFromBaseType_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageActor_GetNumberOfGenerationsFromBaseType_13(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageActor_GetOpacity_14(HandleRef pThis);

	/// <summary>
	/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent. The default is 1.0.
	/// </summary>
	public virtual double GetOpacity()
	{
		return vtkImageActor_GetOpacity_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageActor_GetOpacityMaxValue_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent. The default is 1.0.
	/// </summary>
	public double GetOpacityMaxValue()
	{
		return vtkImageActor_GetOpacityMaxValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageActor_GetOpacityMinValue_16(HandleRef pThis);

	/// <summary>
	/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent. The default is 1.0.
	/// </summary>
	public double GetOpacityMinValue()
	{
		return vtkImageActor_GetOpacityMinValue_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_GetSliceNumber_17(HandleRef pThis);

	/// <summary>
	/// Return the slice number (&amp; min/max slice number) computed from the display
	/// extent.
	/// </summary>
	public int GetSliceNumber()
	{
		return vtkImageActor_GetSliceNumber_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_GetSliceNumberMax_18(HandleRef pThis);

	/// <summary>
	/// Return the slice number (&amp; min/max slice number) computed from the display
	/// extent.
	/// </summary>
	public int GetSliceNumberMax()
	{
		return vtkImageActor_GetSliceNumberMax_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_GetSliceNumberMin_19(HandleRef pThis);

	/// <summary>
	/// Return the slice number (&amp; min/max slice number) computed from the display
	/// extent.
	/// </summary>
	public int GetSliceNumberMin()
	{
		return vtkImageActor_GetSliceNumberMin_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_GetWholeZMax_20(HandleRef pThis);

	/// <summary>
	/// Set/Get the current slice number. The axis Z in ZSlice does not
	/// necessarily have any relation to the z axis of the data on disk.
	/// It is simply the axis orthogonal to the x,y, display plane.
	/// GetWholeZMax and Min are convenience methods for obtaining
	/// the number of slices that can be displayed. Again the number
	/// of slices is in reference to the display z axis, which is not
	/// necessarily the z axis on disk. (due to reformatting etc)
	/// </summary>
	public int GetWholeZMax()
	{
		return vtkImageActor_GetWholeZMax_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_GetWholeZMin_21(HandleRef pThis);

	/// <summary>
	/// Set/Get the current slice number. The axis Z in ZSlice does not
	/// necessarily have any relation to the z axis of the data on disk.
	/// It is simply the axis orthogonal to the x,y, display plane.
	/// GetWholeZMax and Min are convenience methods for obtaining
	/// the number of slices that can be displayed. Again the number
	/// of slices is in reference to the display z axis, which is not
	/// necessarily the z axis on disk. (due to reformatting etc)
	/// </summary>
	public int GetWholeZMin()
	{
		return vtkImageActor_GetWholeZMin_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_GetZSlice_22(HandleRef pThis);

	/// <summary>
	/// Set/Get the current slice number. The axis Z in ZSlice does not
	/// necessarily have any relation to the z axis of the data on disk.
	/// It is simply the axis orthogonal to the x,y, display plane.
	/// GetWholeZMax and Min are convenience methods for obtaining
	/// the number of slices that can be displayed. Again the number
	/// of slices is in reference to the display z axis, which is not
	/// necessarily the z axis on disk. (due to reformatting etc)
	/// </summary>
	public int GetZSlice()
	{
		return vtkImageActor_GetZSlice_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_HasTranslucentPolygonalGeometry_23(HandleRef pThis);

	/// <summary>
	/// Internal method, should only be used by rendering.
	/// Returns true if this image actor has an alpha component or if it
	/// has an opacity that is less than 1.0.  This can be overridden by
	/// ForceOpaqueOn(), which forces this method to return false, or
	/// ForceTranslucentOn(), which forces this method to return true.
	/// </summary>
	public override int HasTranslucentPolygonalGeometry()
	{
		return vtkImageActor_HasTranslucentPolygonalGeometry_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_InterpolateOff_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off linear interpolation of the image when rendering.
	/// More options are available in the Property of the image actor.
	/// </summary>
	public virtual void InterpolateOff()
	{
		vtkImageActor_InterpolateOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_InterpolateOn_25(HandleRef pThis);

	/// <summary>
	/// Turn on/off linear interpolation of the image when rendering.
	/// More options are available in the Property of the image actor.
	/// </summary>
	public virtual void InterpolateOn()
	{
		vtkImageActor_InterpolateOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_IsA_26(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageActor_IsA_26(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageActor_IsTypeOf_27(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageActor_IsTypeOf_27(type);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActor_NewInstance_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageActor NewInstance()
	{
		vtkImageActor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageActor_NewInstance_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageActor_SafeDownCast_30(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageActor SafeDownCast(vtkObjectBase o)
	{
		vtkImageActor vtkImageActor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageActor_SafeDownCast_30(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageActor2 = (vtkImageActor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageActor2.Register(null);
			}
		}
		return vtkImageActor2;
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_SetDisplayExtent_31(HandleRef pThis, IntPtr extent);

	/// <summary>
	/// The image extent is generally set explicitly, but if not set
	/// it will be determined from the input image data.
	/// </summary>
	public void SetDisplayExtent(IntPtr extent)
	{
		vtkImageActor_SetDisplayExtent_31(GetCppThis(), extent);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_SetDisplayExtent_32(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

	/// <summary>
	/// The image extent is generally set explicitly, but if not set
	/// it will be determined from the input image data.
	/// </summary>
	public void SetDisplayExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
	{
		vtkImageActor_SetDisplayExtent_32(GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_SetForceOpaque_33(HandleRef pThis, byte _arg);

	/// <summary>
	/// Force the actor to be rendered during the opaque rendering pass.
	/// Default is false.
	/// See also: ForceTranslucentOn() to use translucent rendering pass.
	/// </summary>
	public virtual void SetForceOpaque(bool _arg)
	{
		vtkImageActor_SetForceOpaque_33(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_SetInputData_34(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get the image data input for the image actor.  This is for
	/// backwards compatibility, for a proper pipeline connection you
	/// should use GetMapper()-&gt;SetInputConnection() instead.
	/// </summary>
	public virtual void SetInputData(vtkImageData arg0)
	{
		vtkImageActor_SetInputData_34(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_SetInterpolate_35(HandleRef pThis, int arg0);

	/// <summary>
	/// Turn on/off linear interpolation of the image when rendering.
	/// More options are available in the Property of the image actor.
	/// </summary>
	public virtual void SetInterpolate(int arg0)
	{
		vtkImageActor_SetInterpolate_35(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_SetOpacity_36(HandleRef pThis, double arg0);

	/// <summary>
	/// Set/Get the object's opacity. 1.0 is totally opaque and 0.0 is completely
	/// transparent. The default is 1.0.
	/// </summary>
	public virtual void SetOpacity(double arg0)
	{
		vtkImageActor_SetOpacity_36(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.RenderingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageActor_SetZSlice_37(HandleRef pThis, int z);

	/// <summary>
	/// Set/Get the current slice number. The axis Z in ZSlice does not
	/// necessarily have any relation to the z axis of the data on disk.
	/// It is simply the axis orthogonal to the x,y, display plane.
	/// GetWholeZMax and Min are convenience methods for obtaining
	/// the number of slices that can be displayed. Again the number
	/// of slices is in reference to the display z axis, which is not
	/// necessarily the z axis on disk. (due to reformatting etc)
	/// </summary>
	public void SetZSlice(int z)
	{
		vtkImageActor_SetZSlice_37(GetCppThis(), z);
	}
}
