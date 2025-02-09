using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPNGReader
/// </summary>
/// <remarks>
///    read PNG files
///
/// vtkPNGReader is a source object that reads PNG files.
/// It should be able to read most any PNG file
///
/// </remarks>
/// <seealso>
///
/// vtkPNGWriter
/// </seealso>
public class vtkPNGReader : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPNGReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPNGReader()
	{
		MRClassNameKey = "class vtkPNGReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPNGReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPNGReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPNGReader New()
	{
		vtkPNGReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPNGReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPNGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPNGReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPNGReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkPNGReader_CanReadFile_01(HandleRef pThis, string fname);

	/// <summary>
	/// Is the given file a PNG file?
	/// </summary>
	public override int CanReadFile(string fname)
	{
		return vtkPNGReader_CanReadFile_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGReader_GetDescriptiveName_02(HandleRef pThis);

	/// <summary>
	/// Return a descriptive name for the file format that might be useful in a GUI.
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkPNGReader_GetDescriptiveName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGReader_GetFileExtensions_03(HandleRef pThis);

	/// <summary>
	/// Get the file extensions for this format.
	/// Returns a string with a space separated list of extensions in
	/// the format .extension
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkPNGReader_GetFileExtensions_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPNGReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPNGReader_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPNGReader_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPNGReader_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkPNGReader_GetNumberOfTextChunks_06(HandleRef pThis);

	/// <summary>
	/// Return the number of text chunks in the PNG file.
	/// Note that we don't process compressed or international text entries
	/// </summary>
	public ulong GetNumberOfTextChunks()
	{
		return vtkPNGReader_GetNumberOfTextChunks_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPNGReader_GetReadSpacingFromFile_07(HandleRef pThis);

	/// <summary>
	/// Set/Get if data spacing should be calculated from the PNG file.
	/// Use default spacing if the PNG file don't have valid pixel per meter parameters.
	/// Default is false.
	/// </summary>
	public virtual bool GetReadSpacingFromFile()
	{
		return (vtkPNGReader_GetReadSpacingFromFile_07(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGReader_GetTextChunks_08(HandleRef pThis, string key, IntPtr beginEndIndex);

	/// <summary>
	/// Given a 'key' for the text chunks, fills in 'beginEndIndex'
	/// with the begin and end indexes. Values are stored between
	/// [begin, end) indexes.
	/// </summary>
	public void GetTextChunks(string key, IntPtr beginEndIndex)
	{
		vtkPNGReader_GetTextChunks_08(GetCppThis(), key, beginEndIndex);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGReader_GetTextKey_09(HandleRef pThis, int index);

	/// <summary>
	/// Returns the text key stored at 'index'.
	/// </summary>
	public string GetTextKey(int index)
	{
		return Marshal.PtrToStringAnsi(vtkPNGReader_GetTextKey_09(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGReader_GetTextValue_10(HandleRef pThis, int index);

	/// <summary>
	/// Returns the text value stored at 'index'. A range of indexes
	/// that store values for a certain key can be obtained by calling
	/// GetTextChunks.
	/// </summary>
	public string GetTextValue(int index)
	{
		return Marshal.PtrToStringAnsi(vtkPNGReader_GetTextValue_10(GetCppThis(), index));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPNGReader_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPNGReader_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPNGReader_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPNGReader_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGReader_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPNGReader NewInstance()
	{
		vtkPNGReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPNGReader_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPNGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGReader_ReadSpacingFromFileOff_15(HandleRef pThis);

	/// <summary>
	/// Set/Get if data spacing should be calculated from the PNG file.
	/// Use default spacing if the PNG file don't have valid pixel per meter parameters.
	/// Default is false.
	/// </summary>
	public virtual void ReadSpacingFromFileOff()
	{
		vtkPNGReader_ReadSpacingFromFileOff_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGReader_ReadSpacingFromFileOn_16(HandleRef pThis);

	/// <summary>
	/// Set/Get if data spacing should be calculated from the PNG file.
	/// Use default spacing if the PNG file don't have valid pixel per meter parameters.
	/// Default is false.
	/// </summary>
	public virtual void ReadSpacingFromFileOn()
	{
		vtkPNGReader_ReadSpacingFromFileOn_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPNGReader_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPNGReader SafeDownCast(vtkObjectBase o)
	{
		vtkPNGReader vtkPNGReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPNGReader_SafeDownCast_17(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPNGReader2 = (vtkPNGReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPNGReader2.Register(null);
			}
		}
		return vtkPNGReader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPNGReader_SetReadSpacingFromFile_18(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/Get if data spacing should be calculated from the PNG file.
	/// Use default spacing if the PNG file don't have valid pixel per meter parameters.
	/// Default is false.
	/// </summary>
	public virtual void SetReadSpacingFromFile(bool _arg)
	{
		vtkPNGReader_SetReadSpacingFromFile_18(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}
}
