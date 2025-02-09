using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkImageWriter
/// </summary>
/// <remarks>
///    Writes images to files.
///
/// vtkImageWriter writes images to files with any data type. The data type of
/// the file is the same scalar type as the input.  The dimensionality
/// determines whether the data will be written in one or multiple files.
/// This class is used as the superclass of most image writing classes
/// such as vtkBMPWriter etc. It supports streaming.
/// </remarks>
public class vtkImageWriter : vtkImageAlgorithm
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkImageWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkImageWriter()
	{
		MRClassNameKey = "class vtkImageWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageWriter New()
	{
		vtkImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkImageWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern void vtkImageWriter_DeleteFiles_01(HandleRef pThis);

	/// <summary>
	/// The main interface which triggers the writer to start.
	/// </summary>
	public void DeleteFiles()
	{
		vtkImageWriter_DeleteFiles_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageWriter_GetFileDimensionality_02(HandleRef pThis);

	/// <summary>
	/// What dimension are the files to be written. Usually this is 2, or 3.
	/// If it is 2 and the input is a volume then the volume will be
	/// written as a series of 2d slices.
	/// </summary>
	public virtual int GetFileDimensionality()
	{
		return vtkImageWriter_GetFileDimensionality_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWriter_GetFileName_03(HandleRef pThis);

	/// <summary>
	/// Specify file name for the image file. You should specify either
	/// a FileName or a FilePrefix. Use FilePrefix if the data is stored
	/// in multiple files.
	/// </summary>
	public virtual string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkImageWriter_GetFileName_03(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWriter_GetFilePattern_04(HandleRef pThis);

	/// <summary>
	/// The snprintf format used to build filename from FilePrefix and number.
	/// </summary>
	public virtual string GetFilePattern()
	{
		return Marshal.PtrToStringAnsi(vtkImageWriter_GetFilePattern_04(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWriter_GetFilePrefix_05(HandleRef pThis);

	/// <summary>
	/// Specify file prefix for the image file(s).You should specify either
	/// a FileName or FilePrefix. Use FilePrefix if the data is stored
	/// in multiple files.
	/// </summary>
	public virtual string GetFilePrefix()
	{
		return Marshal.PtrToStringAnsi(vtkImageWriter_GetFilePrefix_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWriter_GetInput_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Set/Get the input object from the image pipeline.
	/// </summary>
	public new vtkImageData GetInput()
	{
		vtkImageData vtkImageData2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageWriter_GetInput_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkImageWriter_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkImageWriter_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkImageWriter_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkImageWriter_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageWriter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkImageWriter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkImageWriter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkImageWriter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkImageWriter NewInstance()
	{
		vtkImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageWriter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkImageWriter_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkImageWriter SafeDownCast(vtkObjectBase o)
	{
		vtkImageWriter vtkImageWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkImageWriter_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkImageWriter2 = (vtkImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkImageWriter2.Register(null);
			}
		}
		return vtkImageWriter2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWriter_SetFileDimensionality_14(HandleRef pThis, int _arg);

	/// <summary>
	/// What dimension are the files to be written. Usually this is 2, or 3.
	/// If it is 2 and the input is a volume then the volume will be
	/// written as a series of 2d slices.
	/// </summary>
	public virtual void SetFileDimensionality(int _arg)
	{
		vtkImageWriter_SetFileDimensionality_14(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWriter_SetFileName_15(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file name for the image file. You should specify either
	/// a FileName or a FilePrefix. Use FilePrefix if the data is stored
	/// in multiple files.
	/// </summary>
	public virtual void SetFileName(string _arg)
	{
		vtkImageWriter_SetFileName_15(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWriter_SetFilePattern_16(HandleRef pThis, string _arg);

	/// <summary>
	/// The snprintf format used to build filename from FilePrefix and number.
	/// </summary>
	public virtual void SetFilePattern(string _arg)
	{
		vtkImageWriter_SetFilePattern_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWriter_SetFilePrefix_17(HandleRef pThis, string _arg);

	/// <summary>
	/// Specify file prefix for the image file(s).You should specify either
	/// a FileName or FilePrefix. Use FilePrefix if the data is stored
	/// in multiple files.
	/// </summary>
	public virtual void SetFilePrefix(string _arg)
	{
		vtkImageWriter_SetFilePrefix_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkImageWriter_Write_18(HandleRef pThis);

	/// <summary>
	/// The main interface which triggers the writer to start.
	/// </summary>
	public virtual void Write()
	{
		vtkImageWriter_Write_18(GetCppThis());
	}
}
