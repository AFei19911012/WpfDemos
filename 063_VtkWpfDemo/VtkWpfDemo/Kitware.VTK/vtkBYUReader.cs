using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBYUReader
/// </summary>
/// <remarks>
///    read MOVIE.BYU polygon files
///
/// vtkBYUReader is a source object that reads MOVIE.BYU polygon files.
/// These files consist of a geometry file (.g), a scalar file (.s), a
/// displacement or vector file (.d), and a 2D texture coordinate file
/// (.t).
/// </remarks>
public class vtkBYUReader : vtkPolyDataAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBYUReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBYUReader()
	{
		MRClassNameKey = "class vtkBYUReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBYUReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBYUReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBYUReader New()
	{
		vtkBYUReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBYUReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBYUReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBYUReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkBYUReader_CanReadFile_01(string filename);

	/// <summary>
	/// Returns 1 if this file can be read and 0 if the file cannot be read.
	/// Because BYU files do not have anything in the header specifying the file
	/// type, the result is not definitive.  Invalid files may still return 1
	/// although a valid file will never return 0.
	/// </summary>
	public static int CanReadFile(string filename)
	{
		return vtkBYUReader_CanReadFile_01(filename);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUReader_GetDisplacementFileName_02(HandleRef pThis);

	/// <summary>
	/// Specify name of displacement FileName.
	/// </summary>
	public virtual string GetDisplacementFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUReader_GetDisplacementFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUReader_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Specify name of geometry FileName (alias).
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUReader_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUReader_GetGeometryFileName_04(HandleRef pThis);

	/// <summary>
	/// Specify name of geometry FileName.
	/// </summary>
	public virtual string GetGeometryFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUReader_GetGeometryFileName_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBYUReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBYUReader_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBYUReader_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBYUReader_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUReader_GetPartNumber_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the part number to be read.
	/// </summary>
	public virtual int GetPartNumber()
	{
		return vtkBYUReader_GetPartNumber_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUReader_GetPartNumberMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the part number to be read.
	/// </summary>
	public virtual int GetPartNumberMaxValue()
	{
		return vtkBYUReader_GetPartNumberMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUReader_GetPartNumberMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the part number to be read.
	/// </summary>
	public virtual int GetPartNumberMinValue()
	{
		return vtkBYUReader_GetPartNumberMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUReader_GetReadDisplacement_10(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the displacement file.
	/// </summary>
	public virtual int GetReadDisplacement()
	{
		return vtkBYUReader_GetReadDisplacement_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUReader_GetReadScalar_11(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the scalar file.
	/// </summary>
	public virtual int GetReadScalar()
	{
		return vtkBYUReader_GetReadScalar_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUReader_GetReadTexture_12(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the texture coordinate file.
	/// Specify name of geometry FileName.
	/// </summary>
	public virtual int GetReadTexture()
	{
		return vtkBYUReader_GetReadTexture_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUReader_GetScalarFileName_13(HandleRef pThis);

	/// <summary>
	/// Specify name of scalar FileName.
	/// </summary>
	public virtual string GetScalarFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUReader_GetScalarFileName_13(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUReader_GetTextureFileName_14(HandleRef pThis);

	/// <summary>
	/// Specify name of texture coordinates FileName.
	/// </summary>
	public virtual string GetTextureFileName()
	{
		return Marshal.PtrToStringAnsi(vtkBYUReader_GetTextureFileName_14(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUReader_IsA_15(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBYUReader_IsA_15(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBYUReader_IsTypeOf_16(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBYUReader_IsTypeOf_16(type);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUReader_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBYUReader NewInstance()
	{
		vtkBYUReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBYUReader_NewInstance_18(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_ReadDisplacementOff_19(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the displacement file.
	/// </summary>
	public virtual void ReadDisplacementOff()
	{
		vtkBYUReader_ReadDisplacementOff_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_ReadDisplacementOn_20(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the displacement file.
	/// </summary>
	public virtual void ReadDisplacementOn()
	{
		vtkBYUReader_ReadDisplacementOn_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_ReadScalarOff_21(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the scalar file.
	/// </summary>
	public virtual void ReadScalarOff()
	{
		vtkBYUReader_ReadScalarOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_ReadScalarOn_22(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the scalar file.
	/// </summary>
	public virtual void ReadScalarOn()
	{
		vtkBYUReader_ReadScalarOn_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_ReadTextureOff_23(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the texture coordinate file.
	/// Specify name of geometry FileName.
	/// </summary>
	public virtual void ReadTextureOff()
	{
		vtkBYUReader_ReadTextureOff_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_ReadTextureOn_24(HandleRef pThis);

	/// <summary>
	/// Turn on/off the reading of the texture coordinate file.
	/// Specify name of geometry FileName.
	/// </summary>
	public virtual void ReadTextureOn()
	{
		vtkBYUReader_ReadTextureOn_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBYUReader_SafeDownCast_25(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBYUReader SafeDownCast(vtkObjectBase o)
	{
		vtkBYUReader vtkBYUReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBYUReader_SafeDownCast_25(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBYUReader2 = (vtkBYUReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBYUReader2.Register(null);
			}
		}
		return vtkBYUReader2;
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetDisplacementFileName_26(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify name of displacement FileName.
	/// </summary>
	public virtual void SetDisplacementFileName(string _arg)
	{
		vtkBYUReader_SetDisplacementFileName_26(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetFileName_27(HandleRef pThis, string f);

	/// <summary>
	/// Specify name of geometry FileName (alias).
	/// </summary>
	public virtual void SetFileName(string f)
	{
		vtkBYUReader_SetFileName_27(GetCppThis(), f);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetGeometryFileName_28(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify name of geometry FileName.
	/// </summary>
	public virtual void SetGeometryFileName(string _arg)
	{
		vtkBYUReader_SetGeometryFileName_28(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetPartNumber_29(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the part number to be read.
	/// </summary>
	public virtual void SetPartNumber(int _arg)
	{
		vtkBYUReader_SetPartNumber_29(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetReadDisplacement_30(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the reading of the displacement file.
	/// </summary>
	public virtual void SetReadDisplacement(int _arg)
	{
		vtkBYUReader_SetReadDisplacement_30(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetReadScalar_31(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the reading of the scalar file.
	/// </summary>
	public virtual void SetReadScalar(int _arg)
	{
		vtkBYUReader_SetReadScalar_31(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetReadTexture_32(HandleRef pThis, int _arg);

	/// <summary>
	/// Turn on/off the reading of the texture coordinate file.
	/// Specify name of geometry FileName.
	/// </summary>
	public virtual void SetReadTexture(int _arg)
	{
		vtkBYUReader_SetReadTexture_32(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetScalarFileName_33(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify name of scalar FileName.
	/// </summary>
	public virtual void SetScalarFileName(string _arg)
	{
		vtkBYUReader_SetScalarFileName_33(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBYUReader_SetTextureFileName_34(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify name of texture coordinates FileName.
	/// </summary>
	public virtual void SetTextureFileName(string _arg)
	{
		vtkBYUReader_SetTextureFileName_34(GetCppThis(), _arg);
	}
}
