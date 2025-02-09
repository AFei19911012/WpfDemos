using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
/// \class vtkDICOMWriter
/// \brief Write DICOM image files.
///
/// This class writes a series of one or more DICOM files.  The default
/// behavior is to write a series of Secondary Capture files with no
/// modality-specific information.  To write other kinds of DICOM files,
/// use the SetGenerator() method to supply a generator for the type of
/// data set that you wish to write.  Currently, there are generators for
/// MR and CT data sets.
/// </summary>
public class vtkDICOMWriter : vtkImageWriter
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum RowOrder
	{
		/// <summary>enum member</summary>
		BottomUp = 2,
		/// <summary>enum member</summary>
		FileNative = 0,
		/// <summary>enum member</summary>
		TopDown = 1
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum SliceOrder
	{
		/// <summary>enum member</summary>
		LHR = 1,
		/// <summary>enum member</summary>
		RHR = 0,
		/// <summary>enum member</summary>
		Reverse = 3,
		/// <summary>enum member</summary>
		Same = 2
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMWriter()
	{
		MRClassNameKey = "class vtkDICOMWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDICOMWriter New()
	{
		vtkDICOMWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDICOMWriter_GetFileSliceOrder_01(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetFileSliceOrder()
	{
		return vtkDICOMWriter_GetFileSliceOrder_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_GetFileSliceOrderAsString_02(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetFileSliceOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMWriter_GetFileSliceOrderAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_GetGenerator_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMGenerator GetGenerator()
	{
		vtkDICOMGenerator vtkDICOMGenerator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMWriter_GetGenerator_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDICOMWriter_GetImageType_04(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetImageType()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMWriter_GetImageType_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMWriter_GetMemoryRowOrder_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public int GetMemoryRowOrder()
	{
		return vtkDICOMWriter_GetMemoryRowOrder_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_GetMemoryRowOrderAsString_06(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public string GetMemoryRowOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMWriter_GetMemoryRowOrderAsString_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_GetMetaData_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDICOMMetaData GetMetaData()
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMWriter_GetMetaData_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDICOMWriter_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMWriter_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMWriter_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMWriter_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_GetOverlayInput_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageData GetOverlayInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMWriter_GetOverlayInput_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMWriter_GetOverlayType_11(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetOverlayType()
	{
		return vtkDICOMWriter_GetOverlayType_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_GetPatientMatrix_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMatrix4x4 GetPatientMatrix()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMWriter_GetPatientMatrix_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern double vtkDICOMWriter_GetRescaleIntercept_13(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double GetRescaleIntercept()
	{
		return vtkDICOMWriter_GetRescaleIntercept_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMWriter_GetRescaleSlope_14(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double GetRescaleSlope()
	{
		return vtkDICOMWriter_GetRescaleSlope_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_GetSeriesDescription_15(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetSeriesDescription()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMWriter_GetSeriesDescription_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMWriter_GetStreaming_16(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetStreaming()
	{
		return vtkDICOMWriter_GetStreaming_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMWriter_GetTimeAsVector_17(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetTimeAsVector()
	{
		return vtkDICOMWriter_GetTimeAsVector_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMWriter_GetTimeDimension_18(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual int GetTimeDimension()
	{
		return vtkDICOMWriter_GetTimeDimension_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkDICOMWriter_GetTimeSpacing_19(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual double GetTimeSpacing()
	{
		return vtkDICOMWriter_GetTimeSpacing_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_GetTransferSyntaxUID_20(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetTransferSyntaxUID()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMWriter_GetTransferSyntaxUID_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMWriter_IsA_21(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDICOMWriter_IsA_21(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMWriter_IsTypeOf_22(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDICOMWriter_IsTypeOf_22(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_NewInstance_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDICOMWriter NewInstance()
	{
		vtkDICOMWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMWriter_NewInstance_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMWriter_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDICOMWriter SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMWriter vtkDICOMWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMWriter_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMWriter2 = (vtkDICOMWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMWriter2.Register(null);
			}
		}
		return vtkDICOMWriter2;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetFileSliceOrder_26(HandleRef pThis, int order);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetFileSliceOrder(int order)
	{
		vtkDICOMWriter_SetFileSliceOrder_26(GetCppThis(), order);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetFileSliceOrderToLHR_27(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetFileSliceOrderToLHR()
	{
		vtkDICOMWriter_SetFileSliceOrderToLHR_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetFileSliceOrderToRHR_28(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetFileSliceOrderToRHR()
	{
		vtkDICOMWriter_SetFileSliceOrderToRHR_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetFileSliceOrderToReverse_29(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetFileSliceOrderToReverse()
	{
		vtkDICOMWriter_SetFileSliceOrderToReverse_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetFileSliceOrderToSame_30(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetFileSliceOrderToSame()
	{
		vtkDICOMWriter_SetFileSliceOrderToSame_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetGenerator_31(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetGenerator(vtkDICOMGenerator arg0)
	{
		vtkDICOMWriter_SetGenerator_31(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetImageType_32(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetImageType(string _arg)
	{
		vtkDICOMWriter_SetImageType_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetMemoryRowOrder_33(HandleRef pThis, int order);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMemoryRowOrder(int order)
	{
		vtkDICOMWriter_SetMemoryRowOrder_33(GetCppThis(), order);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetMemoryRowOrderToBottomUp_34(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMemoryRowOrderToBottomUp()
	{
		vtkDICOMWriter_SetMemoryRowOrderToBottomUp_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetMemoryRowOrderToFileNative_35(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMemoryRowOrderToFileNative()
	{
		vtkDICOMWriter_SetMemoryRowOrderToFileNative_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetMemoryRowOrderToTopDown_36(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMemoryRowOrderToTopDown()
	{
		vtkDICOMWriter_SetMemoryRowOrderToTopDown_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetMetaData_37(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetMetaData(vtkDICOMMetaData arg0)
	{
		vtkDICOMWriter_SetMetaData_37(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetOverlayInputConnection_38(HandleRef pThis, HandleRef data);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetOverlayInputConnection(vtkAlgorithmOutput data)
	{
		vtkDICOMWriter_SetOverlayInputConnection_38(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetOverlayInputData_39(HandleRef pThis, HandleRef data);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetOverlayInputData(vtkImageData data)
	{
		vtkDICOMWriter_SetOverlayInputData_39(GetCppThis(), data?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetOverlayType_40(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetOverlayType(int _arg)
	{
		vtkDICOMWriter_SetOverlayType_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetOverlayTypeToGraphics_41(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetOverlayTypeToGraphics()
	{
		vtkDICOMWriter_SetOverlayTypeToGraphics_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetOverlayTypeToROI_42(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetOverlayTypeToROI()
	{
		vtkDICOMWriter_SetOverlayTypeToROI_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetPatientMatrix_43(HandleRef pThis, HandleRef arg0);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public void SetPatientMatrix(vtkMatrix4x4 arg0)
	{
		vtkDICOMWriter_SetPatientMatrix_43(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetRescaleIntercept_44(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetRescaleIntercept(double _arg)
	{
		vtkDICOMWriter_SetRescaleIntercept_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetRescaleSlope_45(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetRescaleSlope(double _arg)
	{
		vtkDICOMWriter_SetRescaleSlope_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetSeriesDescription_46(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetSeriesDescription(string _arg)
	{
		vtkDICOMWriter_SetSeriesDescription_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetStreaming_47(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetStreaming(int _arg)
	{
		vtkDICOMWriter_SetStreaming_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetTimeAsVector_48(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTimeAsVector(int _arg)
	{
		vtkDICOMWriter_SetTimeAsVector_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetTimeDimension_49(HandleRef pThis, int _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTimeDimension(int _arg)
	{
		vtkDICOMWriter_SetTimeDimension_49(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetTimeSpacing_50(HandleRef pThis, double _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTimeSpacing(double _arg)
	{
		vtkDICOMWriter_SetTimeSpacing_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_SetTransferSyntaxUID_51(HandleRef pThis, string _arg);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetTransferSyntaxUID(string _arg)
	{
		vtkDICOMWriter_SetTransferSyntaxUID_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_StreamingOff_52(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void StreamingOff()
	{
		vtkDICOMWriter_StreamingOff_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_StreamingOn_53(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void StreamingOn()
	{
		vtkDICOMWriter_StreamingOn_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_TimeAsVectorOff_54(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void TimeAsVectorOff()
	{
		vtkDICOMWriter_TimeAsVectorOff_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_TimeAsVectorOn_55(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void TimeAsVectorOn()
	{
		vtkDICOMWriter_TimeAsVectorOn_55(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMWriter_Write_56(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override void Write()
	{
		vtkDICOMWriter_Write_56(GetCppThis());
	}
}
