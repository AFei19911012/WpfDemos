using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLZMADataCompressor
/// </summary>
/// <remarks>
///    Data compression using LZMA Utils.
///
/// vtkLZMADataCompressor provides a concrete vtkDataCompressor class
/// using LZMA for compressing and uncompressing data.
///
/// @par Thanks:
/// This vtkDataCompressor contributed by Quincy Wofford (qwofford@lanl.gov)
/// and John Patchett (patchett@lanl.gov), Los Alamos National Laboratory
/// (2017)
///
/// </remarks>
public class vtkLZMADataCompressor : vtkDataCompressor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLZMADataCompressor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLZMADataCompressor()
	{
		MRClassNameKey = "class vtkLZMADataCompressor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLZMADataCompressor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLZMADataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLZMADataCompressor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLZMADataCompressor New()
	{
		vtkLZMADataCompressor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLZMADataCompressor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLZMADataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLZMADataCompressor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLZMADataCompressor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLZMADataCompressor_GetCompressionLevel_01(HandleRef pThis);

	/// <summary>
	///  Get/Set the compression level.
	/// </summary>
	public override int GetCompressionLevel()
	{
		return vtkLZMADataCompressor_GetCompressionLevel_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkLZMADataCompressor_GetMaximumCompressionSpace_02(HandleRef pThis, ulong size);

	/// <summary>
	///  Get the maximum space that may be needed to store data of the
	///  given uncompressed size after compression.  This is the minimum
	///  size of the output buffer that can be passed to the four-argument
	///  Compress method.
	/// </summary>
	public override ulong GetMaximumCompressionSpace(ulong size)
	{
		return vtkLZMADataCompressor_GetMaximumCompressionSpace_02(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLZMADataCompressor_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLZMADataCompressor_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLZMADataCompressor_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLZMADataCompressor_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLZMADataCompressor_IsA_05(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLZMADataCompressor_IsA_05(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLZMADataCompressor_IsTypeOf_06(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLZMADataCompressor_IsTypeOf_06(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLZMADataCompressor_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLZMADataCompressor NewInstance()
	{
		vtkLZMADataCompressor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLZMADataCompressor_NewInstance_08(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLZMADataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLZMADataCompressor_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLZMADataCompressor SafeDownCast(vtkObjectBase o)
	{
		vtkLZMADataCompressor vtkLZMADataCompressor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLZMADataCompressor_SafeDownCast_09(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLZMADataCompressor2 = (vtkLZMADataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLZMADataCompressor2.Register(null);
			}
		}
		return vtkLZMADataCompressor2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLZMADataCompressor_SetCompressionLevel_10(HandleRef pThis, int compressionLevel);

	/// <summary>
	///  Get/Set the compression level.
	/// </summary>
	public override void SetCompressionLevel(int compressionLevel)
	{
		vtkLZMADataCompressor_SetCompressionLevel_10(GetCppThis(), compressionLevel);
	}
}
