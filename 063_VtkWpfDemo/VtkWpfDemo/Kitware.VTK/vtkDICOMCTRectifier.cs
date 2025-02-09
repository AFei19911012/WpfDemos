using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkDICOMCTRectifier
/// \brief Prepare a CT for 3D processing
///
/// This class will identify gantry-tilted CT images and resample them
/// into a rectangular volume.  This is often a necessary step prior to
/// volume rendering or other forms of 3D rendering.
/// </summary>
public class vtkDICOMCTRectifier : vtkDICOMAlgorithm
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum Cubic_WrapperEnum
	{
		/// <summary>enum member</summary>
		Cubic = 2,
		/// <summary>enum member</summary>
		Linear = 1,
		/// <summary>enum member</summary>
		Nearest = 0,
		/// <summary>enum member</summary>
		WindowedSinc = 3
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMCTRectifier";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMCTRectifier()
	{
		MRClassNameKey = "class vtkDICOMCTRectifier";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMCTRectifier"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMCTRectifier(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCTRectifier_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDICOMCTRectifier New()
	{
		vtkDICOMCTRectifier result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCTRectifier_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMCTRectifier)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMCTRectifier()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMCTRectifier_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMCTRectifier_GetGantryDetectorTilt_01(HandleRef volumeMatrix);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public static double GetGantryDetectorTilt(vtkMatrix4x4 volumeMatrix)
	{
		return vtkDICOMCTRectifier_GetGantryDetectorTilt_01(volumeMatrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMCTRectifier_GetInterpolationMode_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetInterpolationMode()
	{
		return vtkDICOMCTRectifier_GetInterpolationMode_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMCTRectifier_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMCTRectifier_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMCTRectifier_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMCTRectifier_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCTRectifier_GetRectifiedMatrix_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrix4x4 GetRectifiedMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCTRectifier_GetRectifiedMatrix_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMCTRectifier_GetReverse_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetReverse()
	{
		return vtkDICOMCTRectifier_GetReverse_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCTRectifier_GetVolumeMatrix_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrix4x4 GetVolumeMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCTRectifier_GetVolumeMatrix_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMatrix4x5 = (vtkMatrix4x4)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMatrix4x5.Register(null);
			}
		}
		return vtkMatrix4x5;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMCTRectifier_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDICOMCTRectifier_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMCTRectifier_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDICOMCTRectifier_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCTRectifier_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDICOMCTRectifier NewInstance()
	{
		vtkDICOMCTRectifier result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCTRectifier_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMCTRectifier)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_ReverseOff_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void ReverseOff()
	{
		vtkDICOMCTRectifier_ReverseOff_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_ReverseOn_13(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void ReverseOn()
	{
		vtkDICOMCTRectifier_ReverseOn_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMCTRectifier_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDICOMCTRectifier SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMCTRectifier vtkDICOMCTRectifier2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMCTRectifier_SafeDownCast_14(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMCTRectifier2 = (vtkDICOMCTRectifier)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMCTRectifier2.Register(null);
			}
		}
		return vtkDICOMCTRectifier2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_SetInterpolationMode_15(HandleRef pThis, int t);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInterpolationMode(int t)
	{
		vtkDICOMCTRectifier_SetInterpolationMode_15(GetCppThis(), t);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_SetInterpolationModeToCubic_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInterpolationModeToCubic()
	{
		vtkDICOMCTRectifier_SetInterpolationModeToCubic_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_SetInterpolationModeToLinear_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInterpolationModeToLinear()
	{
		vtkDICOMCTRectifier_SetInterpolationModeToLinear_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_SetInterpolationModeToNearest_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInterpolationModeToNearest()
	{
		vtkDICOMCTRectifier_SetInterpolationModeToNearest_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_SetInterpolationModeToWindowedSinc_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetInterpolationModeToWindowedSinc()
	{
		vtkDICOMCTRectifier_SetInterpolationModeToWindowedSinc_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_SetReverse_20(HandleRef pThis, int v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetReverse(int v)
	{
		vtkDICOMCTRectifier_SetReverse_20(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_SetVolumeMatrix_21(HandleRef pThis, HandleRef matrix);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetVolumeMatrix(vtkMatrix4x4 matrix)
	{
		vtkDICOMCTRectifier_SetVolumeMatrix_21(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMCTRectifier_UpdateMatrix_22(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void UpdateMatrix()
	{
		vtkDICOMCTRectifier_UpdateMatrix_22(GetCppThis());
	}
}
