using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMSliceSorter : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMSliceSorter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMSliceSorter()
	{
		MRClassNameKey = "class vtkDICOMSliceSorter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMSliceSorter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMSliceSorter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSliceSorter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMSliceSorter New()
	{
		vtkDICOMSliceSorter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMSliceSorter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMSliceSorter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMSliceSorter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDICOMSliceSorter_GetDesiredStackID_01(HandleRef pThis);

	public string GetDesiredStackID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMSliceSorter_GetDesiredStackID_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSliceSorter_GetDesiredTimeIndex_02(HandleRef pThis);

	public virtual int GetDesiredTimeIndex()
	{
		return vtkDICOMSliceSorter_GetDesiredTimeIndex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSliceSorter_GetFileIndexArray_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkIntArray GetFileIndexArray()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_GetFileIndexArray_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDICOMSliceSorter_GetFrameIndexArray_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkIntArray GetFrameIndexArray()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_GetFrameIndexArray_04(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDICOMSliceSorter_GetMetaData_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMMetaData GetMetaData()
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_GetMetaData_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDICOMSliceSorter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMSliceSorter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMSliceSorter_GetNumberOfGenerationsFromBaseType_07(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMSliceSorter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSliceSorter_GetRepeatsAsTime_08(HandleRef pThis);

	public virtual int GetRepeatsAsTime()
	{
		return vtkDICOMSliceSorter_GetRepeatsAsTime_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSliceSorter_GetReverseSlices_09(HandleRef pThis);

	public virtual int GetReverseSlices()
	{
		return vtkDICOMSliceSorter_GetReverseSlices_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMSliceSorter_GetSliceSpacing_10(HandleRef pThis);

	public double GetSliceSpacing()
	{
		return vtkDICOMSliceSorter_GetSliceSpacing_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSliceSorter_GetStackIDs_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkStringArray GetStackIDs()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_GetStackIDs_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkStringArray2 = (vtkStringArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkStringArray2.Register(null);
			}
		}
		return vtkStringArray2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSliceSorter_GetTimeAsVector_12(HandleRef pThis);

	public virtual int GetTimeAsVector()
	{
		return vtkDICOMSliceSorter_GetTimeAsVector_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSliceSorter_GetTimeDimension_13(HandleRef pThis);

	public int GetTimeDimension()
	{
		return vtkDICOMSliceSorter_GetTimeDimension_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSliceSorter_GetTimeSequence_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag GetTimeSequence()
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_GetTimeSequence_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMSliceSorter_GetTimeSpacing_15(HandleRef pThis);

	public double GetTimeSpacing()
	{
		return vtkDICOMSliceSorter_GetTimeSpacing_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSliceSorter_GetTimeTag_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag GetTimeTag()
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_GetTimeTag_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSliceSorter_IsA_17(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMSliceSorter_IsA_17(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSliceSorter_IsTypeOf_18(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMSliceSorter_IsTypeOf_18(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSliceSorter_NewInstance_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMSliceSorter NewInstance()
	{
		vtkDICOMSliceSorter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_NewInstance_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMSliceSorter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_RepeatsAsTimeOff_21(HandleRef pThis);

	public virtual void RepeatsAsTimeOff()
	{
		vtkDICOMSliceSorter_RepeatsAsTimeOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_RepeatsAsTimeOn_22(HandleRef pThis);

	public virtual void RepeatsAsTimeOn()
	{
		vtkDICOMSliceSorter_RepeatsAsTimeOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_ReverseSlicesOff_23(HandleRef pThis);

	public virtual void ReverseSlicesOff()
	{
		vtkDICOMSliceSorter_ReverseSlicesOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_ReverseSlicesOn_24(HandleRef pThis);

	public virtual void ReverseSlicesOn()
	{
		vtkDICOMSliceSorter_ReverseSlicesOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSliceSorter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMSliceSorter SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMSliceSorter vtkDICOMSliceSorter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSliceSorter_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMSliceSorter2 = (vtkDICOMSliceSorter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMSliceSorter2.Register(null);
			}
		}
		return vtkDICOMSliceSorter2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_SetDesiredStackID_26(HandleRef pThis, string stackId);

	public void SetDesiredStackID(string stackId)
	{
		vtkDICOMSliceSorter_SetDesiredStackID_26(GetCppThis(), stackId);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_SetDesiredTimeIndex_27(HandleRef pThis, int _arg);

	public virtual void SetDesiredTimeIndex(int _arg)
	{
		vtkDICOMSliceSorter_SetDesiredTimeIndex_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_SetMetaData_28(HandleRef pThis, HandleRef meta);

	public void SetMetaData(vtkDICOMMetaData meta)
	{
		vtkDICOMSliceSorter_SetMetaData_28(GetCppThis(), meta?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_SetRepeatsAsTime_29(HandleRef pThis, int _arg);

	public virtual void SetRepeatsAsTime(int _arg)
	{
		vtkDICOMSliceSorter_SetRepeatsAsTime_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_SetReverseSlices_30(HandleRef pThis, int _arg);

	public virtual void SetReverseSlices(int _arg)
	{
		vtkDICOMSliceSorter_SetReverseSlices_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_SetTimeAsVector_31(HandleRef pThis, int _arg);

	public virtual void SetTimeAsVector(int _arg)
	{
		vtkDICOMSliceSorter_SetTimeAsVector_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_SetTimeSequence_32(HandleRef pThis, HandleRef tag);

	public void SetTimeSequence(vtkDICOMTag tag)
	{
		vtkDICOMSliceSorter_SetTimeSequence_32(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_SetTimeTag_33(HandleRef pThis, HandleRef tag);

	public void SetTimeTag(vtkDICOMTag tag)
	{
		vtkDICOMSliceSorter_SetTimeTag_33(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_TimeAsVectorOff_34(HandleRef pThis);

	public virtual void TimeAsVectorOff()
	{
		vtkDICOMSliceSorter_TimeAsVectorOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_TimeAsVectorOn_35(HandleRef pThis);

	public virtual void TimeAsVectorOn()
	{
		vtkDICOMSliceSorter_TimeAsVectorOn_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMSliceSorter_Update_36(HandleRef pThis);

	public void Update()
	{
		vtkDICOMSliceSorter_Update_36(GetCppThis());
	}
}
