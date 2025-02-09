using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkVolumeReader
/// </summary>
/// <remarks>
///    read image files
///
/// vtkVolumeReader is a source object that reads image files.
///
/// VolumeReader creates structured point datasets. The dimension of the
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
/// byte swapping. Consider using vtkImageReader as a replacement.
///
/// </remarks>
/// <seealso>
///
/// vtkSliceCubes vtkMarchingCubes vtkPNMReader vtkVolume16Reader
/// vtkImageReader
/// </seealso>
public abstract class vtkVolumeReader : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkVolumeReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkVolumeReader()
	{
		MRClassNameKey = "class vtkVolumeReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkVolumeReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkVolumeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern IntPtr vtkVolumeReader_GetDataOrigin_01(HandleRef pThis);

	/// <summary>
	/// Specify the origin for the data.
	/// </summary>
	public virtual double[] GetDataOrigin()
	{
		IntPtr intPtr = vtkVolumeReader_GetDataOrigin_01(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_GetDataOrigin_02(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the origin for the data.
	/// </summary>
	public virtual void GetDataOrigin(IntPtr data)
	{
		vtkVolumeReader_GetDataOrigin_02(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeReader_GetDataSpacing_03(HandleRef pThis);

	/// <summary>
	/// Specify the spacing for the data.
	/// </summary>
	public virtual double[] GetDataSpacing()
	{
		IntPtr intPtr = vtkVolumeReader_GetDataSpacing_03(GetCppThis());
		double[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new double[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_GetDataSpacing_04(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Specify the spacing for the data.
	/// </summary>
	public virtual void GetDataSpacing(IntPtr data)
	{
		vtkVolumeReader_GetDataSpacing_04(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeReader_GetFilePattern_05(HandleRef pThis);

	/// <summary>
	/// The snprintf format used to build filename from FilePrefix and number.
	/// </summary>
	public virtual string GetFilePattern()
	{
		return Marshal.PtrToStringAnsi(vtkVolumeReader_GetFilePattern_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeReader_GetFilePrefix_06(HandleRef pThis);

	/// <summary>
	/// Specify file prefix for the image file(s).
	/// </summary>
	public virtual string GetFilePrefix()
	{
		return Marshal.PtrToStringAnsi(vtkVolumeReader_GetFilePrefix_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeReader_GetImage_07(HandleRef pThis, int ImageNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Other objects make use of this method.
	/// </summary>
	public virtual vtkImageData GetImage(int ImageNumber)
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeReader_GetImage_07(GetCppThis(), ImageNumber, ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkVolumeReader_GetImageRange_08(HandleRef pThis);

	/// <summary>
	/// Set the range of files to read.
	/// </summary>
	public virtual int[] GetImageRange()
	{
		IntPtr intPtr = vtkVolumeReader_GetImageRange_08(GetCppThis());
		int[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new int[2];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_GetImageRange_09(HandleRef pThis, IntPtr data);

	/// <summary>
	/// Set the range of files to read.
	/// </summary>
	public virtual void GetImageRange(IntPtr data)
	{
		vtkVolumeReader_GetImageRange_09(GetCppThis(), data);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkVolumeReader_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkVolumeReader_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkVolumeReader_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeReader_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkVolumeReader_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkVolumeReader_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkVolumeReader_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkVolumeReader NewInstance()
	{
		vtkVolumeReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeReader_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkVolumeReader_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkVolumeReader SafeDownCast(vtkObjectBase o)
	{
		vtkVolumeReader vtkVolumeReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkVolumeReader_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkVolumeReader2 = (vtkVolumeReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkVolumeReader2.Register(null);
			}
		}
		return vtkVolumeReader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_SetDataOrigin_16(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the origin for the data.
	/// </summary>
	public virtual void SetDataOrigin(double _arg1, double _arg2, double _arg3)
	{
		vtkVolumeReader_SetDataOrigin_16(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_SetDataOrigin_17(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the origin for the data.
	/// </summary>
	public virtual void SetDataOrigin(IntPtr _arg)
	{
		vtkVolumeReader_SetDataOrigin_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_SetDataSpacing_18(HandleRef pThis, double _arg1, double _arg2, double _arg3);

	/// <summary>
	/// Specify the spacing for the data.
	/// </summary>
	public virtual void SetDataSpacing(double _arg1, double _arg2, double _arg3)
	{
		vtkVolumeReader_SetDataSpacing_18(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_SetDataSpacing_19(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Specify the spacing for the data.
	/// </summary>
	public virtual void SetDataSpacing(IntPtr _arg)
	{
		vtkVolumeReader_SetDataSpacing_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_SetFilePattern_20(HandleRef pThis, string _arg);

	/// <summary>
	/// The snprintf format used to build filename from FilePrefix and number.
	/// </summary>
	public virtual void SetFilePattern(string _arg)
	{
		vtkVolumeReader_SetFilePattern_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_SetFilePrefix_21(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file prefix for the image file(s).
	/// </summary>
	public virtual void SetFilePrefix(string _arg)
	{
		vtkVolumeReader_SetFilePrefix_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_SetImageRange_22(HandleRef pThis, int _arg1, int _arg2);

	/// <summary>
	/// Set the range of files to read.
	/// </summary>
	public virtual void SetImageRange(int _arg1, int _arg2)
	{
		vtkVolumeReader_SetImageRange_22(GetCppThis(), _arg1, _arg2);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkVolumeReader_SetImageRange_23(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the range of files to read.
	/// </summary>
	public void SetImageRange(IntPtr _arg)
	{
		vtkVolumeReader_SetImageRange_23(GetCppThis(), _arg);
	}
}
