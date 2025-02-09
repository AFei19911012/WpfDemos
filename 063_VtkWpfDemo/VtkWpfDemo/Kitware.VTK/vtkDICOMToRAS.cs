using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkDICOMToRAS
/// \brief Convert DICOM orientation to RAS orientation
///
/// This class will modify an image and its position-and-orientation matrix
/// so that the patient coordinate system follows the conventions of NIFTI
/// and MINC, i.e. the x, y, and z axes will point in the right, anterior,
/// and superior directions respectively.  Optionally, the row and column
/// ordering of the image will also be modified so that the row direction
/// preferentially points right or anterior, and the column direction
/// preferentially points superior or anterior.
/// </summary>
public class vtkDICOMToRAS : vtkThreadedImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMToRAS";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMToRAS()
	{
		MRClassNameKey = "class vtkDICOMToRAS";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMToRAS"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMToRAS(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMToRAS_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDICOMToRAS New()
	{
		vtkDICOMToRAS result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMToRAS_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMToRAS)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMToRAS()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMToRAS_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDICOMToRAS_AllowColumnReorderingOff_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void AllowColumnReorderingOff()
	{
		vtkDICOMToRAS_AllowColumnReorderingOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_AllowColumnReorderingOn_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void AllowColumnReorderingOn()
	{
		vtkDICOMToRAS_AllowColumnReorderingOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_AllowRowReorderingOff_03(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void AllowRowReorderingOff()
	{
		vtkDICOMToRAS_AllowRowReorderingOff_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_AllowRowReorderingOn_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void AllowRowReorderingOn()
	{
		vtkDICOMToRAS_AllowRowReorderingOn_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMToRAS_GetAllowColumnReordering_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetAllowColumnReordering()
	{
		return vtkDICOMToRAS_GetAllowColumnReordering_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMToRAS_GetAllowRowReordering_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetAllowRowReordering()
	{
		return vtkDICOMToRAS_GetAllowRowReordering_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMToRAS_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMToRAS_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMToRAS_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMToRAS_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMToRAS_GetPatientMatrix_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrix4x4 GetPatientMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMToRAS_GetPatientMatrix_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDICOMToRAS_GetRASMatrix_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrix4x4 GetRASMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMToRAS_GetRASMatrix_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDICOMToRAS_GetRASMatrixHasPosition_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetRASMatrixHasPosition()
	{
		return vtkDICOMToRAS_GetRASMatrixHasPosition_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMToRAS_GetRASToDICOM_12(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetRASToDICOM()
	{
		return vtkDICOMToRAS_GetRASToDICOM_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMToRAS_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDICOMToRAS_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMToRAS_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDICOMToRAS_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMToRAS_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDICOMToRAS NewInstance()
	{
		vtkDICOMToRAS result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMToRAS_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMToRAS)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_RASMatrixHasPositionOff_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void RASMatrixHasPositionOff()
	{
		vtkDICOMToRAS_RASMatrixHasPositionOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_RASMatrixHasPositionOn_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void RASMatrixHasPositionOn()
	{
		vtkDICOMToRAS_RASMatrixHasPositionOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_RASToDICOMOff_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void RASToDICOMOff()
	{
		vtkDICOMToRAS_RASToDICOMOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_RASToDICOMOn_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void RASToDICOMOn()
	{
		vtkDICOMToRAS_RASToDICOMOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMToRAS_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDICOMToRAS SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMToRAS vtkDICOMToRAS2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMToRAS_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMToRAS2 = (vtkDICOMToRAS)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMToRAS2.Register(null);
			}
		}
		return vtkDICOMToRAS2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_SetAllowColumnReordering_22(HandleRef pThis, int v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetAllowColumnReordering(int v)
	{
		vtkDICOMToRAS_SetAllowColumnReordering_22(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_SetAllowRowReordering_23(HandleRef pThis, int v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetAllowRowReordering(int v)
	{
		vtkDICOMToRAS_SetAllowRowReordering_23(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_SetPatientMatrix_24(HandleRef pThis, HandleRef matrix);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetPatientMatrix(vtkMatrix4x4 matrix)
	{
		vtkDICOMToRAS_SetPatientMatrix_24(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_SetRASMatrix_25(HandleRef pThis, HandleRef matrix);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetRASMatrix(vtkMatrix4x4 matrix)
	{
		vtkDICOMToRAS_SetRASMatrix_25(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_SetRASMatrixHasPosition_26(HandleRef pThis, int v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetRASMatrixHasPosition(int v)
	{
		vtkDICOMToRAS_SetRASMatrixHasPosition_26(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_SetRASToDICOM_27(HandleRef pThis, int v);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetRASToDICOM(int v)
	{
		vtkDICOMToRAS_SetRASToDICOM_27(GetCppThis(), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMToRAS_UpdateMatrix_28(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void UpdateMatrix()
	{
		vtkDICOMToRAS_UpdateMatrix_28(GetCppThis());
	}
}
