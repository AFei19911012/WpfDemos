using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataReader
/// </summary>
/// <remarks>
///    helper superclass for objects that read vtk data files
///
/// vtkDataReader is a helper superclass that reads the vtk data file header,
/// dataset type, and attribute data (point and cell attributes such as
/// scalars, vectors, normals, etc.) from a vtk data file.  See text for
/// the format of the various vtk file types.
///
/// </remarks>
/// <seealso>
///
/// vtkPolyDataReader vtkStructuredPointsReader vtkStructuredGridReader
/// vtkUnstructuredGridReader vtkRectilinearGridReader
/// </seealso>
public class vtkDataReader : vtkSimpleReader
{
	/// <summary>
	///             Undocumented Block
	/// </summary>
	public enum FieldType
	{
		/// <summary>enum member</summary>
		CELL_DATA = 1,
		/// <summary>enum member</summary>
		FIELD_DATA = 2,
		/// <summary>enum member</summary>
		POINT_DATA = 0
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataReader()
	{
		MRClassNameKey = "class vtkDataReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataReader New()
	{
		vtkDataReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkDataReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_CloseVTKFile_01(HandleRef pThis);

	/// <summary>
	/// Close the vtk file.
	/// </summary>
	public void CloseVTKFile()
	{
		vtkDataReader_CloseVTKFile_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetFieldDataName_02(HandleRef pThis);

	/// <summary>
	/// Set the name of the field data to extract. If not specified, uses
	/// first field data encountered in file.
	/// </summary>
	public virtual string GetFieldDataName()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetFieldDataName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetFieldDataNameInFile_03(HandleRef pThis, int i);

	/// <summary>
	/// What is the name of the ith attribute of a certain type
	/// in this file? This requires reading the file, so the filename
	/// must be set prior to invoking this operation.
	/// </summary>
	public string GetFieldDataNameInFile(int i)
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetFieldDataNameInFile_03(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetFileMajorVersion_04(HandleRef pThis);

	/// <summary>
	/// Return the version of the file read; for example, VTK legacy readers
	/// will return the version of the VTK legacy file. (In the case of VTK
	/// legacy files, see vtkDataWriter.h for the enum types returned.) This
	/// method only returns useful information after a successful read is
	/// performed; and some derived classes may not return relevant
	/// information.) Note that for VTK legacy readers, the FileVersion is
	/// defined by the compositing the major version digits with the minor
	/// version digit. Extremely ancient VTK files (e.g., before version 4.2)
	/// will return a FileVersion of 3.0.
	/// </summary>
	public virtual int GetFileMajorVersion()
	{
		return vtkDataReader_GetFileMajorVersion_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetFileMinorVersion_05(HandleRef pThis);

	/// <summary>
	/// Return the version of the file read; for example, VTK legacy readers
	/// will return the version of the VTK legacy file. (In the case of VTK
	/// legacy files, see vtkDataWriter.h for the enum types returned.) This
	/// method only returns useful information after a successful read is
	/// performed; and some derived classes may not return relevant
	/// information.) Note that for VTK legacy readers, the FileVersion is
	/// defined by the compositing the major version digits with the minor
	/// version digit. Extremely ancient VTK files (e.g., before version 4.2)
	/// will return a FileVersion of 3.0.
	/// </summary>
	public virtual int GetFileMinorVersion()
	{
		return vtkDataReader_GetFileMinorVersion_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetFileName_06(HandleRef pThis);

	/// <summary>
	/// Specify file name of vtk data file to read. This is just
	/// a convenience method that calls the superclass' AddFileName
	/// method.
	/// </summary>
	public string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetFileName_07(HandleRef pThis, int i);

	/// <summary>
	/// Specify file name of vtk data file to read. This is just
	/// a convenience method that calls the superclass' AddFileName
	/// method.
	/// </summary>
	public new string GetFileName(int i)
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetFileName_07(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetFileType_08(HandleRef pThis);

	/// <summary>
	/// Get the type of file (ASCII or BINARY). Returned value only valid
	/// after file has been read.
	/// </summary>
	public virtual int GetFileType()
	{
		return vtkDataReader_GetFileType_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetFileVersion_09(HandleRef pThis);

	/// <summary>
	/// Return the version of the file read; for example, VTK legacy readers
	/// will return the version of the VTK legacy file. (In the case of VTK
	/// legacy files, see vtkDataWriter.h for the enum types returned.) This
	/// method only returns useful information after a successful read is
	/// performed; and some derived classes may not return relevant
	/// information.) Note that for VTK legacy readers, the FileVersion is
	/// defined by the compositing the major version digits with the minor
	/// version digit. Extremely ancient VTK files (e.g., before version 4.2)
	/// will return a FileVersion of 3.0.
	/// </summary>
	public virtual int GetFileVersion()
	{
		return vtkDataReader_GetFileVersion_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetHeader_10(HandleRef pThis);

	/// <summary>
	/// Get the header from the vtk data file.
	/// </summary>
	public virtual string GetHeader()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetHeader_10(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetInputArray_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the vtkCharArray to be used  when reading from a string.
	/// If set, this array has precedence over InputString.
	/// Use this instead of InputString to avoid the extra memory copy.
	/// It should be noted that if the underlying char* is owned by the
	/// user ( vtkCharArray::SetArray(array, 1); ) and is deleted before
	/// the reader, bad things will happen during a pipeline update.
	/// </summary>
	public virtual vtkCharArray GetInputArray()
	{
		vtkCharArray vtkCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataReader_GetInputArray_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkCharArray2 = (vtkCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkCharArray2.Register(null);
			}
		}
		return vtkCharArray2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetInputString_12(HandleRef pThis);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public virtual string GetInputString()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetInputString_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetInputStringLength_13(HandleRef pThis);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public virtual int GetInputStringLength()
	{
		return vtkDataReader_GetInputStringLength_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetLookupTableName_14(HandleRef pThis);

	/// <summary>
	/// Set the name of the lookup table data to extract. If not specified, uses
	/// lookup table named by scalar. Otherwise, this specification supersedes.
	/// </summary>
	public virtual string GetLookupTableName()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetLookupTableName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetNormalsName_15(HandleRef pThis);

	/// <summary>
	/// Set the name of the normal data to extract. If not specified, first
	/// normal data encountered is extracted.
	/// </summary>
	public virtual string GetNormalsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetNormalsName_15(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetNormalsNameInFile_16(HandleRef pThis, int i);

	/// <summary>
	/// What is the name of the ith attribute of a certain type
	/// in this file? This requires reading the file, so the filename
	/// must be set prior to invoking this operation.
	/// </summary>
	public string GetNormalsNameInFile(int i)
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetNormalsNameInFile_16(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetNumberOfFieldDataInFile_17(HandleRef pThis);

	/// <summary>
	/// How many attributes of various types are in this file? This
	/// requires reading the file, so the filename must be set prior
	/// to invoking this operation. (Note: file characteristics are
	/// cached, so only a single read is necessary to return file
	/// characteristics.)
	/// </summary>
	public int GetNumberOfFieldDataInFile()
	{
		return vtkDataReader_GetNumberOfFieldDataInFile_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataReader_GetNumberOfGenerationsFromBase_18(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataReader_GetNumberOfGenerationsFromBase_18(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataReader_GetNumberOfGenerationsFromBaseType_19(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataReader_GetNumberOfGenerationsFromBaseType_19(type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetNumberOfNormalsInFile_20(HandleRef pThis);

	/// <summary>
	/// How many attributes of various types are in this file? This
	/// requires reading the file, so the filename must be set prior
	/// to invoking this operation. (Note: file characteristics are
	/// cached, so only a single read is necessary to return file
	/// characteristics.)
	/// </summary>
	public int GetNumberOfNormalsInFile()
	{
		return vtkDataReader_GetNumberOfNormalsInFile_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetNumberOfScalarsInFile_21(HandleRef pThis);

	/// <summary>
	/// How many attributes of various types are in this file? This
	/// requires reading the file, so the filename must be set prior
	/// to invoking this operation. (Note: file characteristics are
	/// cached, so only a single read is necessary to return file
	/// characteristics.)
	/// </summary>
	public int GetNumberOfScalarsInFile()
	{
		return vtkDataReader_GetNumberOfScalarsInFile_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetNumberOfTCoordsInFile_22(HandleRef pThis);

	/// <summary>
	/// How many attributes of various types are in this file? This
	/// requires reading the file, so the filename must be set prior
	/// to invoking this operation. (Note: file characteristics are
	/// cached, so only a single read is necessary to return file
	/// characteristics.)
	/// </summary>
	public int GetNumberOfTCoordsInFile()
	{
		return vtkDataReader_GetNumberOfTCoordsInFile_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetNumberOfTensorsInFile_23(HandleRef pThis);

	/// <summary>
	/// How many attributes of various types are in this file? This
	/// requires reading the file, so the filename must be set prior
	/// to invoking this operation. (Note: file characteristics are
	/// cached, so only a single read is necessary to return file
	/// characteristics.)
	/// </summary>
	public int GetNumberOfTensorsInFile()
	{
		return vtkDataReader_GetNumberOfTensorsInFile_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetNumberOfVectorsInFile_24(HandleRef pThis);

	/// <summary>
	/// How many attributes of various types are in this file? This
	/// requires reading the file, so the filename must be set prior
	/// to invoking this operation. (Note: file characteristics are
	/// cached, so only a single read is necessary to return file
	/// characteristics.)
	/// </summary>
	public int GetNumberOfVectorsInFile()
	{
		return vtkDataReader_GetNumberOfVectorsInFile_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetReadAllColorScalars_25(HandleRef pThis);

	/// <summary>
	/// Enable reading all color scalars.
	/// </summary>
	public virtual int GetReadAllColorScalars()
	{
		return vtkDataReader_GetReadAllColorScalars_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetReadAllFields_26(HandleRef pThis);

	/// <summary>
	/// Enable reading all fields.
	/// </summary>
	public virtual int GetReadAllFields()
	{
		return vtkDataReader_GetReadAllFields_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetReadAllNormals_27(HandleRef pThis);

	/// <summary>
	/// Enable reading all normals.
	/// </summary>
	public virtual int GetReadAllNormals()
	{
		return vtkDataReader_GetReadAllNormals_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetReadAllScalars_28(HandleRef pThis);

	/// <summary>
	/// Enable reading all scalars.
	/// </summary>
	public virtual int GetReadAllScalars()
	{
		return vtkDataReader_GetReadAllScalars_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetReadAllTCoords_29(HandleRef pThis);

	/// <summary>
	/// Enable reading all tcoords.
	/// </summary>
	public virtual int GetReadAllTCoords()
	{
		return vtkDataReader_GetReadAllTCoords_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetReadAllTensors_30(HandleRef pThis);

	/// <summary>
	/// Enable reading all tensors.
	/// </summary>
	public virtual int GetReadAllTensors()
	{
		return vtkDataReader_GetReadAllTensors_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetReadAllVectors_31(HandleRef pThis);

	/// <summary>
	/// Enable reading all vectors.
	/// </summary>
	public virtual int GetReadAllVectors()
	{
		return vtkDataReader_GetReadAllVectors_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_GetReadFromInputString_32(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString or InputArray instead of the default,
	/// a file.
	/// </summary>
	public virtual int GetReadFromInputString()
	{
		return vtkDataReader_GetReadFromInputString_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetScalarsName_33(HandleRef pThis);

	/// <summary>
	/// Set the name of the scalar data to extract. If not specified, first
	/// scalar data encountered is extracted.
	/// </summary>
	public virtual string GetScalarsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetScalarsName_33(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetScalarsNameInFile_34(HandleRef pThis, int i);

	/// <summary>
	/// What is the name of the ith attribute of a certain type
	/// in this file? This requires reading the file, so the filename
	/// must be set prior to invoking this operation.
	/// </summary>
	public string GetScalarsNameInFile(int i)
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetScalarsNameInFile_34(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetTCoordsName_35(HandleRef pThis);

	/// <summary>
	/// Set the name of the texture coordinate data to extract. If not specified,
	/// first texture coordinate data encountered is extracted.
	/// </summary>
	public virtual string GetTCoordsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetTCoordsName_35(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetTCoordsNameInFile_36(HandleRef pThis, int i);

	/// <summary>
	/// What is the name of the ith attribute of a certain type
	/// in this file? This requires reading the file, so the filename
	/// must be set prior to invoking this operation.
	/// </summary>
	public string GetTCoordsNameInFile(int i)
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetTCoordsNameInFile_36(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetTensorsName_37(HandleRef pThis);

	/// <summary>
	/// Set the name of the tensor data to extract. If not specified, first
	/// tensor data encountered is extracted.
	/// </summary>
	public virtual string GetTensorsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetTensorsName_37(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetTensorsNameInFile_38(HandleRef pThis, int i);

	/// <summary>
	/// What is the name of the ith attribute of a certain type
	/// in this file? This requires reading the file, so the filename
	/// must be set prior to invoking this operation.
	/// </summary>
	public string GetTensorsNameInFile(int i)
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetTensorsNameInFile_38(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetVectorsName_39(HandleRef pThis);

	/// <summary>
	/// Set the name of the vector data to extract. If not specified, first
	/// vector data encountered is extracted.
	/// </summary>
	public virtual string GetVectorsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetVectorsName_39(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_GetVectorsNameInFile_40(HandleRef pThis, int i);

	/// <summary>
	/// What is the name of the ith attribute of a certain type
	/// in this file? This requires reading the file, so the filename
	/// must be set prior to invoking this operation.
	/// </summary>
	public string GetVectorsNameInFile(int i)
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_GetVectorsNameInFile_40(GetCppThis(), i));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_IsA_41(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataReader_IsA_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_IsFilePolyData_42(HandleRef pThis);

	/// <summary>
	/// Is the file a valid vtk file of the passed dataset type ?
	/// The dataset type is passed as a lower case string.
	/// </summary>
	public int IsFilePolyData()
	{
		return vtkDataReader_IsFilePolyData_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_IsFileRectilinearGrid_43(HandleRef pThis);

	/// <summary>
	/// Is the file a valid vtk file of the passed dataset type ?
	/// The dataset type is passed as a lower case string.
	/// </summary>
	public int IsFileRectilinearGrid()
	{
		return vtkDataReader_IsFileRectilinearGrid_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_IsFileStructuredGrid_44(HandleRef pThis);

	/// <summary>
	/// Is the file a valid vtk file of the passed dataset type ?
	/// The dataset type is passed as a lower case string.
	/// </summary>
	public int IsFileStructuredGrid()
	{
		return vtkDataReader_IsFileStructuredGrid_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_IsFileStructuredPoints_45(HandleRef pThis);

	/// <summary>
	/// Is the file a valid vtk file of the passed dataset type ?
	/// The dataset type is passed as a lower case string.
	/// </summary>
	public int IsFileStructuredPoints()
	{
		return vtkDataReader_IsFileStructuredPoints_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_IsFileUnstructuredGrid_46(HandleRef pThis);

	/// <summary>
	/// Is the file a valid vtk file of the passed dataset type ?
	/// The dataset type is passed as a lower case string.
	/// </summary>
	public int IsFileUnstructuredGrid()
	{
		return vtkDataReader_IsFileUnstructuredGrid_46(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_IsFileValid_47(HandleRef pThis, string dstype);

	/// <summary>
	/// Is the file a valid vtk file of the passed dataset type ?
	/// The dataset type is passed as a lower case string.
	/// </summary>
	public int IsFileValid(string dstype)
	{
		return vtkDataReader_IsFileValid_47(GetCppThis(), dstype);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_IsTypeOf_48(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataReader_IsTypeOf_48(type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_LowerCase_49(HandleRef pThis, string str, ulong len);

	/// <summary>
	/// Helper method for reading in data.
	/// </summary>
	public string LowerCase(string str, ulong len)
	{
		return Marshal.PtrToStringAnsi(vtkDataReader_LowerCase_49(GetCppThis(), str, len));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_NewInstance_51(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataReader NewInstance()
	{
		vtkDataReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataReader_NewInstance_51(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_OpenVTKFile_52(HandleRef pThis, string fname);

	/// <summary>
	/// Open a vtk data file. Returns zero if error.
	/// </summary>
	public int OpenVTKFile(string fname)
	{
		return vtkDataReader_OpenVTKFile_52(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDataReader_Peek_53(HandleRef pThis, string str, ulong n);

	/// <summary>
	/// Read @a n character from the stream into @a str, then reset the stream
	/// position. Returns the number of characters actually read.
	/// </summary>
	public ulong Peek(string str, ulong n)
	{
		return vtkDataReader_Peek_53(GetCppThis(), str, n);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_Read_54(HandleRef pThis, string arg0);

	/// <summary>
	/// Internal function to read in a value.  Returns zero if there was an
	/// error.
	/// </summary>
	public int Read(string arg0)
	{
		return vtkDataReader_Read_54(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_Read_55(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Internal function to read in a value.  Returns zero if there was an
	/// error.
	/// </summary>
	public int Read(IntPtr arg0)
	{
		return vtkDataReader_Read_55(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllColorScalarsOff_56(HandleRef pThis);

	/// <summary>
	/// Enable reading all color scalars.
	/// </summary>
	public virtual void ReadAllColorScalarsOff()
	{
		vtkDataReader_ReadAllColorScalarsOff_56(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllColorScalarsOn_57(HandleRef pThis);

	/// <summary>
	/// Enable reading all color scalars.
	/// </summary>
	public virtual void ReadAllColorScalarsOn()
	{
		vtkDataReader_ReadAllColorScalarsOn_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllFieldsOff_58(HandleRef pThis);

	/// <summary>
	/// Enable reading all fields.
	/// </summary>
	public virtual void ReadAllFieldsOff()
	{
		vtkDataReader_ReadAllFieldsOff_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllFieldsOn_59(HandleRef pThis);

	/// <summary>
	/// Enable reading all fields.
	/// </summary>
	public virtual void ReadAllFieldsOn()
	{
		vtkDataReader_ReadAllFieldsOn_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllNormalsOff_60(HandleRef pThis);

	/// <summary>
	/// Enable reading all normals.
	/// </summary>
	public virtual void ReadAllNormalsOff()
	{
		vtkDataReader_ReadAllNormalsOff_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllNormalsOn_61(HandleRef pThis);

	/// <summary>
	/// Enable reading all normals.
	/// </summary>
	public virtual void ReadAllNormalsOn()
	{
		vtkDataReader_ReadAllNormalsOn_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllScalarsOff_62(HandleRef pThis);

	/// <summary>
	/// Enable reading all scalars.
	/// </summary>
	public virtual void ReadAllScalarsOff()
	{
		vtkDataReader_ReadAllScalarsOff_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllScalarsOn_63(HandleRef pThis);

	/// <summary>
	/// Enable reading all scalars.
	/// </summary>
	public virtual void ReadAllScalarsOn()
	{
		vtkDataReader_ReadAllScalarsOn_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllTCoordsOff_64(HandleRef pThis);

	/// <summary>
	/// Enable reading all tcoords.
	/// </summary>
	public virtual void ReadAllTCoordsOff()
	{
		vtkDataReader_ReadAllTCoordsOff_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllTCoordsOn_65(HandleRef pThis);

	/// <summary>
	/// Enable reading all tcoords.
	/// </summary>
	public virtual void ReadAllTCoordsOn()
	{
		vtkDataReader_ReadAllTCoordsOn_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllTensorsOff_66(HandleRef pThis);

	/// <summary>
	/// Enable reading all tensors.
	/// </summary>
	public virtual void ReadAllTensorsOff()
	{
		vtkDataReader_ReadAllTensorsOff_66(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllTensorsOn_67(HandleRef pThis);

	/// <summary>
	/// Enable reading all tensors.
	/// </summary>
	public virtual void ReadAllTensorsOn()
	{
		vtkDataReader_ReadAllTensorsOn_67(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllVectorsOff_68(HandleRef pThis);

	/// <summary>
	/// Enable reading all vectors.
	/// </summary>
	public virtual void ReadAllVectorsOff()
	{
		vtkDataReader_ReadAllVectorsOff_68(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadAllVectorsOn_69(HandleRef pThis);

	/// <summary>
	/// Enable reading all vectors.
	/// </summary>
	public virtual void ReadAllVectorsOn()
	{
		vtkDataReader_ReadAllVectorsOn_69(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_ReadArray_70(HandleRef pThis, string dataType, long numTuples, long numComp, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Helper functions for reading data.
	/// </summary>
	public vtkAbstractArray ReadArray(string dataType, long numTuples, long numComp)
	{
		vtkAbstractArray vtkAbstractArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataReader_ReadArray_70(GetCppThis(), dataType, numTuples, numComp, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAbstractArray2 = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAbstractArray2.Register(null);
			}
		}
		return vtkAbstractArray2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadArrays_71(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

	/// <summary>
	/// Overridden to handle reading from a string. The
	/// superclass only knows about files.
	/// </summary>
	public override int ReadArrays(int arg0, int arg1, int arg2, int arg3, vtkDataObject arg4)
	{
		return vtkDataReader_ReadArrays_71(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadArraysSimple_72(HandleRef pThis, string arg0, HandleRef arg1);

	/// <summary>
	/// Overridden with default implementation of doing nothing
	/// so that subclasses only override what is needed (usually
	/// only ReadMesh).
	/// </summary>
	public override int ReadArraysSimple(string arg0, vtkDataObject arg1)
	{
		return vtkDataReader_ReadArraysSimple_72(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadCellData_73(HandleRef pThis, HandleRef ds, long numCells);

	/// <summary>
	/// Read the cell data of a vtk data file. The number of cells (from the
	/// dataset) must match the number of cells defined in cell attributes (unless
	/// no geometry was defined).
	/// </summary>
	public int ReadCellData(vtkDataSet ds, long numCells)
	{
		return vtkDataReader_ReadCellData_73(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef), numCells);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadCellsLegacy_74(HandleRef pThis, long size, IntPtr data);

	/// <summary>
	/// Read a bunch of "cells". Return 0 if error.
	/// @note Legacy implementation for file versions &lt; 5.0.
	/// </summary>
	public int ReadCellsLegacy(long size, IntPtr data)
	{
		return vtkDataReader_ReadCellsLegacy_74(GetCppThis(), size, data);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadCellsLegacy_75(HandleRef pThis, long size, IntPtr data, int skip1, int read2, int skip3);

	/// <summary>
	/// Read a piece of the cells (for streaming compliance)
	/// </summary>
	public int ReadCellsLegacy(long size, IntPtr data, int skip1, int read2, int skip3)
	{
		return vtkDataReader_ReadCellsLegacy_75(GetCppThis(), size, data, skip1, read2, skip3);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadCoordinates_76(HandleRef pThis, HandleRef rg, int axes, int numCoords);

	/// <summary>
	/// Read the coordinates for a rectilinear grid. The axes parameter specifies
	/// which coordinate axes (0,1,2) is being read.
	/// </summary>
	public int ReadCoordinates(vtkRectilinearGrid rg, int axes, int numCoords)
	{
		return vtkDataReader_ReadCoordinates_76(GetCppThis(), rg?.GetCppThis() ?? default(HandleRef), axes, numCoords);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadEdgeData_77(HandleRef pThis, HandleRef g, long numEdges);

	/// <summary>
	/// Read the edge data of a vtk data file. The number of edges (from the
	/// graph) must match the number of edges defined in edge attributes
	/// (unless no geometry was defined).
	/// </summary>
	public int ReadEdgeData(vtkGraph g, long numEdges)
	{
		return vtkDataReader_ReadEdgeData_77(GetCppThis(), g?.GetCppThis() ?? default(HandleRef), numEdges);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_ReadFieldData_78(HandleRef pThis, FieldType fieldType, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Helper functions for reading data.
	/// </summary>
	public vtkFieldData ReadFieldData(FieldType fieldType)
	{
		vtkFieldData vtkFieldData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataReader_ReadFieldData_78(GetCppThis(), fieldType, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkFieldData2 = (vtkFieldData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkFieldData2.Register(null);
			}
		}
		return vtkFieldData2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadFromInputStringOff_79(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString or InputArray instead of the default,
	/// a file.
	/// </summary>
	public virtual void ReadFromInputStringOff()
	{
		vtkDataReader_ReadFromInputStringOff_79(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_ReadFromInputStringOn_80(HandleRef pThis);

	/// <summary>
	/// Enable reading from an InputString or InputArray instead of the default,
	/// a file.
	/// </summary>
	public virtual void ReadFromInputStringOn()
	{
		vtkDataReader_ReadFromInputStringOn_80(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadHeader_81(HandleRef pThis, string fname);

	/// <summary>
	/// Read the header of a vtk data file. Returns 0 if error.
	/// </summary>
	public int ReadHeader(string fname)
	{
		return vtkDataReader_ReadHeader_81(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadLine_82(HandleRef pThis, string result);

	/// <summary>
	/// Internal function to read in a line up to 256 characters.
	/// Returns zero if there was an error.
	/// </summary>
	public int ReadLine(string result)
	{
		return vtkDataReader_ReadLine_82(GetCppThis(), result);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadMesh_83(HandleRef pThis, int piece, int npieces, int nghosts, int timestep, HandleRef output);

	/// <summary>
	/// Overridden to handle reading from a string. The
	/// superclass only knows about files.
	/// </summary>
	public override int ReadMesh(int piece, int npieces, int nghosts, int timestep, vtkDataObject output)
	{
		return vtkDataReader_ReadMesh_83(GetCppThis(), piece, npieces, nghosts, timestep, output?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadMeshSimple_84(HandleRef pThis, string arg0, HandleRef arg1);

	/// <summary>
	/// Overridden with default implementation of doing nothing
	/// so that subclasses only override what is needed (usually
	/// only ReadMesh).
	/// </summary>
	public override int ReadMeshSimple(string arg0, vtkDataObject arg1)
	{
		return vtkDataReader_ReadMeshSimple_84(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadPointCoordinates_85(HandleRef pThis, HandleRef ps, long numPts);

	/// <summary>
	/// Read point coordinates. Return 0 if error.
	/// </summary>
	public int ReadPointCoordinates(vtkPointSet ps, long numPts)
	{
		return vtkDataReader_ReadPointCoordinates_85(GetCppThis(), ps?.GetCppThis() ?? default(HandleRef), numPts);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadPointCoordinates_86(HandleRef pThis, HandleRef g, long numPts);

	/// <summary>
	/// Read point coordinates. Return 0 if error.
	/// </summary>
	public int ReadPointCoordinates(vtkGraph g, long numPts)
	{
		return vtkDataReader_ReadPointCoordinates_86(GetCppThis(), g?.GetCppThis() ?? default(HandleRef), numPts);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadPointData_87(HandleRef pThis, HandleRef ds, long numPts);

	/// <summary>
	/// Read the point data of a vtk data file. The number of points (from the
	/// dataset) must match the number of points defined in point attributes
	/// (unless no geometry was defined).
	/// </summary>
	public int ReadPointData(vtkDataSet ds, long numPts)
	{
		return vtkDataReader_ReadPointData_87(GetCppThis(), ds?.GetCppThis() ?? default(HandleRef), numPts);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadPoints_88(HandleRef pThis, int arg0, int arg1, int arg2, int arg3, HandleRef arg4);

	/// <summary>
	/// Overridden to handle reading from a string. The
	/// superclass only knows about files.
	/// </summary>
	public override int ReadPoints(int arg0, int arg1, int arg2, int arg3, vtkDataObject arg4)
	{
		return vtkDataReader_ReadPoints_88(GetCppThis(), arg0, arg1, arg2, arg3, arg4?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadPointsSimple_89(HandleRef pThis, string arg0, HandleRef arg1);

	/// <summary>
	/// Overridden with default implementation of doing nothing
	/// so that subclasses only override what is needed (usually
	/// only ReadMesh).
	/// </summary>
	public override int ReadPointsSimple(string arg0, vtkDataObject arg1)
	{
		return vtkDataReader_ReadPointsSimple_89(GetCppThis(), arg0, arg1?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadRowData_90(HandleRef pThis, HandleRef t, long numEdges);

	/// <summary>
	/// Read the row data of a vtk data file.
	/// </summary>
	public int ReadRowData(vtkTable t, long numEdges)
	{
		return vtkDataReader_ReadRowData_90(GetCppThis(), t?.GetCppThis() ?? default(HandleRef), numEdges);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadTimeDependentMetaData_91(HandleRef pThis, int timestep, HandleRef metadata);

	/// <summary>
	/// Overridden to handle reading from a string. The
	/// superclass only knows about files.
	/// </summary>
	public override int ReadTimeDependentMetaData(int timestep, vtkInformation metadata)
	{
		return vtkDataReader_ReadTimeDependentMetaData_91(GetCppThis(), timestep, metadata?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataReader_ReadVertexData_92(HandleRef pThis, HandleRef g, long numVertices);

	/// <summary>
	/// Read the vertex data of a vtk data file. The number of vertices (from the
	/// graph) must match the number of vertices defined in vertex attributes
	/// (unless no geometry was defined).
	/// </summary>
	public int ReadVertexData(vtkGraph g, long numVertices)
	{
		return vtkDataReader_ReadVertexData_92(GetCppThis(), g?.GetCppThis() ?? default(HandleRef), numVertices);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataReader_SafeDownCast_93(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataReader SafeDownCast(vtkObjectBase o)
	{
		vtkDataReader vtkDataReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataReader_SafeDownCast_93(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataReader2 = (vtkDataReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataReader2.Register(null);
			}
		}
		return vtkDataReader2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetBinaryInputString_94(HandleRef pThis, string arg0, int len);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public void SetBinaryInputString(string arg0, int len)
	{
		vtkDataReader_SetBinaryInputString_94(GetCppThis(), arg0, len);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetFieldDataName_95(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the field data to extract. If not specified, uses
	/// first field data encountered in file.
	/// </summary>
	public virtual void SetFieldDataName(string _arg)
	{
		vtkDataReader_SetFieldDataName_95(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetFileName_96(HandleRef pThis, string fname);

	/// <summary>
	/// Specify file name of vtk data file to read. This is just
	/// a convenience method that calls the superclass' AddFileName
	/// method.
	/// </summary>
	public void SetFileName(string fname)
	{
		vtkDataReader_SetFileName_96(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetInputArray_97(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the vtkCharArray to be used  when reading from a string.
	/// If set, this array has precedence over InputString.
	/// Use this instead of InputString to avoid the extra memory copy.
	/// It should be noted that if the underlying char* is owned by the
	/// user ( vtkCharArray::SetArray(array, 1); ) and is deleted before
	/// the reader, bad things will happen during a pipeline update.
	/// </summary>
	public virtual void SetInputArray(vtkCharArray arg0)
	{
		vtkDataReader_SetInputArray_97(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetInputString_98(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public void SetInputString(string arg0)
	{
		vtkDataReader_SetInputString_98(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetInputString_99(HandleRef pThis, string arg0, int len);

	/// <summary>
	/// Specify the InputString for use when reading from a character array.
	/// Optionally include the length for binary strings. Note that a copy
	/// of the string is made and stored. If this causes exceedingly large
	/// memory consumption, consider using InputArray instead.
	/// </summary>
	public void SetInputString(string arg0, int len)
	{
		vtkDataReader_SetInputString_99(GetCppThis(), arg0, len);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetLookupTableName_100(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the lookup table data to extract. If not specified, uses
	/// lookup table named by scalar. Otherwise, this specification supersedes.
	/// </summary>
	public virtual void SetLookupTableName(string _arg)
	{
		vtkDataReader_SetLookupTableName_100(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetNormalsName_101(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the normal data to extract. If not specified, first
	/// normal data encountered is extracted.
	/// </summary>
	public virtual void SetNormalsName(string _arg)
	{
		vtkDataReader_SetNormalsName_101(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetReadAllColorScalars_102(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading all color scalars.
	/// </summary>
	public virtual void SetReadAllColorScalars(int _arg)
	{
		vtkDataReader_SetReadAllColorScalars_102(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetReadAllFields_103(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading all fields.
	/// </summary>
	public virtual void SetReadAllFields(int _arg)
	{
		vtkDataReader_SetReadAllFields_103(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetReadAllNormals_104(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading all normals.
	/// </summary>
	public virtual void SetReadAllNormals(int _arg)
	{
		vtkDataReader_SetReadAllNormals_104(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetReadAllScalars_105(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading all scalars.
	/// </summary>
	public virtual void SetReadAllScalars(int _arg)
	{
		vtkDataReader_SetReadAllScalars_105(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetReadAllTCoords_106(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading all tcoords.
	/// </summary>
	public virtual void SetReadAllTCoords(int _arg)
	{
		vtkDataReader_SetReadAllTCoords_106(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetReadAllTensors_107(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading all tensors.
	/// </summary>
	public virtual void SetReadAllTensors(int _arg)
	{
		vtkDataReader_SetReadAllTensors_107(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetReadAllVectors_108(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading all vectors.
	/// </summary>
	public virtual void SetReadAllVectors(int _arg)
	{
		vtkDataReader_SetReadAllVectors_108(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetReadFromInputString_109(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable reading from an InputString or InputArray instead of the default,
	/// a file.
	/// </summary>
	public virtual void SetReadFromInputString(int _arg)
	{
		vtkDataReader_SetReadFromInputString_109(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetScalarsName_110(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the scalar data to extract. If not specified, first
	/// scalar data encountered is extracted.
	/// </summary>
	public virtual void SetScalarsName(string _arg)
	{
		vtkDataReader_SetScalarsName_110(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetTCoordsName_111(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the texture coordinate data to extract. If not specified,
	/// first texture coordinate data encountered is extracted.
	/// </summary>
	public virtual void SetTCoordsName(string _arg)
	{
		vtkDataReader_SetTCoordsName_111(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetTensorsName_112(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the tensor data to extract. If not specified, first
	/// tensor data encountered is extracted.
	/// </summary>
	public virtual void SetTensorsName(string _arg)
	{
		vtkDataReader_SetTensorsName_112(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataReader_SetVectorsName_113(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the name of the vector data to extract. If not specified, first
	/// vector data encountered is extracted.
	/// </summary>
	public virtual void SetVectorsName(string _arg)
	{
		vtkDataReader_SetVectorsName_113(GetCppThis(), _arg);
	}
}
