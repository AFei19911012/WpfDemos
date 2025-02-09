using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageGaussianSource
/// </summary>
/// <remarks>
///    Create an image with Gaussian pixel values.
///
/// vtkImageGaussianSource just produces images with pixel values determined
/// by a Gaussian.
/// </remarks>
public class vtkImageGaussianSource : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageGaussianSource";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageGaussianSource()
	{
		MRClassNameKey = "class vtkImageGaussianSource";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageGaussianSource"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageGaussianSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGaussianSource New()
	{
		vtkImageGaussianSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGaussianSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageGaussianSource()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageGaussianSource_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSource_GetCenter_01(HandleRef pThis);

	/// <summary>
	/// Set/Get the center of the Gaussian.
	/// </summary>
	public virtual double[] GetCenter()
	{
		IntPtr intPtr = vtkImageGaussianSource_GetCenter_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the center of the Gaussian.
	/// </summary>
	public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageGaussianSource_GetCenter_02(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the center of the Gaussian.
	/// </summary>
	public virtual void GetCenter(IntPtr _arg)
	{
		vtkImageGaussianSource_GetCenter_03(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageGaussianSource_GetMaximum_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the Maximum value of the gaussian
	/// </summary>
	public virtual double GetMaximum()
	{
		return vtkImageGaussianSource_GetMaximum_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGaussianSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageGaussianSource_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageGaussianSource_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageGaussianSource_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkImageGaussianSource_GetStandardDeviation_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the standard deviation of the gaussian
	/// </summary>
	public virtual double GetStandardDeviation()
	{
		return vtkImageGaussianSource_GetStandardDeviation_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGaussianSource_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageGaussianSource_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageGaussianSource_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageGaussianSource_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSource_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageGaussianSource NewInstance()
	{
		vtkImageGaussianSource result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGaussianSource_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageGaussianSource_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageGaussianSource SafeDownCast(vtkObjectBase o)
	{
		vtkImageGaussianSource vtkImageGaussianSource2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageGaussianSource_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageGaussianSource2 = (vtkImageGaussianSource)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageGaussianSource2.Register(null);
			}
		}
		return vtkImageGaussianSource2;
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSource_SetCenter_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the center of the Gaussian.
	/// </summary>
	public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
	{
		vtkImageGaussianSource_SetCenter_13(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSource_SetCenter_14(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the center of the Gaussian.
	/// </summary>
	public virtual void SetCenter(IntPtr _arg)
	{
		vtkImageGaussianSource_SetCenter_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSource_SetMaximum_15(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the Maximum value of the gaussian
	/// </summary>
	public virtual void SetMaximum(double _arg)
	{
		vtkImageGaussianSource_SetMaximum_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSource_SetStandardDeviation_16(HandleRef pThis, double _arg);

	/// <summary>
	/// Set/Get the standard deviation of the gaussian
	/// </summary>
	public virtual void SetStandardDeviation(double _arg)
	{
		vtkImageGaussianSource_SetStandardDeviation_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageGaussianSource_SetWholeExtent_17(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

	/// <summary>
	/// Set/Get the extent of the whole output image.
	/// </summary>
	public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
	{
		vtkImageGaussianSource_SetWholeExtent_17(GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
	}
}
