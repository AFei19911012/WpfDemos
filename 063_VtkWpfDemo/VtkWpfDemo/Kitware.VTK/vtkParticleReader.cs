using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkParticleReader
/// </summary>
/// <remarks>
///    Read ASCII or binary particle
///                            data and (optionally) one scalar
///                            value associated with each particle.
///
/// vtkParticleReader reads either a binary or a text file of
///  particles. Each particle can have associated with it an optional
///  scalar value. So the format is: x, y, z, scalar
///  (all floats or doubles). The text file can consist of a comma
///  delimited set of values. In most cases vtkParticleReader can
///  automatically determine whether the file is text or binary.
///  The data can be either float or double.
///  Progress updates are provided.
///  With respect to binary files, random access into the file to read
///  pieces is supported.
///
/// </remarks>
public class vtkParticleReader : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkParticleReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkParticleReader()
	{
		MRClassNameKey = "class vtkParticleReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkParticleReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkParticleReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParticleReader New()
	{
		vtkParticleReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParticleReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkParticleReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkParticleReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetDataByteOrder_01(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public int GetDataByteOrder()
	{
		return vtkParticleReader_GetDataByteOrder_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleReader_GetDataByteOrderAsString_02(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public string GetDataByteOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkParticleReader_GetDataByteOrderAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetDataType_03(HandleRef pThis);

	/// <summary>
	/// Get/Set the data type.  The options are:
	/// - VTK_FLOAT (default) single precision floating point.
	/// - VTK_DOUBLE double precision floating point.
	/// </summary>
	public virtual int GetDataType()
	{
		return vtkParticleReader_GetDataType_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetDataTypeMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Get/Set the data type.  The options are:
	/// - VTK_FLOAT (default) single precision floating point.
	/// - VTK_DOUBLE double precision floating point.
	/// </summary>
	public virtual int GetDataTypeMaxValue()
	{
		return vtkParticleReader_GetDataTypeMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetDataTypeMinValue_05(HandleRef pThis);

	/// <summary>
	/// Get/Set the data type.  The options are:
	/// - VTK_FLOAT (default) single precision floating point.
	/// - VTK_DOUBLE double precision floating point.
	/// </summary>
	public virtual int GetDataTypeMinValue()
	{
		return vtkParticleReader_GetDataTypeMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleReader_GetFileName_06(HandleRef pThis);

	/// <summary>
	/// Specify file name.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkParticleReader_GetFileName_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetFileType_07(HandleRef pThis);

	/// <summary>
	/// Get/Set the file type.  The options are:
	/// - FILE_TYPE_IS_UNKNOWN (default) the class
	/// will attempt to determine the file type.
	/// If this fails then you should set the file type
	/// yourself.
	/// - FILE_TYPE_IS_TEXT the file type is text.
	/// - FILE_TYPE_IS_BINARY the file type is binary.
	/// </summary>
	public virtual int GetFileType()
	{
		return vtkParticleReader_GetFileType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetFileTypeMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Get/Set the file type.  The options are:
	/// - FILE_TYPE_IS_UNKNOWN (default) the class
	/// will attempt to determine the file type.
	/// If this fails then you should set the file type
	/// yourself.
	/// - FILE_TYPE_IS_TEXT the file type is text.
	/// - FILE_TYPE_IS_BINARY the file type is binary.
	/// </summary>
	public virtual int GetFileTypeMaxValue()
	{
		return vtkParticleReader_GetFileTypeMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetFileTypeMinValue_09(HandleRef pThis);

	/// <summary>
	/// Get/Set the file type.  The options are:
	/// - FILE_TYPE_IS_UNKNOWN (default) the class
	/// will attempt to determine the file type.
	/// If this fails then you should set the file type
	/// yourself.
	/// - FILE_TYPE_IS_TEXT the file type is text.
	/// - FILE_TYPE_IS_BINARY the file type is binary.
	/// </summary>
	public virtual int GetFileTypeMinValue()
	{
		return vtkParticleReader_GetFileTypeMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetHasScalar_10(HandleRef pThis);

	/// <summary>
	/// Default: 1. If 1 then each particle has a value associated with it.
	/// </summary>
	public virtual int GetHasScalar()
	{
		return vtkParticleReader_GetHasScalar_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParticleReader_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkParticleReader_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkParticleReader_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkParticleReader_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_GetSwapBytes_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// Not used when reading text files.
	/// </summary>
	public int GetSwapBytes()
	{
		return vtkParticleReader_GetSwapBytes_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_HasScalarOff_14(HandleRef pThis);

	/// <summary>
	/// Default: 1. If 1 then each particle has a value associated with it.
	/// </summary>
	public virtual void HasScalarOff()
	{
		vtkParticleReader_HasScalarOff_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_HasScalarOn_15(HandleRef pThis);

	/// <summary>
	/// Default: 1. If 1 then each particle has a value associated with it.
	/// </summary>
	public virtual void HasScalarOn()
	{
		vtkParticleReader_HasScalarOn_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_IsA_16(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkParticleReader_IsA_16(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkParticleReader_IsTypeOf_17(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkParticleReader_IsTypeOf_17(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleReader_NewInstance_19(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkParticleReader NewInstance()
	{
		vtkParticleReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParticleReader_NewInstance_19(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkParticleReader_SafeDownCast_20(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkParticleReader SafeDownCast(vtkObjectBase o)
	{
		vtkParticleReader vtkParticleReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkParticleReader_SafeDownCast_20(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkParticleReader2 = (vtkParticleReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkParticleReader2.Register(null);
			}
		}
		return vtkParticleReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetDataByteOrder_21(HandleRef pThis, int arg0);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public void SetDataByteOrder(int arg0)
	{
		vtkParticleReader_SetDataByteOrder_21(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetDataByteOrderToBigEndian_22(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public void SetDataByteOrderToBigEndian()
	{
		vtkParticleReader_SetDataByteOrderToBigEndian_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetDataByteOrderToLittleEndian_23(HandleRef pThis);

	/// <summary>
	/// These methods should be used instead of the SwapBytes methods.
	/// They indicate the byte ordering of the file you are trying
	/// to read in. These methods will then either swap or not swap
	/// the bytes depending on the byte ordering of the machine it is
	/// being run on. For example, reading in a BigEndian file on a
	/// BigEndian machine will result in no swapping. Trying to read
	/// the same file on a LittleEndian machine will result in swapping.
	/// As a quick note most UNIX machines are BigEndian while PC's
	/// and VAX tend to be LittleEndian. So if the file you are reading
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian
	/// otherwise SetDataByteOrderToBigEndian. Not used when reading
	/// text files.
	/// </summary>
	public void SetDataByteOrderToLittleEndian()
	{
		vtkParticleReader_SetDataByteOrderToLittleEndian_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetDataType_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the data type.  The options are:
	/// - VTK_FLOAT (default) single precision floating point.
	/// - VTK_DOUBLE double precision floating point.
	/// </summary>
	public virtual void SetDataType(int _arg)
	{
		vtkParticleReader_SetDataType_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetDataTypeToDouble_25(HandleRef pThis);

	/// <summary>
	/// Get/Set the data type.  The options are:
	/// - VTK_FLOAT (default) single precision floating point.
	/// - VTK_DOUBLE double precision floating point.
	/// </summary>
	public void SetDataTypeToDouble()
	{
		vtkParticleReader_SetDataTypeToDouble_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetDataTypeToFloat_26(HandleRef pThis);

	/// <summary>
	/// Get/Set the data type.  The options are:
	/// - VTK_FLOAT (default) single precision floating point.
	/// - VTK_DOUBLE double precision floating point.
	/// </summary>
	public void SetDataTypeToFloat()
	{
		vtkParticleReader_SetDataTypeToFloat_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetFileName_27(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkParticleReader_SetFileName_27(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetFileType_28(HandleRef pThis, int _arg);

	/// <summary>
	/// Get/Set the file type.  The options are:
	/// - FILE_TYPE_IS_UNKNOWN (default) the class
	/// will attempt to determine the file type.
	/// If this fails then you should set the file type
	/// yourself.
	/// - FILE_TYPE_IS_TEXT the file type is text.
	/// - FILE_TYPE_IS_BINARY the file type is binary.
	/// </summary>
	public virtual void SetFileType(int _arg)
	{
		vtkParticleReader_SetFileType_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetFileTypeToBinary_29(HandleRef pThis);

	/// <summary>
	/// Get/Set the file type.  The options are:
	/// - FILE_TYPE_IS_UNKNOWN (default) the class
	/// will attempt to determine the file type.
	/// If this fails then you should set the file type
	/// yourself.
	/// - FILE_TYPE_IS_TEXT the file type is text.
	/// - FILE_TYPE_IS_BINARY the file type is binary.
	/// </summary>
	public void SetFileTypeToBinary()
	{
		vtkParticleReader_SetFileTypeToBinary_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetFileTypeToText_30(HandleRef pThis);

	/// <summary>
	/// Get/Set the file type.  The options are:
	/// - FILE_TYPE_IS_UNKNOWN (default) the class
	/// will attempt to determine the file type.
	/// If this fails then you should set the file type
	/// yourself.
	/// - FILE_TYPE_IS_TEXT the file type is text.
	/// - FILE_TYPE_IS_BINARY the file type is binary.
	/// </summary>
	public void SetFileTypeToText()
	{
		vtkParticleReader_SetFileTypeToText_30(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetFileTypeToUnknown_31(HandleRef pThis);

	/// <summary>
	/// Get/Set the file type.  The options are:
	/// - FILE_TYPE_IS_UNKNOWN (default) the class
	/// will attempt to determine the file type.
	/// If this fails then you should set the file type
	/// yourself.
	/// - FILE_TYPE_IS_TEXT the file type is text.
	/// - FILE_TYPE_IS_BINARY the file type is binary.
	/// </summary>
	public void SetFileTypeToUnknown()
	{
		vtkParticleReader_SetFileTypeToUnknown_31(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetHasScalar_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Default: 1. If 1 then each particle has a value associated with it.
	/// </summary>
	public virtual void SetHasScalar(int _arg)
	{
		vtkParticleReader_SetHasScalar_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SetSwapBytes_33(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// Not used when reading text files.
	/// </summary>
	public virtual void SetSwapBytes(int _arg)
	{
		vtkParticleReader_SetSwapBytes_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SwapBytesOff_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// Not used when reading text files.
	/// </summary>
	public virtual void SwapBytesOff()
	{
		vtkParticleReader_SwapBytesOff_34(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkParticleReader_SwapBytesOn_35(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// Not used when reading text files.
	/// </summary>
	public virtual void SwapBytesOn()
	{
		vtkParticleReader_SwapBytesOn_35(GetCppThis());
	}
}
