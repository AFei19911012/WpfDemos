using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageSpatialAlgorithm
/// </summary>
/// <remarks>
///    Filters that operate on pixel neighborhoods.
///
/// vtkImageSpatialAlgorithm is a super class for filters that operate on an
/// input neighborhood for each output pixel. It handles even sized
/// neighborhoods, but their can be a half pixel shift associated with
/// processing.  This superclass has some logic for handling boundaries.  It
/// can split regions into boundary and non-boundary pieces and call different
/// execute methods.
/// </remarks>
public class vtkImageSpatialAlgorithm : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageSpatialAlgorithm";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageSpatialAlgorithm()
	{
		MRClassNameKey = "class vtkImageSpatialAlgorithm";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSpatialAlgorithm"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageSpatialAlgorithm(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSpatialAlgorithm_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSpatialAlgorithm New()
	{
		vtkImageSpatialAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSpatialAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageSpatialAlgorithm()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageSpatialAlgorithm_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSpatialAlgorithm_GetKernelMiddle_01(HandleRef pThis);

	/// <summary>
	/// Get the Kernel middle.
	/// </summary>
	public virtual int[] GetKernelMiddle()
	{
		IntPtr intPtr = vtkImageSpatialAlgorithm_GetKernelMiddle_01(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSpatialAlgorithm_GetKernelMiddle_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Get the Kernel middle.
	/// </summary>
	public virtual void GetKernelMiddle(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageSpatialAlgorithm_GetKernelMiddle_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSpatialAlgorithm_GetKernelMiddle_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the Kernel middle.
	/// </summary>
	public virtual void GetKernelMiddle(IntPtr _arg)
	{
		vtkImageSpatialAlgorithm_GetKernelMiddle_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSpatialAlgorithm_GetKernelSize_04(HandleRef pThis);

	/// <summary>
	/// Get the Kernel size.
	/// </summary>
	public virtual int[] GetKernelSize()
	{
		IntPtr intPtr = vtkImageSpatialAlgorithm_GetKernelSize_04(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSpatialAlgorithm_GetKernelSize_05(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Get the Kernel size.
	/// </summary>
	public virtual void GetKernelSize(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageSpatialAlgorithm_GetKernelSize_05(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageSpatialAlgorithm_GetKernelSize_06(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get the Kernel size.
	/// </summary>
	public virtual void GetKernelSize(IntPtr _arg)
	{
		vtkImageSpatialAlgorithm_GetKernelSize_06(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSpatialAlgorithm_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageSpatialAlgorithm_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageSpatialAlgorithm_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageSpatialAlgorithm_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSpatialAlgorithm_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageSpatialAlgorithm_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageSpatialAlgorithm_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageSpatialAlgorithm_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSpatialAlgorithm_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageSpatialAlgorithm NewInstance()
	{
		vtkImageSpatialAlgorithm result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSpatialAlgorithm_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageSpatialAlgorithm_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageSpatialAlgorithm SafeDownCast(vtkObjectBase o)
	{
		vtkImageSpatialAlgorithm vtkImageSpatialAlgorithm2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageSpatialAlgorithm_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageSpatialAlgorithm2 = (vtkImageSpatialAlgorithm)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageSpatialAlgorithm2.Register(null);
			}
		}
		return vtkImageSpatialAlgorithm2;
	}
}
