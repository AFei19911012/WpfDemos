using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkTIFFWriter
/// </summary>
/// <remarks>
///    write out image data as a TIFF file
///
/// vtkTIFFWriter writes image data as a TIFF data file. Data can be written
/// uncompressed or compressed. Several forms of compression are supported
/// including packed bits, JPEG, deflation, and LZW. (Note: LZW compression
/// is currently under patent in the US and is disabled until the patent
/// expires. However, the mechanism for supporting this compression is available
/// for those with a valid license or to whom the patent does not apply.)
/// </remarks>
public class vtkTIFFWriter : vtkImageWriter
{
	/// <summary>
	/// The main interface which triggers the writer to start.
	/// </summary>
	public enum Deflate_WrapperEnum
	{
		/// <summary>enum member</summary>
		Deflate = 3,
		/// <summary>enum member</summary>
		JPEG = 2,
		/// <summary>enum member</summary>
		LZW = 4,
		/// <summary>enum member</summary>
		NoCompression = 0,
		/// <summary>enum member</summary>
		PackBits = 1
	}

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkTIFFWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkTIFFWriter()
	{
		MRClassNameKey = "class vtkTIFFWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkTIFFWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkTIFFWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTIFFWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTIFFWriter New()
	{
		vtkTIFFWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTIFFWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkTIFFWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkTIFFWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern int vtkTIFFWriter_GetCompression_01(HandleRef pThis);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public virtual int GetCompression()
	{
		return vtkTIFFWriter_GetCompression_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTIFFWriter_GetCompressionMaxValue_02(HandleRef pThis);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public virtual int GetCompressionMaxValue()
	{
		return vtkTIFFWriter_GetCompressionMaxValue_02(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTIFFWriter_GetCompressionMinValue_03(HandleRef pThis);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public virtual int GetCompressionMinValue()
	{
		return vtkTIFFWriter_GetCompressionMinValue_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTIFFWriter_GetNumberOfGenerationsFromBase_04(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkTIFFWriter_GetNumberOfGenerationsFromBase_04(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkTIFFWriter_GetNumberOfGenerationsFromBaseType_05(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkTIFFWriter_GetNumberOfGenerationsFromBaseType_05(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTIFFWriter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkTIFFWriter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkTIFFWriter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkTIFFWriter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTIFFWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkTIFFWriter NewInstance()
	{
		vtkTIFFWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTIFFWriter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkTIFFWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkTIFFWriter SafeDownCast(vtkObjectBase o)
	{
		vtkTIFFWriter vtkTIFFWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkTIFFWriter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkTIFFWriter2 = (vtkTIFFWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkTIFFWriter2.Register(null);
			}
		}
		return vtkTIFFWriter2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFWriter_SetCompression_11(HandleRef pThis, int _arg);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public virtual void SetCompression(int _arg)
	{
		vtkTIFFWriter_SetCompression_11(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFWriter_SetCompressionToDeflate_12(HandleRef pThis);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public void SetCompressionToDeflate()
	{
		vtkTIFFWriter_SetCompressionToDeflate_12(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFWriter_SetCompressionToJPEG_13(HandleRef pThis);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public void SetCompressionToJPEG()
	{
		vtkTIFFWriter_SetCompressionToJPEG_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFWriter_SetCompressionToLZW_14(HandleRef pThis);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public void SetCompressionToLZW()
	{
		vtkTIFFWriter_SetCompressionToLZW_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFWriter_SetCompressionToNoCompression_15(HandleRef pThis);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public void SetCompressionToNoCompression()
	{
		vtkTIFFWriter_SetCompressionToNoCompression_15(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFWriter_SetCompressionToPackBits_16(HandleRef pThis);

	/// <summary>
	/// Set compression type. Sinze LZW compression is patented outside US, the
	/// additional work steps have to be taken in order to use that compression.
	/// </summary>
	public void SetCompressionToPackBits()
	{
		vtkTIFFWriter_SetCompressionToPackBits_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkTIFFWriter_Write_17(HandleRef pThis);

	/// <summary>
	/// The main interface which triggers the writer to start.
	/// </summary>
	public override void Write()
	{
		vtkTIFFWriter_Write_17(GetCppThis());
	}
}
