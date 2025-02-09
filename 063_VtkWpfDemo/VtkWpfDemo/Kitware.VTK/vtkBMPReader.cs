using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBMPReader
/// </summary>
/// <remarks>
///    read Windows BMP files
///
/// vtkBMPReader is a source object that reads Windows BMP files.
/// This includes indexed and 24bit bitmaps
/// Usually, all BMPs are converted to 24bit RGB, but BMPs may be output
/// as 8bit images with a LookupTable if the Allow8BitBMP flag is set.
///
/// BMPReader creates structured point datasets. The dimension of the
/// dataset depends upon the number of files read. Reading a single file
/// results in a 2D image, while reading more than one file results in a
/// 3D volume.
///
/// To read a volume, files must be of the form "FileName.&lt;number&gt;"
/// (e.g., foo.bmp.0, foo.bmp.1, ...). You must also specify the image
/// range. This range specifies the beginning and ending files to read (range
/// can be any pair of non-negative numbers).
///
/// The default behavior is to read a single file. In this case, the form
/// of the file is simply "FileName" (e.g., foo.bmp).
///
/// </remarks>
/// <seealso>
///
/// vtkBMPWriter
/// </seealso>
public class vtkBMPReader : vtkImageReader
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBMPReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBMPReader()
	{
		MRClassNameKey = "class vtkBMPReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBMPReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBMPReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBMPReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBMPReader New()
	{
		vtkBMPReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBMPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBMPReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBMPReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkBMPReader_Allow8BitBMPOff_01(HandleRef pThis);

	/// <summary>
	/// If this flag is set and the BMP reader encounters an 8bit file,
	/// the data will be kept as unsigned chars and a lookuptable will be
	/// exported
	/// </summary>
	public virtual void Allow8BitBMPOff()
	{
		vtkBMPReader_Allow8BitBMPOff_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBMPReader_Allow8BitBMPOn_02(HandleRef pThis);

	/// <summary>
	/// If this flag is set and the BMP reader encounters an 8bit file,
	/// the data will be kept as unsigned chars and a lookuptable will be
	/// exported
	/// </summary>
	public virtual void Allow8BitBMPOn()
	{
		vtkBMPReader_Allow8BitBMPOn_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBMPReader_CanReadFile_03(HandleRef pThis, string fname);

	/// <summary>
	/// Is the given file a BMP file?
	/// </summary>
	public override int CanReadFile(string fname)
	{
		return vtkBMPReader_CanReadFile_03(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBMPReader_GetAllow8BitBMP_04(HandleRef pThis);

	/// <summary>
	/// If this flag is set and the BMP reader encounters an 8bit file,
	/// the data will be kept as unsigned chars and a lookuptable will be
	/// exported
	/// </summary>
	public virtual int GetAllow8BitBMP()
	{
		return vtkBMPReader_GetAllow8BitBMP_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBMPReader_GetColors_05(HandleRef pThis);

	/// <summary>
	/// Returns the color lut.
	/// </summary>
	public virtual IntPtr GetColors()
	{
		return vtkBMPReader_GetColors_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBMPReader_GetDepth_06(HandleRef pThis);

	/// <summary>
	/// Returns the depth of the BMP, either 8 or 24.
	/// </summary>
	public virtual int GetDepth()
	{
		return vtkBMPReader_GetDepth_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBMPReader_GetDescriptiveName_07(HandleRef pThis);

	/// <summary>
	/// Return a descriptive name for the file format that might be useful in a GUI.
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkBMPReader_GetDescriptiveName_07(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBMPReader_GetFileExtensions_08(HandleRef pThis);

	/// <summary>
	/// Get the file extensions for this format.
	/// Returns a string with a space separated list of extensions in
	/// the format .extension
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkBMPReader_GetFileExtensions_08(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBMPReader_GetLookupTable_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// If this flag is set and the BMP reader encounters an 8bit file,
	/// the data will be kept as unsigned chars and a lookuptable will be
	/// exported
	/// </summary>
	public virtual vtkLookupTable GetLookupTable()
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBMPReader_GetLookupTable_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLookupTable2 = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLookupTable2.Register(null);
			}
		}
		return vtkLookupTable2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBMPReader_GetNumberOfGenerationsFromBase_10(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBMPReader_GetNumberOfGenerationsFromBase_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBMPReader_GetNumberOfGenerationsFromBaseType_11(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBMPReader_GetNumberOfGenerationsFromBaseType_11(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBMPReader_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBMPReader_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBMPReader_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBMPReader_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBMPReader_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBMPReader NewInstance()
	{
		vtkBMPReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBMPReader_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBMPReader_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBMPReader SafeDownCast(vtkObjectBase o)
	{
		vtkBMPReader vtkBMPReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBMPReader_SafeDownCast_16(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBMPReader2 = (vtkBMPReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBMPReader2.Register(null);
			}
		}
		return vtkBMPReader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBMPReader_SetAllow8BitBMP_17(HandleRef pThis, int _arg);

	/// <summary>
	/// If this flag is set and the BMP reader encounters an 8bit file,
	/// the data will be kept as unsigned chars and a lookuptable will be
	/// exported
	/// </summary>
	public virtual void SetAllow8BitBMP(int _arg)
	{
		vtkBMPReader_SetAllow8BitBMP_17(GetCppThis(), _arg);
	}
}
