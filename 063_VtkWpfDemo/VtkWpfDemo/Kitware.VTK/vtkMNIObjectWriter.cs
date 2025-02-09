using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMNIObjectWriter
/// </summary>
/// <remarks>
///    A writer for MNI surface mesh files.
///
/// The MNI .obj file format is used to store geometrical data.  This
/// file format was developed at the McConnell Brain Imaging Centre at
/// the Montreal Neurological Institute and is used by their software.
/// Only polygon and line files are supported by this writer.  For these
/// formats, all data elements are written including normals, colors,
/// and surface properties.  ASCII and binary file types are supported.
/// </remarks>
/// <seealso>
///
/// vtkMINCImageReader vtkMNIObjectReader vtkMNITransformReader
/// @par Thanks:
/// Thanks to David Gobbi for writing this class and Atamai Inc. for
/// contributing it to VTK.
/// </seealso>
public class vtkMNIObjectWriter : vtkWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMNIObjectWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMNIObjectWriter()
	{
		MRClassNameKey = "class vtkMNIObjectWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMNIObjectWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMNIObjectWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMNIObjectWriter New()
	{
		vtkMNIObjectWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNIObjectWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMNIObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkMNIObjectWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMNIObjectWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_GetDescriptiveName_01(HandleRef pThis);

	/// <summary>
	/// Get the name of this file format.
	/// </summary>
	public virtual string GetDescriptiveName()
	{
		return Marshal.PtrToStringAnsi(vtkMNIObjectWriter_GetDescriptiveName_01(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_GetFileExtensions_02(HandleRef pThis);

	/// <summary>
	/// Get the extension for this file format.
	/// </summary>
	public virtual string GetFileExtensions()
	{
		return Marshal.PtrToStringAnsi(vtkMNIObjectWriter_GetFileExtensions_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Specify file name of vtk polygon data file to write.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMNIObjectWriter_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNIObjectWriter_GetFileType_04(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileType()
	{
		return vtkMNIObjectWriter_GetFileType_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNIObjectWriter_GetFileTypeMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileTypeMaxValue()
	{
		return vtkMNIObjectWriter_GetFileTypeMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNIObjectWriter_GetFileTypeMinValue_06(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual int GetFileTypeMinValue()
	{
		return vtkMNIObjectWriter_GetFileTypeMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_GetInput_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkPolyData GetInput()
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNIObjectWriter_GetInput_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_GetInput_08(HandleRef pThis, int port, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Get the input to this writer.
	/// </summary>
	public new vtkPolyData GetInput(int port)
	{
		vtkPolyData vtkPolyData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNIObjectWriter_GetInput_08(GetCppThis(), port, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_GetLookupTable_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the lookup table associated with the object.  This will be
	/// used to convert scalar values to colors, if a mapper is not set.
	/// </summary>
	public virtual vtkLookupTable GetLookupTable()
	{
		vtkLookupTable vtkLookupTable2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNIObjectWriter_GetLookupTable_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_GetMapper_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the mapper associated with the object.  Optional.
	/// This is useful for exporting an actor with the same colors
	/// that are used to display the actor within VTK.
	/// </summary>
	public virtual vtkMapper GetMapper()
	{
		vtkMapper vtkMapper2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNIObjectWriter_GetMapper_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMapper2 = (vtkMapper)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMapper2.Register(null);
			}
		}
		return vtkMapper2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMNIObjectWriter_GetNumberOfGenerationsFromBase_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMNIObjectWriter_GetNumberOfGenerationsFromBase_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMNIObjectWriter_GetNumberOfGenerationsFromBaseType_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMNIObjectWriter_GetNumberOfGenerationsFromBaseType_12(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_GetProperty_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set the property associated with the object.  Optional.
	/// This is useful for exporting an actor.
	/// </summary>
	public virtual vtkProperty GetProperty()
	{
		vtkProperty vtkProperty2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNIObjectWriter_GetProperty_13(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkProperty2 = (vtkProperty)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkProperty2.Register(null);
			}
		}
		return vtkProperty2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNIObjectWriter_IsA_14(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMNIObjectWriter_IsA_14(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMNIObjectWriter_IsTypeOf_15(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMNIObjectWriter_IsTypeOf_15(type);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMNIObjectWriter NewInstance()
	{
		vtkMNIObjectWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNIObjectWriter_NewInstance_17(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMNIObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMNIObjectWriter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMNIObjectWriter SafeDownCast(vtkObjectBase o)
	{
		vtkMNIObjectWriter vtkMNIObjectWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMNIObjectWriter_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMNIObjectWriter2 = (vtkMNIObjectWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMNIObjectWriter2.Register(null);
			}
		}
		return vtkMNIObjectWriter2;
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNIObjectWriter_SetFileName_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name of vtk polygon data file to write.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkMNIObjectWriter_SetFileName_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNIObjectWriter_SetFileType_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public virtual void SetFileType(int _arg)
	{
		vtkMNIObjectWriter_SetFileType_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNIObjectWriter_SetFileTypeToASCII_21(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public void SetFileTypeToASCII()
	{
		vtkMNIObjectWriter_SetFileTypeToASCII_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNIObjectWriter_SetFileTypeToBinary_22(HandleRef pThis);

	/// <summary>
	/// Specify file type (ASCII or BINARY) for vtk data file.
	/// </summary>
	public void SetFileTypeToBinary()
	{
		vtkMNIObjectWriter_SetFileTypeToBinary_22(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNIObjectWriter_SetLookupTable_23(HandleRef pThis, HandleRef table);

	/// <summary>
	/// Set the lookup table associated with the object.  This will be
	/// used to convert scalar values to colors, if a mapper is not set.
	/// </summary>
	public virtual void SetLookupTable(vtkLookupTable table)
	{
		vtkMNIObjectWriter_SetLookupTable_23(GetCppThis(), table?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNIObjectWriter_SetMapper_24(HandleRef pThis, HandleRef mapper);

	/// <summary>
	/// Set the mapper associated with the object.  Optional.
	/// This is useful for exporting an actor with the same colors
	/// that are used to display the actor within VTK.
	/// </summary>
	public virtual void SetMapper(vtkMapper mapper)
	{
		vtkMNIObjectWriter_SetMapper_24(GetCppThis(), mapper?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOMINC.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMNIObjectWriter_SetProperty_25(HandleRef pThis, HandleRef property);

	/// <summary>
	/// Set the property associated with the object.  Optional.
	/// This is useful for exporting an actor.
	/// </summary>
	public virtual void SetProperty(vtkProperty property)
	{
		vtkMNIObjectWriter_SetProperty_25(GetCppThis(), property?.GetCppThis() ?? default(HandleRef));
	}
}
