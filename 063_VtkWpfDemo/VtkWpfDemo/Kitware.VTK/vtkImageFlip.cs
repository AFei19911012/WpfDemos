using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageFlip
/// </summary>
/// <remarks>
///    This flips an axis of an image. Right becomes left ...
///
/// vtkImageFlip will reflect the data along the filtered axis.  This filter is
/// actually a thin wrapper around vtkImageReslice.
/// </remarks>
public class vtkImageFlip : vtkImageReslice
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageFlip";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageFlip()
	{
		MRClassNameKey = "class vtkImageFlip";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageFlip"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageFlip(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageFlip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageFlip New()
	{
		vtkImageFlip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageFlip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageFlip()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageFlip_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageFlip_FlipAboutOriginOff_01(HandleRef pThis);

	/// <summary>
	/// By default the image will be flipped about its center, and the
	/// Origin, Spacing and Extent of the output will be identical to
	/// the input.  However, if you have a coordinate system associated
	/// with the image and you want to use the flip to convert +ve values
	/// along one axis to -ve values (and vice versa) then you actually
	/// want to flip the image about coordinate (0,0,0) instead of about
	/// the center of the image.  This method will adjust the Origin of
	/// the output such that the flip occurs about (0,0,0).  Note that
	/// this method only changes the Origin (and hence the coordinate system)
	/// the output data: the actual pixel values are the same whether or not
	/// this method is used.  Also note that the Origin in this method name
	/// refers to (0,0,0) in the coordinate system associated with the image,
	/// it does not refer to the Origin ivar that is associated with a
	/// vtkImageData.
	/// </summary>
	public virtual void FlipAboutOriginOff()
	{
		vtkImageFlip_FlipAboutOriginOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageFlip_FlipAboutOriginOn_02(HandleRef pThis);

	/// <summary>
	/// By default the image will be flipped about its center, and the
	/// Origin, Spacing and Extent of the output will be identical to
	/// the input.  However, if you have a coordinate system associated
	/// with the image and you want to use the flip to convert +ve values
	/// along one axis to -ve values (and vice versa) then you actually
	/// want to flip the image about coordinate (0,0,0) instead of about
	/// the center of the image.  This method will adjust the Origin of
	/// the output such that the flip occurs about (0,0,0).  Note that
	/// this method only changes the Origin (and hence the coordinate system)
	/// the output data: the actual pixel values are the same whether or not
	/// this method is used.  Also note that the Origin in this method name
	/// refers to (0,0,0) in the coordinate system associated with the image,
	/// it does not refer to the Origin ivar that is associated with a
	/// vtkImageData.
	/// </summary>
	public virtual void FlipAboutOriginOn()
	{
		vtkImageFlip_FlipAboutOriginOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageFlip_GetFilteredAxes_03(HandleRef pThis);

	/// <summary>
	/// Keep the mis-named Axes variations around for compatibility with old
	/// scripts. Axis is singular, not plural...
	/// </summary>
	public int GetFilteredAxes()
	{
		return vtkImageFlip_GetFilteredAxes_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageFlip_GetFilteredAxis_04(HandleRef pThis);

	/// <summary>
	/// Specify which axis will be flipped.  This must be an integer
	/// between 0 (for x) and 2 (for z). Initial value is 0.
	/// </summary>
	public virtual int GetFilteredAxis()
	{
		return vtkImageFlip_GetFilteredAxis_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageFlip_GetFlipAboutOrigin_05(HandleRef pThis);

	/// <summary>
	/// By default the image will be flipped about its center, and the
	/// Origin, Spacing and Extent of the output will be identical to
	/// the input.  However, if you have a coordinate system associated
	/// with the image and you want to use the flip to convert +ve values
	/// along one axis to -ve values (and vice versa) then you actually
	/// want to flip the image about coordinate (0,0,0) instead of about
	/// the center of the image.  This method will adjust the Origin of
	/// the output such that the flip occurs about (0,0,0).  Note that
	/// this method only changes the Origin (and hence the coordinate system)
	/// the output data: the actual pixel values are the same whether or not
	/// this method is used.  Also note that the Origin in this method name
	/// refers to (0,0,0) in the coordinate system associated with the image,
	/// it does not refer to the Origin ivar that is associated with a
	/// vtkImageData.
	/// </summary>
	public virtual int GetFlipAboutOrigin()
	{
		return vtkImageFlip_GetFlipAboutOrigin_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageFlip_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageFlip_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageFlip_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageFlip_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageFlip_GetPreserveImageExtent_08(HandleRef pThis);

	/// <summary>
	/// PreserveImageExtentOff wasn't covered by test scripts and its
	/// implementation was broken.  It is deprecated now and it has
	/// no effect (i.e. the ImageExtent is always preserved).
	/// </summary>
	public virtual int GetPreserveImageExtent()
	{
		return vtkImageFlip_GetPreserveImageExtent_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageFlip_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageFlip_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageFlip_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageFlip_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageFlip_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageFlip NewInstance()
	{
		vtkImageFlip result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageFlip_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageFlip_PreserveImageExtentOff_13(HandleRef pThis);

	/// <summary>
	/// PreserveImageExtentOff wasn't covered by test scripts and its
	/// implementation was broken.  It is deprecated now and it has
	/// no effect (i.e. the ImageExtent is always preserved).
	/// </summary>
	public virtual void PreserveImageExtentOff()
	{
		vtkImageFlip_PreserveImageExtentOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageFlip_PreserveImageExtentOn_14(HandleRef pThis);

	/// <summary>
	/// PreserveImageExtentOff wasn't covered by test scripts and its
	/// implementation was broken.  It is deprecated now and it has
	/// no effect (i.e. the ImageExtent is always preserved).
	/// </summary>
	public virtual void PreserveImageExtentOn()
	{
		vtkImageFlip_PreserveImageExtentOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageFlip_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageFlip SafeDownCast(vtkObjectBase o)
	{
		vtkImageFlip vtkImageFlip2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageFlip_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageFlip2 = (vtkImageFlip)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageFlip2.Register(null);
			}
		}
		return vtkImageFlip2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageFlip_SetFilteredAxes_16(HandleRef pThis, int axis);

	/// <summary>
	/// Keep the mis-named Axes variations around for compatibility with old
	/// scripts. Axis is singular, not plural...
	/// </summary>
	public void SetFilteredAxes(int axis)
	{
		vtkImageFlip_SetFilteredAxes_16(GetCppThis(), axis);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageFlip_SetFilteredAxis_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify which axis will be flipped.  This must be an integer
	/// between 0 (for x) and 2 (for z). Initial value is 0.
	/// </summary>
	public virtual void SetFilteredAxis(int _arg)
	{
		vtkImageFlip_SetFilteredAxis_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageFlip_SetFlipAboutOrigin_18(HandleRef pThis, int _arg);

	/// <summary>
	/// By default the image will be flipped about its center, and the
	/// Origin, Spacing and Extent of the output will be identical to
	/// the input.  However, if you have a coordinate system associated
	/// with the image and you want to use the flip to convert +ve values
	/// along one axis to -ve values (and vice versa) then you actually
	/// want to flip the image about coordinate (0,0,0) instead of about
	/// the center of the image.  This method will adjust the Origin of
	/// the output such that the flip occurs about (0,0,0).  Note that
	/// this method only changes the Origin (and hence the coordinate system)
	/// the output data: the actual pixel values are the same whether or not
	/// this method is used.  Also note that the Origin in this method name
	/// refers to (0,0,0) in the coordinate system associated with the image,
	/// it does not refer to the Origin ivar that is associated with a
	/// vtkImageData.
	/// </summary>
	public virtual void SetFlipAboutOrigin(int _arg)
	{
		vtkImageFlip_SetFlipAboutOrigin_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageFlip_SetPreserveImageExtent_19(HandleRef pThis, int _arg);

	/// <summary>
	/// PreserveImageExtentOff wasn't covered by test scripts and its
	/// implementation was broken.  It is deprecated now and it has
	/// no effect (i.e. the ImageExtent is always preserved).
	/// </summary>
	public virtual void SetPreserveImageExtent(int _arg)
	{
		vtkImageFlip_SetPreserveImageExtent_19(GetCppThis(), _arg);
	}
}
