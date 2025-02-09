using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPolyDataToImageStencil
/// </summary>
/// <remarks>
///    use polydata to mask an image
///
/// The vtkPolyDataToImageStencil class will convert polydata into
/// an image stencil.  The polydata can either be a closed surface
/// mesh or a series of polyline contours (one contour per slice).
/// @warning
/// If contours are provided, the contours must be aligned with the
/// Z planes.  Other contour orientations are not supported.
/// </remarks>
/// <seealso>
///
/// vtkImageStencil vtkImageAccumulate vtkImageBlend vtkImageReslice
/// </seealso>
public class vtkPolyDataToImageStencil : vtkImageStencilSource
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataToImageStencil";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPolyDataToImageStencil()
	{
		MRClassNameKey = "class vtkPolyDataToImageStencil";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataToImageStencil"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPolyDataToImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataToImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataToImageStencil New()
	{
		vtkPolyDataToImageStencil result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataToImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPolyDataToImageStencil()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPolyDataToImageStencil_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataToImageStencil_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the implicit function to convert into a stencil.
	/// </summary>
	public vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataToImageStencil_GetInput_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataToImageStencil_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPolyDataToImageStencil_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPolyDataToImageStencil_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPolyDataToImageStencil_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataToImageStencil_GetTolerance_04(HandleRef pThis);

	/// <summary>
	/// The tolerance for including a voxel inside the stencil.
	/// This is in fractions of a voxel, and must be between 0 and 1.
	/// Tolerance is only applied in the x and y directions, not in z.
	/// Setting the tolerance to zero disables all tolerance checks and
	/// might result in faster performance.
	/// </summary>
	public virtual double GetTolerance()
	{
		return vtkPolyDataToImageStencil_GetTolerance_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataToImageStencil_GetToleranceMaxValue_05(HandleRef pThis);

	/// <summary>
	/// The tolerance for including a voxel inside the stencil.
	/// This is in fractions of a voxel, and must be between 0 and 1.
	/// Tolerance is only applied in the x and y directions, not in z.
	/// Setting the tolerance to zero disables all tolerance checks and
	/// might result in faster performance.
	/// </summary>
	public virtual double GetToleranceMaxValue()
	{
		return vtkPolyDataToImageStencil_GetToleranceMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkPolyDataToImageStencil_GetToleranceMinValue_06(HandleRef pThis);

	/// <summary>
	/// The tolerance for including a voxel inside the stencil.
	/// This is in fractions of a voxel, and must be between 0 and 1.
	/// Tolerance is only applied in the x and y directions, not in z.
	/// Setting the tolerance to zero disables all tolerance checks and
	/// might result in faster performance.
	/// </summary>
	public virtual double GetToleranceMinValue()
	{
		return vtkPolyDataToImageStencil_GetToleranceMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataToImageStencil_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPolyDataToImageStencil_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPolyDataToImageStencil_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPolyDataToImageStencil_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataToImageStencil_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPolyDataToImageStencil NewInstance()
	{
		vtkPolyDataToImageStencil result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataToImageStencil_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPolyDataToImageStencil_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPolyDataToImageStencil SafeDownCast(vtkObjectBase o)
	{
		vtkPolyDataToImageStencil vtkPolyDataToImageStencil2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPolyDataToImageStencil_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyDataToImageStencil2 = (vtkPolyDataToImageStencil)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyDataToImageStencil2.Register(null);
			}
		}
		return vtkPolyDataToImageStencil2;
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataToImageStencil_SetInputData_12(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the implicit function to convert into a stencil.
	/// </summary>
	public virtual void SetInputData(vtkPolyData arg0)
	{
		vtkPolyDataToImageStencil_SetInputData_12(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPolyDataToImageStencil_SetTolerance_13(HandleRef pThis, double _arg);

	/// <summary>
	/// The tolerance for including a voxel inside the stencil.
	/// This is in fractions of a voxel, and must be between 0 and 1.
	/// Tolerance is only applied in the x and y directions, not in z.
	/// Setting the tolerance to zero disables all tolerance checks and
	/// might result in faster performance.
	/// </summary>
	public virtual void SetTolerance(double _arg)
	{
		vtkPolyDataToImageStencil_SetTolerance_13(GetCppThis(), _arg);
	}
}
