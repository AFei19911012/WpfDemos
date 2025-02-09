using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkDataCompressor
/// </summary>
/// <remarks>
///    Abstract interface for data compression classes.
///
/// vtkDataCompressor provides a universal interface for data
/// compression.  Subclasses provide one compression method and one
/// decompression method.  The public interface to all compressors
/// remains the same, and is defined by this class.
///
/// @par Note:
/// vtkDataCompressor CompressionLevel maye take on values 1 to 9. With
/// values of 1 giving best compression write performance, and a value of 9
/// giving best compression ratio. Subclasses of vtkDataCompressor objects
/// should be implemented with this in mind to provide a predictable
/// compressor interface for vtkDataCompressor users.
///
/// @par Thanks:
/// Homogeneous CompressionLevel behavior contributed by Quincy Wofford
/// (qwofford@lanl.gov) and John Patchett (patchett@lanl.gov)
///
/// </remarks>
public abstract class vtkDataCompressor : vtkObject
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkDataCompressor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkDataCompressor()
	{
		MRClassNameKey = "class vtkDataCompressor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkDataCompressor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkDataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
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
	internal static extern ulong vtkDataCompressor_Compress_01(HandleRef pThis, IntPtr uncompressedData, ulong uncompressedSize, IntPtr compressedData, ulong compressionSpace);

	/// <summary>
	/// Compress the given input data buffer into the given output
	/// buffer.  The size of the output buffer must be at least as large
	/// as the value given by GetMaximumCompressionSpace for the given
	/// input size.
	/// </summary>
	public ulong Compress(IntPtr uncompressedData, ulong uncompressedSize, IntPtr compressedData, ulong compressionSpace)
	{
		return vtkDataCompressor_Compress_01(GetCppThis(), uncompressedData, uncompressedSize, compressedData, compressionSpace);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataCompressor_Compress_02(HandleRef pThis, IntPtr uncompressedData, ulong uncompressedSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Compress the given data.  A vtkUnsignedCharArray containing the
	/// compressed data is returned with a reference count of 1.
	/// </summary>
	public vtkUnsignedCharArray Compress(IntPtr uncompressedData, ulong uncompressedSize)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataCompressor_Compress_02(GetCppThis(), uncompressedData, uncompressedSize, ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataCompressor_GetCompressionLevel_03(HandleRef pThis);

	/// <summary>
	///  Require level setting from any vtkDataCompressor
	///  Different compressors handle performance parameters differently
	///  vtkDataCompressors should take a value between 1 and 9
	///  where 1 is fastest compression, and 9 is best compression.
	/// </summary>
	public virtual int GetCompressionLevel()
	{
		return vtkDataCompressor_GetCompressionLevel_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDataCompressor_GetMaximumCompressionSpace_04(HandleRef pThis, ulong size);

	/// <summary>
	/// Get the maximum space that may be needed to store data of the
	/// given uncompressed size after compression.  This is the minimum
	/// size of the output buffer that can be passed to the four-argument
	/// Compress method.
	/// </summary>
	public virtual ulong GetMaximumCompressionSpace(ulong size)
	{
		return vtkDataCompressor_GetMaximumCompressionSpace_04(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataCompressor_GetNumberOfGenerationsFromBase_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkDataCompressor_GetNumberOfGenerationsFromBase_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkDataCompressor_GetNumberOfGenerationsFromBaseType_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkDataCompressor_GetNumberOfGenerationsFromBaseType_06(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataCompressor_IsA_07(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkDataCompressor_IsA_07(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkDataCompressor_IsTypeOf_08(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkDataCompressor_IsTypeOf_08(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataCompressor_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkDataCompressor NewInstance()
	{
		vtkDataCompressor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataCompressor_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataCompressor_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkDataCompressor SafeDownCast(vtkObjectBase o)
	{
		vtkDataCompressor vtkDataCompressor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataCompressor_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkDataCompressor2 = (vtkDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkDataCompressor2.Register(null);
			}
		}
		return vtkDataCompressor2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkDataCompressor_SetCompressionLevel_11(HandleRef pThis, int compressionLevel);

	/// <summary>
	///  Require level setting from any vtkDataCompressor
	///  Different compressors handle performance parameters differently
	///  vtkDataCompressors should take a value between 1 and 9
	///  where 1 is fastest compression, and 9 is best compression.
	/// </summary>
	public virtual void SetCompressionLevel(int compressionLevel)
	{
		vtkDataCompressor_SetCompressionLevel_11(GetCppThis(), compressionLevel);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkDataCompressor_Uncompress_12(HandleRef pThis, IntPtr compressedData, ulong compressedSize, IntPtr uncompressedData, ulong uncompressedSize);

	/// <summary>
	/// Uncompress the given input data into the given output buffer.
	/// The size of the uncompressed data must be known by the caller.
	/// It should be transmitted from the compressor by a means outside
	/// of this class.
	/// </summary>
	public ulong Uncompress(IntPtr compressedData, ulong compressedSize, IntPtr uncompressedData, ulong uncompressedSize)
	{
		return vtkDataCompressor_Uncompress_12(GetCppThis(), compressedData, compressedSize, uncompressedData, uncompressedSize);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkDataCompressor_Uncompress_13(HandleRef pThis, IntPtr compressedData, ulong compressedSize, ulong uncompressedSize, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Uncompress the given data.  A vtkUnsignedCharArray containing the
	/// compressed data is returned with a reference count of 1.  The
	/// size of the uncompressed data must be known by the caller.  It
	/// should be transmitted from the compressor by a means outside of
	/// this class.
	/// </summary>
	public vtkUnsignedCharArray Uncompress(IntPtr compressedData, ulong compressedSize, ulong uncompressedSize)
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkDataCompressor_Uncompress_13(GetCppThis(), compressedData, compressedSize, uncompressedSize, ref mteStatus, ref mteIndex, ref rawRefCount);
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
}
