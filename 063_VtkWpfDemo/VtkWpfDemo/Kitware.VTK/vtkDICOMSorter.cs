using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMSorter : vtkDICOMFileSorter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMSorter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMSorter()
	{
		MRClassNameKey = "class vtkDICOMSorter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMSorter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMSorter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSorter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMSorter New()
	{
		vtkDICOMSorter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSorter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMSorter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMSorter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMSorter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkDICOMSorter_GetFirstSeriesInStudy_01(HandleRef pThis, int study);

	public int GetFirstSeriesInStudy(int study)
	{
		return vtkDICOMSorter_GetFirstSeriesInStudy_01(GetCppThis(), study);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMSorter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMSorter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMSorter_GetNumberOfGenerationsFromBaseType_03(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMSorter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSorter_GetNumberOfSeriesInStudy_04(HandleRef pThis, int study);

	public int GetNumberOfSeriesInStudy(int study)
	{
		return vtkDICOMSorter_GetNumberOfSeriesInStudy_04(GetCppThis(), study);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSorter_IsA_05(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMSorter_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMSorter_IsTypeOf_06(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMSorter_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSorter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMSorter NewInstance()
	{
		vtkDICOMSorter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSorter_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMSorter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMSorter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMSorter SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMSorter vtkDICOMSorter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMSorter_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDICOMSorter2 = (vtkDICOMSorter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDICOMSorter2.Register(null);
			}
		}
		return vtkDICOMSorter2;
	}
}
