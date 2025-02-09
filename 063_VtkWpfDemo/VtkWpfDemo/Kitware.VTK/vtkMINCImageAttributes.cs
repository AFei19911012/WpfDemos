using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMINCImageAttributes
/// </summary>
/// <remarks>
///    A container for a MINC image header.
///
/// This class provides methods to access all of the information
/// contained in the MINC header.  If you read a MINC file into
/// VTK and then write it out again, you can use
/// writer-&gt;SetImageAttributes(reader-&gt;GetImageAttributes) to
/// ensure that all of the medical information contained in the
/// file is transferred from the reader to the writer.  If you
/// want to change any of the header information, you must
/// use ShallowCopy to make a copy of the reader's attributes
/// and then modify only the copy.
/// </remarks>
/// <seealso>
///
/// vtkMINCImageReader vtkMINCImageWriter
/// @par Thanks:
/// Thanks to David Gobbi for writing this class and Atamai Inc. for
/// contributing it to VTK.
/// </seealso>
public class vtkMINCImageAttributes : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMINCImageAttributes";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMINCImageAttributes()
	{
		MRClassNameKey = "class vtkMINCImageAttributes";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMINCImageAttributes"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMINCImageAttributes(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMINCImageAttributes New()
	{
		vtkMINCImageAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMINCImageAttributes()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMINCImageAttributes_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMINCImageAttributes_AddDimension_01(HandleRef pThis, string dimension);

	/// <summary>
	/// Add the names of up to five dimensions. The ordering of these
	/// dimensions will determine the dimension order of the file.  If
	/// no DimensionNames are set, the writer will set the dimension
	/// order of the file to be the same as the dimension order in memory.
	/// </summary>
	public virtual void AddDimension(string dimension)
	{
		vtkMINCImageAttributes_AddDimension_01(GetCppThis(), dimension);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_AddDimension_02(HandleRef pThis, string dimension, long length);

	/// <summary>
	/// Add the names of up to five dimensions. The ordering of these
	/// dimensions will determine the dimension order of the file.  If
	/// no DimensionNames are set, the writer will set the dimension
	/// order of the file to be the same as the dimension order in memory.
	/// </summary>
	public virtual void AddDimension(string dimension, long length)
	{
		vtkMINCImageAttributes_AddDimension_02(GetCppThis(), dimension, length);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_FindImageRange_03(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Find the image range of the data from the information stored
	/// in the attributes.
	/// </summary>
	public virtual void FindImageRange(IntPtr range)
	{
		vtkMINCImageAttributes_FindImageRange_03(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_FindValidRange_04(HandleRef pThis, IntPtr range);

	/// <summary>
	/// Find the valid range of the data from the information stored
	/// in the attributes.
	/// </summary>
	public virtual void FindValidRange(IntPtr range)
	{
		vtkMINCImageAttributes_FindValidRange_04(GetCppThis(), range);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetAttributeNames_05(HandleRef pThis, string variable, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// List the attribute names for a variable.  Set the variable
	/// to the empty string to get a list of the global attributes.
	/// </summary>
	public virtual vtkStringArray GetAttributeNames(string variable)
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_GetAttributeNames_05(GetCppThis(), variable, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetAttributeValueAsArray_06(HandleRef pThis, string variable, string attribute, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set attribute values for a variable as a vtkDataArray.
	/// Set the variable to the empty string to access global attributes.
	/// </summary>
	public virtual vtkDataArray GetAttributeValueAsArray(string variable, string attribute)
	{
		vtkDataArray vtkDataArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_GetAttributeValueAsArray_06(GetCppThis(), variable, attribute, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataArray2 = (vtkDataArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataArray2.Register(null);
			}
		}
		return vtkDataArray2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern double vtkMINCImageAttributes_GetAttributeValueAsDouble_07(HandleRef pThis, string variable, string attribute);

	/// <summary>
	/// Set an attribute value as a double.  Set the variable
	/// to the empty string to access global attributes.
	/// If you specify a variable that does not exist, it will be
	/// created.
	/// </summary>
	public virtual double GetAttributeValueAsDouble(string variable, string attribute)
	{
		return vtkMINCImageAttributes_GetAttributeValueAsDouble_07(GetCppThis(), variable, attribute);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageAttributes_GetAttributeValueAsInt_08(HandleRef pThis, string variable, string attribute);

	/// <summary>
	/// Set an attribute value as an int. Set the variable
	/// to the empty string to access global attributes.
	/// If you specify a variable that does not exist, it will be
	/// created.
	/// </summary>
	public virtual int GetAttributeValueAsInt(string variable, string attribute)
	{
		return vtkMINCImageAttributes_GetAttributeValueAsInt_08(GetCppThis(), variable, attribute);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetAttributeValueAsString_09(HandleRef pThis, string variable, string attribute);

	/// <summary>
	/// Set an attribute value as a string.  Set the variable
	/// to the empty string to access global attributes.
	/// If you specify a variable that does not exist, it will be
	/// created.
	/// </summary>
	public virtual string GetAttributeValueAsString(string variable, string attribute)
	{
		return Marshal.PtrToStringAnsi(vtkMINCImageAttributes_GetAttributeValueAsString_09(GetCppThis(), variable, attribute));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageAttributes_GetDataType_10(HandleRef pThis);

	/// <summary>
	/// Get the image data type, as stored on disk.  This information
	/// is useful if the file was converted to floating-point when it
	/// was loaded.  When writing a file from float or double image data,
	/// you can use this method to prescribe the output type.
	/// </summary>
	public virtual int GetDataType()
	{
		return vtkMINCImageAttributes_GetDataType_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetDimensionLengths_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the lengths of all the dimensions.  The dimension lengths
	/// are informative, the vtkMINCImageWriter does not look at these values
	/// but instead uses the dimension sizes of its input.
	/// </summary>
	public virtual vtkIdTypeArray GetDimensionLengths()
	{
		vtkIdTypeArray vtkIdTypeArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_GetDimensionLengths_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkIdTypeArray2 = (vtkIdTypeArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkIdTypeArray2.Register(null);
			}
		}
		return vtkIdTypeArray2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetDimensionNames_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the dimension names.  The dimension names are same order
	/// as written in the file, starting with the slowest-varying
	/// dimension.  Use this method to get the array if you need to
	/// change "space" dimensions to "frequency" after performing a
	/// Fourier transform.
	/// </summary>
	public virtual vtkStringArray GetDimensionNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_GetDimensionNames_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetImageMax_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the image min and max arrays. These are set by the reader,
	/// but they aren't used by the writer except to compute the full
	/// real data range of the original file.
	/// </summary>
	public virtual vtkDoubleArray GetImageMax()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_GetImageMax_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetImageMin_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the image min and max arrays. These are set by the reader,
	/// but they aren't used by the writer except to compute the full
	/// real data range of the original file.
	/// </summary>
	public virtual vtkDoubleArray GetImageMin()
	{
		vtkDoubleArray vtkDoubleArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_GetImageMin_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDoubleArray2 = (vtkDoubleArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDoubleArray2.Register(null);
			}
		}
		return vtkDoubleArray2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetName_15(HandleRef pThis);

	/// <summary>
	/// Get the name of the image, not including the path or
	/// the extension.  This is only needed for printing the
	/// header and there is usually no need to set it.
	/// </summary>
	public virtual string GetName()
	{
		return Marshal.PtrToStringAnsi(vtkMINCImageAttributes_GetName_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMINCImageAttributes_GetNumberOfGenerationsFromBase_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMINCImageAttributes_GetNumberOfGenerationsFromBase_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMINCImageAttributes_GetNumberOfGenerationsFromBaseType_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMINCImageAttributes_GetNumberOfGenerationsFromBaseType_17(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageAttributes_GetNumberOfImageMinMaxDimensions_18(HandleRef pThis);

	/// <summary>
	/// Get the number of ImageMinMax dimensions.
	/// </summary>
	public virtual int GetNumberOfImageMinMaxDimensions()
	{
		return vtkMINCImageAttributes_GetNumberOfImageMinMaxDimensions_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageAttributes_GetValidateAttributes_19(HandleRef pThis);

	/// <summary>
	/// Set this to Off if you do not want to automatically validate
	/// every attribute that is set.
	/// </summary>
	public virtual int GetValidateAttributes()
	{
		return vtkMINCImageAttributes_GetValidateAttributes_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_GetVariableNames_20(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the names of all the variables.
	/// </summary>
	public virtual vtkStringArray GetVariableNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_GetVariableNames_20(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageAttributes_HasAttribute_21(HandleRef pThis, string variable, string attribute);

	/// <summary>
	/// Check to see if a particular attribute exists.
	/// </summary>
	public virtual int HasAttribute(string variable, string attribute)
	{
		return vtkMINCImageAttributes_HasAttribute_21(GetCppThis(), variable, attribute);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageAttributes_IsA_22(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMINCImageAttributes_IsA_22(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageAttributes_IsTypeOf_23(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMINCImageAttributes_IsTypeOf_23(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_NewInstance_25(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMINCImageAttributes NewInstance()
	{
		vtkMINCImageAttributes result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_NewInstance_25(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMINCImageAttributes)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_PrintFileHeader_26(HandleRef pThis);

	/// <summary>
	/// A diagnostic function.  Print the header of the file in
	/// the same format as ncdump or mincheader.
	/// </summary>
	public virtual void PrintFileHeader()
	{
		vtkMINCImageAttributes_PrintFileHeader_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_Reset_27(HandleRef pThis);

	/// <summary>
	/// Reset all the attributes in preparation for loading
	/// new information.
	/// </summary>
	public virtual void Reset()
	{
		vtkMINCImageAttributes_Reset_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMINCImageAttributes_SafeDownCast_28(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMINCImageAttributes SafeDownCast(vtkObjectBase o)
	{
		vtkMINCImageAttributes vtkMINCImageAttributes2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMINCImageAttributes_SafeDownCast_28(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkMINCImageAttributes_SetAttributeValueAsArray_29(HandleRef pThis, string variable, string attribute, HandleRef array);

	/// <summary>
	/// Set attribute values for a variable as a vtkDataArray.
	/// Set the variable to the empty string to access global attributes.
	/// </summary>
	public virtual void SetAttributeValueAsArray(string variable, string attribute, vtkDataArray array)
	{
		vtkMINCImageAttributes_SetAttributeValueAsArray_29(GetCppThis(), variable, attribute, array?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetAttributeValueAsDouble_30(HandleRef pThis, string variable, string attribute, double value);

	/// <summary>
	/// Set an attribute value as a double.  Set the variable
	/// to the empty string to access global attributes.
	/// If you specify a variable that does not exist, it will be
	/// created.
	/// </summary>
	public virtual void SetAttributeValueAsDouble(string variable, string attribute, double value)
	{
		vtkMINCImageAttributes_SetAttributeValueAsDouble_30(GetCppThis(), variable, attribute, value);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetAttributeValueAsInt_31(HandleRef pThis, string variable, string attribute, int value);

	/// <summary>
	/// Set an attribute value as an int. Set the variable
	/// to the empty string to access global attributes.
	/// If you specify a variable that does not exist, it will be
	/// created.
	/// </summary>
	public virtual void SetAttributeValueAsInt(string variable, string attribute, int value)
	{
		vtkMINCImageAttributes_SetAttributeValueAsInt_31(GetCppThis(), variable, attribute, value);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetAttributeValueAsString_32(HandleRef pThis, string variable, string attribute, string value);

	/// <summary>
	/// Set an attribute value as a string.  Set the variable
	/// to the empty string to access global attributes.
	/// If you specify a variable that does not exist, it will be
	/// created.
	/// </summary>
	public virtual void SetAttributeValueAsString(string variable, string attribute, string value)
	{
		vtkMINCImageAttributes_SetAttributeValueAsString_32(GetCppThis(), variable, attribute, value);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetDataType_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the image data type, as stored on disk.  This information
	/// is useful if the file was converted to floating-point when it
	/// was loaded.  When writing a file from float or double image data,
	/// you can use this method to prescribe the output type.
	/// </summary>
	public virtual void SetDataType(int _arg)
	{
		vtkMINCImageAttributes_SetDataType_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetImageMax_34(HandleRef pThis, HandleRef imageMax);

	/// <summary>
	/// Get the image min and max arrays. These are set by the reader,
	/// but they aren't used by the writer except to compute the full
	/// real data range of the original file.
	/// </summary>
	public virtual void SetImageMax(vtkDoubleArray imageMax)
	{
		vtkMINCImageAttributes_SetImageMax_34(GetCppThis(), imageMax?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetImageMin_35(HandleRef pThis, HandleRef imageMin);

	/// <summary>
	/// Get the image min and max arrays. These are set by the reader,
	/// but they aren't used by the writer except to compute the full
	/// real data range of the original file.
	/// </summary>
	public virtual void SetImageMin(vtkDoubleArray imageMin)
	{
		vtkMINCImageAttributes_SetImageMin_35(GetCppThis(), imageMin?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetName_36(HandleRef pThis, string _arg);

	/// <summary>
	/// Get the name of the image, not including the path or
	/// the extension.  This is only needed for printing the
	/// header and there is usually no need to set it.
	/// </summary>
	public virtual void SetName(string _arg)
	{
		vtkMINCImageAttributes_SetName_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetNumberOfImageMinMaxDimensions_37(HandleRef pThis, int _arg);

	/// <summary>
	/// Get the number of ImageMinMax dimensions.
	/// </summary>
	public virtual void SetNumberOfImageMinMaxDimensions(int _arg)
	{
		vtkMINCImageAttributes_SetNumberOfImageMinMaxDimensions_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_SetValidateAttributes_38(HandleRef pThis, int _arg);

	/// <summary>
	/// Set this to Off if you do not want to automatically validate
	/// every attribute that is set.
	/// </summary>
	public virtual void SetValidateAttributes(int _arg)
	{
		vtkMINCImageAttributes_SetValidateAttributes_38(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_ShallowCopy_39(HandleRef pThis, HandleRef source);

	/// <summary>
	/// Do a shallow copy.  This will copy all the attributes
	/// from the source.  It is much more efficient than a DeepCopy
	/// would be, since it only copies pointers to the attribute values
	/// instead of copying the arrays themselves.  You must use this
	/// method to make a copy if you want to modify any MINC attributes
	/// from a MINCReader before you pass them to a MINCWriter.
	/// </summary>
	public virtual void ShallowCopy(vtkMINCImageAttributes source)
	{
		vtkMINCImageAttributes_ShallowCopy_39(GetCppThis(), source?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMINCImageAttributes_ValidateAttribute_40(HandleRef pThis, string varname, string attname, HandleRef array);

	/// <summary>
	/// Validate a particular attribute.  This involves checking
	/// that the attribute is a MINC standard attribute, and checking
	/// whether it can be set (as opposed to being set automatically
	/// from the image information).  The return values is 0 if
	/// the attribute is set automatically and therefore should not
	/// be copied from here, 1 if this attribute is valid and should
	/// be set, and 2 if the attribute is non-standard.
	/// </summary>
	public virtual int ValidateAttribute(string varname, string attname, vtkDataArray array)
	{
		return vtkMINCImageAttributes_ValidateAttribute_40(GetCppThis(), varname, attname, array?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_ValidateAttributesOff_41(HandleRef pThis);

	/// <summary>
	/// Set this to Off if you do not want to automatically validate
	/// every attribute that is set.
	/// </summary>
	public virtual void ValidateAttributesOff()
	{
		vtkMINCImageAttributes_ValidateAttributesOff_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMINCImageAttributes_ValidateAttributesOn_42(HandleRef pThis);

	/// <summary>
	/// Set this to Off if you do not want to automatically validate
	/// every attribute that is set.
	/// </summary>
	public virtual void ValidateAttributesOn()
	{
		vtkMINCImageAttributes_ValidateAttributesOn_42(GetCppThis());
	}
}
