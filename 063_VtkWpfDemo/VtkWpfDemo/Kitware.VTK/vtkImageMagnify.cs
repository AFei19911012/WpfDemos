using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageMagnify
/// </summary>
/// <remarks>
///    magnify an image by an integer value
///
/// vtkImageMagnify maps each pixel of the input onto a nxmx... region
/// of the output.  Location (0,0,...) remains in the same place. The
/// magnification occurs via pixel replication, or if Interpolate is on,
/// by bilinear interpolation. Initially, interpolation is off and magnification
/// factors are set to 1 in all directions.
/// </remarks>
public class vtkImageMagnify : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageMagnify";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageMagnify()
	{
		MRClassNameKey = "class vtkImageMagnify";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMagnify"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageMagnify(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMagnify_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMagnify New()
	{
		vtkImageMagnify result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMagnify_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageMagnify()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageMagnify_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageMagnify_GetInterpolate_01(HandleRef pThis);

	/// <summary>
	/// Turn interpolation on and off (pixel replication is used when off).
	/// Initially, interpolation is off.
	/// </summary>
	public virtual int GetInterpolate()
	{
		return vtkImageMagnify_GetInterpolate_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMagnify_GetMagnificationFactors_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the integer magnification factors in the i-j-k directions.
	/// Initially, factors are set to 1 in all directions.
	/// </summary>
	public virtual int[] GetMagnificationFactors()
	{
		IntPtr intPtr = vtkImageMagnify_GetMagnificationFactors_02(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMagnify_GetMagnificationFactors_03(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

	/// <summary>
	/// Set/Get the integer magnification factors in the i-j-k directions.
	/// Initially, factors are set to 1 in all directions.
	/// </summary>
	public virtual void GetMagnificationFactors(ref int _arg1, ref int _arg2, ref int _arg3)
	{
		vtkImageMagnify_GetMagnificationFactors_03(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMagnify_GetMagnificationFactors_04(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the integer magnification factors in the i-j-k directions.
	/// Initially, factors are set to 1 in all directions.
	/// </summary>
	public virtual void GetMagnificationFactors(IntPtr _arg)
	{
		vtkImageMagnify_GetMagnificationFactors_04(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMagnify_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageMagnify_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageMagnify_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageMagnify_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMagnify_InterpolateOff_07(HandleRef pThis);

	/// <summary>
	/// Turn interpolation on and off (pixel replication is used when off).
	/// Initially, interpolation is off.
	/// </summary>
	public virtual void InterpolateOff()
	{
		vtkImageMagnify_InterpolateOff_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMagnify_InterpolateOn_08(HandleRef pThis);

	/// <summary>
	/// Turn interpolation on and off (pixel replication is used when off).
	/// Initially, interpolation is off.
	/// </summary>
	public virtual void InterpolateOn()
	{
		vtkImageMagnify_InterpolateOn_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMagnify_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageMagnify_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageMagnify_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageMagnify_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMagnify_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageMagnify NewInstance()
	{
		vtkImageMagnify result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMagnify_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageMagnify_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageMagnify SafeDownCast(vtkObjectBase o)
	{
		vtkImageMagnify vtkImageMagnify2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageMagnify_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageMagnify2 = (vtkImageMagnify)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageMagnify2.Register(null);
			}
		}
		return vtkImageMagnify2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMagnify_SetInterpolate_14(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn interpolation on and off (pixel replication is used when off).
	/// Initially, interpolation is off.
	/// </summary>
	public virtual void SetInterpolate(int _arg)
	{
		vtkImageMagnify_SetInterpolate_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMagnify_SetMagnificationFactors_15(HandleRef pThis, int _arg1, int _arg2, int _arg3);

	/// <summary>
	/// Set/Get the integer magnification factors in the i-j-k directions.
	/// Initially, factors are set to 1 in all directions.
	/// </summary>
	public virtual void SetMagnificationFactors(int _arg1, int _arg2, int _arg3)
	{
		vtkImageMagnify_SetMagnificationFactors_15(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageMagnify_SetMagnificationFactors_16(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the integer magnification factors in the i-j-k directions.
	/// Initially, factors are set to 1 in all directions.
	/// </summary>
	public virtual void SetMagnificationFactors(IntPtr _arg)
	{
		vtkImageMagnify_SetMagnificationFactors_16(GetCppThis(), _arg);
	}
}
