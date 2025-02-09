using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMINCImageWriter
/// </summary>
/// <remarks>
///    A writer for MINC files.
///
/// MINC is a NetCDF-based medical image file format that was developed
/// at the Montreal Neurological Institute in 1992.
/// The data is written slice-by-slice, and this writer is therefore
/// suitable for streaming MINC data that is larger than the memory
/// size through VTK.  This writer can also produce files with up to
/// 4 dimensions, where the fourth dimension is provided by using
/// AddInput() to specify multiple input data sets.  If you want to
/// set header information for the file, you must supply a
/// vtkMINCImageAttributes
/// </remarks>
/// <seealso>
///
/// vtkMINCImageReader vtkMINCImageAttributes
/// @par Thanks:
/// Thanks to David Gobbi for writing this class and Atamai Inc. for
/// contributing it to VTK.
/// </seealso>
public class vtkMINCImageWriter : vtkImageWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMINCImageWriter()
	{
		MRClassNameKey = "class vtkMINCImageWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMINCImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMINCImageWriter New()
	{
		vtkMINCImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMINCImageWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMINCImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageWriter_GetDescriptiveName_01(HandleRef pThis);

	/// <summary>
	/// Get the name of this file format.
	/// </summary>
	public virtual string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkMINCImageWriter_GetDescriptiveName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageWriter_GetDirectionCosines_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set a matrix that describes the orientation of the data.  The
	/// three columns of this matrix should give the unit-vector
	/// directions for the VTK x, y and z dimensions respectively.
	/// The writer will use this information to determine how to map
	/// the VTK dimensions to the canonical MINC dimensions, and if
	/// necessary, the writer will re-order one or more dimensions
	/// back-to-front to ensure that no MINC dimension ends up with
	/// a direction cosines vector whose dot product with the canonical
	/// unit vector for that dimension is negative.
	/// </summary>
	public virtual vtkMatrix4x4 GetDirectionCosines()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageWriter_GetDirectionCosines_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageWriter_GetFileExtensions_03(HandleRef pThis);

	/// <summary>
	/// Get the extension for this file format.
	/// </summary>
	public virtual string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkMINCImageWriter_GetFileExtensions_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageWriter_GetHistoryAddition_04(HandleRef pThis);

	/// <summary>
	/// Set a string value to append to the history of the file.  This
	/// string should describe, briefly, how the file was processed.
	/// </summary>
	public virtual string GetHistoryAddition()
	{
		return Marshal.PtrToStringAnsi(vtkMINCImageWriter_GetHistoryAddition_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageWriter_GetImageAttributes_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the image attributes, which contain patient information and
	/// other useful metadata.
	/// </summary>
	public virtual vtkMINCImageAttributes GetImageAttributes()
	{
		vtkMINCImageAttributes vtkMINCImageAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageWriter_GetImageAttributes_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMINCImageAttributes2 = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMINCImageAttributes2.Register(null);
			}
		}
		return vtkMINCImageAttributes2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMINCImageWriter_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMINCImageWriter_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMINCImageWriter_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMINCImageWriter_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMINCImageWriter_GetRescaleIntercept_08(HandleRef pThis);

	/// <summary>
	/// Set the slope and intercept for rescaling the intensities.  The
	/// default values are zero, which indicates to the reader that no
	/// rescaling is to be performed.
	/// </summary>
	public virtual double GetRescaleIntercept()
	{
		return vtkMINCImageWriter_GetRescaleIntercept_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMINCImageWriter_GetRescaleSlope_09(HandleRef pThis);

	/// <summary>
	/// Set the slope and intercept for rescaling the intensities.  The
	/// default values are zero, which indicates to the reader that no
	/// rescaling is to be performed.
	/// </summary>
	public virtual double GetRescaleSlope()
	{
		return vtkMINCImageWriter_GetRescaleSlope_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageWriter_GetStrictValidation_10(HandleRef pThis);

	/// <summary>
	/// Set whether to validate that all variable attributes that
	/// have been set are ones that are listed in the MINC standard.
	/// </summary>
	public virtual int GetStrictValidation()
	{
		return vtkMINCImageWriter_GetStrictValidation_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageWriter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMINCImageWriter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageWriter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMINCImageWriter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMINCImageWriter NewInstance()
	{
		vtkMINCImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageWriter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMINCImageWriter SafeDownCast(vtkObjectBase o)
	{
		vtkMINCImageWriter vtkMINCImageWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageWriter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMINCImageWriter2 = (vtkMINCImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMINCImageWriter2.Register(null);
			}
		}
		return vtkMINCImageWriter2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_SetDirectionCosines_16(HandleRef pThis, HandleRef matrix);

	/// <summary>
	/// Set a matrix that describes the orientation of the data.  The
	/// three columns of this matrix should give the unit-vector
	/// directions for the VTK x, y and z dimensions respectively.
	/// The writer will use this information to determine how to map
	/// the VTK dimensions to the canonical MINC dimensions, and if
	/// necessary, the writer will re-order one or more dimensions
	/// back-to-front to ensure that no MINC dimension ends up with
	/// a direction cosines vector whose dot product with the canonical
	/// unit vector for that dimension is negative.
	/// </summary>
	public virtual void SetDirectionCosines(vtkMatrix4x4 matrix)
	{
		vtkMINCImageWriter_SetDirectionCosines_16(GetCppThis(), matrix?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_SetFileName_17(HandleRef pThis, string name);

	/// <summary>
	/// Set the file name.
	/// </summary>
	public override void SetFileName(string name)
	{
		vtkMINCImageWriter_SetFileName_17(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_SetHistoryAddition_18(HandleRef pThis, string _arg);

	/// <summary>
	/// Set a string value to append to the history of the file.  This
	/// string should describe, briefly, how the file was processed.
	/// </summary>
	public virtual void SetHistoryAddition(string _arg)
	{
		vtkMINCImageWriter_SetHistoryAddition_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_SetImageAttributes_19(HandleRef pThis, HandleRef attributes);

	/// <summary>
	/// Set the image attributes, which contain patient information and
	/// other useful metadata.
	/// </summary>
	public virtual void SetImageAttributes(vtkMINCImageAttributes attributes)
	{
		vtkMINCImageWriter_SetImageAttributes_19(GetCppThis(), attributes?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_SetRescaleIntercept_20(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the slope and intercept for rescaling the intensities.  The
	/// default values are zero, which indicates to the reader that no
	/// rescaling is to be performed.
	/// </summary>
	public virtual void SetRescaleIntercept(double _arg)
	{
		vtkMINCImageWriter_SetRescaleIntercept_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_SetRescaleSlope_21(HandleRef pThis, double _arg);

	/// <summary>
	/// Set the slope and intercept for rescaling the intensities.  The
	/// default values are zero, which indicates to the reader that no
	/// rescaling is to be performed.
	/// </summary>
	public virtual void SetRescaleSlope(double _arg)
	{
		vtkMINCImageWriter_SetRescaleSlope_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_SetStrictValidation_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set whether to validate that all variable attributes that
	/// have been set are ones that are listed in the MINC standard.
	/// </summary>
	public virtual void SetStrictValidation(int _arg)
	{
		vtkMINCImageWriter_SetStrictValidation_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_StrictValidationOff_23(HandleRef pThis);

	/// <summary>
	/// Set whether to validate that all variable attributes that
	/// have been set are ones that are listed in the MINC standard.
	/// </summary>
	public virtual void StrictValidationOff()
	{
		vtkMINCImageWriter_StrictValidationOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_StrictValidationOn_24(HandleRef pThis);

	/// <summary>
	/// Set whether to validate that all variable attributes that
	/// have been set are ones that are listed in the MINC standard.
	/// </summary>
	public virtual void StrictValidationOn()
	{
		vtkMINCImageWriter_StrictValidationOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageWriter_Write_25(HandleRef pThis);

	/// <summary>
	/// Write the data.  This will attempt to stream the data
	/// slice-by-slice through the pipeline and out to the file,
	/// unless the whole extent of the input has already been
	/// updated.
	/// </summary>
	public override void Write()
	{
		vtkMINCImageWriter_Write_25(GetCppThis());
	}
}
