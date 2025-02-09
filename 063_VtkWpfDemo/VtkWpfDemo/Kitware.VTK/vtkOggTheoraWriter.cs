using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkOggTheoraWriter
/// </summary>
/// <remarks>
///    Uses the ogg and theora libraries to write video
/// files.
///
/// vtkOggTheoraWriter is an adapter that allows VTK to use the ogg and theora
/// libraries to write movie files.  This class creates .ogv files containing
/// theora encoded video without audio.
///
/// This implementation is based on vtkFFMPEGWriter and uses some code derived
/// from the encoder example distributed with libtheora.
///
/// </remarks>
public class vtkOggTheoraWriter : vtkGenericMovieWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkOggTheoraWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkOggTheoraWriter()
	{
		MRClassNameKey = "class vtkOggTheoraWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkOggTheoraWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkOggTheoraWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOggTheoraWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOggTheoraWriter New()
	{
		vtkOggTheoraWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOggTheoraWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOggTheoraWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkOggTheoraWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkOggTheoraWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOggTheoraWriter_End_01(HandleRef pThis);

	/// <summary>
	/// These methods start writing an Movie file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public override void End()
	{
		vtkOggTheoraWriter_End_01(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOggTheoraWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkOggTheoraWriter_GetNumberOfGenerationsFromBase_02(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkOggTheoraWriter_GetNumberOfGenerationsFromBaseType_03(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkOggTheoraWriter_GetNumberOfGenerationsFromBaseType_03(type);
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_GetQuality_04(HandleRef pThis);

	/// <summary>
	/// Set/Get the compression quality.
	/// 0 means worst quality and smallest file size
	/// 2 means best quality and largest file size
	/// </summary>
	public virtual int GetQuality()
	{
		return vtkOggTheoraWriter_GetQuality_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_GetQualityMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Set/Get the compression quality.
	/// 0 means worst quality and smallest file size
	/// 2 means best quality and largest file size
	/// </summary>
	public virtual int GetQualityMaxValue()
	{
		return vtkOggTheoraWriter_GetQualityMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_GetQualityMinValue_06(HandleRef pThis);

	/// <summary>
	/// Set/Get the compression quality.
	/// 0 means worst quality and smallest file size
	/// 2 means best quality and largest file size
	/// </summary>
	public virtual int GetQualityMinValue()
	{
		return vtkOggTheoraWriter_GetQualityMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_GetRate_07(HandleRef pThis);

	/// <summary>
	/// Set/Get the frame rate, in frame/s.
	/// </summary>
	public virtual int GetRate()
	{
		return vtkOggTheoraWriter_GetRate_07(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_GetRateMaxValue_08(HandleRef pThis);

	/// <summary>
	/// Set/Get the frame rate, in frame/s.
	/// </summary>
	public virtual int GetRateMaxValue()
	{
		return vtkOggTheoraWriter_GetRateMaxValue_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_GetRateMinValue_09(HandleRef pThis);

	/// <summary>
	/// Set/Get the frame rate, in frame/s.
	/// </summary>
	public virtual int GetRateMinValue()
	{
		return vtkOggTheoraWriter_GetRateMinValue_09(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_GetSubsampling_10(HandleRef pThis);

	/// <summary>
	/// Is the video to be encoded using 4:2:0 subsampling?
	/// </summary>
	public virtual int GetSubsampling()
	{
		return vtkOggTheoraWriter_GetSubsampling_10(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_IsA_11(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkOggTheoraWriter_IsA_11(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkOggTheoraWriter_IsTypeOf_12(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkOggTheoraWriter_IsTypeOf_12(type);
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOggTheoraWriter_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkOggTheoraWriter NewInstance()
	{
		vtkOggTheoraWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOggTheoraWriter_NewInstance_14(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkOggTheoraWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkOggTheoraWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkOggTheoraWriter SafeDownCast(vtkObjectBase o)
	{
		vtkOggTheoraWriter vtkOggTheoraWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkOggTheoraWriter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkOggTheoraWriter2 = (vtkOggTheoraWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkOggTheoraWriter2.Register(null);
			}
		}
		return vtkOggTheoraWriter2;
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOggTheoraWriter_SetQuality_16(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the compression quality.
	/// 0 means worst quality and smallest file size
	/// 2 means best quality and largest file size
	/// </summary>
	public virtual void SetQuality(int _arg)
	{
		vtkOggTheoraWriter_SetQuality_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOggTheoraWriter_SetRate_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Set/Get the frame rate, in frame/s.
	/// </summary>
	public virtual void SetRate(int _arg)
	{
		vtkOggTheoraWriter_SetRate_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOggTheoraWriter_SetSubsampling_18(HandleRef pThis, int _arg);

	/// <summary>
	/// Is the video to be encoded using 4:2:0 subsampling?
	/// </summary>
	public virtual void SetSubsampling(int _arg)
	{
		vtkOggTheoraWriter_SetSubsampling_18(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOggTheoraWriter_Start_19(HandleRef pThis);

	/// <summary>
	/// These methods start writing an Movie file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public override void Start()
	{
		vtkOggTheoraWriter_Start_19(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOggTheoraWriter_SubsamplingOff_20(HandleRef pThis);

	/// <summary>
	/// Is the video to be encoded using 4:2:0 subsampling?
	/// </summary>
	public virtual void SubsamplingOff()
	{
		vtkOggTheoraWriter_SubsamplingOff_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOggTheoraWriter_SubsamplingOn_21(HandleRef pThis);

	/// <summary>
	/// Is the video to be encoded using 4:2:0 subsampling?
	/// </summary>
	public virtual void SubsamplingOn()
	{
		vtkOggTheoraWriter_SubsamplingOn_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOOggTheora.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkOggTheoraWriter_Write_22(HandleRef pThis);

	/// <summary>
	/// These methods start writing an Movie file, write a frame to the file
	/// and then end the writing process.
	/// </summary>
	public override void Write()
	{
		vtkOggTheoraWriter_Write_22(GetCppThis());
	}
}
