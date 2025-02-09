using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

public class vtkDICOMUIDGenerator : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDICOMUIDGenerator";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDICOMUIDGenerator()
	{
		MRClassNameKey = "class vtkDICOMUIDGenerator";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDICOMUIDGenerator"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDICOMUIDGenerator(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUIDGenerator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMUIDGenerator New()
	{
		vtkDICOMUIDGenerator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMUIDGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMUIDGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	public vtkDICOMUIDGenerator()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDICOMUIDGenerator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern string vtkDICOMUIDGenerator_GenerateUID_01(HandleRef pThis, HandleRef tag);

	public virtual string GenerateUID(vtkDICOMTag tag)
	{
		return vtkDICOMUIDGenerator_GenerateUID_01(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMUIDGenerator_GenerateUIDs_02(HandleRef pThis, HandleRef tag, HandleRef uids);

	public virtual void GenerateUIDs(vtkDICOMTag tag, vtkStringArray uids)
	{
		vtkDICOMUIDGenerator_GenerateUIDs_02(GetCppThis(), tag?.GetCppThis() ?? default(HandleRef), uids?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUIDGenerator_GetDefault_03(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public static vtkDICOMUIDGenerator GetDefault()
	{
		vtkDICOMUIDGenerator vtkDICOMUIDGenerator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMUIDGenerator_GetDefault_03(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkDICOMUIDGenerator_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDICOMUIDGenerator_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDICOMUIDGenerator_GetNumberOfGenerationsFromBaseType_05(string type);

	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDICOMUIDGenerator_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUIDGenerator_GetUIDPrefix_06(HandleRef pThis);

	public string GetUIDPrefix()
	{
		return Marshal.PtrToStringAnsi(vtkDICOMUIDGenerator_GetUIDPrefix_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMUIDGenerator_IsA_07(HandleRef pThis, string type);

	public override int IsA(string type)
	{
		return vtkDICOMUIDGenerator_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDICOMUIDGenerator_IsTypeOf_08(string type);

	public new static int IsTypeOf(string type)
	{
		return vtkDICOMUIDGenerator_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUIDGenerator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new vtkDICOMUIDGenerator NewInstance()
	{
		vtkDICOMUIDGenerator result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMUIDGenerator_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDICOMUIDGenerator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDICOMUIDGenerator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	public new static vtkDICOMUIDGenerator SafeDownCast(vtkObjectBase o)
	{
		vtkDICOMUIDGenerator vtkDICOMUIDGenerator2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDICOMUIDGenerator_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkDICOMUIDGenerator_SetDefault_12(HandleRef uidgen);

	public static void SetDefault(vtkDICOMUIDGenerator uidgen)
	{
		vtkDICOMUIDGenerator_SetDefault_12(uidgen?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.DICOM.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDICOMUIDGenerator_SetUIDPrefix_13(HandleRef pThis, string prefix);

	public void SetUIDPrefix(string prefix)
	{
		vtkDICOMUIDGenerator_SetUIDPrefix_13(GetCppThis(), prefix);
	}
}
