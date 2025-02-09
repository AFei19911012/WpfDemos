using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///     vtkThreadedImageWriter
/// </summary>
/// <remarks>
///     class used to compress/write images using threads to prevent
///           locking while encoding data.
///
/// @details  This writer allow to encode an image data based on its file
///           extension: tif, tiff, bpm, png, jpg, jpeg, vti, Z, ppm, raw
///
/// @author   Patricia Kroll Fasel @ LANL
/// </remarks>
public class vtkThreadedImageWriter : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkThreadedImageWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkThreadedImageWriter()
	{
		MRClassNameKey = "class vtkThreadedImageWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkThreadedImageWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkThreadedImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreadedImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThreadedImageWriter New()
	{
		vtkThreadedImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThreadedImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThreadedImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkThreadedImageWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkThreadedImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageWriter_EncodeAndWrite_01(HandleRef pThis, HandleRef image, string fileName);

	/// <summary>
	/// Push an image into the threaded writer. It is not safe to modify the image
	/// after this point.
	/// You may run into thread safety issues. Typically, the caller code will
	/// simply release reference to the data and stop using it.
	/// </summary>
	public void EncodeAndWrite(vtkImageData image, string fileName)
	{
		vtkThreadedImageWriter_EncodeAndWrite_01(GetCppThis(), image?.GetCppThis() ?? default(HandleRef), fileName);
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageWriter_Finalize_02(HandleRef pThis);

	/// <summary>
	/// This method will wait for any running thread to terminate.
	/// </summary>
	public void FinalizeWrapper()
	{
		vtkThreadedImageWriter_Finalize_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkThreadedImageWriter_GetMaxThreads_03(HandleRef pThis);

	/// <summary>
	/// Define the number of worker thread to use.
	/// Initialize() need to be called after any thread count change.
	/// </summary>
	public virtual uint GetMaxThreads()
	{
		return vtkThreadedImageWriter_GetMaxThreads_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThreadedImageWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkThreadedImageWriter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkThreadedImageWriter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkThreadedImageWriter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageWriter_Initialize_06(HandleRef pThis);

	/// <summary>
	/// Need to be called at least once before using the class.
	/// Then it should be called again after any change on the
	/// thread count or if Finalize() was called.
	///
	/// This method will wait for any running thread to terminate and start
	/// a new pool with the given number of threads.
	/// </summary>
	public void Initialize()
	{
		vtkThreadedImageWriter_Initialize_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageWriter_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkThreadedImageWriter_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkThreadedImageWriter_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkThreadedImageWriter_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreadedImageWriter_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkThreadedImageWriter NewInstance()
	{
		vtkThreadedImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThreadedImageWriter_NewInstance_10(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkThreadedImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkThreadedImageWriter_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkThreadedImageWriter SafeDownCast(vtkObjectBase o)
	{
		vtkThreadedImageWriter vtkThreadedImageWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkThreadedImageWriter_SafeDownCast_11(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkThreadedImageWriter2 = (vtkThreadedImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkThreadedImageWriter2.Register(null);
			}
		}
		return vtkThreadedImageWriter2;
	}

	[DllImport("Kitware.VTK.IOAsynchronous.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkThreadedImageWriter_SetMaxThreads_12(HandleRef pThis, uint arg0);

	/// <summary>
	/// Define the number of worker thread to use.
	/// Initialize() need to be called after any thread count change.
	/// </summary>
	public void SetMaxThreads(uint arg0)
	{
		vtkThreadedImageWriter_SetMaxThreads_12(GetCppThis(), arg0);
	}
}
