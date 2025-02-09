using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMMetaDataAdapter : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMMetaDataAdapter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMMetaDataAdapter()
	{
		MRClassNameKey = "class vtkDICOMMetaDataAdapter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMMetaDataAdapter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMMetaDataAdapter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern IntPtr vtkDICOMMetaDataAdapter_Get_01(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaDataAdapter_Get_01(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaDataAdapter_Get_02(HandleRef pThis, int idx, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue Get(int idx, vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaDataAdapter_Get_02(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaDataAdapter_GetAttributeValue_03(HandleRef pThis, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaDataAdapter_GetAttributeValue_03(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaDataAdapter_GetAttributeValue_04(HandleRef pThis, int idx, HandleRef tag, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMValue GetAttributeValue(int idx, vtkDICOMTag tag)
	{
		vtkDICOMValue result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaDataAdapter_GetAttributeValue_04(GetCppThis(), idx, tag?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMValue)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMMetaDataAdapter_GetNumberOfInstances_05(HandleRef pThis);

	public int GetNumberOfInstances()
	{
		return vtkDICOMMetaDataAdapter_GetNumberOfInstances_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMMetaDataAdapter_Has_06(HandleRef pThis, HandleRef tag);

	public bool Has(vtkDICOMTag tag)
	{
		return (vtkDICOMMetaDataAdapter_Has_06(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMMetaDataAdapter_HasAttribute_07(HandleRef pThis, HandleRef tag);

	public bool HasAttribute(vtkDICOMTag tag)
	{
		return (vtkDICOMMetaDataAdapter_HasAttribute_07(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef)) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaDataAdapter_ResolvePrivateTag_08(HandleRef pThis, HandleRef ptag, string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag ResolvePrivateTag(vtkDICOMTag ptag, string creator)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaDataAdapter_ResolvePrivateTag_08(GetCppThis(), ptag?.GetCppThis() ?? default(HandleRef), creator, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaDataAdapter_ResolvePrivateTag_09(HandleRef pThis, int idx, HandleRef ptag, string creator, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag ResolvePrivateTag(int idx, vtkDICOMTag ptag, string creator)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMMetaDataAdapter_ResolvePrivateTag_09(GetCppThis(), idx, ptag?.GetCppThis() ?? default(HandleRef), creator, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMMetaDataAdapter_New(HandleRef meta, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMMetaDataAdapter(vtkDICOMMetaData meta)
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMMetaDataAdapter_New(meta?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		SetCppThis(rawCppThis, callDisposalMethod: true, (mteStatus != 0 && rawRefCount >= 2) ? true : false);
	}
}
