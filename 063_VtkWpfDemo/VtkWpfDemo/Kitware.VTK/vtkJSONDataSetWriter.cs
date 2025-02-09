using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkJSONDataSetWriter
/// </summary>
/// <remarks>
///    write vtkDataSet using a vtkArchiver with a JSON meta file along
///          with all the binary arrays written as standalone binary files.
///          The generated format can be used by vtk.js using the reader below
///          https://kitware.github.io/vtk-js/examples/HttpDataSetReader.html
///
/// vtkJSONDataSetWriter writes vtkImageData / vtkPolyData into a set of files
/// representing each arrays that compose the dataset along with a JSON meta file
/// that describe what they are and how they should be assembled into an actual
/// vtkDataSet.
///
///
/// @warning
/// This writer assume LittleEndian by default. Additional work should be done to
/// properly
/// handle endianness.
///
///
/// </remarks>
/// <seealso>
///
/// vtkArchiver
/// </seealso>
public class vtkJSONDataSetWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkJSONDataSetWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkJSONDataSetWriter()
	{
		MRClassNameKey = "class vtkJSONDataSetWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkJSONDataSetWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkJSONDataSetWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONDataSetWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public new static vtkJSONDataSetWriter New()
	{
		vtkJSONDataSetWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONDataSetWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJSONDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public vtkJSONDataSetWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkJSONDataSetWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONDataSetWriter_ComputeMD5_01(IntPtr content, int size, string hash);

	/// <summary>
	/// Compute a MD5 digest of a void/(const unsigned char) pointer to compute a
	///  string hash
	/// </summary>
	public static void ComputeMD5(IntPtr content, int size, string hash)
	{
		vtkJSONDataSetWriter_ComputeMD5_01(content, size, hash);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONDataSetWriter_GetArchiver_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Specify the Scene Archiver object
	/// </summary>
	public virtual vtkArchiver GetArchiver()
	{
		vtkArchiver vtkArchiver2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONDataSetWriter_GetArchiver_02(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkArchiver2 = (vtkArchiver)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkArchiver2.Register(null);
			}
		}
		return vtkArchiver2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONDataSetWriter_GetInput_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkDataSet GetInput()
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONDataSetWriter_GetInput_03(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONDataSetWriter_GetInput_04(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkDataSet GetInput(int port)
	{
		vtkDataSet vtkDataSet2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONDataSetWriter_GetInput_04(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataSet2 = (vtkDataSet)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataSet2.Register(null);
			}
		}
		return vtkDataSet2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJSONDataSetWriter_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkJSONDataSetWriter_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJSONDataSetWriter_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkJSONDataSetWriter_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkJSONDataSetWriter_GetShortType_07(HandleRef input, ref byte needConversion);

	/// <summary>
	/// Compute the target JavaScript typed array name for the given vtkDataArray
	/// (Uin8, Uint16, Uin32, Int8, Int16, Int32, Float32, Float64) or
	/// "xxx" if no match found
	///
	/// Since Uint64 and Int64 does not exist in JavaScript, the needConversion
	/// argument will be set to true and Uint32/Int32 will be returned instead.
	/// </summary>
	public static string GetShortType(vtkDataArray input, ref byte needConversion)
	{
		return vtkJSONDataSetWriter_GetShortType_07(input?.GetCppThis() ?? default(HandleRef), ref needConversion);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkJSONDataSetWriter_GetUID_08(HandleRef arg0, ref byte needConversion);

	/// <summary>
	/// Return a Unique identifier for that array
	/// (i.e.: Float32_356_13f880891af7b77262c49cae09a41e28 )
	/// </summary>
	public static string GetUID(vtkDataArray arg0, ref byte needConversion)
	{
		return vtkJSONDataSetWriter_GetUID_08(arg0?.GetCppThis() ?? default(HandleRef), ref needConversion);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkJSONDataSetWriter_GetValidString_09(HandleRef pThis, string arg0);

	/// <summary>
	/// Return a Unique identifier for any invalid string
	/// </summary>
	public string GetValidString(string arg0)
	{
		return vtkJSONDataSetWriter_GetValidString_09(GetCppThis(), arg0);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONDataSetWriter_IsA_10(HandleRef pThis, string type);

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public override int IsA(string type)
	{
		return vtkJSONDataSetWriter_IsA_10(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkJSONDataSetWriter_IsDataSetValid_11(HandleRef pThis);

	/// <summary>
	/// Specify the Scene Archiver object
	/// </summary>
	public bool IsDataSetValid()
	{
		return (vtkJSONDataSetWriter_IsDataSetValid_11(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJSONDataSetWriter_IsTypeOf_12(string type);

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkJSONDataSetWriter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONDataSetWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public new vtkJSONDataSetWriter NewInstance()
	{
		vtkJSONDataSetWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONDataSetWriter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJSONDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJSONDataSetWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public new static vtkJSONDataSetWriter SafeDownCast(vtkObjectBase o)
	{
		vtkJSONDataSetWriter vtkJSONDataSetWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJSONDataSetWriter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkJSONDataSetWriter2 = (vtkJSONDataSetWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkJSONDataSetWriter2.Register(null);
			}
		}
		return vtkJSONDataSetWriter2;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONDataSetWriter_SetArchiver_16(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the Scene Archiver object
	/// </summary>
	public virtual void SetArchiver(vtkArchiver arg0)
	{
		vtkJSONDataSetWriter_SetArchiver_16(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJSONDataSetWriter_Write_17(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// Specify the Scene Archiver object
	/// </summary>
	public void Write(vtkDataSet arg0)
	{
		vtkJSONDataSetWriter_Write_17(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkJSONDataSetWriter_WriteArrayAsRAW_18(HandleRef arg0, string filePath);

	/// <summary>
	/// For backwards compatibility, this static method writes a data array's
	/// contents directly to a file.
	/// </summary>
	public static bool WriteArrayAsRAW(vtkDataArray arg0, string filePath)
	{
		return (vtkJSONDataSetWriter_WriteArrayAsRAW_18(arg0?.GetCppThis() ?? default(HandleRef), filePath) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOExport.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkJSONDataSetWriter_WriteArrayContents_19(HandleRef pThis, HandleRef arg0, string relativeFilePath);

	/// <summary>
	/// Write the contents of the vtkDataArray to disk based on the filePath
	/// provided without any extra information. Just the raw data will be
	/// written.
	///
	/// If vtkDataArray is a Uint64 or Int64, the data will be converted
	/// to Uint32 or Int32 before being written.
	/// </summary>
	public bool WriteArrayContents(vtkDataArray arg0, string relativeFilePath)
	{
		return (vtkJSONDataSetWriter_WriteArrayContents_19(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef), relativeFilePath) != 0) ? true : false;
	}
}
