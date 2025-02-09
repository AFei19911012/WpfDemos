using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageReader2
/// </summary>
/// <remarks>
///    Superclass of binary file readers.
///
/// vtkImageReader2 is a parent class for many VTK image readers.
/// It was written to simplify the interface of vtkImageReader.
/// It can also be used directly to read data without headers (raw).
/// It is a good super class for streaming readers that do not require
/// a mask or transform on the data. An example of reading a raw file is
/// shown below:
/// <code>
///  vtkSmartPointer&lt;vtkImageReader2&gt; reader =
///   vtkSmartPointer&lt;vtkImageReader2&gt;::New();
/// reader-&gt;SetFilePrefix(argv[1]);
/// reader-&gt;SetDataExtent(0, 63, 0, 63, 1, 93);
/// reader-&gt;SetDataSpacing(3.2, 3.2, 1.5);
/// reader-&gt;SetDataOrigin(0.0, 0.0, 0.0);
/// reader-&gt;SetDataScalarTypeToUnsignedShort();
/// reader-&gt;SetDataByteOrderToLittleEndian();
/// reader-&gt;UpdateWholeExtent();
/// </code>
///
/// </remarks>
/// <seealso>
///
/// vtkJPEGReader vtkPNGReader vtkImageReader vtkGESignaReader
/// </seealso>
public class vtkImageReader2 : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader2";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageReader2()
	{
		MRClassNameKey = "class vtkImageReader2";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader2"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageReader2(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageReader2 New()
	{
		vtkImageReader2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageReader2()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageReader2_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkImageReader2_CanReadFile_01(HandleRef pThis, string arg0);

	/// <summary>
	/// Return non zero if the reader can read the given file name.
	/// Should be implemented by all sub-classes of vtkImageReader2.
	/// For non zero return values the following values are to be used
	/// 1 - I think I can read the file but I cannot prove it
	/// 2 - I definitely can read the file
	/// 3 - I can read the file and I have validated that I am the
	/// correct reader for this file
	/// </summary>
	public virtual int CanReadFile(string arg0)
	{
		return vtkImageReader2_CanReadFile_01(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_CloseFile_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public void CloseFile()
	{
		vtkImageReader2_CloseFile_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_ComputeInternalFileName_03(HandleRef pThis, int slice);

	/// <summary>
	/// Set/Get the internal file name
	/// </summary>
	public virtual void ComputeInternalFileName(int slice)
	{
		vtkImageReader2_ComputeInternalFileName_03(GetCppThis(), slice);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_FileLowerLeftOff_04(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the data comes from the file starting in the lower left
	/// corner or upper left corner.
	/// </summary>
	public virtual void FileLowerLeftOff()
	{
		vtkImageReader2_FileLowerLeftOff_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_FileLowerLeftOn_05(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the data comes from the file starting in the lower left
	/// corner or upper left corner.
	/// </summary>
	public virtual void FileLowerLeftOn()
	{
		vtkImageReader2_FileLowerLeftOn_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_GetDataByteOrder_06(HandleRef pThis);

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
	/// otherwise SetDataByteOrderToBigEndian.
	/// </summary>
	public virtual int GetDataByteOrder()
	{
		return vtkImageReader2_GetDataByteOrder_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetDataByteOrderAsString_07(HandleRef pThis);

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
	/// otherwise SetDataByteOrderToBigEndian.
	/// </summary>
	public virtual string GetDataByteOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkImageReader2_GetDataByteOrderAsString_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetDataDirection_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the direction of the data (9 elements: 3x3 matrix).
	/// </summary>
	public virtual double[] GetDataDirection()
	{
		IntPtr intPtr = vtkImageReader2_GetDataDirection_08(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[9];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_GetDataDirection_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the direction of the data (9 elements: 3x3 matrix).
	/// </summary>
	public virtual void GetDataDirection(IntPtr data)
	{
		vtkImageReader2_GetDataDirection_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetDataExtent_10(HandleRef pThis);

	/// <summary>
	/// Get/Set the extent of the data on disk.
	/// </summary>
	public virtual int[] GetDataExtent()
	{
		IntPtr intPtr = vtkImageReader2_GetDataExtent_10(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[6];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_GetDataExtent_11(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

	/// <summary>
	/// Get/Set the extent of the data on disk.
	/// </summary>
	public virtual void GetDataExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
	{
		vtkImageReader2_GetDataExtent_11(GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_GetDataExtent_12(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the extent of the data on disk.
	/// </summary>
	public virtual void GetDataExtent(IntPtr _arg)
	{
		vtkImageReader2_GetDataExtent_12(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetDataIncrements_13(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public virtual uint[] GetDataIncrements()
	{
		IntPtr intPtr = vtkImageReader2_GetDataIncrements_13(GetCppThis());
		uint[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new uint[4];
			int[] array2 = new int[4];
			Marshal.Copy(intPtr, array2, 0, array.Length);
			for (int i = 0; i < 4; i++)
			{
				array[i] = (uint)array2[i];
			}
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_GetDataIncrements_14(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public virtual void GetDataIncrements(IntPtr data)
	{
		vtkImageReader2_GetDataIncrements_14(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetDataOrigin_15(HandleRef pThis);

	/// <summary>
	/// Set/Get the origin of the data (location of first pixel in the file).
	/// </summary>
	public virtual double[] GetDataOrigin()
	{
		IntPtr intPtr = vtkImageReader2_GetDataOrigin_15(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_GetDataOrigin_16(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the origin of the data (location of first pixel in the file).
	/// </summary>
	public virtual void GetDataOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageReader2_GetDataOrigin_16(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_GetDataOrigin_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the data (location of first pixel in the file).
	/// </summary>
	public virtual void GetDataOrigin(IntPtr _arg)
	{
		vtkImageReader2_GetDataOrigin_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_GetDataScalarType_18(HandleRef pThis);

	/// <summary>
	/// Get the file format.  Pixels are this type in the file.
	/// </summary>
	public virtual int GetDataScalarType()
	{
		return vtkImageReader2_GetDataScalarType_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetDataSpacing_19(HandleRef pThis);

	/// <summary>
	/// Set/Get the spacing of the data in the file.
	/// </summary>
	public virtual double[] GetDataSpacing()
	{
		IntPtr intPtr = vtkImageReader2_GetDataSpacing_19(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_GetDataSpacing_20(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

	/// <summary>
	/// Set/Get the spacing of the data in the file.
	/// </summary>
	public virtual void GetDataSpacing(ref double _arg1, ref double _arg2, ref double _arg3)
	{
		vtkImageReader2_GetDataSpacing_20(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_GetDataSpacing_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the spacing of the data in the file.
	/// </summary>
	public virtual void GetDataSpacing(IntPtr _arg)
	{
		vtkImageReader2_GetDataSpacing_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetDescriptiveName_22(HandleRef pThis);

	/// <summary>
	/// Return a descriptive name for the file format that might be useful in a GUI.
	/// </summary>
	public virtual string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkImageReader2_GetDescriptiveName_22(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_GetFileDimensionality_23(HandleRef pThis);

	/// <summary>
	/// The number of dimensions stored in a file. This defaults to two.
	/// </summary>
	public int GetFileDimensionality()
	{
		return vtkImageReader2_GetFileDimensionality_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetFileExtensions_24(HandleRef pThis);

	/// <summary>
	/// Get the file extensions for this format.
	/// Returns a string with a space separated list of extensions in
	/// the format .extension
	/// </summary>
	public virtual string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkImageReader2_GetFileExtensions_24(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_GetFileLowerLeft_25(HandleRef pThis);

	/// <summary>
	/// Set/Get whether the data comes from the file starting in the lower left
	/// corner or upper left corner.
	/// </summary>
	public virtual int GetFileLowerLeft()
	{
		return vtkImageReader2_GetFileLowerLeft_25(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetFileName_26(HandleRef pThis);

	/// <summary>
	/// Specify file name for the image file. If the data is stored in
	/// multiple files, then use SetFileNames or SetFilePrefix instead.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkImageReader2_GetFileName_26(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_GetFileNameSliceOffset_27(HandleRef pThis);

	/// <summary>
	/// When reading files which start at an unusual index, this can be added
	/// to the slice number when generating the file name (default = 0)
	/// </summary>
	public virtual int GetFileNameSliceOffset()
	{
		return vtkImageReader2_GetFileNameSliceOffset_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_GetFileNameSliceSpacing_28(HandleRef pThis);

	/// <summary>
	/// When reading files which have regular, but non contiguous slices
	/// (eg filename.1,filename.3,filename.5)
	/// a spacing can be specified to skip missing files (default = 1)
	/// </summary>
	public virtual int GetFileNameSliceSpacing()
	{
		return vtkImageReader2_GetFileNameSliceSpacing_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetFileNames_29(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify a list of file names.  Each file must be a single slice,
	/// and each slice must be of the same size. The files must be in the
	/// correct order.
	/// Use SetFileName when reading a volume (multiple slice), since
	/// DataExtent will be modified after a SetFileNames call.
	/// </summary>
	public virtual vtkStringArray GetFileNames()
	{
		vtkStringArray vtkStringArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2_GetFileNames_29(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetFilePattern_30(HandleRef pThis);

	/// <summary>
	/// The snprintf-style format string used to build filename from
	/// FilePrefix and slice number.
	/// </summary>
	public virtual string GetFilePattern()
	{
		return Marshal.PtrToStringAnsi(vtkImageReader2_GetFilePattern_30(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetFilePrefix_31(HandleRef pThis);

	/// <summary>
	/// Specify file prefix for the image file or files.  This can be
	/// used in place of SetFileName or SetFileNames if the filenames
	/// follow a specific naming pattern, but you must explicitly set
	/// the DataExtent so that the reader will know what range of slices
	/// to load.
	/// </summary>
	public virtual string GetFilePrefix()
	{
		return Marshal.PtrToStringAnsi(vtkImageReader2_GetFilePrefix_31(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkImageReader2_GetHeaderSize_32(HandleRef pThis);

	/// <summary>
	/// Get the size of the header computed by this object.
	/// </summary>
	public uint GetHeaderSize()
	{
		return vtkImageReader2_GetHeaderSize_32(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkImageReader2_GetHeaderSize_33(HandleRef pThis, uint slice);

	/// <summary>
	/// Get the size of the header computed by this object.
	/// </summary>
	public uint GetHeaderSize(uint slice)
	{
		return vtkImageReader2_GetHeaderSize_33(GetCppThis(), slice);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetInternalFileName_34(HandleRef pThis);

	/// <summary>
	/// Set/Get the internal file name
	/// </summary>
	public virtual string GetInternalFileName()
	{
		return Marshal.PtrToStringAnsi(vtkImageReader2_GetInternalFileName_34(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_GetMemoryBuffer_35(HandleRef pThis);

	/// <summary>
	/// Specify the in memory image buffer.
	/// May be used by a reader to allow the reading
	/// of an image from memory instead of from file.
	/// </summary>
	public virtual IntPtr GetMemoryBuffer()
	{
		return vtkImageReader2_GetMemoryBuffer_35(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReader2_GetMemoryBufferLength_36(HandleRef pThis);

	/// <summary>
	/// Specify the in memory image buffer length.
	/// </summary>
	public long GetMemoryBufferLength()
	{
		return vtkImageReader2_GetMemoryBufferLength_36(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReader2_GetNumberOfGenerationsFromBase_37(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageReader2_GetNumberOfGenerationsFromBase_37(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageReader2_GetNumberOfGenerationsFromBaseType_38(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageReader2_GetNumberOfGenerationsFromBaseType_38(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_GetNumberOfScalarComponents_39(HandleRef pThis);

	/// <summary>
	/// Set/Get the number of scalar components
	/// </summary>
	public virtual int GetNumberOfScalarComponents()
	{
		return vtkImageReader2_GetNumberOfScalarComponents_39(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_GetSwapBytes_40(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public virtual int GetSwapBytes()
	{
		return vtkImageReader2_GetSwapBytes_40(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_IsA_41(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageReader2_IsA_41(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_IsTypeOf_42(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageReader2_IsTypeOf_42(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_NewInstance_44(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageReader2 NewInstance()
	{
		vtkImageReader2 result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2_NewInstance_44(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageReader2_OpenFile_45(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public virtual int OpenFile()
	{
		return vtkImageReader2_OpenFile_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageReader2_SafeDownCast_46(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageReader2 SafeDownCast(vtkObjectBase o)
	{
		vtkImageReader2 vtkImageReader3 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageReader2_SafeDownCast_46(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageReader3 = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageReader3.Register(null);
			}
		}
		return vtkImageReader3;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SeekFile_47(HandleRef pThis, int i, int j, int k);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public virtual void SeekFile(int i, int j, int k)
	{
		vtkImageReader2_SeekFile_47(GetCppThis(), i, j, k);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataByteOrder_48(HandleRef pThis, int arg0);

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
	/// otherwise SetDataByteOrderToBigEndian.
	/// </summary>
	public virtual void SetDataByteOrder(int arg0)
	{
		vtkImageReader2_SetDataByteOrder_48(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataByteOrderToBigEndian_49(HandleRef pThis);

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
	/// otherwise SetDataByteOrderToBigEndian.
	/// </summary>
	public virtual void SetDataByteOrderToBigEndian()
	{
		vtkImageReader2_SetDataByteOrderToBigEndian_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataByteOrderToLittleEndian_50(HandleRef pThis);

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
	/// otherwise SetDataByteOrderToBigEndian.
	/// </summary>
	public virtual void SetDataByteOrderToLittleEndian()
	{
		vtkImageReader2_SetDataByteOrderToLittleEndian_50(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataDirection_51(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set/Get the direction of the data (9 elements: 3x3 matrix).
	/// </summary>
	public virtual void SetDataDirection(IntPtr data)
	{
		vtkImageReader2_SetDataDirection_51(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataExtent_52(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

	/// <summary>
	/// Get/Set the extent of the data on disk.
	/// </summary>
	public virtual void SetDataExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
	{
		vtkImageReader2_SetDataExtent_52(GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataExtent_53(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Get/Set the extent of the data on disk.
	/// </summary>
	public virtual void SetDataExtent(IntPtr _arg)
	{
		vtkImageReader2_SetDataExtent_53(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataOrigin_54(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the origin of the data (location of first pixel in the file).
	/// </summary>
	public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkImageReader2_SetDataOrigin_54(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataOrigin_55(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the origin of the data (location of first pixel in the file).
	/// </summary>
	public virtual void SetDataOrigin(IntPtr _arg)
	{
		vtkImageReader2_SetDataOrigin_55(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarType_56(HandleRef pThis, int type);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarType(int type)
	{
		vtkImageReader2_SetDataScalarType_56(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToChar_57(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToChar()
	{
		vtkImageReader2_SetDataScalarTypeToChar_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToDouble_58(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToDouble()
	{
		vtkImageReader2_SetDataScalarTypeToDouble_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToFloat_59(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToFloat()
	{
		vtkImageReader2_SetDataScalarTypeToFloat_59(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToInt_60(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToInt()
	{
		vtkImageReader2_SetDataScalarTypeToInt_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToShort_61(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToShort()
	{
		vtkImageReader2_SetDataScalarTypeToShort_61(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToSignedChar_62(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToSignedChar()
	{
		vtkImageReader2_SetDataScalarTypeToSignedChar_62(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedChar_63(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToUnsignedChar()
	{
		vtkImageReader2_SetDataScalarTypeToUnsignedChar_63(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedInt_64(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToUnsignedInt()
	{
		vtkImageReader2_SetDataScalarTypeToUnsignedInt_64(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataScalarTypeToUnsignedShort_65(HandleRef pThis);

	/// <summary>
	/// Set the data type of pixels in the file.
	/// If you want the output scalar type to have a different value, set it
	/// after this method is called.
	/// </summary>
	public virtual void SetDataScalarTypeToUnsignedShort()
	{
		vtkImageReader2_SetDataScalarTypeToUnsignedShort_65(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataSpacing_66(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Set/Get the spacing of the data in the file.
	/// </summary>
	public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkImageReader2_SetDataSpacing_66(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetDataSpacing_67(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set/Get the spacing of the data in the file.
	/// </summary>
	public virtual void SetDataSpacing(IntPtr _arg)
	{
		vtkImageReader2_SetDataSpacing_67(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetFileDimensionality_68(HandleRef pThis, int _arg);

	/// <summary>
	/// The number of dimensions stored in a file. This defaults to two.
	/// </summary>
	public virtual void SetFileDimensionality(int _arg)
	{
		vtkImageReader2_SetFileDimensionality_68(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetFileLowerLeft_69(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get whether the data comes from the file starting in the lower left
	/// corner or upper left corner.
	/// </summary>
	public virtual void SetFileLowerLeft(int _arg)
	{
		vtkImageReader2_SetFileLowerLeft_69(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetFileName_70(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify file name for the image file. If the data is stored in
	/// multiple files, then use SetFileNames or SetFilePrefix instead.
	/// </summary>
	public virtual void SetFileName(string arg0)
	{
		vtkImageReader2_SetFileName_70(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetFileNameSliceOffset_71(HandleRef pThis, int _arg);

	/// <summary>
	/// When reading files which start at an unusual index, this can be added
	/// to the slice number when generating the file name (default = 0)
	/// </summary>
	public virtual void SetFileNameSliceOffset(int _arg)
	{
		vtkImageReader2_SetFileNameSliceOffset_71(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetFileNameSliceSpacing_72(HandleRef pThis, int _arg);

	/// <summary>
	/// When reading files which have regular, but non contiguous slices
	/// (eg filename.1,filename.3,filename.5)
	/// a spacing can be specified to skip missing files (default = 1)
	/// </summary>
	public virtual void SetFileNameSliceSpacing(int _arg)
	{
		vtkImageReader2_SetFileNameSliceSpacing_72(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetFileNames_73(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify a list of file names.  Each file must be a single slice,
	/// and each slice must be of the same size. The files must be in the
	/// correct order.
	/// Use SetFileName when reading a volume (multiple slice), since
	/// DataExtent will be modified after a SetFileNames call.
	/// </summary>
	public virtual void SetFileNames(vtkStringArray arg0)
	{
		vtkImageReader2_SetFileNames_73(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetFilePattern_74(HandleRef pThis, string arg0);

	/// <summary>
	/// The snprintf-style format string used to build filename from
	/// FilePrefix and slice number.
	/// </summary>
	public virtual void SetFilePattern(string arg0)
	{
		vtkImageReader2_SetFilePattern_74(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetFilePrefix_75(HandleRef pThis, string arg0);

	/// <summary>
	/// Specify file prefix for the image file or files.  This can be
	/// used in place of SetFileName or SetFileNames if the filenames
	/// follow a specific naming pattern, but you must explicitly set
	/// the DataExtent so that the reader will know what range of slices
	/// to load.
	/// </summary>
	public virtual void SetFilePrefix(string arg0)
	{
		vtkImageReader2_SetFilePrefix_75(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetHeaderSize_76(HandleRef pThis, uint size);

	/// <summary>
	/// If there is a tail on the file, you want to explicitly set the
	/// header size.
	/// </summary>
	public virtual void SetHeaderSize(uint size)
	{
		vtkImageReader2_SetHeaderSize_76(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetMemoryBuffer_77(HandleRef pThis, IntPtr arg0);

	/// <summary>
	/// Specify the in memory image buffer.
	/// May be used by a reader to allow the reading
	/// of an image from memory instead of from file.
	/// </summary>
	public virtual void SetMemoryBuffer(IntPtr arg0)
	{
		vtkImageReader2_SetMemoryBuffer_77(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetMemoryBufferLength_78(HandleRef pThis, long buflen);

	/// <summary>
	/// Specify the in memory image buffer length.
	/// </summary>
	public virtual void SetMemoryBufferLength(long buflen)
	{
		vtkImageReader2_SetMemoryBufferLength_78(GetCppThis(), buflen);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetNumberOfScalarComponents_79(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the number of scalar components
	/// </summary>
	public virtual void SetNumberOfScalarComponents(int _arg)
	{
		vtkImageReader2_SetNumberOfScalarComponents_79(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SetSwapBytes_80(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public virtual void SetSwapBytes(int _arg)
	{
		vtkImageReader2_SetSwapBytes_80(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SwapBytesOff_81(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public virtual void SwapBytesOff()
	{
		vtkImageReader2_SwapBytesOff_81(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageReader2_SwapBytesOn_82(HandleRef pThis);

	/// <summary>
	/// Set/Get the byte swapping to explicitly swap the bytes of a file.
	/// </summary>
	public virtual void SwapBytesOn()
	{
		vtkImageReader2_SwapBytesOn_82(GetCppThis());
	}
}
