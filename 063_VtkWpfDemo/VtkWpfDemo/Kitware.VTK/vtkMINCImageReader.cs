using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMINCImageReader
/// </summary>
/// <remarks>
///    A reader for MINC files.
///
/// MINC is a NetCDF-based medical image file format that was developed
/// at the Montreal Neurological Institute in 1992.
/// This class will read a MINC file into VTK, rearranging the data to
/// match the VTK x, y, and z dimensions, and optionally rescaling
/// real-valued data to VTK_FLOAT if RescaleRealValuesOn() is set.
/// If RescaleRealValues is off, then the data will be stored in its
/// original data type and the GetRescaleSlope(), GetRescaleIntercept()
/// method can be used to retrieve global rescaling parameters.
/// If the original file had a time dimension, the SetTimeStep() method
/// can be used to specify a time step to read.
/// All of the original header information can be accessed though the
/// GetImageAttributes() method.
/// </remarks>
/// <seealso>
///
/// vtkMINCImageWriter vtkMINCImageAttributes
/// @par Thanks:
/// Thanks to David Gobbi for writing this class and Atamai Inc. for
/// contributing it to VTK.
/// </seealso>
public class vtkMINCImageReader : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMINCImageReader()
	{
		MRClassNameKey = "class vtkMINCImageReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMINCImageReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMINCImageReader New()
	{
		vtkMINCImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMINCImageReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMINCImageReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkMINCImageReader_CanReadFile_01(HandleRef pThis, string name);

	/// <summary>
	/// Test whether the specified file can be read.
	/// </summary>
	public override int CanReadFile(string name)
	{
		return vtkMINCImageReader_CanReadFile_01(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageReader_GetDataRange_02(HandleRef pThis);

	/// <summary>
	/// Get the scalar range of the output from the information in
	/// the file header.  This is more efficient that computing the
	/// scalar range, but in some cases the MINC file stores an
	/// incorrect valid_range and the DataRange will be incorrect.
	/// </summary>
	public virtual double[] GetDataRange()
	{
		IntPtr intPtr = vtkMINCImageReader_GetDataRange_02(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageReader_GetDataRange_03(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Get the scalar range of the output from the information in
	/// the file header.  This is more efficient that computing the
	/// scalar range, but in some cases the MINC file stores an
	/// incorrect valid_range and the DataRange will be incorrect.
	/// </summary>
	public virtual void GetDataRange(IntPtr range)
	{
		vtkMINCImageReader_GetDataRange_03(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageReader_GetDescriptiveName_04(HandleRef pThis);

	/// <summary>
	/// Get the name of this file format.
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkMINCImageReader_GetDescriptiveName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageReader_GetDirectionCosines_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get a matrix that describes the orientation of the data.
	/// The three columns of the matrix are the direction cosines
	/// for the x, y and z dimensions respectively.
	/// </summary>
	public virtual vtkMatrix4x4 GetDirectionCosines()
	{
		vtkMatrix4x4 vtkMatrix4x5 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageReader_GetDirectionCosines_05(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkMINCImageReader_GetFileExtensions_06(HandleRef pThis);

	/// <summary>
	/// Get the extension for this file format.
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkMINCImageReader_GetFileExtensions_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageReader_GetImageAttributes_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the image attributes, which contain patient information and
	/// other useful metadata.
	/// </summary>
	public virtual vtkMINCImageAttributes GetImageAttributes()
	{
		vtkMINCImageAttributes vtkMINCImageAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageReader_GetImageAttributes_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkMINCImageReader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMINCImageReader_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMINCImageReader_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMINCImageReader_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageReader_GetNumberOfTimeSteps_10(HandleRef pThis);

	/// <summary>
	/// Get the number of time steps in the file.
	/// </summary>
	public virtual int GetNumberOfTimeSteps()
	{
		return vtkMINCImageReader_GetNumberOfTimeSteps_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMINCImageReader_GetRescaleIntercept_11(HandleRef pThis);

	/// <summary>
	/// Get the slope and intercept for rescaling the scalar values
	/// to real data values.  To convert scalar values to real values,
	/// use the equation y = x*RescaleSlope + RescaleIntercept.
	/// </summary>
	public virtual double GetRescaleIntercept()
	{
		return vtkMINCImageReader_GetRescaleIntercept_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageReader_GetRescaleRealValues_12(HandleRef pThis);

	/// <summary>
	/// Rescale real data values to float.  If this is done, the
	/// RescaleSlope and RescaleIntercept will be set to 1 and 0
	/// respectively.  This is off by default.
	/// </summary>
	public virtual int GetRescaleRealValues()
	{
		return vtkMINCImageReader_GetRescaleRealValues_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMINCImageReader_GetRescaleSlope_13(HandleRef pThis);

	/// <summary>
	/// Get the slope and intercept for rescaling the scalar values
	/// to real data values.  To convert scalar values to real values,
	/// use the equation y = x*RescaleSlope + RescaleIntercept.
	/// </summary>
	public virtual double GetRescaleSlope()
	{
		return vtkMINCImageReader_GetRescaleSlope_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageReader_GetTimeStep_14(HandleRef pThis);

	/// <summary>
	/// Set the time step to read.
	/// </summary>
	public virtual int GetTimeStep()
	{
		return vtkMINCImageReader_GetTimeStep_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageReader_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMINCImageReader_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageReader_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMINCImageReader_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageReader_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMINCImageReader NewInstance()
	{
		vtkMINCImageReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageReader_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageReader_RescaleRealValuesOff_19(HandleRef pThis);

	/// <summary>
	/// Rescale real data values to float.  If this is done, the
	/// RescaleSlope and RescaleIntercept will be set to 1 and 0
	/// respectively.  This is off by default.
	/// </summary>
	public virtual void RescaleRealValuesOff()
	{
		vtkMINCImageReader_RescaleRealValuesOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageReader_RescaleRealValuesOn_20(HandleRef pThis);

	/// <summary>
	/// Rescale real data values to float.  If this is done, the
	/// RescaleSlope and RescaleIntercept will be set to 1 and 0
	/// respectively.  This is off by default.
	/// </summary>
	public virtual void RescaleRealValuesOn()
	{
		vtkMINCImageReader_RescaleRealValuesOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageReader_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMINCImageReader SafeDownCast(vtkObjectBase o)
	{
		vtkMINCImageReader vtkMINCImageReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageReader_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMINCImageReader2 = (vtkMINCImageReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMINCImageReader2.Register(null);
			}
		}
		return vtkMINCImageReader2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageReader_SetFileName_22(HandleRef pThis, string name);

	/// <summary>
	/// Set the file name.
	/// </summary>
	public override void SetFileName(string name)
	{
		vtkMINCImageReader_SetFileName_22(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageReader_SetRescaleRealValues_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Rescale real data values to float.  If this is done, the
	/// RescaleSlope and RescaleIntercept will be set to 1 and 0
	/// respectively.  This is off by default.
	/// </summary>
	public virtual void SetRescaleRealValues(int _arg)
	{
		vtkMINCImageReader_SetRescaleRealValues_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageReader_SetTimeStep_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Set the time step to read.
	/// </summary>
	public virtual void SetTimeStep(int _arg)
	{
		vtkMINCImageReader_SetTimeStep_24(GetCppThis(), _arg);
	}
}
