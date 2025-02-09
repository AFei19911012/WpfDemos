using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageDilateErode3D
/// </summary>
/// <remarks>
///    Dilates one value and erodes another.
///
/// vtkImageDilateErode3D will dilate one value and erode another.
/// It uses an elliptical foot print, and only erodes/dilates on the
/// boundary of the two values.  The filter is restricted to the
/// X, Y, and Z axes for now.  It can degenerate to a 2 or 1 dimensional
/// filter by setting the kernel size to 1 for a specific axis.
/// </remarks>
public class vtkImageDilateErode3D : vtkImageSpatialAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageDilateErode3D";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageDilateErode3D()
	{
		MRClassNameKey = "class vtkImageDilateErode3D";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDilateErode3D"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageDilateErode3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDilateErode3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageDilateErode3D filter.
	/// By default zero values are dilated.
	/// </summary>
	public new static vtkImageDilateErode3D New()
	{
		vtkImageDilateErode3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDilateErode3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct an instance of vtkImageDilateErode3D filter.
	/// By default zero values are dilated.
	/// </summary>
	public vtkImageDilateErode3D()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageDilateErode3D_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkImageDilateErode3D_GetDilateValue_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the Dilate and Erode values to be used by this filter.
	/// </summary>
	public virtual double GetDilateValue()
	{
		return vtkImageDilateErode3D_GetDilateValue_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageDilateErode3D_GetErodeValue_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the Dilate and Erode values to be used by this filter.
	/// </summary>
	public virtual double GetErodeValue()
	{
		return vtkImageDilateErode3D_GetErodeValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDilateErode3D_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageDilateErode3D filter.
	/// By default zero values are dilated.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageDilateErode3D_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageDilateErode3D_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	/// Construct an instance of vtkImageDilateErode3D filter.
	/// By default zero values are dilated.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageDilateErode3D_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDilateErode3D_IsA_05(HandleRef pThis, string type);

	/// <summary>
	/// Construct an instance of vtkImageDilateErode3D filter.
	/// By default zero values are dilated.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageDilateErode3D_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageDilateErode3D_IsTypeOf_06(string type);

	/// <summary>
	/// Construct an instance of vtkImageDilateErode3D filter.
	/// By default zero values are dilated.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageDilateErode3D_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDilateErode3D_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageDilateErode3D filter.
	/// By default zero values are dilated.
	/// </summary>
	public new vtkImageDilateErode3D NewInstance()
	{
		vtkImageDilateErode3D result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDilateErode3D_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageDilateErode3D_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct an instance of vtkImageDilateErode3D filter.
	/// By default zero values are dilated.
	/// </summary>
	public new static vtkImageDilateErode3D SafeDownCast(vtkObjectBase o)
	{
		vtkImageDilateErode3D vtkImageDilateErode3D2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageDilateErode3D_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageDilateErode3D2 = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageDilateErode3D2.Register(null);
			}
		}
		return vtkImageDilateErode3D2;
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDilateErode3D_SetDilateValue_10(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Dilate and Erode values to be used by this filter.
	/// </summary>
	public virtual void SetDilateValue(double _arg)
	{
		vtkImageDilateErode3D_SetDilateValue_10(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDilateErode3D_SetErodeValue_11(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Dilate and Erode values to be used by this filter.
	/// </summary>
	public virtual void SetErodeValue(double _arg)
	{
		vtkImageDilateErode3D_SetErodeValue_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageDilateErode3D_SetKernelSize_12(HandleRef pThis, int size0, int size1, int size2);

	/// <summary>
	/// This method sets the size of the neighborhood.  It also sets the
	/// default middle of the neighborhood and computes the elliptical foot print.
	/// </summary>
	public void SetKernelSize(int size0, int size1, int size2)
	{
		vtkImageDilateErode3D_SetKernelSize_12(GetCppThis(), size0, size1, size2);
	}
}
