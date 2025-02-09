using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMTagPath : WrappedObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMTagPath";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMTagPath()
	{
		MRClassNameKey = "class vtkDICOMTagPath";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMTagPath"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMTagPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
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
	internal static extern IntPtr vtkDICOMTagPath_GetHead_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag GetHead()
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMTagPath_GetHead_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMTagPath_GetIndex_02(HandleRef pThis);

	public uint GetIndex()
	{
		return vtkDICOMTagPath_GetIndex_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMTagPath_GetIndex_03(HandleRef pThis, uint i);

	public uint GetIndex(uint i)
	{
		return vtkDICOMTagPath_GetIndex_03(GetCppThis(), i);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkDICOMTagPath_GetSize_04(HandleRef pThis);

	public uint GetSize()
	{
		return vtkDICOMTagPath_GetSize_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMTagPath_GetTag_05(HandleRef pThis, uint i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public vtkDICOMTag GetTag(uint i)
	{
		vtkDICOMTag result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMTagPath_GetTag_05(GetCppThis(), i, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMTag)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern vtkDICOMTagPath vtkDICOMTagPath_GetTail_06(HandleRef pThis);

	public vtkDICOMTagPath GetTail()
	{
		return vtkDICOMTagPath_GetTail_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDICOMTagPath_HasTail_07(HandleRef pThis);

	public bool HasTail()
	{
		return (vtkDICOMTagPath_HasTail_07(GetCppThis()) != 0) ? true : false;
	}
}
