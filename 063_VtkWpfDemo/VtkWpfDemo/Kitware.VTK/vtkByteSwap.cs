using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkByteSwap
/// </summary>
/// <remarks>
///    perform machine dependent byte swapping
///
/// vtkByteSwap is used by other classes to perform machine dependent byte
/// swapping. Byte swapping is often used when reading or writing binary
/// files.
/// </remarks>
public class vtkByteSwap : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkByteSwap";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkByteSwap()
	{
		MRClassNameKey = "class vtkByteSwap";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkByteSwap"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkByteSwap(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkByteSwap_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkByteSwap New()
	{
		vtkByteSwap result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkByteSwap_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkByteSwap()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkByteSwap_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkByteSwap_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkByteSwap_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkByteSwap_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkByteSwap_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkByteSwap_IsA_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkByteSwap_IsA_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkByteSwap_IsTypeOf_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkByteSwap_IsTypeOf_04(type);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkByteSwap_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkByteSwap NewInstance()
	{
		vtkByteSwap result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkByteSwap_NewInstance_06(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkByteSwap_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkByteSwap SafeDownCast(vtkObjectBase o)
	{
		vtkByteSwap vtkByteSwap2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkByteSwap_SafeDownCast_07(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkByteSwap2 = (vtkByteSwap)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkByteSwap2.Register(null);
			}
		}
		return vtkByteSwap2;
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap2BE_08(IntPtr p);

	/// <summary>
	/// Swap 2, 4, or 8 bytes for storage as Big Endian.
	/// </summary>
	public static void Swap2BE(IntPtr p)
	{
		vtkByteSwap_Swap2BE_08(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap2BERange_09(IntPtr p, ulong num);

	/// <summary>
	/// Swap a block of 2-, 4-, or 8-byte segments for storage as Big Endian.
	/// </summary>
	public static void Swap2BERange(IntPtr p, ulong num)
	{
		vtkByteSwap_Swap2BERange_09(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap2LE_10(IntPtr p);

	/// <summary>
	/// Swap 2, 4, or 8 bytes for storage as Little Endian.
	/// </summary>
	public static void Swap2LE(IntPtr p)
	{
		vtkByteSwap_Swap2LE_10(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap2LERange_11(IntPtr p, ulong num);

	/// <summary>
	/// Swap a block of 2-, 4-, or 8-byte segments for storage as Little Endian.
	/// </summary>
	public static void Swap2LERange(IntPtr p, ulong num)
	{
		vtkByteSwap_Swap2LERange_11(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap4BE_12(IntPtr p);

	/// <summary>
	/// Swap 2, 4, or 8 bytes for storage as Big Endian.
	/// </summary>
	public static void Swap4BE(IntPtr p)
	{
		vtkByteSwap_Swap4BE_12(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap4BERange_13(IntPtr p, ulong num);

	/// <summary>
	/// Swap a block of 2-, 4-, or 8-byte segments for storage as Big Endian.
	/// </summary>
	public static void Swap4BERange(IntPtr p, ulong num)
	{
		vtkByteSwap_Swap4BERange_13(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap4LE_14(IntPtr p);

	/// <summary>
	/// Swap 2, 4, or 8 bytes for storage as Little Endian.
	/// </summary>
	public static void Swap4LE(IntPtr p)
	{
		vtkByteSwap_Swap4LE_14(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap4LERange_15(IntPtr p, ulong num);

	/// <summary>
	/// Swap a block of 2-, 4-, or 8-byte segments for storage as Little Endian.
	/// </summary>
	public static void Swap4LERange(IntPtr p, ulong num)
	{
		vtkByteSwap_Swap4LERange_15(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap8BE_16(IntPtr p);

	/// <summary>
	/// Swap 2, 4, or 8 bytes for storage as Big Endian.
	/// </summary>
	public static void Swap8BE(IntPtr p)
	{
		vtkByteSwap_Swap8BE_16(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap8BERange_17(IntPtr p, ulong num);

	/// <summary>
	/// Swap a block of 2-, 4-, or 8-byte segments for storage as Big Endian.
	/// </summary>
	public static void Swap8BERange(IntPtr p, ulong num)
	{
		vtkByteSwap_Swap8BERange_17(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap8LE_18(IntPtr p);

	/// <summary>
	/// Swap 2, 4, or 8 bytes for storage as Little Endian.
	/// </summary>
	public static void Swap8LE(IntPtr p)
	{
		vtkByteSwap_Swap8LE_18(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_Swap8LERange_19(IntPtr p, ulong num);

	/// <summary>
	/// Swap a block of 2-, 4-, or 8-byte segments for storage as Little Endian.
	/// </summary>
	public static void Swap8LERange(IntPtr p, ulong num)
	{
		vtkByteSwap_Swap8LERange_19(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapBE_20(IntPtr p);

	/// <summary>
	/// Type-safe swap signatures to swap for storage in either Little
	/// Endian or Big Endian format.  Swapping is performed according to
	/// the true size of the type given.
	/// </summary>
	public static void SwapBE(IntPtr p)
	{
		vtkByteSwap_SwapBE_20(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapBE_21(string p);

	/// <summary>
	/// Type-safe swap signatures to swap for storage in either Little
	/// Endian or Big Endian format.  Swapping is performed according to
	/// the true size of the type given.
	/// </summary>
	public static void SwapBE(string p)
	{
		vtkByteSwap_SwapBE_21(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapBERange_22(IntPtr p, ulong num);

	/// <summary>
	/// Type-safe swap signatures to swap for storage in either Little
	/// Endian or Big Endian format.  Swapping is performed according to
	/// the true size of the type given.
	/// </summary>
	public static void SwapBERange(IntPtr p, ulong num)
	{
		vtkByteSwap_SwapBERange_22(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapBERange_23(string p, ulong num);

	/// <summary>
	/// Type-safe swap signatures to swap for storage in either Little
	/// Endian or Big Endian format.  Swapping is performed according to
	/// the true size of the type given.
	/// </summary>
	public static void SwapBERange(string p, ulong num)
	{
		vtkByteSwap_SwapBERange_23(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapLE_24(IntPtr p);

	/// <summary>
	/// Type-safe swap signatures to swap for storage in either Little
	/// Endian or Big Endian format.  Swapping is performed according to
	/// the true size of the type given.
	/// </summary>
	public static void SwapLE(IntPtr p)
	{
		vtkByteSwap_SwapLE_24(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapLE_25(string p);

	/// <summary>
	/// Type-safe swap signatures to swap for storage in either Little
	/// Endian or Big Endian format.  Swapping is performed according to
	/// the true size of the type given.
	/// </summary>
	public static void SwapLE(string p)
	{
		vtkByteSwap_SwapLE_25(p);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapLERange_26(IntPtr p, ulong num);

	/// <summary>
	/// Type-safe swap signatures to swap for storage in either Little
	/// Endian or Big Endian format.  Swapping is performed according to
	/// the true size of the type given.
	/// </summary>
	public static void SwapLERange(IntPtr p, ulong num)
	{
		vtkByteSwap_SwapLERange_26(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapLERange_27(string p, ulong num);

	/// <summary>
	/// Type-safe swap signatures to swap for storage in either Little
	/// Endian or Big Endian format.  Swapping is performed according to
	/// the true size of the type given.
	/// </summary>
	public static void SwapLERange(string p, ulong num)
	{
		vtkByteSwap_SwapLERange_27(p, num);
	}

	[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkByteSwap_SwapVoidRange_28(IntPtr buffer, ulong numWords, ulong wordSize);

	/// <summary>
	/// Swaps the bytes of a buffer.  Uses an arbitrary word size, but
	/// assumes the word size is divisible by two.
	/// </summary>
	public static void SwapVoidRange(IntPtr buffer, ulong numWords, ulong wordSize)
	{
		vtkByteSwap_SwapVoidRange_28(buffer, numWords, wordSize);
	}
}
