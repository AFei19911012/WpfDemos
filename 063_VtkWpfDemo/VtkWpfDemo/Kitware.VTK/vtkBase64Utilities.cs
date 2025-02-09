using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkBase64Utilities
/// </summary>
/// <remarks>
///    base64 encode and decode utilities.
///
/// vtkBase64Utilities implements base64 encoding and decoding.
/// </remarks>
public class vtkBase64Utilities : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkBase64Utilities";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkBase64Utilities()
	{
		MRClassNameKey = "class vtkBase64Utilities";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkBase64Utilities"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkBase64Utilities(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBase64Utilities_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBase64Utilities New()
	{
		vtkBase64Utilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBase64Utilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkBase64Utilities()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkBase64Utilities_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern ulong vtkBase64Utilities_DecodeSafely_01(IntPtr input, ulong inputLen, IntPtr output, ulong outputLen);

	/// <summary>
	/// Decode 4 bytes at a time from the input buffer and store the decoded
	/// stream into the output buffer. The required output buffer size must be
	/// determined and allocated by the caller. The needed output space is
	/// always less than the input buffer size, so a good first order
	/// approximation is to allocate the same size. Base64 encoding is about
	/// 4/3 overhead, so a tighter bound is possible.
	/// Return the number of bytes atually placed into the output buffer.
	/// </summary>
	public static ulong DecodeSafely(IntPtr input, ulong inputLen, IntPtr output, ulong outputLen)
	{
		return vtkBase64Utilities_DecodeSafely_01(input, inputLen, output, outputLen);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBase64Utilities_DecodeTriplet_02(byte i0, byte i1, byte i2, byte i3, IntPtr o0, IntPtr o1, IntPtr o2);

	/// <summary>
	/// Decode 4 bytes into 3 bytes.
	/// Return the number of bytes actually decoded (0 to 3, inclusive).
	/// </summary>
	public static int DecodeTriplet(byte i0, byte i1, byte i2, byte i3, IntPtr o0, IntPtr o1, IntPtr o2)
	{
		return vtkBase64Utilities_DecodeTriplet_02(i0, i1, i2, i3, o0, o1, o2);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkBase64Utilities_Encode_03(IntPtr input, uint length, IntPtr output, int mark_end);

	/// <summary>
	/// Encode 'length' bytes from the input buffer and store the
	/// encoded stream into the output buffer. Return the length of
	/// the encoded stream. Note that the output buffer must be allocated
	/// by the caller (length * 1.5 should be a safe estimate).
	/// If 'mark_end' is true then an extra set of 4 bytes is added
	/// to the end of the stream if the input is a multiple of 3 bytes.
	/// These bytes are invalid chars and therefore they will stop the decoder
	/// thus enabling the caller to decode a stream without actually knowing
	/// how much data to expect (if the input is not a multiple of 3 bytes then
	/// the extra padding needed to complete the encode 4 bytes will stop the
	/// decoding anyway).
	/// </summary>
	public static uint Encode(IntPtr input, uint length, IntPtr output, int mark_end)
	{
		return vtkBase64Utilities_Encode_03(input, length, output, mark_end);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBase64Utilities_EncodePair_04(byte i0, byte i1, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

	/// <summary>
	/// Encode 2 bytes into 4 bytes
	/// </summary>
	public static void EncodePair(byte i0, byte i1, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
	{
		vtkBase64Utilities_EncodePair_04(i0, i1, o0, o1, o2, o3);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBase64Utilities_EncodeSingle_05(byte i0, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

	/// <summary>
	/// Encode 1 byte into 4 bytes
	/// </summary>
	public static void EncodeSingle(byte i0, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
	{
		vtkBase64Utilities_EncodeSingle_05(i0, o0, o1, o2, o3);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkBase64Utilities_EncodeTriplet_06(byte i0, byte i1, byte i2, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3);

	/// <summary>
	/// Encode 3 bytes into 4 bytes
	/// </summary>
	public static void EncodeTriplet(byte i0, byte i1, byte i2, IntPtr o0, IntPtr o1, IntPtr o2, IntPtr o3)
	{
		vtkBase64Utilities_EncodeTriplet_06(i0, i1, i2, o0, o1, o2, o3);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBase64Utilities_GetNumberOfGenerationsFromBase_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkBase64Utilities_GetNumberOfGenerationsFromBase_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkBase64Utilities_GetNumberOfGenerationsFromBaseType_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkBase64Utilities_GetNumberOfGenerationsFromBaseType_08(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBase64Utilities_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkBase64Utilities_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkBase64Utilities_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkBase64Utilities_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBase64Utilities_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkBase64Utilities NewInstance()
	{
		vtkBase64Utilities result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBase64Utilities_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkBase64Utilities_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkBase64Utilities SafeDownCast(vtkObjectBase o)
	{
		vtkBase64Utilities vtkBase64Utilities2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkBase64Utilities_SafeDownCast_13(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkBase64Utilities2 = (vtkBase64Utilities)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkBase64Utilities2.Register(null);
			}
		}
		return vtkBase64Utilities2;
	}
}
