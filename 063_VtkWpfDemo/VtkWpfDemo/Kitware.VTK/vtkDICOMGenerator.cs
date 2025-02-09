using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMGenerator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMGenerator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMGenerator()
	{
		MRClassNameKey = "class vtkDICOMGenerator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMGenerator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMGenerator New()
	{
		vtkDICOMGenerator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMGenerator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDICOMGenerator_ExtendedOff_01(HandleRef pThis);

	public virtual void ExtendedOff()
	{
		vtkDICOMGenerator_ExtendedOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_ExtendedOn_02(HandleRef pThis);

	public virtual void ExtendedOn()
	{
		vtkDICOMGenerator_ExtendedOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMGenerator_GenerateInstance_03(HandleRef pThis, HandleRef arg0);

	public virtual bool GenerateInstance(vtkInformation arg0)
	{
		return (vtkDICOMGenerator_GenerateInstance_03(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_GetComponentIndexArray_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkIntArray GetComponentIndexArray()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_GetComponentIndexArray_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_GetExtended_05(HandleRef pThis);

	public virtual int GetExtended()
	{
		return vtkDICOMGenerator_GetExtended_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_GetMetaData_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMMetaData GetMetaData()
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_GetMetaData_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMMetaData2 = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMMetaData2.Register(null);
			}
		}
		return vtkDICOMMetaData2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_GetMultiFrame_07(HandleRef pThis);

	public virtual int GetMultiFrame()
	{
		return vtkDICOMGenerator_GetMultiFrame_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMGenerator_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMGenerator_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMGenerator_GetNumberOfGenerationsFromBaseType_09(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMGenerator_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_GetNumberOfOverlays_10(HandleRef pThis);

	public virtual int GetNumberOfOverlays()
	{
		return vtkDICOMGenerator_GetNumberOfOverlays_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_GetOriginAtBottom_11(HandleRef pThis);

	public virtual int GetOriginAtBottom()
	{
		return vtkDICOMGenerator_GetOriginAtBottom_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_GetPatientMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkMatrix4x4 GetPatientMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_GetPatientMatrix_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkDICOMGenerator_GetRescaleIntercept_13(HandleRef pThis);

	public virtual double GetRescaleIntercept()
	{
		return vtkDICOMGenerator_GetRescaleIntercept_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMGenerator_GetRescaleSlope_14(HandleRef pThis);

	public virtual double GetRescaleSlope()
	{
		return vtkDICOMGenerator_GetRescaleSlope_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_GetReverseSliceOrder_15(HandleRef pThis);

	public virtual int GetReverseSliceOrder()
	{
		return vtkDICOMGenerator_GetReverseSliceOrder_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_GetSliceIndexArray_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkIntArray GetSliceIndexArray()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_GetSliceIndexArray_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIntArray2 = (vtkIntArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIntArray2.Register(null);
			}
		}
		return vtkIntArray2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_GetSourceMetaData_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMMetaData GetSourceMetaData()
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_GetSourceMetaData_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMMetaData2 = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMMetaData2.Register(null);
			}
		}
		return vtkDICOMMetaData2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_GetTimeAsVector_18(HandleRef pThis);

	public virtual int GetTimeAsVector()
	{
		return vtkDICOMGenerator_GetTimeAsVector_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_GetTimeDimension_19(HandleRef pThis);

	public virtual int GetTimeDimension()
	{
		return vtkDICOMGenerator_GetTimeDimension_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMGenerator_GetTimeSpacing_20(HandleRef pThis);

	public virtual double GetTimeSpacing()
	{
		return vtkDICOMGenerator_GetTimeSpacing_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_GetUIDGenerator_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMUIDGenerator GetUIDGenerator()
	{
		vtkDICOMUIDGenerator vtkDICOMUIDGenerator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_GetUIDGenerator_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMUIDGenerator2 = (vtkDICOMUIDGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMUIDGenerator2.Register(null);
			}
		}
		return vtkDICOMUIDGenerator2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_IsA_22(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMGenerator_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMGenerator_IsTypeOf_23(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMGenerator_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_MultiFrameOff_24(HandleRef pThis);

	public virtual void MultiFrameOff()
	{
		vtkDICOMGenerator_MultiFrameOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_MultiFrameOn_25(HandleRef pThis);

	public virtual void MultiFrameOn()
	{
		vtkDICOMGenerator_MultiFrameOn_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_NewInstance_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMGenerator NewInstance()
	{
		vtkDICOMGenerator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_NewInstance_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMGenerator_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMGenerator SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMGenerator vtkDICOMGenerator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMGenerator_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMGenerator2 = (vtkDICOMGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMGenerator2.Register(null);
			}
		}
		return vtkDICOMGenerator2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetExtended_29(HandleRef pThis, int _arg);

	public virtual void SetExtended(int _arg)
	{
		vtkDICOMGenerator_SetExtended_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetMultiFrame_30(HandleRef pThis, int _arg);

	public virtual void SetMultiFrame(int _arg)
	{
		vtkDICOMGenerator_SetMultiFrame_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetNumberOfOverlays_31(HandleRef pThis, int _arg);

	public virtual void SetNumberOfOverlays(int _arg)
	{
		vtkDICOMGenerator_SetNumberOfOverlays_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetOriginAtBottom_32(HandleRef pThis, int _arg);

	public virtual void SetOriginAtBottom(int _arg)
	{
		vtkDICOMGenerator_SetOriginAtBottom_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetPatientMatrix_33(HandleRef pThis, HandleRef arg0);

	public void SetPatientMatrix(vtkMatrix4x4 arg0)
	{
		vtkDICOMGenerator_SetPatientMatrix_33(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetRescaleIntercept_34(HandleRef pThis, double _arg);

	public virtual void SetRescaleIntercept(double _arg)
	{
		vtkDICOMGenerator_SetRescaleIntercept_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetRescaleSlope_35(HandleRef pThis, double _arg);

	public virtual void SetRescaleSlope(double _arg)
	{
		vtkDICOMGenerator_SetRescaleSlope_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetReverseSliceOrder_36(HandleRef pThis, int _arg);

	public virtual void SetReverseSliceOrder(int _arg)
	{
		vtkDICOMGenerator_SetReverseSliceOrder_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetSourceMetaData_37(HandleRef pThis, HandleRef arg0);

	public void SetSourceMetaData(vtkDICOMMetaData arg0)
	{
		vtkDICOMGenerator_SetSourceMetaData_37(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetTimeAsVector_38(HandleRef pThis, int _arg);

	public virtual void SetTimeAsVector(int _arg)
	{
		vtkDICOMGenerator_SetTimeAsVector_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetTimeDimension_39(HandleRef pThis, int _arg);

	public virtual void SetTimeDimension(int _arg)
	{
		vtkDICOMGenerator_SetTimeDimension_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetTimeSpacing_40(HandleRef pThis, double _arg);

	public virtual void SetTimeSpacing(double _arg)
	{
		vtkDICOMGenerator_SetTimeSpacing_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_SetUIDGenerator_41(HandleRef pThis, HandleRef arg0);

	public void SetUIDGenerator(vtkDICOMUIDGenerator arg0)
	{
		vtkDICOMGenerator_SetUIDGenerator_41(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_TimeAsVectorOff_42(HandleRef pThis);

	public virtual void TimeAsVectorOff()
	{
		vtkDICOMGenerator_TimeAsVectorOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMGenerator_TimeAsVectorOn_43(HandleRef pThis);

	public virtual void TimeAsVectorOn()
	{
		vtkDICOMGenerator_TimeAsVectorOn_43(GetCppThis());
	}
}
