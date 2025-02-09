using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK;

/// <summary>
///    vtkJPEGWriter
/// </summary>
/// <remarks>
///    Writes JPEG files.
///
/// vtkJPEGWriter writes JPEG files. It supports 1 and 3 component data of
/// unsigned char. It relies on the IJG's libjpeg.  Thanks to IJG for
/// supplying a public jpeg IO library.
///
/// </remarks>
/// <seealso>
///
/// vtkJPEGReader
/// </seealso>
public class vtkJPEGWriter : vtkImageWriter
{
	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new const string MRFullTypeName = "Kitware.VTK.vtkJPEGWriter";

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	public new static readonly string MRClassNameKey;

	/// <summary>
	/// Automatically generated type registration mechanics.
	/// </summary>
	static vtkJPEGWriter()
	{
		MRClassNameKey = "class vtkJPEGWriter";
		Methods.RegisterType(Assembly.GetExecutingAssembly(), MRClassNameKey, Type.GetType("Kitware.VTK.vtkJPEGWriter"));
	}

	/// <summary>
	/// Automatically generated constructor - called from generated code.
	/// DO NOT call directly.
	/// </summary>
	public vtkJPEGWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong)
		: base(rawCppThis, callDisposalMethod, strong)
	{
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJPEGWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJPEGWriter New()
	{
		vtkJPEGWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJPEGWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public vtkJPEGWriter()
		: base(IntPtr.Zero, callDisposalMethod: false, strong: false)
	{
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr rawCppThis = vtkJPEGWriter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
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
	internal static extern long vtkJPEGWriter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override long GetNumberOfGenerationsFromBase(string type)
	{
		return vtkJPEGWriter_GetNumberOfGenerationsFromBase_01(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern long vtkJPEGWriter_GetNumberOfGenerationsFromBaseType_02(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static long GetNumberOfGenerationsFromBaseType(string type)
	{
		return vtkJPEGWriter_GetNumberOfGenerationsFromBaseType_02(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkJPEGWriter_GetProgressive_03(HandleRef pThis);

	/// <summary>
	/// Progressive JPEG generation.
	/// </summary>
	public virtual uint GetProgressive()
	{
		return vtkJPEGWriter_GetProgressive_03(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJPEGWriter_GetQuality_04(HandleRef pThis);

	/// <summary>
	/// Compression quality. 0 = Low quality, 100 = High quality
	/// </summary>
	public virtual int GetQuality()
	{
		return vtkJPEGWriter_GetQuality_04(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJPEGWriter_GetQualityMaxValue_05(HandleRef pThis);

	/// <summary>
	/// Compression quality. 0 = Low quality, 100 = High quality
	/// </summary>
	public virtual int GetQualityMaxValue()
	{
		return vtkJPEGWriter_GetQualityMaxValue_05(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJPEGWriter_GetQualityMinValue_06(HandleRef pThis);

	/// <summary>
	/// Compression quality. 0 = Low quality, 100 = High quality
	/// </summary>
	public virtual int GetQualityMinValue()
	{
		return vtkJPEGWriter_GetQualityMinValue_06(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJPEGWriter_GetResult_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	/// When writing to memory this is the result, it will be nullptr until the
	/// data is written the first time
	/// </summary>
	public virtual vtkUnsignedCharArray GetResult()
	{
		vtkUnsignedCharArray vtkUnsignedCharArray2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJPEGWriter_GetResult_07(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
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

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern uint vtkJPEGWriter_GetWriteToMemory_08(HandleRef pThis);

	/// <summary>
	/// Write the image to memory (a vtkUnsignedCharArray)
	/// </summary>
	public virtual uint GetWriteToMemory()
	{
		return vtkJPEGWriter_GetWriteToMemory_08(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJPEGWriter_IsA_09(HandleRef pThis, string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public override int IsA(string type)
	{
		return vtkJPEGWriter_IsA_09(GetCppThis(), type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern int vtkJPEGWriter_IsTypeOf_10(string type);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static int IsTypeOf(string type)
	{
		return vtkJPEGWriter_IsTypeOf_10(type);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJPEGWriter_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new vtkJPEGWriter NewInstance()
	{
		vtkJPEGWriter result = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJPEGWriter_NewInstance_12(GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			result = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var _);
		}
		return result;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_ProgressiveOff_13(HandleRef pThis);

	/// <summary>
	/// Progressive JPEG generation.
	/// </summary>
	public virtual void ProgressiveOff()
	{
		vtkJPEGWriter_ProgressiveOff_13(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_ProgressiveOn_14(HandleRef pThis);

	/// <summary>
	/// Progressive JPEG generation.
	/// </summary>
	public virtual void ProgressiveOn()
	{
		vtkJPEGWriter_ProgressiveOn_14(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern IntPtr vtkJPEGWriter_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

	/// <summary>
	///             Undocumented Block
	/// </summary>
	public new static vtkJPEGWriter SafeDownCast(vtkObjectBase o)
	{
		vtkJPEGWriter vtkJPEGWriter2 = null;
		uint mteStatus = 0u;
		uint mteIndex = uint.MaxValue;
		uint rawRefCount = 0u;
		IntPtr intPtr = vtkJPEGWriter_SafeDownCast_15(o?.GetCppThis() ?? default(HandleRef), ref mteStatus, ref mteIndex, ref rawRefCount);
		if (IntPtr.Zero != intPtr)
		{
			vtkJPEGWriter2 = (vtkJPEGWriter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, callDisposalMethod: true, out var found);
			if (found)
			{
				vtkJPEGWriter2.Register(null);
			}
		}
		return vtkJPEGWriter2;
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_SetProgressive_16(HandleRef pThis, uint _arg);

	/// <summary>
	/// Progressive JPEG generation.
	/// </summary>
	public virtual void SetProgressive(uint _arg)
	{
		vtkJPEGWriter_SetProgressive_16(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_SetQuality_17(HandleRef pThis, int _arg);

	/// <summary>
	/// Compression quality. 0 = Low quality, 100 = High quality
	/// </summary>
	public virtual void SetQuality(int _arg)
	{
		vtkJPEGWriter_SetQuality_17(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_SetResult_18(HandleRef pThis, HandleRef arg0);

	/// <summary>
	/// When writing to memory this is the result, it will be nullptr until the
	/// data is written the first time
	/// </summary>
	public virtual void SetResult(vtkUnsignedCharArray arg0)
	{
		vtkJPEGWriter_SetResult_18(GetCppThis(), arg0?.GetCppThis() ?? default(HandleRef));
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_SetWriteToMemory_19(HandleRef pThis, uint _arg);

	/// <summary>
	/// Write the image to memory (a vtkUnsignedCharArray)
	/// </summary>
	public virtual void SetWriteToMemory(uint _arg)
	{
		vtkJPEGWriter_SetWriteToMemory_19(GetCppThis(), _arg);
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_Write_20(HandleRef pThis);

	/// <summary>
	/// The main interface which triggers the writer to start.
	/// </summary>
	public override void Write()
	{
		vtkJPEGWriter_Write_20(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_WriteToMemoryOff_21(HandleRef pThis);

	/// <summary>
	/// Write the image to memory (a vtkUnsignedCharArray)
	/// </summary>
	public virtual void WriteToMemoryOff()
	{
		vtkJPEGWriter_WriteToMemoryOff_21(GetCppThis());
	}

	[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
	internal static extern void vtkJPEGWriter_WriteToMemoryOn_22(HandleRef pThis);

	/// <summary>
	/// Write the image to memory (a vtkUnsignedCharArray)
	/// </summary>
	public virtual void WriteToMemoryOn()
	{
		vtkJPEGWriter_WriteToMemoryOn_22(GetCppThis());
	}
}
