using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageInterpolator
/// </summary>
/// <remarks>
///    interpolate data values from images
///
/// vtkImageInterpolator provides a simple interface for interpolating image
/// data.  It provides linear, cubic, and nearest-neighbor interpolation.
/// @par Thanks:
/// Thanks to David Gobbi at the Seaman Family MR Centre and Dept. of Clinical
/// Neurosciences, Foothills Medical Centre, Calgary, for providing this class.
/// </remarks>
/// <seealso>
///
/// vtkImageReslice
/// </seealso>
public class vtkImageInterpolator : vtkAbstractImageInterpolator
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageInterpolator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageInterpolator()
	{
		MRClassNameKey = "class vtkImageInterpolator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageInterpolator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageInterpolator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageInterpolator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageInterpolator New()
	{
		vtkImageInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageInterpolator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageInterpolator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageInterpolator_ComputeSupportSize_01(HandleRef pThis, IntPtr matrix, IntPtr size);

	/// <summary>
	/// Get the support size for use in computing update extents.  If the data
	/// will be sampled on a regular grid, then pass a matrix describing the
	/// structured coordinate transformation between the output and the input.
	/// Otherwise, pass nullptr as the matrix to retrieve the full kernel size.
	/// </summary>
	public override void ComputeSupportSize(IntPtr matrix, IntPtr size)
	{
		vtkImageInterpolator_ComputeSupportSize_01(GetCppThis(), matrix, size);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageInterpolator_GetInterpolationMode_02(HandleRef pThis);

	/// <summary>
	/// The interpolation mode for point scalars (default: linear).  Subclasses
	/// will provide additional interpolation modes, so this is a virtual method.
	/// </summary>
	public int GetInterpolationMode()
	{
		return vtkImageInterpolator_GetInterpolationMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageInterpolator_GetInterpolationModeAsString_03(HandleRef pThis);

	/// <summary>
	/// The interpolation mode for point scalars (default: linear).  Subclasses
	/// will provide additional interpolation modes, so this is a virtual method.
	/// </summary>
	public virtual string GetInterpolationModeAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageInterpolator_GetInterpolationModeAsString_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageInterpolator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageInterpolator_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageInterpolator_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageInterpolator_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageInterpolator_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageInterpolator_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkImageInterpolator_IsSeparable_07(HandleRef pThis);

	/// <summary>
	/// Returns true if the interpolator supports weight precomputation.
	/// This will always return true for this interpolator.
	/// </summary>
	public override bool IsSeparable()
	{
		return (vtkImageInterpolator_IsSeparable_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageInterpolator_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageInterpolator_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageInterpolator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageInterpolator NewInstance()
	{
		vtkImageInterpolator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageInterpolator_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageInterpolator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageInterpolator SafeDownCast(vtkObjectBase o)
	{
		vtkImageInterpolator vtkImageInterpolator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageInterpolator_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageInterpolator2 = (vtkImageInterpolator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageInterpolator2.Register(null);
			}
		}
		return vtkImageInterpolator2;
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageInterpolator_SetInterpolationMode_12(HandleRef pThis, int mode);

	/// <summary>
	/// The interpolation mode for point scalars (default: linear).  Subclasses
	/// will provide additional interpolation modes, so this is a virtual method.
	/// </summary>
	public virtual void SetInterpolationMode(int mode)
	{
		vtkImageInterpolator_SetInterpolationMode_12(GetCppThis(), mode);
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageInterpolator_SetInterpolationModeToCubic_13(HandleRef pThis);

	/// <summary>
	/// The interpolation mode for point scalars (default: linear).  Subclasses
	/// will provide additional interpolation modes, so this is a virtual method.
	/// </summary>
	public void SetInterpolationModeToCubic()
	{
		vtkImageInterpolator_SetInterpolationModeToCubic_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageInterpolator_SetInterpolationModeToLinear_14(HandleRef pThis);

	/// <summary>
	/// The interpolation mode for point scalars (default: linear).  Subclasses
	/// will provide additional interpolation modes, so this is a virtual method.
	/// </summary>
	public void SetInterpolationModeToLinear()
	{
		vtkImageInterpolator_SetInterpolationModeToLinear_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageInterpolator_SetInterpolationModeToNearest_15(HandleRef pThis);

	/// <summary>
	/// The interpolation mode for point scalars (default: linear).  Subclasses
	/// will provide additional interpolation modes, so this is a virtual method.
	/// </summary>
	public void SetInterpolationModeToNearest()
	{
		vtkImageInterpolator_SetInterpolationModeToNearest_15(GetCppThis());
	}
}
