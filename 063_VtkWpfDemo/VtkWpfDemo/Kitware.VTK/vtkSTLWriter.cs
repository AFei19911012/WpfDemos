using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkSTLWriter
/// </summary>
/// <remarks>
///    write stereo lithography files
///
/// vtkSTLWriter writes stereo lithography (.stl) files in either ASCII or
/// binary form. Stereo lithography files contain only triangles. Since VTK 8.1,
/// this writer converts non-triangle polygons into triangles, so there is no
/// longer a need to use vtkTriangleFilter prior to using this writer if the
/// input contains polygons with more than three vertices.
///
/// @warning
/// Binary files written on one system may not be readable on other systems.
/// vtkSTLWriter uses VAX or PC byte ordering and swaps bytes on other systems.
/// </remarks>
public class vtkSTLWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkSTLWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkSTLWriter()
	{
		MRClassNameKey = "class vtkSTLWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkSTLWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkSTLWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSTLWriter New()
	{
		vtkSTLWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSTLWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkSTLWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkSTLWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern IntPtr vtkSTLWriter_GetBinaryHeader_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set binary header for the file.
	/// Binary header is only used when writing binary type files.
	/// If both Header and BinaryHeader are specified then BinaryHeader is used.
	/// Maximum length of binary header is 80 bytes, any content over this limit is ignored.
	/// </summary>
	public virtual vtkUnsignedCharArray GetBinaryHeader()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLWriter_GetBinaryHeader_01(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkUnsignedCharArray2 = (vtkUnsignedCharArray)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkUnsignedCharArray2.Register(null);
			}
		}
		return vtkUnsignedCharArray2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLWriter_GetFileName_02(HandleRef pThis);

	/// <summary>
	/// Specify file name of vtk polygon data file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkSTLWriter_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLWriter_GetFileType_03(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileType()
	{
		return vtkSTLWriter_GetFileType_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLWriter_GetFileTypeMaxValue_04(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileTypeMaxValue()
	{
		return vtkSTLWriter_GetFileTypeMaxValue_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLWriter_GetFileTypeMinValue_05(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileTypeMinValue()
	{
		return vtkSTLWriter_GetFileTypeMinValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLWriter_GetHeader_06(HandleRef pThis);

	/// <summary>
	/// Set the header for the file as text. The header cannot contain 0x00 characters.
	/// \sa SetBinaryHeader()
	/// </summary>
	public virtual string GetHeader()
	{
		return Marshal.PtrToStringAnsi(vtkSTLWriter_GetHeader_06(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLWriter_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLWriter_GetInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLWriter_GetInput_08(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkPolyData GetInput(int port)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLWriter_GetInput_08(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPolyData2 = (vtkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPolyData2.Register(null);
			}
		}
		return vtkPolyData2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSTLWriter_GetNumberOfGenerationsFromBase_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkSTLWriter_GetNumberOfGenerationsFromBase_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkSTLWriter_GetNumberOfGenerationsFromBaseType_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkSTLWriter_GetNumberOfGenerationsFromBaseType_10(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLWriter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkSTLWriter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkSTLWriter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkSTLWriter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkSTLWriter NewInstance()
	{
		vtkSTLWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLWriter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkSTLWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkSTLWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkSTLWriter SafeDownCast(vtkObjectBase o)
	{
		vtkSTLWriter vtkSTLWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkSTLWriter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkSTLWriter2 = (vtkSTLWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkSTLWriter2.Register(null);
			}
		}
		return vtkSTLWriter2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLWriter_SetBinaryHeader_16(HandleRef pThis, HandleRef binaryHeader);

	/// <summary>
	/// Set binary header for the file.
	/// Binary header is only used when writing binary type files.
	/// If both Header and BinaryHeader are specified then BinaryHeader is used.
	/// Maximum length of binary header is 80 bytes, any content over this limit is ignored.
	/// </summary>
	public virtual void SetBinaryHeader(vtkUnsignedCharArray binaryHeader)
	{
		vtkSTLWriter_SetBinaryHeader_16(GetCppThis(), binaryHeader?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLWriter_SetFileName_17(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of vtk polygon data file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkSTLWriter_SetFileName_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLWriter_SetFileType_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual void SetFileType(int _arg)
	{
		vtkSTLWriter_SetFileType_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLWriter_SetFileTypeToASCII_19(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public void SetFileTypeToASCII()
	{
		vtkSTLWriter_SetFileTypeToASCII_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLWriter_SetFileTypeToBinary_20(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public void SetFileTypeToBinary()
	{
		vtkSTLWriter_SetFileTypeToBinary_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkSTLWriter_SetHeader_21(HandleRef pThis, string _arg);

	/// <summary>
	/// Set the header for the file as text. The header cannot contain 0x00 characters.
	/// \sa SetBinaryHeader()
	/// </summary>
	public virtual void SetHeader(string _arg)
	{
		vtkSTLWriter_SetHeader_21(GetCppThis(), _arg);
	}
}
