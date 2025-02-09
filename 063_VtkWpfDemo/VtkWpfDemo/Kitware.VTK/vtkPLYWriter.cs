using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkPLYWriter
/// </summary>
/// <remarks>
///    write Stanford PLY file format
///
/// vtkPLYWriter writes polygonal data in Stanford University PLY format
/// (see http://graphics.stanford.edu/data/3Dscanrep/). The data can be
/// written in either binary (little or big endian) or ASCII representation.
/// As for PointData and CellData, vtkPLYWriter cannot handle normals or
/// vectors. It only handles RGB PointData and CellData. You need to set the
/// name of the array (using SetName for the array and SetArrayName for the
/// writer). If the array is not a vtkUnsignedCharArray with 3 or 4 components,
/// you need to specify a vtkLookupTable to map the scalars to RGB.
///
/// To enable saving out alpha (opacity) values, you must enable alpha using
/// `vtkPLYWriter::SetEnableAlpha()`.
///
/// @warning
/// PLY does not handle big endian versus little endian correctly.
///
/// </remarks>
/// <seealso>
///
/// vtkPLYReader
/// </seealso>
public class vtkPLYWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkPLYWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkPLYWriter()
	{
		MRClassNameKey = "class vtkPLYWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkPLYWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkPLYWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPLYWriter New()
	{
		vtkPLYWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkPLYWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkPLYWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_AddComment_01(HandleRef pThis, string comment);

	/// <summary>
	/// Add a comment in the header part.
	/// </summary>
	public void AddComment(string comment)
	{
		vtkPLYWriter_AddComment_01(GetCppThis(), comment);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_EnableAlphaOff_02(HandleRef pThis);

	/// <summary>
	/// Enable alpha output. Default is off, i.e. only color values will be saved
	/// based on ColorMode.
	/// </summary>
	public virtual void EnableAlphaOff()
	{
		vtkPLYWriter_EnableAlphaOff_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_EnableAlphaOn_03(HandleRef pThis);

	/// <summary>
	/// Enable alpha output. Default is off, i.e. only color values will be saved
	/// based on ColorMode.
	/// </summary>
	public virtual void EnableAlphaOn()
	{
		vtkPLYWriter_EnableAlphaOn_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPLYWriter_GetAlpha_04(HandleRef pThis);

	/// <summary>
	///  both) and EnableAlpha is ON.
	/// </summary>
	public virtual byte GetAlpha()
	{
		return vtkPLYWriter_GetAlpha_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_GetArrayName_05(HandleRef pThis);

	/// <summary>
	/// Specify the array name to use to color the data.
	/// </summary>
	public virtual string GetArrayName()
	{
		return Marshal.PtrToStringAnsi(vtkPLYWriter_GetArrayName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_GetColor_06(HandleRef pThis);

	/// <summary>
	/// Set the color to use when using a uniform color (either point or cells,
	/// or both). The color is specified as a triplet of three unsigned chars
	/// between (0,255). This only takes effect when the ColorMode is set to
	/// uniform point, uniform cell, or uniform color.
	/// </summary>
	public virtual byte[] GetColor()
	{
		IntPtr intPtr = vtkPLYWriter_GetColor_06(GetCppThis());
		byte[] array = null;
		if (IntPtr.Zero != intPtr)
		{
			array = new byte[3];
			Marshal.Copy(intPtr, array, 0, array.Length);
		}
		return array;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_GetColor_07(HandleRef pThis, ref byte _arg1, ref byte _arg2, ref byte _arg3);

	/// <summary>
	/// Set the color to use when using a uniform color (either point or cells,
	/// or both). The color is specified as a triplet of three unsigned chars
	/// between (0,255). This only takes effect when the ColorMode is set to
	/// uniform point, uniform cell, or uniform color.
	/// </summary>
	public virtual void GetColor(ref byte _arg1, ref byte _arg2, ref byte _arg3)
	{
		vtkPLYWriter_GetColor_07(GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_GetColor_08(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when using a uniform color (either point or cells,
	/// or both). The color is specified as a triplet of three unsigned chars
	/// between (0,255). This only takes effect when the ColorMode is set to
	/// uniform point, uniform cell, or uniform color.
	/// </summary>
	public virtual void GetColor(IntPtr _arg)
	{
		vtkPLYWriter_GetColor_08(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetColorMode_09(HandleRef pThis);

	/// <summary>
	/// These methods enable the user to control how to add color into the PLY
	/// output file. The default behavior is as follows. The user provides the
	/// name of an array and a component number. If the type of the array is
	/// three components, unsigned char, then the data is written as three
	/// separate "red", "green" and "blue" properties. If the type of the array is
	/// four components, unsigned char, then the data is written as three separate
	/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
	/// unsigned char, and a lookup table is provided, then the array/component
	/// are mapped through the table to generate three separate "red", "green"
	/// and "blue" properties in the PLY file. The user can also set the
	/// ColorMode to specify a uniform color for the whole part (on a vertex
	/// colors, face colors, or both. (Note: vertex colors or cell colors may be
	/// written, depending on where the named array is found. If points and
	/// cells have the arrays with the same name, then both colors will be
	/// written.)
	/// </summary>
	public virtual int GetColorMode()
	{
		return vtkPLYWriter_GetColorMode_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetComponent_10(HandleRef pThis);

	/// <summary>
	/// Specify the array component to use to color the data.
	/// </summary>
	public virtual int GetComponent()
	{
		return vtkPLYWriter_GetComponent_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetComponentMaxValue_11(HandleRef pThis);

	/// <summary>
	/// Specify the array component to use to color the data.
	/// </summary>
	public virtual int GetComponentMaxValue()
	{
		return vtkPLYWriter_GetComponentMaxValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetComponentMinValue_12(HandleRef pThis);

	/// <summary>
	/// Specify the array component to use to color the data.
	/// </summary>
	public virtual int GetComponentMinValue()
	{
		return vtkPLYWriter_GetComponentMinValue_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetDataByteOrder_13(HandleRef pThis);

	/// <summary>
	/// If the file type is binary, then the user can specify which
	/// byte order to use (little versus big endian).
	/// </summary>
	public virtual int GetDataByteOrder()
	{
		return vtkPLYWriter_GetDataByteOrder_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetDataByteOrderMaxValue_14(HandleRef pThis);

	/// <summary>
	/// If the file type is binary, then the user can specify which
	/// byte order to use (little versus big endian).
	/// </summary>
	public virtual int GetDataByteOrderMaxValue()
	{
		return vtkPLYWriter_GetDataByteOrderMaxValue_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetDataByteOrderMinValue_15(HandleRef pThis);

	/// <summary>
	/// If the file type is binary, then the user can specify which
	/// byte order to use (little versus big endian).
	/// </summary>
	public virtual int GetDataByteOrderMinValue()
	{
		return vtkPLYWriter_GetDataByteOrderMinValue_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPLYWriter_GetEnableAlpha_16(HandleRef pThis);

	/// <summary>
	/// Enable alpha output. Default is off, i.e. only color values will be saved
	/// based on ColorMode.
	/// </summary>
	public virtual bool GetEnableAlpha()
	{
		return (vtkPLYWriter_GetEnableAlpha_16(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_GetFileName_17(HandleRef pThis);

	/// <summary>
	/// Specify file name of vtk polygon data file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkPLYWriter_GetFileName_17(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetFileType_18(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileType()
	{
		return vtkPLYWriter_GetFileType_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetFileTypeMaxValue_19(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileTypeMaxValue()
	{
		return vtkPLYWriter_GetFileTypeMaxValue_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetFileTypeMinValue_20(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileTypeMinValue()
	{
		return vtkPLYWriter_GetFileTypeMinValue_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_GetInput_21(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYWriter_GetInput_21(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_GetInput_22(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkPolyData GetInput(int port)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYWriter_GetInput_22(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_GetLookupTable_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// A lookup table can be specified in order to convert data arrays to
	/// RGBA colors.
	/// </summary>
	public virtual vtkScalarsToColors GetLookupTable()
	{
		vtkScalarsToColors vtkScalarsToColors2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYWriter_GetLookupTable_23(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkScalarsToColors2 = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkScalarsToColors2.Register(null);
			}
		}
		return vtkScalarsToColors2;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPLYWriter_GetNumberOfGenerationsFromBase_24(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkPLYWriter_GetNumberOfGenerationsFromBase_24(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkPLYWriter_GetNumberOfGenerationsFromBaseType_25(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkPLYWriter_GetNumberOfGenerationsFromBaseType_25(type);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern string vtkPLYWriter_GetOutputString_26(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// Note that writing to an output stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to write the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public string GetOutputString()
	{
		return vtkPLYWriter_GetOutputString_26(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetTextureCoordinatesName_27(HandleRef pThis);

	/// <summary>
	/// Choose the name used for the texture coordinates.
	/// (u, v) or (texture_u, texture_v)
	/// </summary>
	public virtual int GetTextureCoordinatesName()
	{
		return vtkPLYWriter_GetTextureCoordinatesName_27(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetTextureCoordinatesNameMaxValue_28(HandleRef pThis);

	/// <summary>
	/// Choose the name used for the texture coordinates.
	/// (u, v) or (texture_u, texture_v)
	/// </summary>
	public virtual int GetTextureCoordinatesNameMaxValue()
	{
		return vtkPLYWriter_GetTextureCoordinatesNameMaxValue_28(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_GetTextureCoordinatesNameMinValue_29(HandleRef pThis);

	/// <summary>
	/// Choose the name used for the texture coordinates.
	/// (u, v) or (texture_u, texture_v)
	/// </summary>
	public virtual int GetTextureCoordinatesNameMinValue()
	{
		return vtkPLYWriter_GetTextureCoordinatesNameMinValue_29(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkPLYWriter_GetWriteToOutputString_30(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// Note that writing to an output stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to write the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public virtual bool GetWriteToOutputString()
	{
		return (vtkPLYWriter_GetWriteToOutputString_30(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_IsA_31(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkPLYWriter_IsA_31(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkPLYWriter_IsTypeOf_32(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkPLYWriter_IsTypeOf_32(type);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_NewInstance_34(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkPLYWriter NewInstance()
	{
		vtkPLYWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYWriter_NewInstance_34(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkPLYWriter_SafeDownCast_35(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkPLYWriter SafeDownCast(vtkObjectBase o)
	{
		vtkPLYWriter vtkPLYWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkPLYWriter_SafeDownCast_35(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkPLYWriter2 = (vtkPLYWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkPLYWriter2.Register(null);
			}
		}
		return vtkPLYWriter2;
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetAlpha_36(HandleRef pThis, byte _arg);

	/// <summary>
	///  both) and EnableAlpha is ON.
	/// </summary>
	public virtual void SetAlpha(byte _arg)
	{
		vtkPLYWriter_SetAlpha_36(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetArrayName_37(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify the array name to use to color the data.
	/// </summary>
	public virtual void SetArrayName(string _arg)
	{
		vtkPLYWriter_SetArrayName_37(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetColor_38(HandleRef pThis, byte _arg1, byte _arg2, byte _arg3);

	/// <summary>
	/// Set the color to use when using a uniform color (either point or cells,
	/// or both). The color is specified as a triplet of three unsigned chars
	/// between (0,255). This only takes effect when the ColorMode is set to
	/// uniform point, uniform cell, or uniform color.
	/// </summary>
	public virtual void SetColor(byte _arg1, byte _arg2, byte _arg3)
	{
		vtkPLYWriter_SetColor_38(GetCppThis(), _arg1, _arg2, _arg3);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetColor_39(HandleRef pThis, IntPtr _arg);

	/// <summary>
	/// Set the color to use when using a uniform color (either point or cells,
	/// or both). The color is specified as a triplet of three unsigned chars
	/// between (0,255). This only takes effect when the ColorMode is set to
	/// uniform point, uniform cell, or uniform color.
	/// </summary>
	public virtual void SetColor(IntPtr _arg)
	{
		vtkPLYWriter_SetColor_39(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetColorMode_40(HandleRef pThis, int _arg);

	/// <summary>
	/// These methods enable the user to control how to add color into the PLY
	/// output file. The default behavior is as follows. The user provides the
	/// name of an array and a component number. If the type of the array is
	/// three components, unsigned char, then the data is written as three
	/// separate "red", "green" and "blue" properties. If the type of the array is
	/// four components, unsigned char, then the data is written as three separate
	/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
	/// unsigned char, and a lookup table is provided, then the array/component
	/// are mapped through the table to generate three separate "red", "green"
	/// and "blue" properties in the PLY file. The user can also set the
	/// ColorMode to specify a uniform color for the whole part (on a vertex
	/// colors, face colors, or both. (Note: vertex colors or cell colors may be
	/// written, depending on where the named array is found. If points and
	/// cells have the arrays with the same name, then both colors will be
	/// written.)
	/// </summary>
	public virtual void SetColorMode(int _arg)
	{
		vtkPLYWriter_SetColorMode_40(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetColorModeToDefault_41(HandleRef pThis);

	/// <summary>
	/// These methods enable the user to control how to add color into the PLY
	/// output file. The default behavior is as follows. The user provides the
	/// name of an array and a component number. If the type of the array is
	/// three components, unsigned char, then the data is written as three
	/// separate "red", "green" and "blue" properties. If the type of the array is
	/// four components, unsigned char, then the data is written as three separate
	/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
	/// unsigned char, and a lookup table is provided, then the array/component
	/// are mapped through the table to generate three separate "red", "green"
	/// and "blue" properties in the PLY file. The user can also set the
	/// ColorMode to specify a uniform color for the whole part (on a vertex
	/// colors, face colors, or both. (Note: vertex colors or cell colors may be
	/// written, depending on where the named array is found. If points and
	/// cells have the arrays with the same name, then both colors will be
	/// written.)
	/// </summary>
	public void SetColorModeToDefault()
	{
		vtkPLYWriter_SetColorModeToDefault_41(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetColorModeToOff_42(HandleRef pThis);

	/// <summary>
	/// These methods enable the user to control how to add color into the PLY
	/// output file. The default behavior is as follows. The user provides the
	/// name of an array and a component number. If the type of the array is
	/// three components, unsigned char, then the data is written as three
	/// separate "red", "green" and "blue" properties. If the type of the array is
	/// four components, unsigned char, then the data is written as three separate
	/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
	/// unsigned char, and a lookup table is provided, then the array/component
	/// are mapped through the table to generate three separate "red", "green"
	/// and "blue" properties in the PLY file. The user can also set the
	/// ColorMode to specify a uniform color for the whole part (on a vertex
	/// colors, face colors, or both. (Note: vertex colors or cell colors may be
	/// written, depending on where the named array is found. If points and
	/// cells have the arrays with the same name, then both colors will be
	/// written.)
	/// </summary>
	public void SetColorModeToOff()
	{
		vtkPLYWriter_SetColorModeToOff_42(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetColorModeToUniformCellColor_43(HandleRef pThis);

	/// <summary>
	/// These methods enable the user to control how to add color into the PLY
	/// output file. The default behavior is as follows. The user provides the
	/// name of an array and a component number. If the type of the array is
	/// three components, unsigned char, then the data is written as three
	/// separate "red", "green" and "blue" properties. If the type of the array is
	/// four components, unsigned char, then the data is written as three separate
	/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
	/// unsigned char, and a lookup table is provided, then the array/component
	/// are mapped through the table to generate three separate "red", "green"
	/// and "blue" properties in the PLY file. The user can also set the
	/// ColorMode to specify a uniform color for the whole part (on a vertex
	/// colors, face colors, or both. (Note: vertex colors or cell colors may be
	/// written, depending on where the named array is found. If points and
	/// cells have the arrays with the same name, then both colors will be
	/// written.)
	/// </summary>
	public void SetColorModeToUniformCellColor()
	{
		vtkPLYWriter_SetColorModeToUniformCellColor_43(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetColorModeToUniformColor_44(HandleRef pThis);

	/// <summary>
	/// These methods enable the user to control how to add color into the PLY
	/// output file. The default behavior is as follows. The user provides the
	/// name of an array and a component number. If the type of the array is
	/// three components, unsigned char, then the data is written as three
	/// separate "red", "green" and "blue" properties. If the type of the array is
	/// four components, unsigned char, then the data is written as three separate
	/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
	/// unsigned char, and a lookup table is provided, then the array/component
	/// are mapped through the table to generate three separate "red", "green"
	/// and "blue" properties in the PLY file. The user can also set the
	/// ColorMode to specify a uniform color for the whole part (on a vertex
	/// colors, face colors, or both. (Note: vertex colors or cell colors may be
	/// written, depending on where the named array is found. If points and
	/// cells have the arrays with the same name, then both colors will be
	/// written.)
	/// </summary>
	public void SetColorModeToUniformColor()
	{
		vtkPLYWriter_SetColorModeToUniformColor_44(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetColorModeToUniformPointColor_45(HandleRef pThis);

	/// <summary>
	/// These methods enable the user to control how to add color into the PLY
	/// output file. The default behavior is as follows. The user provides the
	/// name of an array and a component number. If the type of the array is
	/// three components, unsigned char, then the data is written as three
	/// separate "red", "green" and "blue" properties. If the type of the array is
	/// four components, unsigned char, then the data is written as three separate
	/// "red", "green" and "blue" properties, dropping the "alpha". If the type is not
	/// unsigned char, and a lookup table is provided, then the array/component
	/// are mapped through the table to generate three separate "red", "green"
	/// and "blue" properties in the PLY file. The user can also set the
	/// ColorMode to specify a uniform color for the whole part (on a vertex
	/// colors, face colors, or both. (Note: vertex colors or cell colors may be
	/// written, depending on where the named array is found. If points and
	/// cells have the arrays with the same name, then both colors will be
	/// written.)
	/// </summary>
	public void SetColorModeToUniformPointColor()
	{
		vtkPLYWriter_SetColorModeToUniformPointColor_45(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetComponent_46(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify the array component to use to color the data.
	/// </summary>
	public virtual void SetComponent(int _arg)
	{
		vtkPLYWriter_SetComponent_46(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetDataByteOrder_47(HandleRef pThis, int _arg);

	/// <summary>
	/// If the file type is binary, then the user can specify which
	/// byte order to use (little versus big endian).
	/// </summary>
	public virtual void SetDataByteOrder(int _arg)
	{
		vtkPLYWriter_SetDataByteOrder_47(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetDataByteOrderToBigEndian_48(HandleRef pThis);

	/// <summary>
	/// If the file type is binary, then the user can specify which
	/// byte order to use (little versus big endian).
	/// </summary>
	public void SetDataByteOrderToBigEndian()
	{
		vtkPLYWriter_SetDataByteOrderToBigEndian_48(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetDataByteOrderToLittleEndian_49(HandleRef pThis);

	/// <summary>
	/// If the file type is binary, then the user can specify which
	/// byte order to use (little versus big endian).
	/// </summary>
	public void SetDataByteOrderToLittleEndian()
	{
		vtkPLYWriter_SetDataByteOrderToLittleEndian_49(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetEnableAlpha_50(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable alpha output. Default is off, i.e. only color values will be saved
	/// based on ColorMode.
	/// </summary>
	public virtual void SetEnableAlpha(bool _arg)
	{
		vtkPLYWriter_SetEnableAlpha_50(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetFileName_51(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of vtk polygon data file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkPLYWriter_SetFileName_51(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetFileType_52(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual void SetFileType(int _arg)
	{
		vtkPLYWriter_SetFileType_52(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetFileTypeToASCII_53(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public void SetFileTypeToASCII()
	{
		vtkPLYWriter_SetFileTypeToASCII_53(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetFileTypeToBinary_54(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public void SetFileTypeToBinary()
	{
		vtkPLYWriter_SetFileTypeToBinary_54(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetLookupTable_55(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// A lookup table can be specified in order to convert data arrays to
	/// RGBA colors.
	/// </summary>
	public virtual void SetLookupTable(vtkScalarsToColors arg0)
	{
		vtkPLYWriter_SetLookupTable_55(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetTextureCoordinatesName_56(HandleRef pThis, int _arg);

	/// <summary>
	/// Choose the name used for the texture coordinates.
	/// (u, v) or (texture_u, texture_v)
	/// </summary>
	public virtual void SetTextureCoordinatesName(int _arg)
	{
		vtkPLYWriter_SetTextureCoordinatesName_56(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetTextureCoordinatesNameToTextureUV_57(HandleRef pThis);

	/// <summary>
	/// Choose the name used for the texture coordinates.
	/// (u, v) or (texture_u, texture_v)
	/// </summary>
	public void SetTextureCoordinatesNameToTextureUV()
	{
		vtkPLYWriter_SetTextureCoordinatesNameToTextureUV_57(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetTextureCoordinatesNameToUV_58(HandleRef pThis);

	/// <summary>
	/// Choose the name used for the texture coordinates.
	/// (u, v) or (texture_u, texture_v)
	/// </summary>
	public void SetTextureCoordinatesNameToUV()
	{
		vtkPLYWriter_SetTextureCoordinatesNameToUV_58(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_SetWriteToOutputString_59(HandleRef pThis, byte _arg);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// Note that writing to an output stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to write the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public virtual void SetWriteToOutputString(bool _arg)
	{
		vtkPLYWriter_SetWriteToOutputString_59(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_WriteToOutputStringOff_60(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// Note that writing to an output stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to write the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public virtual void WriteToOutputStringOff()
	{
		vtkPLYWriter_WriteToOutputStringOff_60(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOPLY.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkPLYWriter_WriteToOutputStringOn_61(HandleRef pThis);

	/// <summary>
	/// Enable writing to an OutputString instead of the default, a file.
	/// Note that writing to an output stream would be more flexible (enabling
	/// other kind of streams) and possibly more efficient because we don't need
	/// to write the whole stream to a string. However a stream interface
	/// does not translate well to python and the string interface satisfies
	/// our current needs. So we leave the stream interface for future work.
	/// </summary>
	public virtual void WriteToOutputStringOn()
	{
		vtkPLYWriter_WriteToOutputStringOn_61(GetCppThis());
	}
}
