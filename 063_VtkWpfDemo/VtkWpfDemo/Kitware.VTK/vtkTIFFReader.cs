using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTIFFReader
/// </summary>
/// <remarks>
///    read TIFF files
///
/// vtkTIFFReader is a source object that reads TIFF files.
/// It should be able to read almost any TIFF file
///
/// </remarks>
/// <seealso>
///
/// vtkTIFFWriter
/// </seealso>
public class vtkTIFFReader : vtkImageReader2
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTIFFReader";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTIFFReader()
	{
		MRClassNameKey = "class vtkTIFFReader";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTIFFReader"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTIFFReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTIFFReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTIFFReader New()
	{
		vtkTIFFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTIFFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTIFFReader()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTIFFReader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTIFFReader_CanReadFile_01(HandleRef pThis, string fname);

	/// <summary>
	/// Is the given file name a tiff file?
	/// </summary>
	public override int CanReadFile(string fname)
	{
		return vtkTIFFReader_CanReadFile_01(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTIFFReader_GetDescriptiveName_02(HandleRef pThis);

	/// <summary>
	/// Return a descriptive name for the file format that might be useful
	/// in a GUI.
	/// </summary>
	public override string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkTIFFReader_GetDescriptiveName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTIFFReader_GetFileExtensions_03(HandleRef pThis);

	/// <summary>
	/// Get the file extensions for this format.
	/// Returns a string with a space separated list of extensions in
	/// the format .extension
	/// </summary>
	public override string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkTIFFReader_GetFileExtensions_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTIFFReader_GetIgnoreColorMap_04(HandleRef pThis);

	/// <summary>
	/// When set to true (default false), TIFFTAG_COLORMAP, if any, will be
	/// ignored.
	/// </summary>
	public virtual bool GetIgnoreColorMap()
	{
		return (vtkTIFFReader_GetIgnoreColorMap_04(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTIFFReader_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTIFFReader_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTIFFReader_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTIFFReader_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkTIFFReader_GetOrientationType_07(HandleRef pThis);

	/// <summary>
	/// Set orientation type
	/// ORIENTATION_TOPLEFT         1       (row 0 top, col 0 lhs)
	/// ORIENTATION_TOPRIGHT        2       (row 0 top, col 0 rhs)
	/// ORIENTATION_BOTRIGHT        3       (row 0 bottom, col 0 rhs)
	/// ORIENTATION_BOTLEFT         4       (row 0 bottom, col 0 lhs)
	/// ORIENTATION_LEFTTOP         5       (row 0 lhs, col 0 top)
	/// ORIENTATION_RIGHTTOP        6       (row 0 rhs, col 0 top)
	/// ORIENTATION_RIGHTBOT        7       (row 0 rhs, col 0 bottom)
	/// ORIENTATION_LEFTBOT         8       (row 0 lhs, col 0 bottom)
	/// User need to explicitly include vtk_tiff.h header to have access to those these macros
	/// </summary>
	public virtual uint GetOrientationType()
	{
		return vtkTIFFReader_GetOrientationType_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTIFFReader_GetOrientationTypeSpecifiedFlag_08(HandleRef pThis);

	/// <summary>
	/// Get method to check if orientation type is specified.
	/// </summary>
	public virtual bool GetOrientationTypeSpecifiedFlag()
	{
		return (vtkTIFFReader_GetOrientationTypeSpecifiedFlag_08(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTIFFReader_GetOriginSpecifiedFlag_09(HandleRef pThis);

	/// <summary>
	/// Set/get methods to see if manual origin has been set.
	/// </summary>
	public virtual bool GetOriginSpecifiedFlag()
	{
		return (vtkTIFFReader_GetOriginSpecifiedFlag_09(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern byte vtkTIFFReader_GetSpacingSpecifiedFlag_10(HandleRef pThis);

	/// <summary>
	/// Set/get if the spacing flag has been specified.
	/// </summary>
	public virtual bool GetSpacingSpecifiedFlag()
	{
		return (vtkTIFFReader_GetSpacingSpecifiedFlag_10(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_IgnoreColorMapOff_11(HandleRef pThis);

	/// <summary>
	/// When set to true (default false), TIFFTAG_COLORMAP, if any, will be
	/// ignored.
	/// </summary>
	public virtual void IgnoreColorMapOff()
	{
		vtkTIFFReader_IgnoreColorMapOff_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_IgnoreColorMapOn_12(HandleRef pThis);

	/// <summary>
	/// When set to true (default false), TIFFTAG_COLORMAP, if any, will be
	/// ignored.
	/// </summary>
	public virtual void IgnoreColorMapOn()
	{
		vtkTIFFReader_IgnoreColorMapOn_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTIFFReader_IsA_13(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTIFFReader_IsA_13(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTIFFReader_IsTypeOf_14(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTIFFReader_IsTypeOf_14(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTIFFReader_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTIFFReader NewInstance()
	{
		vtkTIFFReader result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTIFFReader_NewInstance_16(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_OriginSpecifiedFlagOff_17(HandleRef pThis);

	/// <summary>
	/// Set/get methods to see if manual origin has been set.
	/// </summary>
	public virtual void OriginSpecifiedFlagOff()
	{
		vtkTIFFReader_OriginSpecifiedFlagOff_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_OriginSpecifiedFlagOn_18(HandleRef pThis);

	/// <summary>
	/// Set/get methods to see if manual origin has been set.
	/// </summary>
	public virtual void OriginSpecifiedFlagOn()
	{
		vtkTIFFReader_OriginSpecifiedFlagOn_18(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTIFFReader_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTIFFReader SafeDownCast(vtkObjectBase o)
	{
		vtkTIFFReader vtkTIFFReader2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTIFFReader_SafeDownCast_19(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTIFFReader2 = (vtkTIFFReader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTIFFReader2.Register(null);
			}
		}
		return vtkTIFFReader2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_SetIgnoreColorMap_20(HandleRef pThis, byte _arg);

	/// <summary>
	/// When set to true (default false), TIFFTAG_COLORMAP, if any, will be
	/// ignored.
	/// </summary>
	public virtual void SetIgnoreColorMap(bool _arg)
	{
		vtkTIFFReader_SetIgnoreColorMap_20(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_SetOrientationType_21(HandleRef pThis, uint orientationType);

	/// <summary>
	/// Set orientation type
	/// ORIENTATION_TOPLEFT         1       (row 0 top, col 0 lhs)
	/// ORIENTATION_TOPRIGHT        2       (row 0 top, col 0 rhs)
	/// ORIENTATION_BOTRIGHT        3       (row 0 bottom, col 0 rhs)
	/// ORIENTATION_BOTLEFT         4       (row 0 bottom, col 0 lhs)
	/// ORIENTATION_LEFTTOP         5       (row 0 lhs, col 0 top)
	/// ORIENTATION_RIGHTTOP        6       (row 0 rhs, col 0 top)
	/// ORIENTATION_RIGHTBOT        7       (row 0 rhs, col 0 bottom)
	/// ORIENTATION_LEFTBOT         8       (row 0 lhs, col 0 bottom)
	/// User need to explicitly include vtk_tiff.h header to have access to those these macros
	/// </summary>
	public void SetOrientationType(uint orientationType)
	{
		vtkTIFFReader_SetOrientationType_21(GetCppThis(), orientationType);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_SetOriginSpecifiedFlag_22(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get methods to see if manual origin has been set.
	/// </summary>
	public virtual void SetOriginSpecifiedFlag(bool _arg)
	{
		vtkTIFFReader_SetOriginSpecifiedFlag_22(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_SetSpacingSpecifiedFlag_23(HandleRef pThis, byte _arg);

	/// <summary>
	/// Set/get if the spacing flag has been specified.
	/// </summary>
	public virtual void SetSpacingSpecifiedFlag(bool _arg)
	{
		vtkTIFFReader_SetSpacingSpecifiedFlag_23(GetCppThis(), (byte)(_arg ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_SpacingSpecifiedFlagOff_24(HandleRef pThis);

	/// <summary>
	/// Set/get if the spacing flag has been specified.
	/// </summary>
	public virtual void SpacingSpecifiedFlagOff()
	{
		vtkTIFFReader_SpacingSpecifiedFlagOff_24(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFReader_SpacingSpecifiedFlagOn_25(HandleRef pThis);

	/// <summary>
	/// Set/get if the spacing flag has been specified.
	/// </summary>
	public virtual void SpacingSpecifiedFlagOn()
	{
		vtkTIFFReader_SpacingSpecifiedFlagOn_25(GetCppThis());
	}
}
