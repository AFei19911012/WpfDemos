using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolume16Reader
/// </summary>
/// <remarks>
///    read 16 bit image files
///
/// vtkVolume16Reader is a source object that reads 16 bit image files.
///
/// Volume16Reader creates structured point datasets. The dimension of the
/// dataset depends upon the number of files read. Reading a single file
/// results in a 2D image, while reading more than one file results in a
/// 3D volume.
///
/// File names are created using FilePattern and FilePrefix as follows:
/// snprintf (filename, sizeof(filename), FilePattern, FilePrefix, number);
/// where number is in the range ImageRange[0] to ImageRange[1]. If
/// ImageRange[1] &lt;= ImageRange[0], then slice number ImageRange[0] is
/// read. Thus to read an image set ImageRange[0] = ImageRange[1] = slice
/// number. The default behavior is to read a single file (i.e., image slice 1).
///
/// The DataMask instance variable is used to read data files with embedded
/// connectivity or segmentation information. For example, some data has
/// the high order bit set to indicate connected surface. The DataMask allows
/// you to select this data. Other important ivars include HeaderSize, which
/// allows you to skip over initial info, and SwapBytes, which turns on/off
/// byte swapping.
///
/// The Transform instance variable specifies a permutation transformation
/// to map slice space into world space. vtkImageReader has replaced the
/// functionality of this class and should be used instead.
///
/// </remarks>
/// <seealso>
///
/// vtkSliceCubes vtkMarchingCubes vtkImageReader
/// </seealso>
public class vtkVolume16Reader : vtkVolumeReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolume16Reader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolume16Reader()
	{
		MRClassNameKey = "class vtkVolume16Reader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolume16Reader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolume16Reader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume16Reader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with nullptr file prefix; file pattern "%s.%d"; image range
	/// set to (1,1); data origin (0,0,0); data spacing (1,1,1); no data mask;
	/// header size 0; and byte swapping turned off.
	/// </summary>
	public new static vtkVolume16Reader New()
	{
		vtkVolume16Reader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume16Reader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with nullptr file prefix; file pattern "%s.%d"; image range
	/// set to (1,1); data origin (0,0,0); data spacing (1,1,1); no data mask;
	/// header size 0; and byte swapping turned off.
	/// </summary>
	public vtkVolume16Reader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkVolume16Reader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkVolume16Reader_GetDataByteOrder_01(HandleRef pThis);

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
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public int GetDataByteOrder()
	{
		return vtkVolume16Reader_GetDataByteOrder_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume16Reader_GetDataByteOrderAsString_02(HandleRef pThis);

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
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public string GetDataByteOrderAsString()
	{
		return Marshal.PtrToStringAnsi(vtkVolume16Reader_GetDataByteOrderAsString_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume16Reader_GetDataDimensions_03(HandleRef pThis);

	/// <summary>
	/// Specify the dimensions for the data.
	/// </summary>
	public virtual int[] GetDataDimensions()
	{
		IntPtr intPtr = vtkVolume16Reader_GetDataDimensions_03(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_GetDataDimensions_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the dimensions for the data.
	/// </summary>
	public virtual void GetDataDimensions(IntPtr data)
	{
		vtkVolume16Reader_GetDataDimensions_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ushort vtkVolume16Reader_GetDataMask_05(HandleRef pThis);

	/// <summary>
	/// Specify a mask used to eliminate data in the data file (e.g.,
	/// connectivity bits).
	/// </summary>
	public virtual ushort GetDataMask()
	{
		return vtkVolume16Reader_GetDataMask_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolume16Reader_GetHeaderSize_06(HandleRef pThis);

	/// <summary>
	/// Specify the number of bytes to seek over at start of image.
	/// </summary>
	public virtual int GetHeaderSize()
	{
		return vtkVolume16Reader_GetHeaderSize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume16Reader_GetImage_07(HandleRef pThis, int ImageNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Other objects make use of these methods
	/// </summary>
	public override vtkImageData GetImage(int ImageNumber)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume16Reader_GetImage_07(GetCppThis(), ImageNumber, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageData2 = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageData2.Register(null);
			}
		}
		return vtkImageData2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolume16Reader_GetNumberOfGenerationsFromBase_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolume16Reader_GetNumberOfGenerationsFromBase_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolume16Reader_GetNumberOfGenerationsFromBaseType_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolume16Reader_GetNumberOfGenerationsFromBaseType_09(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolume16Reader_GetSwapBytes_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off byte swapping.
	/// </summary>
	public virtual int GetSwapBytes()
	{
		return vtkVolume16Reader_GetSwapBytes_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume16Reader_GetTransform_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get transformation matrix to transform the data from slice space
	/// into world space. This matrix must be a permutation matrix. To qualify,
	/// the sums of the rows must be + or - 1.
	/// </summary>
	public virtual vtkTransform GetTransform()
	{
		vtkTransform vtkTransform2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume16Reader_GetTransform_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTransform2 = (vtkTransform)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTransform2.Register(null);
			}
		}
		return vtkTransform2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolume16Reader_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolume16Reader_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolume16Reader_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolume16Reader_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume16Reader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolume16Reader NewInstance()
	{
		vtkVolume16Reader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume16Reader_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolume16Reader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolume16Reader SafeDownCast(vtkObjectBase o)
	{
		vtkVolume16Reader vtkVolume16Reader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolume16Reader_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolume16Reader2 = (vtkVolume16Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolume16Reader2.Register(null);
			}
		}
		return vtkVolume16Reader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetDataByteOrder_17(HandleRef pThis, int arg0);

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
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public void SetDataByteOrder(int arg0)
	{
		vtkVolume16Reader_SetDataByteOrder_17(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetDataByteOrderToBigEndian_18(HandleRef pThis);

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
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public void SetDataByteOrderToBigEndian()
	{
		vtkVolume16Reader_SetDataByteOrderToBigEndian_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetDataByteOrderToLittleEndian_19(HandleRef pThis);

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
	/// in was generated on a VAX or PC, SetDataByteOrderToLittleEndian otherwise
	/// SetDataByteOrderToBigEndian.
	/// </summary>
	public void SetDataByteOrderToLittleEndian()
	{
		vtkVolume16Reader_SetDataByteOrderToLittleEndian_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetDataDimensions_20(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Specify the dimensions for the data.
	/// </summary>
	public virtual void SetDataDimensions(int _arg1, int _arg2)
	{
		vtkVolume16Reader_SetDataDimensions_20(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetDataDimensions_21(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the dimensions for the data.
	/// </summary>
	public void SetDataDimensions(IntPtr _arg)
	{
		vtkVolume16Reader_SetDataDimensions_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetDataMask_22(HandleRef pThis, ushort _arg);

	/// <summary>
	/// Specify a mask used to eliminate data in the data file (e.g.,
	/// connectivity bits).
	/// </summary>
	public virtual void SetDataMask(ushort _arg)
	{
		vtkVolume16Reader_SetDataMask_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetHeaderSize_23(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the number of bytes to seek over at start of image.
	/// </summary>
	public virtual void SetHeaderSize(int _arg)
	{
		vtkVolume16Reader_SetHeaderSize_23(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetSwapBytes_24(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off byte swapping.
	/// </summary>
	public virtual void SetSwapBytes(int _arg)
	{
		vtkVolume16Reader_SetSwapBytes_24(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SetTransform_25(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Set/Get transformation matrix to transform the data from slice space
	/// into world space. This matrix must be a permutation matrix. To qualify,
	/// the sums of the rows must be + or - 1.
	/// </summary>
	public virtual void SetTransform(vtkTransform arg0)
	{
		vtkVolume16Reader_SetTransform_25(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SwapBytesOff_26(HandleRef pThis);

	/// <summary>
	/// Turn on/off byte swapping.
	/// </summary>
	public virtual void SwapBytesOff()
	{
		vtkVolume16Reader_SwapBytesOff_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolume16Reader_SwapBytesOn_27(HandleRef pThis);

	/// <summary>
	/// Turn on/off byte swapping.
	/// </summary>
	public virtual void SwapBytesOn()
	{
		vtkVolume16Reader_SwapBytesOn_27(GetCppThis());
	}
}
