using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageContinuousErode3D
/// </summary>
/// <remarks>
///    Erosion implemented as a minimum.
///
/// vtkImageContinuousErode3D replaces a pixel with the minimum over
/// an ellipsoidal neighborhood.  If KernelSize of an axis is 1, no processing
/// is done on that axis.
/// </remarks>
public class vtkImageContinuousErode3D : vtkImageSpatialAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageContinuousErode3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageContinuousErode3D()
	{
		MRClassNameKey = "class vtkImageContinuousErode3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageContinuousErode3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageContinuousErode3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageContinuousErode3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageContinuousErode3D filter.
	/// By default zero values are eroded.
	/// </summary>
	public new static vtkImageContinuousErode3D New()
	{
		vtkImageContinuousErode3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageContinuousErode3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageContinuousErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an instance of vtkImageContinuousErode3D filter.
	/// By default zero values are eroded.
	/// </summary>
	public vtkImageContinuousErode3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageContinuousErode3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageContinuousErode3D_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageContinuousErode3D filter.
	/// By default zero values are eroded.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageContinuousErode3D_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageContinuousErode3D_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	/// Construct an instance of vtkImageContinuousErode3D filter.
	/// By default zero values are eroded.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageContinuousErode3D_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageContinuousErode3D_IsA_03(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageContinuousErode3D filter.
	/// By default zero values are eroded.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageContinuousErode3D_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageContinuousErode3D_IsTypeOf_04(string type);

	/// <summary>
	/// Construct an instance of vtkImageContinuousErode3D filter.
	/// By default zero values are eroded.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageContinuousErode3D_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageContinuousErode3D_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageContinuousErode3D filter.
	/// By default zero values are eroded.
	/// </summary>
	public new vtkImageContinuousErode3D NewInstance()
	{
		vtkImageContinuousErode3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageContinuousErode3D_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageContinuousErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageContinuousErode3D_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageContinuousErode3D filter.
	/// By default zero values are eroded.
	/// </summary>
	public new static vtkImageContinuousErode3D SafeDownCast(vtkObjectBase o)
	{
		vtkImageContinuousErode3D vtkImageContinuousErode3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageContinuousErode3D_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageContinuousErode3D2 = (vtkImageContinuousErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageContinuousErode3D2.Register(null);
			}
		}
		return vtkImageContinuousErode3D2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageContinuousErode3D_SetKernelSize_08(HandleRef pThis, int size0, int size1, int size2);

	/// <summary>
	/// This method sets the size of the neighborhood.  It also sets the
	/// default middle of the neighborhood and computes the elliptical foot print.
	/// </summary>
	public void SetKernelSize(int size0, int size1, int size2)
	{
		vtkImageContinuousErode3D_SetKernelSize_08(GetCppThis(), size0, size1, size2);
	}
}
