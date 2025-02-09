using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMedicalImageReader2
/// </summary>
/// <remarks>
///    vtkImageReader2 with medical meta data.
///
/// vtkMedicalImageReader2 is a parent class for medical image readers.
/// It provides a place to store patient information that may be stored
/// in the image header.
/// </remarks>
/// <seealso>
///
/// vtkImageReader2 vtkGESignaReader vtkMedicalImageProperties
/// </seealso>
public class vtkMedicalImageReader2 : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMedicalImageReader2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMedicalImageReader2()
	{
		MRClassNameKey = "class vtkMedicalImageReader2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMedicalImageReader2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMedicalImageReader2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMedicalImageReader2 New()
	{
		vtkMedicalImageReader2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMedicalImageReader2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMedicalImageReader2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMedicalImageReader2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_GetDate_01(HandleRef pThis);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual string GetDate()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageReader2_GetDate_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_GetImageNumber_02(HandleRef pThis);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual string GetImageNumber()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageReader2_GetImageNumber_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_GetMedicalImageProperties_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the medical image properties object
	/// </summary>
	public virtual vtkMedicalImageProperties GetMedicalImageProperties()
	{
		vtkMedicalImageProperties vtkMedicalImageProperties2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMedicalImageReader2_GetMedicalImageProperties_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMedicalImageProperties2 = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMedicalImageProperties2.Register(null);
			}
		}
		return vtkMedicalImageProperties2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_GetModality_04(HandleRef pThis);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual string GetModality()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageReader2_GetModality_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMedicalImageReader2_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMedicalImageReader2_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMedicalImageReader2_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMedicalImageReader2_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_GetPatientID_07(HandleRef pThis);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual string GetPatientID()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageReader2_GetPatientID_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_GetPatientName_08(HandleRef pThis);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual string GetPatientName()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageReader2_GetPatientName_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_GetSeries_09(HandleRef pThis);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual string GetSeries()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageReader2_GetSeries_09(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_GetStudy_10(HandleRef pThis);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual string GetStudy()
	{
		return Marshal.PtrToStringAnsi(vtkMedicalImageReader2_GetStudy_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageReader2_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMedicalImageReader2_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMedicalImageReader2_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMedicalImageReader2_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMedicalImageReader2 NewInstance()
	{
		vtkMedicalImageReader2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMedicalImageReader2_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMedicalImageReader2_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMedicalImageReader2 SafeDownCast(vtkObjectBase o)
	{
		vtkMedicalImageReader2 vtkMedicalImageReader3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMedicalImageReader2_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMedicalImageReader3 = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMedicalImageReader3.Register(null);
			}
		}
		return vtkMedicalImageReader3;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageReader2_SetDate_16(HandleRef pThis, string arg0);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual void SetDate(string arg0)
	{
		vtkMedicalImageReader2_SetDate_16(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageReader2_SetImageNumber_17(HandleRef pThis, string arg0);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual void SetImageNumber(string arg0)
	{
		vtkMedicalImageReader2_SetImageNumber_17(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageReader2_SetModality_18(HandleRef pThis, string arg0);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual void SetModality(string arg0)
	{
		vtkMedicalImageReader2_SetModality_18(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageReader2_SetPatientID_19(HandleRef pThis, string arg0);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual void SetPatientID(string arg0)
	{
		vtkMedicalImageReader2_SetPatientID_19(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageReader2_SetPatientName_20(HandleRef pThis, string arg0);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual void SetPatientName(string arg0)
	{
		vtkMedicalImageReader2_SetPatientName_20(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageReader2_SetSeries_21(HandleRef pThis, string arg0);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual void SetSeries(string arg0)
	{
		vtkMedicalImageReader2_SetSeries_21(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMedicalImageReader2_SetStudy_22(HandleRef pThis, string arg0);

	/// <summary>
	/// For backward compatibility, propagate calls to the MedicalImageProperties
	/// object.
	/// </summary>
	public virtual void SetStudy(string arg0)
	{
		vtkMedicalImageReader2_SetStudy_22(GetCppThis(), arg0);
	}
}
