using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataWriter
/// </summary>
/// <remarks>
///    helper class for objects that write VTK data files
///
/// vtkDataWriter is a helper class that opens and writes the VTK header and
/// point data (e.g., scalars, vectors, normals, etc.) from a vtk data file.
/// See the VTK textbook and online resources for various formats.
///
/// </remarks>
/// <seealso>
///
/// vtkDataSetWriter vtkPolyDataWriter vtkStructuredGridWriter
/// vtkStructuredPointsWriter vtkUnstructuredGridWriter
/// vtkFieldDataWriter vtkRectilinearGridWriter
/// </seealso>
public class vtkDataWriter : vtkWriter
{
	/// <summary>
	/// Specify the file name of VTK data file to write.
	/// </summary>
	public enum VTKFileVersion
	{
		/// <summary>enum member</summary>
		VTK_LEGACY_READER_VERSION_4_2 = 42,
		/// <summary>enum member</summary>
		VTK_LEGACY_READER_VERSION_5_1 = 51
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataWriter()
	{
		MRClassNameKey = "class vtkDataWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Create object with default header, ASCII format, and default names for
	/// scalars, vectors, tensors, normals, and texture coordinates.
	/// </summary>
	public new static vtkDataWriter New()
	{
		vtkDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Create object with default header, ASCII format, and default names for
	/// scalars, vectors, tensors, normals, and texture coordinates.
	/// </summary>
	public vtkDataWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkDataWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkDataWriter_GetBinaryOutputString_01(HandleRef pThis);

	/// <summary>
	/// When WriteToOutputString in on, then a string is allocated, written to,
	/// and can be retrieved with these methods.  The string is deleted during
	/// the next call to write ...
	/// </summary>
	public IntPtr GetBinaryOutputString()
	{
		return vtkDataWriter_GetBinaryOutputString_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetEdgeFlagsName_02(HandleRef pThis);

	/// <summary>
	/// Give a name to the edge flags data. If not specified, uses
	/// default name "edge_flags".
	/// </summary>
	public virtual string GetEdgeFlagsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetEdgeFlagsName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetFieldDataName_03(HandleRef pThis);

	/// <summary>
	/// Give a name to the field data. If not specified, uses default
	/// name "field".
	/// </summary>
	public virtual string GetFieldDataName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetFieldDataName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_GetFileMajorVersion_04(HandleRef pThis);

	/// <summary>
	/// Specify the VTK file version to write. See the enum documentation above
	/// (VTKFileVersion) for additional information about supported versions.
	/// It is possible to get the file major and minor versions separately.  See
	/// also vtkDataReader for related methods. (Note, the parsing of the
	/// FileVersion into major and minor version is as follows: the least
	/// significant digit is the minor version; the remaining digits are the
	/// major version.
	/// </summary>
	public virtual int GetFileMajorVersion()
	{
		return vtkDataWriter_GetFileMajorVersion_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_GetFileMinorVersion_05(HandleRef pThis);

	/// <summary>
	/// Specify the VTK file version to write. See the enum documentation above
	/// (VTKFileVersion) for additional information about supported versions.
	/// It is possible to get the file major and minor versions separately.  See
	/// also vtkDataReader for related methods. (Note, the parsing of the
	/// FileVersion into major and minor version is as follows: the least
	/// significant digit is the minor version; the remaining digits are the
	/// major version.
	/// </summary>
	public virtual int GetFileMinorVersion()
	{
		return vtkDataWriter_GetFileMinorVersion_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetFileName_06(HandleRef pThis);

	/// <summary>
	/// Specify the file name of VTK data file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_GetFileType_07(HandleRef pThis);

	/// <summary>
	/// Specify the file type (ASCII or BINARY) of the VTK data file.
	/// </summary>
	public virtual int GetFileType()
	{
		return vtkDataWriter_GetFileType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_GetFileTypeMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Specify the file type (ASCII or BINARY) of the VTK data file.
	/// </summary>
	public virtual int GetFileTypeMaxValue()
	{
		return vtkDataWriter_GetFileTypeMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_GetFileTypeMinValue_09(HandleRef pThis);

	/// <summary>
	/// Specify the file type (ASCII or BINARY) of the VTK data file.
	/// </summary>
	public virtual int GetFileTypeMinValue()
	{
		return vtkDataWriter_GetFileTypeMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_GetFileVersion_10(HandleRef pThis);

	/// <summary>
	/// Specify the VTK file version to write. See the enum documentation above
	/// (VTKFileVersion) for additional information about supported versions.
	/// It is possible to get the file major and minor versions separately.  See
	/// also vtkDataReader for related methods. (Note, the parsing of the
	/// FileVersion into major and minor version is as follows: the least
	/// significant digit is the minor version; the remaining digits are the
	/// major version.
	/// </summary>
	public virtual int GetFileVersion()
	{
		return vtkDataWriter_GetFileVersion_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetGlobalIdsName_11(HandleRef pThis);

	/// <summary>
	/// Give a name to the global ids data. If not specified, uses
	/// default name "global_ids".
	/// </summary>
	public virtual string GetGlobalIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetGlobalIdsName_11(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetHeader_12(HandleRef pThis);

	/// <summary>
	/// Specify the header for the VTK data file.
	/// </summary>
	public virtual string GetHeader()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetHeader_12(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetLookupTableName_13(HandleRef pThis);

	/// <summary>
	/// Give a name to the lookup table. If not specified, uses default
	/// name "lookupTable".
	/// </summary>
	public virtual string GetLookupTableName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetLookupTableName_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetNormalsName_14(HandleRef pThis);

	/// <summary>
	/// Give a name to the normals data. If not specified, uses default
	/// name "normals".
	/// </summary>
	public virtual string GetNormalsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetNormalsName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataWriter_GetNumberOfGenerationsFromBase_15(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataWriter_GetNumberOfGenerationsFromBase_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataWriter_GetNumberOfGenerationsFromBaseType_16(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataWriter_GetNumberOfGenerationsFromBaseType_16(type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkDataWriter_GetOutputStdString_17(HandleRef pThis);

	/// <summary>
	/// When WriteToOutputString is on, this method returns a copy of the
	/// output string in a vtkStdString.
	/// </summary>
	public string GetOutputStdString()
	{
		return vtkDataWriter_GetOutputStdString_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetOutputString_18(HandleRef pThis);

	/// <summary>
	/// When WriteToOutputString in on, then a string is allocated, written to,
	/// and can be retrieved with these methods.  The string is deleted during
	/// the next call to write ...
	/// </summary>
	public virtual string GetOutputString()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetOutputString_18(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataWriter_GetOutputStringLength_19(HandleRef pThis);

	/// <summary>
	/// When WriteToOutputString in on, then a string is allocated, written to,
	/// and can be retrieved with these methods.  The string is deleted during
	/// the next call to write ...
	/// </summary>
	public virtual long GetOutputStringLength()
	{
		return vtkDataWriter_GetOutputStringLength_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetPedigreeIdsName_20(HandleRef pThis);

	/// <summary>
	/// Give a name to the pedigree ids data. If not specified, uses
	/// default name "pedigree_ids".
	/// </summary>
	public virtual string GetPedigreeIdsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetPedigreeIdsName_20(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetScalarsName_21(HandleRef pThis);

	/// <summary>
	/// Give a name to the scalar data. If not specified, uses default
	/// name "scalars".
	/// </summary>
	public virtual string GetScalarsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetScalarsName_21(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetTCoordsName_22(HandleRef pThis);

	/// <summary>
	/// Give a name to the texture coordinates data. If not specified, uses
	/// default name "textureCoords".
	/// </summary>
	public virtual string GetTCoordsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetTCoordsName_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetTensorsName_23(HandleRef pThis);

	/// <summary>
	/// Give a name to the tensors data. If not specified, uses default
	/// name "tensors".
	/// </summary>
	public virtual string GetTensorsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetTensorsName_23(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_GetVectorsName_24(HandleRef pThis);

	/// <summary>
	/// Give a name to the vector data. If not specified, uses default
	/// name "vectors".
	/// </summary>
	public virtual string GetVectorsName()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_GetVectorsName_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkDataWriter_GetWriteArrayMetaData_25(HandleRef pThis);

	/// <summary>
	/// If true, vtkInformation objects attached to arrays and array component
	/// nameswill be written to the output. The default is true.
	/// </summary>
	public virtual bool GetWriteArrayMetaData()
	{
		return (vtkDataWriter_GetWriteArrayMetaData_25(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_GetWriteToOutputString_26(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual int GetWriteToOutputString()
	{
		return vtkDataWriter_GetWriteToOutputString_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_IsA_27(HandleRef pThis, string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataWriter_IsA_27(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataWriter_IsTypeOf_28(string type);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataWriter_IsTypeOf_28(type);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_NewInstance_30(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new vtkDataWriter NewInstance()
	{
		vtkDataWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataWriter_NewInstance_30(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_RegisterAndGetOutputString_31(HandleRef pThis);

	/// <summary>
	/// This convenience method returns the string, sets the IVAR to nullptr,
	/// so that the user is responsible for deleting the string.
	/// I am not sure what the name should be, so it may change in the future.
	/// </summary>
	public string RegisterAndGetOutputString()
	{
		return Marshal.PtrToStringAnsi(vtkDataWriter_RegisterAndGetOutputString_31(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataWriter_SafeDownCast_32(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Standard methods for type information and printing.
	/// </summary>
	public new static vtkDataWriter SafeDownCast(vtkObjectBase o)
	{
		vtkDataWriter vtkDataWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataWriter_SafeDownCast_32(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataWriter2 = (vtkDataWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataWriter2.Register(null);
			}
		}
		return vtkDataWriter2;
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetEdgeFlagsName_33(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the edge flags data. If not specified, uses
	/// default name "edge_flags".
	/// </summary>
	public virtual void SetEdgeFlagsName(string _arg)
	{
		vtkDataWriter_SetEdgeFlagsName_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetFieldDataName_34(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the field data. If not specified, uses default
	/// name "field".
	/// </summary>
	public virtual void SetFieldDataName(string _arg)
	{
		vtkDataWriter_SetFieldDataName_34(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetFileName_35(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the file name of VTK data file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkDataWriter_SetFileName_35(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetFileType_36(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the file type (ASCII or BINARY) of the VTK data file.
	/// </summary>
	public virtual void SetFileType(int _arg)
	{
		vtkDataWriter_SetFileType_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetFileTypeToASCII_37(HandleRef pThis);

	/// <summary>
	/// Specify the file type (ASCII or BINARY) of the VTK data file.
	/// </summary>
	public void SetFileTypeToASCII()
	{
		vtkDataWriter_SetFileTypeToASCII_37(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetFileTypeToBinary_38(HandleRef pThis);

	/// <summary>
	/// Specify the file type (ASCII or BINARY) of the VTK data file.
	/// </summary>
	public void SetFileTypeToBinary()
	{
		vtkDataWriter_SetFileTypeToBinary_38(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetFileVersion_39(HandleRef pThis, int arg0);

	/// <summary>
	/// Specify the VTK file version to write. See the enum documentation above
	/// (VTKFileVersion) for additional information about supported versions.
	/// It is possible to get the file major and minor versions separately.  See
	/// also vtkDataReader for related methods. (Note, the parsing of the
	/// FileVersion into major and minor version is as follows: the least
	/// significant digit is the minor version; the remaining digits are the
	/// major version.
	/// </summary>
	public void SetFileVersion(int arg0)
	{
		vtkDataWriter_SetFileVersion_39(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetGlobalIdsName_40(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the global ids data. If not specified, uses
	/// default name "global_ids".
	/// </summary>
	public virtual void SetGlobalIdsName(string _arg)
	{
		vtkDataWriter_SetGlobalIdsName_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetHeader_41(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the header for the VTK data file.
	/// </summary>
	public virtual void SetHeader(string _arg)
	{
		vtkDataWriter_SetHeader_41(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetLookupTableName_42(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the lookup table. If not specified, uses default
	/// name "lookupTable".
	/// </summary>
	public virtual void SetLookupTableName(string _arg)
	{
		vtkDataWriter_SetLookupTableName_42(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetNormalsName_43(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the normals data. If not specified, uses default
	/// name "normals".
	/// </summary>
	public virtual void SetNormalsName(string _arg)
	{
		vtkDataWriter_SetNormalsName_43(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetPedigreeIdsName_44(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the pedigree ids data. If not specified, uses
	/// default name "pedigree_ids".
	/// </summary>
	public virtual void SetPedigreeIdsName(string _arg)
	{
		vtkDataWriter_SetPedigreeIdsName_44(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetScalarsName_45(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the scalar data. If not specified, uses default
	/// name "scalars".
	/// </summary>
	public virtual void SetScalarsName(string _arg)
	{
		vtkDataWriter_SetScalarsName_45(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetTCoordsName_46(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the texture coordinates data. If not specified, uses
	/// default name "textureCoords".
	/// </summary>
	public virtual void SetTCoordsName(string _arg)
	{
		vtkDataWriter_SetTCoordsName_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetTensorsName_47(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the tensors data. If not specified, uses default
	/// name "tensors".
	/// </summary>
	public virtual void SetTensorsName(string _arg)
	{
		vtkDataWriter_SetTensorsName_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetVectorsName_48(HandleRef pThis, string _arg);

	/// <summary>
	/// Give a name to the vector data. If not specified, uses default
	/// name "vectors".
	/// </summary>
	public virtual void SetVectorsName(string _arg)
	{
		vtkDataWriter_SetVectorsName_48(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetWriteArrayMetaData_49(HandleRef pThis, byte _arg);

	/// <summary>
	/// If true, vtkInformation objects attached to arrays and array component
	/// nameswill be written to the output. The default is true.
	/// </summary>
	public virtual void SetWriteArrayMetaData(bool _arg)
	{
		vtkDataWriter_SetWriteArrayMetaData_49(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_SetWriteToOutputString_50(HandleRef pThis, int _arg);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void SetWriteToOutputString(int _arg)
	{
		vtkDataWriter_SetWriteToOutputString_50(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_WriteArrayMetaDataOff_51(HandleRef pThis);

	/// <summary>
	/// If true, vtkInformation objects attached to arrays and array component
	/// nameswill be written to the output. The default is true.
	/// </summary>
	public virtual void WriteArrayMetaDataOff()
	{
		vtkDataWriter_WriteArrayMetaDataOff_51(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_WriteArrayMetaDataOn_52(HandleRef pThis);

	/// <summary>
	/// If true, vtkInformation objects attached to arrays and array component
	/// nameswill be written to the output. The default is true.
	/// </summary>
	public virtual void WriteArrayMetaDataOn()
	{
		vtkDataWriter_WriteArrayMetaDataOn_52(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_WriteToOutputStringOff_53(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void WriteToOutputStringOff()
	{
		vtkDataWriter_WriteToOutputStringOff_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataWriter_WriteToOutputStringOn_54(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// </summary>
	public virtual void WriteToOutputStringOn()
	{
		vtkDataWriter_WriteToOutputStringOn_54(GetCppThis());
	}
}
