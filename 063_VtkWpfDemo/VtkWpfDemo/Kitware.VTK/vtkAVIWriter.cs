using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkAVIWriter
/// </summary>
/// <remarks>
///    Writes Windows AVI files.
///
/// vtkAVIWriter writes AVI files. Note that this class in only available
/// on the Microsoft Windows platform. The data type of the file is
/// unsigned char regardless of the input type.
/// </remarks>
/// <seealso>
///
/// vtkGenericMovieWriter
/// </seealso>
public class vtkAVIWriter : vtkGenericMovieWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkAVIWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkAVIWriter()
	{
		MRClassNameKey = "class vtkAVIWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkAVIWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkAVIWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVIWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAVIWriter New()
	{
		vtkAVIWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAVIWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkAVIWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkAVIWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_End_01(HandleRef pThis);

	/// <summary>
	/// These methods start writing an AVI file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public override void End()
	{
		vtkAVIWriter_End_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVIWriter_GetCompressorFourCC_02(HandleRef pThis);

	/// <summary>
	/// Set/Get the compressor FourCC.
	/// A FourCC (literally, four-character code) is a sequence of four bytes
	/// used to uniquely identify data formats. [...] One of the most well-known
	/// uses of FourCCs is to identify the video codec used in AVI files.
	/// Common identifiers include DIVX, XVID, and H264.
	/// http://en.wikipedia.org/wiki/FourCC.
	/// Default value is:
	/// - MSVC
	/// Other examples include:
	/// - DIB: Full Frames (Uncompressed)
	/// - LAGS: Lagarith Lossless Codec
	/// - MJPG: M-JPG, aka Motion JPEG (say, Pegasus Imaging PicVideo M-JPEG)
	/// Links:
	/// - http://www.fourcc.org/
	/// - http://www.microsoft.com/whdc/archive/fourcc.mspx
	/// - http://abcavi.kibi.ru/fourcc.php
	/// </summary>
	public virtual string GetCompressorFourCC()
	{
		return Marshal.PtrToStringAnsi(vtkAVIWriter_GetCompressorFourCC_02(GetCppThis()));
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAVIWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkAVIWriter_GetNumberOfGenerationsFromBase_03(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkAVIWriter_GetNumberOfGenerationsFromBaseType_04(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkAVIWriter_GetNumberOfGenerationsFromBaseType_04(type);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_GetPromptCompressionOptions_05(HandleRef pThis);

	/// <summary>
	/// Set/Get if the user should be prompted for compression options, i.e.
	/// pick a compressor, set the compression rate (override Rate), etc.).
	/// Default is OFF (legacy).
	/// </summary>
	public virtual int GetPromptCompressionOptions()
	{
		return vtkAVIWriter_GetPromptCompressionOptions_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_GetQuality_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the compression quality.
	/// 0 means worst quality and smallest file size
	/// 2 means best quality and largest file size
	/// </summary>
	public virtual int GetQuality()
	{
		return vtkAVIWriter_GetQuality_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_GetQualityMaxValue_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the compression quality.
	/// 0 means worst quality and smallest file size
	/// 2 means best quality and largest file size
	/// </summary>
	public virtual int GetQualityMaxValue()
	{
		return vtkAVIWriter_GetQualityMaxValue_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_GetQualityMinValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the compression quality.
	/// 0 means worst quality and smallest file size
	/// 2 means best quality and largest file size
	/// </summary>
	public virtual int GetQualityMinValue()
	{
		return vtkAVIWriter_GetQualityMinValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_GetRate_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the frame rate, in frame/s.
	/// </summary>
	public virtual int GetRate()
	{
		return vtkAVIWriter_GetRate_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_GetRateMaxValue_10(HandleRef pThis);

	/// <summary>
	/// Set/Get the frame rate, in frame/s.
	/// </summary>
	public virtual int GetRateMaxValue()
	{
		return vtkAVIWriter_GetRateMaxValue_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_GetRateMinValue_11(HandleRef pThis);

	/// <summary>
	/// Set/Get the frame rate, in frame/s.
	/// </summary>
	public virtual int GetRateMinValue()
	{
		return vtkAVIWriter_GetRateMinValue_11(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_IsA_12(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkAVIWriter_IsA_12(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkAVIWriter_IsTypeOf_13(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkAVIWriter_IsTypeOf_13(type);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVIWriter_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkAVIWriter NewInstance()
	{
		vtkAVIWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAVIWriter_NewInstance_15(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_PromptCompressionOptionsOff_16(HandleRef pThis);

	/// <summary>
	/// Set/Get if the user should be prompted for compression options, i.e.
	/// pick a compressor, set the compression rate (override Rate), etc.).
	/// Default is OFF (legacy).
	/// </summary>
	public virtual void PromptCompressionOptionsOff()
	{
		vtkAVIWriter_PromptCompressionOptionsOff_16(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_PromptCompressionOptionsOn_17(HandleRef pThis);

	/// <summary>
	/// Set/Get if the user should be prompted for compression options, i.e.
	/// pick a compressor, set the compression rate (override Rate), etc.).
	/// Default is OFF (legacy).
	/// </summary>
	public virtual void PromptCompressionOptionsOn()
	{
		vtkAVIWriter_PromptCompressionOptionsOn_17(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkAVIWriter_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkAVIWriter SafeDownCast(vtkObjectBase o)
	{
		vtkAVIWriter vtkAVIWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkAVIWriter_SafeDownCast_18(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkAVIWriter2 = (vtkAVIWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkAVIWriter2.Register(null);
			}
		}
		return vtkAVIWriter2;
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_SetCompressorFourCC_19(HandleRef pThis, string _arg);

	/// <summary>
	/// Set/Get the compressor FourCC.
	/// A FourCC (literally, four-character code) is a sequence of four bytes
	/// used to uniquely identify data formats. [...] One of the most well-known
	/// uses of FourCCs is to identify the video codec used in AVI files.
	/// Common identifiers include DIVX, XVID, and H264.
	/// http://en.wikipedia.org/wiki/FourCC.
	/// Default value is:
	/// - MSVC
	/// Other examples include:
	/// - DIB: Full Frames (Uncompressed)
	/// - LAGS: Lagarith Lossless Codec
	/// - MJPG: M-JPG, aka Motion JPEG (say, Pegasus Imaging PicVideo M-JPEG)
	/// Links:
	/// - http://www.fourcc.org/
	/// - http://www.microsoft.com/whdc/archive/fourcc.mspx
	/// - http://abcavi.kibi.ru/fourcc.php
	/// </summary>
	public virtual void SetCompressorFourCC(string _arg)
	{
		vtkAVIWriter_SetCompressorFourCC_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_SetPromptCompressionOptions_20(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get if the user should be prompted for compression options, i.e.
	/// pick a compressor, set the compression rate (override Rate), etc.).
	/// Default is OFF (legacy).
	/// </summary>
	public virtual void SetPromptCompressionOptions(int _arg)
	{
		vtkAVIWriter_SetPromptCompressionOptions_20(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_SetQuality_21(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the compression quality.
	/// 0 means worst quality and smallest file size
	/// 2 means best quality and largest file size
	/// </summary>
	public virtual void SetQuality(int _arg)
	{
		vtkAVIWriter_SetQuality_21(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_SetRate_22(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the frame rate, in frame/s.
	/// </summary>
	public virtual void SetRate(int _arg)
	{
		vtkAVIWriter_SetRate_22(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_Start_23(HandleRef pThis);

	/// <summary>
	/// These methods start writing an AVI file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public override void Start()
	{
		vtkAVIWriter_Start_23(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOMovie.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkAVIWriter_Write_24(HandleRef pThis);

	/// <summary>
	/// These methods start writing an AVI file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public override void Write()
	{
		vtkAVIWriter_Write_24(GetCppThis());
	}
}
