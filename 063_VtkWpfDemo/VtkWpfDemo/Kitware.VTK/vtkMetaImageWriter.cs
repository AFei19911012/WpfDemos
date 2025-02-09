using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkMetaImageWriter
/// </summary>
/// <remarks>
///    write a binary UNC meta image data
///
/// One of the formats for which a reader is already available in the toolkit is
/// the MetaImage file format. This is a fairly simple yet powerful format
/// consisting of a text header and a binary data section. The following
/// instructions describe how you can write a MetaImage header for the data that
/// you download from the BrainWeb page.
///
/// The minimal structure of the MetaImage header is the following:
///
///    NDims = 3
///    DimSize = 181 217 181
///    ElementType = MET_UCHAR
///    ElementSpacing = 1.0 1.0 1.0
///    ElementByteOrderMSB = False
///    ElementDataFile = brainweb1.raw
///
///    * NDims indicate that this is a 3D image. ITK can handle images of
///      arbitrary dimension.
///    * DimSize indicates the size of the volume in pixels along each
///      direction.
///    * ElementType indicate the primitive type used for pixels. In this case
///      is "unsigned char", implying that the data is digitized in 8 bits /
///      pixel.
///    * ElementSpacing indicates the physical separation between the center of
///      one pixel and the center of the next pixel along each direction in space.
///      The units used are millimeters.
///    * ElementByteOrderMSB indicates is the data is encoded in little or big
///      endian order. You might want to play with this value when moving data
///      between different computer platforms.
///    * ElementDataFile is the name of the file containing the raw binary data
///      of the image. This file must be in the same directory as the header.
///
/// MetaImage headers are expected to have extension: ".mha" or ".mhd"
///
/// Once you write this header text file, it should be possible to read the
/// image into your ITK based application using the itk::FileIOToImageFilter
/// class.
///
///
///
/// </remarks>
/// <seealso>
///
/// vtkImageWriter vtkMetaImageReader
/// </seealso>
public class vtkMetaImageWriter : vtkImageWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkMetaImageWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkMetaImageWriter()
	{
		MRClassNameKey = "class vtkMetaImageWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkMetaImageWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkMetaImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public new static vtkMetaImageWriter New()
	{
		vtkMetaImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMetaImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	/// Construct object with FlipNormals turned off and Normals set to true.
	/// </summary>
	public vtkMetaImageWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkMetaImageWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern byte vtkMetaImageWriter_GetCompression_01(HandleRef pThis);

	/// <summary>
	/// Specify the file name of the raw image data.
	/// </summary>
	public virtual bool GetCompression()
	{
		return (vtkMetaImageWriter_GetCompression_01(GetCppThis()) != 0) ? true : false;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageWriter_GetFileName_02(HandleRef pThis);

	/// <summary>
	/// Specify file name of meta file
	/// </summary>
	public override string GetFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageWriter_GetFileName_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMetaImageWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkMetaImageWriter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkMetaImageWriter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkMetaImageWriter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageWriter_GetRAWFileName_05(HandleRef pThis);

	/// <summary>
	/// Specify the file name of the raw image data.
	/// </summary>
	public virtual string GetRAWFileName()
	{
		return Marshal.PtrToStringAnsi(vtkMetaImageWriter_GetRAWFileName_05(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageWriter_IsA_06(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkMetaImageWriter_IsA_06(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkMetaImageWriter_IsTypeOf_07(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkMetaImageWriter_IsTypeOf_07(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkMetaImageWriter NewInstance()
	{
		vtkMetaImageWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMetaImageWriter_NewInstance_09(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkMetaImageWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkMetaImageWriter SafeDownCast(vtkObjectBase o)
	{
		vtkMetaImageWriter vtkMetaImageWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkMetaImageWriter_SafeDownCast_10(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkMetaImageWriter2 = (vtkMetaImageWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkMetaImageWriter2.Register(null);
			}
		}
		return vtkMetaImageWriter2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMetaImageWriter_SetCompression_11(HandleRef pThis, byte compress);

	/// <summary>
	/// Specify the file name of the raw image data.
	/// </summary>
	public virtual void SetCompression(bool compress)
	{
		vtkMetaImageWriter_SetCompression_11(GetCppThis(), (byte)(compress ? 1u : 0u));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMetaImageWriter_SetFileName_12(HandleRef pThis, string fname);

	/// <summary>
	/// Specify file name of meta file
	/// </summary>
	public override void SetFileName(string fname)
	{
		vtkMetaImageWriter_SetFileName_12(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMetaImageWriter_SetRAWFileName_13(HandleRef pThis, string fname);

	/// <summary>
	/// Specify the file name of the raw image data.
	/// </summary>
	public virtual void SetRAWFileName(string fname)
	{
		vtkMetaImageWriter_SetRAWFileName_13(GetCppThis(), fname);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkMetaImageWriter_Write_14(HandleRef pThis);

	/// <summary>
	/// Specify the file name of the raw image data.
	/// </summary>
	public override void Write()
	{
		vtkMetaImageWriter_Write_14(GetCppThis());
	}
}
