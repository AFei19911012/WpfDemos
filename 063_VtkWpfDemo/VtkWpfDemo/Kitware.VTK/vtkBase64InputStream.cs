using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBase64InputStream
/// </summary>
/// <remarks>
///    Reads base64-encoded input from a stream.
///
/// vtkBase64InputStream implements base64 decoding with the
/// vtkInputStream interface.
/// </remarks>
public class vtkBase64InputStream : vtkInputStream
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBase64InputStream";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBase64InputStream()
	{
		MRClassNameKey = "class vtkBase64InputStream";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBase64InputStream"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBase64InputStream(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBase64InputStream_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBase64InputStream New()
	{
		vtkBase64InputStream result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBase64InputStream_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBase64InputStream()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBase64InputStream_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBase64InputStream_EndReading_01(HandleRef pThis);

	/// <summary>
	/// Called after all desired calls to Seek and Read have been made.
	/// After this call, the caller is free to change the position of the
	/// stream.  Additional reads should not be done until after another
	/// call to StartReading.
	/// </summary>
	public override void EndReading()
	{
		vtkBase64InputStream_EndReading_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBase64InputStream_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBase64InputStream_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBase64InputStream_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBase64InputStream_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBase64InputStream_IsA_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBase64InputStream_IsA_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBase64InputStream_IsTypeOf_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBase64InputStream_IsTypeOf_05(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBase64InputStream_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBase64InputStream NewInstance()
	{
		vtkBase64InputStream result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBase64InputStream_NewInstance_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkBase64InputStream_Read_08(HandleRef pThis, IntPtr data, ulong length);

	/// <summary>
	/// Read input data of the given length.  Returns amount actually
	/// read.
	/// </summary>
	public override ulong Read(IntPtr data, ulong length)
	{
		return vtkBase64InputStream_Read_08(GetCppThis(), data, length);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBase64InputStream_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBase64InputStream SafeDownCast(vtkObjectBase o)
	{
		vtkBase64InputStream vtkBase64InputStream2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBase64InputStream_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBase64InputStream2 = (vtkBase64InputStream)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBase64InputStream2.Register(null);
			}
		}
		return vtkBase64InputStream2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBase64InputStream_Seek_10(HandleRef pThis, long offset);

	/// <summary>
	/// Seek to the given offset in the input data.  Returns 1 for
	/// success, 0 for failure.
	/// </summary>
	public override int Seek(long offset)
	{
		return vtkBase64InputStream_Seek_10(GetCppThis(), offset);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBase64InputStream_StartReading_11(HandleRef pThis);

	/// <summary>
	/// Called after the stream position has been set by the caller, but
	/// before any Seek or Read calls.  The stream position should not be
	/// adjusted by the caller until after an EndReading call.
	/// </summary>
	public override void StartReading()
	{
		vtkBase64InputStream_StartReading_11(GetCppThis());
	}
}
