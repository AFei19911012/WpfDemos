using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMMetaData : vtkDataObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMMetaData";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMMetaData()
	{
		MRClassNameKey = "class vtkDICOMMetaData";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMMetaData"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMMetaData(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMMetaData New()
	{
		vtkDICOMMetaData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMMetaData()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMMetaData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDICOMMetaData_Begin_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMDataElementIterator Begin()
	{
		vtkDICOMDataElementIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_Begin_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Clear_02(HandleRef pThis);

	public void Clear()
	{
		vtkDICOMMetaData_Clear_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_CopyAttributes_03(HandleRef pThis, HandleRef source);

	public void CopyAttributes(vtkDICOMMetaData source)
	{
		vtkDICOMMetaData_CopyAttributes_03(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_DeepCopy_04(HandleRef pThis, HandleRef source);

	public override void DeepCopy(vtkDataObject source)
	{
		vtkDICOMMetaData_DeepCopy_04(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_End_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMDataElementIterator End()
	{
		vtkDICOMDataElementIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_End_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Erase_06(HandleRef pThis, HandleRef tag);

	public void Erase(vtkDICOMTag tag)
	{
		vtkDICOMMetaData_Erase_06(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_Find_07(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMDataElementIterator Find(vtkDICOMTag tag)
	{
		vtkDICOMDataElementIterator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_Find_07(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDataElementIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_FindDictEntry_08(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMDictEntry FindDictEntry(vtkDICOMTag tag)
	{
		vtkDICOMDictEntry result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_FindDictEntry_08(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMDictEntry)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMVR vtkDICOMMetaData_FindDictVR_09(HandleRef pThis, int idx, HandleRef tag);

	public vtkDICOMVR FindDictVR(int idx, vtkDICOMTag tag)
	{
		return vtkDICOMMetaData_FindDictVR_09(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_Get_10(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_Get_10(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_Get_11(HandleRef pThis, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(vtkDICOMTagPath p)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_Get_11(GetCppThis(), p, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_Get_12(HandleRef pThis, int idx, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(int idx, vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_Get_12(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_Get_13(HandleRef pThis, int idx, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(int idx, vtkDICOMTagPath p)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_Get_13(GetCppThis(), idx, p, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_Get_14(HandleRef pThis, int idx, int frame, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(int idx, int frame, vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_Get_14(GetCppThis(), idx, frame, tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_Get_15(HandleRef pThis, int idx, int frame, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(int idx, int frame, vtkDICOMTagPath p)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_Get_15(GetCppThis(), idx, frame, p, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_16(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_GetAttributeValue_16(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_17(HandleRef pThis, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(vtkDICOMTagPath p)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_GetAttributeValue_17(GetCppThis(), p, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_18(HandleRef pThis, int idx, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(int idx, vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_GetAttributeValue_18(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_19(HandleRef pThis, int idx, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(int idx, vtkDICOMTagPath p)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_GetAttributeValue_19(GetCppThis(), idx, p, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_20(HandleRef pThis, int idx, int frame, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(int idx, int frame, vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_GetAttributeValue_20(GetCppThis(), idx, frame, tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_GetAttributeValue_21(HandleRef pThis, int idx, int frame, vtkDICOMTagPath p, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(int idx, int frame, vtkDICOMTagPath p)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_GetAttributeValue_21(GetCppThis(), idx, frame, p, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMMetaData_GetFileIndex_22(HandleRef pThis, int sliceIdx, int compIdx, int numComps);

	public int GetFileIndex(int sliceIdx, int compIdx, int numComps)
	{
		return vtkDICOMMetaData_GetFileIndex_22(GetCppThis(), sliceIdx, compIdx, numComps);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMMetaData_GetFileIndex_23(HandleRef pThis, int sliceIdx);

	public int GetFileIndex(int sliceIdx)
	{
		return vtkDICOMMetaData_GetFileIndex_23(GetCppThis(), sliceIdx);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_GetFileIndexArray_24(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkIntArray GetFileIndexArray()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_GetFileIndexArray_24(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDICOMMetaData_GetFrameIndex_25(HandleRef pThis, int sliceIdx, int compIdx, int numComps);

	public int GetFrameIndex(int sliceIdx, int compIdx, int numComps)
	{
		return vtkDICOMMetaData_GetFrameIndex_25(GetCppThis(), sliceIdx, compIdx, numComps);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMMetaData_GetFrameIndex_26(HandleRef pThis, int sliceIdx);

	public int GetFrameIndex(int sliceIdx)
	{
		return vtkDICOMMetaData_GetFrameIndex_26(GetCppThis(), sliceIdx);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_GetFrameIndexArray_27(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkIntArray GetFrameIndexArray()
	{
		vtkIntArray vtkIntArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_GetFrameIndexArray_27(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDICOMMetaData_GetNumberOfDataElements_28(HandleRef pThis);

	public int GetNumberOfDataElements()
	{
		return vtkDICOMMetaData_GetNumberOfDataElements_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMMetaData_GetNumberOfGenerationsFromBase_29(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMMetaData_GetNumberOfGenerationsFromBase_29(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMMetaData_GetNumberOfGenerationsFromBaseType_30(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMMetaData_GetNumberOfGenerationsFromBaseType_30(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMMetaData_GetNumberOfInstances_31(HandleRef pThis);

	public int GetNumberOfInstances()
	{
		return vtkDICOMMetaData_GetNumberOfInstances_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMMetaData_Has_32(HandleRef pThis, HandleRef tag);

	public bool Has(vtkDICOMTag tag)
	{
		return (vtkDICOMMetaData_Has_32(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMMetaData_HasAttribute_33(HandleRef pThis, HandleRef tag);

	public bool HasAttribute(vtkDICOMTag tag)
	{
		return (vtkDICOMMetaData_HasAttribute_33(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Initialize_34(HandleRef pThis);

	public override void Initialize()
	{
		vtkDICOMMetaData_Initialize_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMMetaData_IsA_35(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMMetaData_IsA_35(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMMetaData_IsTypeOf_36(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMMetaData_IsTypeOf_36(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_MakeValueWithSpecificCharacterSet_37(HandleRef pThis, vtkDICOMVR vr, string v, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue MakeValueWithSpecificCharacterSet(vtkDICOMVR vr, string v)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_MakeValueWithSpecificCharacterSet_37(GetCppThis(), vr, v, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_NewInstance_39(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMMetaData NewInstance()
	{
		vtkDICOMMetaData result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_NewInstance_39(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMMetaData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_RemoveAttribute_40(HandleRef pThis, HandleRef tag);

	public void RemoveAttribute(vtkDICOMTag tag)
	{
		vtkDICOMMetaData_RemoveAttribute_40(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_ResolvePrivateTag_41(HandleRef pThis, HandleRef ptag, string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag ResolvePrivateTag(vtkDICOMTag ptag, string creator)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_ResolvePrivateTag_41(GetCppThis(), ptag?.GetCppThis() ?? default(HandleRef), creator, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_ResolvePrivateTag_42(HandleRef pThis, int idx, HandleRef ptag, string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag ResolvePrivateTag(int idx, vtkDICOMTag ptag, string creator)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_ResolvePrivateTag_42(GetCppThis(), idx, ptag?.GetCppThis() ?? default(HandleRef), creator, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_ResolvePrivateTagForWriting_43(HandleRef pThis, HandleRef ptag, string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag ResolvePrivateTagForWriting(vtkDICOMTag ptag, string creator)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_ResolvePrivateTagForWriting_43(GetCppThis(), ptag?.GetCppThis() ?? default(HandleRef), creator, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_ResolvePrivateTagForWriting_44(HandleRef pThis, int idx, HandleRef ptag, string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag ResolvePrivateTagForWriting(int idx, vtkDICOMTag ptag, string creator)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_ResolvePrivateTagForWriting_44(GetCppThis(), idx, ptag?.GetCppThis() ?? default(HandleRef), creator, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaData_SafeDownCast_45(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMMetaData SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMMetaData vtkDICOMMetaData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaData_SafeDownCast_45(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDICOMMetaData_Set_46(HandleRef pThis, int idx, HandleRef tag, HandleRef v);

	public void Set(int idx, vtkDICOMTag tag, vtkDICOMValue v)
	{
		vtkDICOMMetaData_Set_46(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_47(HandleRef pThis, int idx, HandleRef tag, double v);

	public void Set(int idx, vtkDICOMTag tag, double v)
	{
		vtkDICOMMetaData_Set_47(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_48(HandleRef pThis, int idx, HandleRef tag, string v);

	public void Set(int idx, vtkDICOMTag tag, string v)
	{
		vtkDICOMMetaData_Set_48(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_49(HandleRef pThis, HandleRef tag, HandleRef v);

	public void Set(vtkDICOMTag tag, vtkDICOMValue v)
	{
		vtkDICOMMetaData_Set_49(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_50(HandleRef pThis, HandleRef tag, double v);

	public void Set(vtkDICOMTag tag, double v)
	{
		vtkDICOMMetaData_Set_50(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_51(HandleRef pThis, HandleRef tag, string v);

	public void Set(vtkDICOMTag tag, string v)
	{
		vtkDICOMMetaData_Set_51(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_52(HandleRef pThis, int idx, vtkDICOMTagPath tag, HandleRef v);

	public void Set(int idx, vtkDICOMTagPath tag, vtkDICOMValue v)
	{
		vtkDICOMMetaData_Set_52(GetCppThis(), idx, tag, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_53(HandleRef pThis, int idx, vtkDICOMTagPath tag, double v);

	public void Set(int idx, vtkDICOMTagPath tag, double v)
	{
		vtkDICOMMetaData_Set_53(GetCppThis(), idx, tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_54(HandleRef pThis, int idx, vtkDICOMTagPath tag, string v);

	public void Set(int idx, vtkDICOMTagPath tag, string v)
	{
		vtkDICOMMetaData_Set_54(GetCppThis(), idx, tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_55(HandleRef pThis, vtkDICOMTagPath tag, HandleRef v);

	public void Set(vtkDICOMTagPath tag, vtkDICOMValue v)
	{
		vtkDICOMMetaData_Set_55(GetCppThis(), tag, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_56(HandleRef pThis, vtkDICOMTagPath tag, double v);

	public void Set(vtkDICOMTagPath tag, double v)
	{
		vtkDICOMMetaData_Set_56(GetCppThis(), tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_Set_57(HandleRef pThis, vtkDICOMTagPath tag, string v);

	public void Set(vtkDICOMTagPath tag, string v)
	{
		vtkDICOMMetaData_Set_57(GetCppThis(), tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_58(HandleRef pThis, int idx, HandleRef tag, HandleRef v);

	public void SetAttributeValue(int idx, vtkDICOMTag tag, vtkDICOMValue v)
	{
		vtkDICOMMetaData_SetAttributeValue_58(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_59(HandleRef pThis, int idx, HandleRef tag, double v);

	public void SetAttributeValue(int idx, vtkDICOMTag tag, double v)
	{
		vtkDICOMMetaData_SetAttributeValue_59(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_60(HandleRef pThis, int idx, HandleRef tag, string v);

	public void SetAttributeValue(int idx, vtkDICOMTag tag, string v)
	{
		vtkDICOMMetaData_SetAttributeValue_60(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_61(HandleRef pThis, HandleRef tag, HandleRef v);

	public void SetAttributeValue(vtkDICOMTag tag, vtkDICOMValue v)
	{
		vtkDICOMMetaData_SetAttributeValue_61(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_62(HandleRef pThis, HandleRef tag, double v);

	public void SetAttributeValue(vtkDICOMTag tag, double v)
	{
		vtkDICOMMetaData_SetAttributeValue_62(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_63(HandleRef pThis, HandleRef tag, string v);

	public void SetAttributeValue(vtkDICOMTag tag, string v)
	{
		vtkDICOMMetaData_SetAttributeValue_63(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_64(HandleRef pThis, int idx, vtkDICOMTagPath tag, HandleRef v);

	public void SetAttributeValue(int idx, vtkDICOMTagPath tag, vtkDICOMValue v)
	{
		vtkDICOMMetaData_SetAttributeValue_64(GetCppThis(), idx, tag, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_65(HandleRef pThis, int idx, vtkDICOMTagPath tag, double v);

	public void SetAttributeValue(int idx, vtkDICOMTagPath tag, double v)
	{
		vtkDICOMMetaData_SetAttributeValue_65(GetCppThis(), idx, tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_66(HandleRef pThis, int idx, vtkDICOMTagPath tag, string v);

	public void SetAttributeValue(int idx, vtkDICOMTagPath tag, string v)
	{
		vtkDICOMMetaData_SetAttributeValue_66(GetCppThis(), idx, tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_67(HandleRef pThis, vtkDICOMTagPath tag, HandleRef v);

	public void SetAttributeValue(vtkDICOMTagPath tag, vtkDICOMValue v)
	{
		vtkDICOMMetaData_SetAttributeValue_67(GetCppThis(), tag, v?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_68(HandleRef pThis, vtkDICOMTagPath tag, double v);

	public void SetAttributeValue(vtkDICOMTagPath tag, double v)
	{
		vtkDICOMMetaData_SetAttributeValue_68(GetCppThis(), tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetAttributeValue_69(HandleRef pThis, vtkDICOMTagPath tag, string v);

	public void SetAttributeValue(vtkDICOMTagPath tag, string v)
	{
		vtkDICOMMetaData_SetAttributeValue_69(GetCppThis(), tag, v);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetFileIndexArray_70(HandleRef pThis, HandleRef fileArray);

	public void SetFileIndexArray(vtkIntArray fileArray)
	{
		vtkDICOMMetaData_SetFileIndexArray_70(GetCppThis(), fileArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetFrameIndexArray_71(HandleRef pThis, HandleRef frameArray);

	public void SetFrameIndexArray(vtkIntArray frameArray)
	{
		vtkDICOMMetaData_SetFrameIndexArray_71(GetCppThis(), frameArray?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_SetNumberOfInstances_72(HandleRef pThis, int n);

	public void SetNumberOfInstances(int n)
	{
		vtkDICOMMetaData_SetNumberOfInstances_72(GetCppThis(), n);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMMetaData_ShallowCopy_73(HandleRef pThis, HandleRef source);

	public override void ShallowCopy(vtkDataObject source)
	{
		vtkDICOMMetaData_ShallowCopy_73(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}
}
