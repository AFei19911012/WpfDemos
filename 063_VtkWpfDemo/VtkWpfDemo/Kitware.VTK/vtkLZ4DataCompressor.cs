using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkLZ4DataCompressor
/// </summary>
/// <remarks>
///    Data compression using LZ4.
///
/// vtkLZ4DataCompressor provides a concrete vtkDataCompressor class
/// using LZ4 for compressing and uncompressing data.
/// </remarks>
public class vtkLZ4DataCompressor : vtkDataCompressor
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkLZ4DataCompressor";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkLZ4DataCompressor()
	{
		MRClassNameKey = "class vtkLZ4DataCompressor";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkLZ4DataCompressor"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkLZ4DataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLZ4DataCompressor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLZ4DataCompressor New()
	{
		vtkLZ4DataCompressor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLZ4DataCompressor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLZ4DataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkLZ4DataCompressor()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkLZ4DataCompressor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkLZ4DataCompressor_GetAccelerationLevel_01(HandleRef pThis);

	/// <summary>
	///  Get/Set the compression level.
	/// </summary>
	public virtual int GetAccelerationLevel()
	{
		return vtkLZ4DataCompressor_GetAccelerationLevel_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLZ4DataCompressor_GetAccelerationLevelMaxValue_02(HandleRef pThis);

	/// <summary>
	///  Get/Set the compression level.
	/// </summary>
	public virtual int GetAccelerationLevelMaxValue()
	{
		return vtkLZ4DataCompressor_GetAccelerationLevelMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLZ4DataCompressor_GetAccelerationLevelMinValue_03(HandleRef pThis);

	/// <summary>
	///  Get/Set the compression level.
	/// </summary>
	public virtual int GetAccelerationLevelMinValue()
	{
		return vtkLZ4DataCompressor_GetAccelerationLevelMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLZ4DataCompressor_GetCompressionLevel_04(HandleRef pThis);

	/// <summary>
	///  Get/Set the compression level.
	/// </summary>
	public override int GetCompressionLevel()
	{
		return vtkLZ4DataCompressor_GetCompressionLevel_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern ulong vtkLZ4DataCompressor_GetMaximumCompressionSpace_05(HandleRef pThis, ulong size);

	/// <summary>
	///  Get the maximum space that may be needed to store data of the
	///  given uncompressed size after compression.  This is the minimum
	///  size of the output buffer that can be passed to the four-argument
	///  Compress method.
	/// </summary>
	public override ulong GetMaximumCompressionSpace(ulong size)
	{
		return vtkLZ4DataCompressor_GetMaximumCompressionSpace_05(GetCppThis(), size);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLZ4DataCompressor_GetNumberOfGenerationsFromBase_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkLZ4DataCompressor_GetNumberOfGenerationsFromBase_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkLZ4DataCompressor_GetNumberOfGenerationsFromBaseType_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkLZ4DataCompressor_GetNumberOfGenerationsFromBaseType_07(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLZ4DataCompressor_IsA_08(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkLZ4DataCompressor_IsA_08(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkLZ4DataCompressor_IsTypeOf_09(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkLZ4DataCompressor_IsTypeOf_09(type);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLZ4DataCompressor_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkLZ4DataCompressor NewInstance()
	{
		vtkLZ4DataCompressor result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLZ4DataCompressor_NewInstance_11(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkLZ4DataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkLZ4DataCompressor_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkLZ4DataCompressor SafeDownCast(vtkObjectBase o)
	{
		vtkLZ4DataCompressor vtkLZ4DataCompressor2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkLZ4DataCompressor_SafeDownCast_12(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkLZ4DataCompressor2 = (vtkLZ4DataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkLZ4DataCompressor2.Register(null);
			}
		}
		return vtkLZ4DataCompressor2;
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLZ4DataCompressor_SetAccelerationLevel_13(HandleRef pThis, int _arg);

	/// <summary>
	///  Get/Set the compression level.
	/// </summary>
	public virtual void SetAccelerationLevel(int _arg)
	{
		vtkLZ4DataCompressor_SetAccelerationLevel_13(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkLZ4DataCompressor_SetCompressionLevel_14(HandleRef pThis, int compressionLevel);

	/// <summary>
	///  Get/Set the compression level.
	/// </summary>
	public override void SetCompressionLevel(int compressionLevel)
	{
		vtkLZ4DataCompressor_SetCompressionLevel_14(GetCppThis(), compressionLevel);
	}
}
