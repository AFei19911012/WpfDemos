using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkNetCDFReader
///
///
///
/// A superclass for reading netCDF files.  Subclass add conventions to the
/// reader.  This class just outputs data into a multi block data set with a
/// vtkImageData at each block.  A block is created for each variable except that
/// variables with matching dimensions will be placed in the same block.
/// </summary>
public class vtkNetCDFReader : vtkDataObjectAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkNetCDFReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkNetCDFReader()
	{
		MRClassNameKey = "class vtkNetCDFReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkNetCDFReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkNetCDFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFReader New()
	{
		vtkNetCDFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkNetCDFReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkNetCDFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkNetCDFReader_ComputeArraySelection_01(HandleRef pThis);

	/// <summary>
	/// Enables arrays in VariableArraySelection depending on Dimensions.
	/// Returns true if one variable matching Dimensions was found.
	/// </summary>
	public bool ComputeArraySelection()
	{
		return (vtkNetCDFReader_ComputeArraySelection_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_GetAllDimensions_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns an array with string encodings for the dimension combinations used
	/// in the variables.  The result is the same as GetVariableDimensions except
	/// that each entry in the array is unique (a set of dimensions is only given
	/// once even if it occurs for multiple variables) and the order is
	/// meaningless.
	/// </summary>
	public virtual vtkStringArray GetAllDimensions()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFReader_GetAllDimensions_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_GetAllVariableArrayNames_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Convenience method to get a list of variable arrays.  The length of the
	/// returned list is the same as GetNumberOfVariableArrays, and the string
	/// at each index i is the same as returned from GetVariableArrayname(i).
	/// </summary>
	public virtual vtkStringArray GetAllVariableArrayNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFReader_GetAllVariableArrayNames_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_GetCalendar_04(HandleRef pThis);

	/// <summary>
	/// Access to the time dimensions units.
	/// Can be used by the udunits library to convert raw numerical time values
	/// into meaningful representations.
	/// </summary>
	public virtual string GetCalendar()
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFReader_GetCalendar_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_GetFileName_05(HandleRef pThis);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFReader_GetFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFReader_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkNetCDFReader_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkNetCDFReader_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkNetCDFReader_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFReader_GetNumberOfVariableArrays_08(HandleRef pThis);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual int GetNumberOfVariableArrays()
	{
		return vtkNetCDFReader_GetNumberOfVariableArrays_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFReader_GetReplaceFillValueWithNan_09(HandleRef pThis);

	/// <summary>
	/// If on, any float or double variable read that has a _FillValue attribute
	/// will have that fill value replaced with a not-a-number (NaN) value.  The
	/// advantage of setting these to NaN values is that, if implemented properly
	/// by the system and careful math operations are used, they can implicitly be
	/// ignored by calculations like finding the range of the values.  That said,
	/// this option should be used with caution as VTK does not fully support NaN
	/// values and therefore odd calculations may occur.  By default this is off.
	/// </summary>
	public virtual int GetReplaceFillValueWithNan()
	{
		return vtkNetCDFReader_GetReplaceFillValueWithNan_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_GetTimeUnits_10(HandleRef pThis);

	/// <summary>
	/// Access to the time dimensions units.
	/// Can be used by the udunits library to convert raw numerical time values
	/// into meaningful representations.
	/// </summary>
	public virtual string GetTimeUnits()
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFReader_GetTimeUnits_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_GetVariableArrayName_11(HandleRef pThis, int index);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual string GetVariableArrayName(int index)
	{
		return Marshal.PtrToStringAnsi(vtkNetCDFReader_GetVariableArrayName_11(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFReader_GetVariableArrayStatus_12(HandleRef pThis, string name);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual int GetVariableArrayStatus(string name)
	{
		return vtkNetCDFReader_GetVariableArrayStatus_12(GetCppThis(), name);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_GetVariableDimensions_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Returns an array with string encodings for the dimensions used in each of
	/// the variables.  The indices in the returned array correspond to those used
	/// in the GetVariableArrayName method.  Two arrays with the same dimensions
	/// will have the same encoded string returned by this method.
	/// </summary>
	public virtual vtkStringArray GetVariableDimensions()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFReader_GetVariableDimensions_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFReader_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkNetCDFReader_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFReader_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkNetCDFReader_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkNetCDFReader NewInstance()
	{
		vtkNetCDFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFReader_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkNetCDFReader_QueryArrayUnits_18(HandleRef pThis, string ArrayName);

	/// <summary>
	/// Get units attached to a particular array in the netcdf file.
	/// </summary>
	public string QueryArrayUnits(string ArrayName)
	{
		return vtkNetCDFReader_QueryArrayUnits_18(GetCppThis(), ArrayName);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFReader_ReplaceFillValueWithNanOff_19(HandleRef pThis);

	/// <summary>
	/// If on, any float or double variable read that has a _FillValue attribute
	/// will have that fill value replaced with a not-a-number (NaN) value.  The
	/// advantage of setting these to NaN values is that, if implemented properly
	/// by the system and careful math operations are used, they can implicitly be
	/// ignored by calculations like finding the range of the values.  That said,
	/// this option should be used with caution as VTK does not fully support NaN
	/// values and therefore odd calculations may occur.  By default this is off.
	/// </summary>
	public virtual void ReplaceFillValueWithNanOff()
	{
		vtkNetCDFReader_ReplaceFillValueWithNanOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFReader_ReplaceFillValueWithNanOn_20(HandleRef pThis);

	/// <summary>
	/// If on, any float or double variable read that has a _FillValue attribute
	/// will have that fill value replaced with a not-a-number (NaN) value.  The
	/// advantage of setting these to NaN values is that, if implemented properly
	/// by the system and careful math operations are used, they can implicitly be
	/// ignored by calculations like finding the range of the values.  That said,
	/// this option should be used with caution as VTK does not fully support NaN
	/// values and therefore odd calculations may occur.  By default this is off.
	/// </summary>
	public virtual void ReplaceFillValueWithNanOn()
	{
		vtkNetCDFReader_ReplaceFillValueWithNanOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkNetCDFReader_SafeDownCast_21(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkNetCDFReader SafeDownCast(vtkObjectBase o)
	{
		vtkNetCDFReader vtkNetCDFReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkNetCDFReader_SafeDownCast_21(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkNetCDFReader2 = (vtkNetCDFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkNetCDFReader2.Register(null);
			}
		}
		return vtkNetCDFReader2;
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFReader_SetDimensions_22(HandleRef pThis, string dimensions);

	/// <summary>
	/// Loads the grid with the given dimensions.  The dimensions are encoded in a
	/// string that conforms to the same format as returned by
	/// GetVariableDimensions and GetAllDimensions.  This method is really a
	/// convenience method for SetVariableArrayStatus.  It turns on all variables
	/// that have the given dimensions and turns off all other variables.
	/// </summary>
	public virtual void SetDimensions(string dimensions)
	{
		vtkNetCDFReader_SetDimensions_22(GetCppThis(), dimensions);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFReader_SetFileName_23(HandleRef pThis, string filename);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public virtual void SetFileName(string filename)
	{
		vtkNetCDFReader_SetFileName_23(GetCppThis(), filename);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFReader_SetReplaceFillValueWithNan_24(HandleRef pThis, int _arg);

	/// <summary>
	/// If on, any float or double variable read that has a _FillValue attribute
	/// will have that fill value replaced with a not-a-number (NaN) value.  The
	/// advantage of setting these to NaN values is that, if implemented properly
	/// by the system and careful math operations are used, they can implicitly be
	/// ignored by calculations like finding the range of the values.  That said,
	/// this option should be used with caution as VTK does not fully support NaN
	/// values and therefore odd calculations may occur.  By default this is off.
	/// </summary>
	public virtual void SetReplaceFillValueWithNan(int _arg)
	{
		vtkNetCDFReader_SetReplaceFillValueWithNan_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkNetCDFReader_SetVariableArrayStatus_25(HandleRef pThis, string name, int status);

	/// <summary>
	/// Variable array selection.
	/// </summary>
	public virtual void SetVariableArrayStatus(string name, int status)
	{
		vtkNetCDFReader_SetVariableArrayStatus_25(GetCppThis(), name, status);
	}

	[DllImport("Kitware.VTK.IONetCDF.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkNetCDFReader_UpdateMetaData_26(HandleRef pThis);

	/// <summary>
	/// Update the meta data from the current file.  Automatically called
	/// during the RequestInformation pipeline update stage.
	/// </summary>
	public int UpdateMetaData()
	{
		return vtkNetCDFReader_UpdateMetaData_26(GetCppThis());
	}
}
